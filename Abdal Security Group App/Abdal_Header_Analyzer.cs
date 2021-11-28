using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Abdal_Security_Group_App
{
    public partial class Form1 : Telerik.WinControls.UI.RadForm
    {
        public Form1()
        {
            InitializeComponent();

            //change form title
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            Text = "Abdal Header Analyzer" + " " + version.Major + "." + version.Minor; 

            // Call Global Chilkat Unlock
            Abdal_Security_Group_App.GlobalUnlockChilkat GlobalUnlock = new Abdal_Security_Group_App.GlobalUnlockChilkat();
            GlobalUnlock.unlock();

        }


        #region Dragable Form Start
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        #endregion

      

        private void radLabelElement4_Click(object sender, EventArgs e)
        {
        
            System.Diagnostics.Process.Start("https://abdalagency.ir/");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://donate.abdalagency.ir/");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/abdal-security-group/abdal-header-analyzer");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gitlab.com/abdal-security-group/abdal-header-analyzer");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (backgroundWorker_reponser.IsBusy != true)
            {
                radWaitingBar1.Visible = true;
                radWaitingBar1.StartWaiting();

                backgroundWorker_reponser.RunWorkerAsync();
            }
          
           
        }

        private string GetDateTime()
        {
            var date_time = string.Format("{0:HH:mm:ss tt}", DateTime.Now);
            return date_time;
        }
        private void backgroundWorker_reponser_DoWork(object sender, DoWorkEventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"start.wav"))
            {
                soundPlayer.PlaySync(); // can also use soundPlayer.Play()
            }

            try
            {
                if (target_url_tb.Text != "")
                {

                    result_lb.AppendText("==================== " + GetDateTime() + " ==================== " + target_url_tb.Text + Environment.NewLine);
                    result_lb.SelectionStart = result_lb.Text.Length;
                    result_lb.ScrollToCaret();

                    bool success = false;
                    Chilkat.Http http = new Chilkat.Http();

                    Chilkat.HttpResponse resp = http.QuickGetObj(target_url_tb.Text);

                    if (http.LastMethodSuccess == false)

                    {
                        radWaitingBar1.StopWaiting();
                        radWaitingBar1.Visible = false;
                        using (var soundPlayer = new SoundPlayer(@"error.wav"))
                        {
                            soundPlayer.PlaySync(); // can also use soundPlayer.Play()
                        }
                        MessageBox.Show("This target is not accessible, maybe you are blocked Or your network has a problem", "Abdal Header Reader",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int status = resp.StatusCode;

                    //Add AttackLog in Result Box
                    result_lb.AppendText("HTTP Response Status: " + status + Environment.NewLine);
                    result_lb.SelectionStart = result_lb.Text.Length;
                    result_lb.ScrollToCaret();

                    

                    int loopCount = 0;

                    if (resp.StatusCode == 302 || resp.StatusCode == 301)
                    {
                        #region While

                        while ((status == 302))
                        {

                            // IMPORTANT: This example requires Chilkat v9.5.0.49 or greater because
                            // the FinalRedirectUrl in prior versions is only set when redirects
                            // are automatically followed.   Starting in v9.5.0.49, the FinalRedirectUrl is
                            // set to the next redirect URL when a 301/302 response is received, regardless
                            // of the value of the FollowRedirects property.
                            //Add AttackLog in Result Box
                            result_lb.AppendText("Redirect URL: " + http.FinalRedirectUrl + Environment.NewLine);
                            result_lb.SelectionStart = result_lb.Text.Length;
                            result_lb.ScrollToCaret();

                            string nextUrl = http.FinalRedirectUrl;
                            resp = http.QuickGetObj(nextUrl);
                            if (http.LastMethodSuccess == false)
                            {
                                radWaitingBar1.StopWaiting();
                                radWaitingBar1.Visible = false;
                                using (var soundPlayer = new SoundPlayer(@"error.wav"))
                                {
                                    soundPlayer.PlaySync(); // can also use soundPlayer.Play()
                                }
                                MessageBox.Show("This target is not accessible", "Abdal Header Reader",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            status = resp.StatusCode;
                            //Add AttackLog in Result Box
                            result_lb.AppendText("HTTP Response Status: " + Convert.ToString(status) + Environment.NewLine);
                            result_lb.SelectionStart = result_lb.Text.Length;
                            result_lb.ScrollToCaret();

                            // For safety, prevent infinite loops by
                            // keeping a loopCount and only allows following a max 
                            // of 10 redirects:
                            loopCount = loopCount + 1;
                            if (loopCount > 10)
                            {
                                radWaitingBar1.StopWaiting();
                                radWaitingBar1.Visible = false;
                                using (var soundPlayer = new SoundPlayer(@"error.wav"))
                                {
                                    soundPlayer.PlaySync(); // can also use soundPlayer.Play()
                                }
                                MessageBox.Show("Too many redirects", "Abdal Header Reader",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                return;
                            }

                            //Add AttackLog in Result Box
                            result_lb.AppendText(resp.Header + Environment.NewLine);
                            result_lb.SelectionStart = result_lb.Text.Length;
                            result_lb.ScrollToCaret();

                            string app_words = "Server:,X-Clacks-Overhead,X-Backend-Server,CF-RAY,X-Ezoic-Cdn,X-Origin-Cache-Control,server,X-Powered-By,X-Served-By,Set-Cookie,HTTP Response Status";
                            highlight_app_name(app_words);

                            string header_words = "X-XSS-Protection,X-Frame-Options,Referrer-Policy,X-Content-Type-Options,Strict-Transport-Security,Expect-CT,Feature-Policy,Content-Security-Policy,Clear-Site-Data,X-DNS-Prefetch-Control";
                            highlight_secure_header_name(header_words);


                        }

                        #endregion
                    }
                    else
                    {

                        //Add AttackLog in Result Box
                        result_lb.AppendText(resp.Header + Environment.NewLine);
                        result_lb.SelectionStart = result_lb.Text.Length;
                        result_lb.ScrollToCaret();

                        string app_words = "Server:,X-Clacks-Overhead,X-Backend-Server,CF-RAY,X-Ezoic-Cdn,X-Origin-Cache-Control,server,X-Powered-By,X-Served-By,Set-Cookie,HTTP Response Status";
                        highlight_app_name(app_words);
                        
                        string header_words = "X-XSS-Protection,X-Frame-Options,Referrer-Policy,X-Content-Type-Options,Strict-Transport-Security,Expect-CT,Feature-Policy,Content-Security-Policy,Clear-Site-Data,X-DNS-Prefetch-Control";
                        highlight_secure_header_name(header_words);


                    }
                   



                }

                else
                {
                    using (var soundPlayer = new SoundPlayer(@"error.wav"))
                    {
                        soundPlayer.PlaySync(); // can also use soundPlayer.Play()
                    }
                    MessageBox.Show("Please enter the url","Abdal Header Reader",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                
            }
            catch (Exception exception)
            {
                radWaitingBar1.Visible = false;
                using (var soundPlayer = new SoundPlayer(@"error.wav"))
                {
                    soundPlayer.PlaySync(); // can also use soundPlayer.Play()
                }
                MessageBox.Show(exception.ToString(), "Abdal Header Reader",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
         

        }

        private void highlight_app_name(string list_app_name)
        {
            //highlight text
            string[] app_words = list_app_name.Split(',');
            foreach (string word in app_words)
            {
                int startindex = 0;
                while (startindex < result_lb.TextLength)
                {
                    int wordstartIndex = result_lb.Find(word, startindex, RichTextBoxFinds.None);
                    if (wordstartIndex != -1)
                    {
                        result_lb.SelectionStart = wordstartIndex;
                        result_lb.SelectionLength = word.Length;
                        result_lb.SelectionColor = Color.Black;
                        result_lb.SelectionBackColor = Color.Yellow;
                    }
                    else
                        break;
                    startindex += wordstartIndex + word.Length;
                }
            }

        }


        private void highlight_secure_header_name(string list_app_name)
        {
            //highlight text
            string[] app_words = list_app_name.Split(',');
            foreach (string word in app_words)
            {
                int startindex = 0;
                while (startindex < result_lb.TextLength)
                {
                    int wordstartIndex = result_lb.Find(word, startindex, RichTextBoxFinds.None);
                    if (wordstartIndex != -1)
                    {
                        result_lb.SelectionStart = wordstartIndex;
                        result_lb.SelectionLength = word.Length;
                        result_lb.SelectionColor = Color.White;
                        result_lb.SelectionBackColor = Color.Red;
                    }
                    else
                        break;
                    startindex += wordstartIndex + word.Length;
                }
            }

        }

        private void backgroundWorker_reponser_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            radWaitingBar1.StopWaiting();
            radWaitingBar1.Visible = false;
            using (var soundPlayer = new SoundPlayer(@"done.wav"))
            {
                soundPlayer.PlaySync(); // can also use soundPlayer.Play()
            }

            MessageBox.Show("Header analysis completed", "Abdal Header Reader",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            if (backgroundWorker_reponser.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker_reponser.CancelAsync();
                radWaitingBar1.StopWaiting();
                radWaitingBar1.Visible = false;
                using (var soundPlayer = new SoundPlayer(@"cancel.wav"))
                {
                    soundPlayer.PlaySync(); // can also use soundPlayer.Play()
                }
                MessageBox.Show("Cancel process by user","Abdal Header Reader",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            
             
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            result_lb.Clear();
            target_url_tb.Text = "";
        }
    }
}
