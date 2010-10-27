using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using KeepFocused.Properties;

namespace KeepFocused
{
    public partial class KeepFocusedForm : Form
    {
        #region Form Dragging API Support
        //The SendMessage function sends a message to a window or windows.
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
        //ReleaseCapture releases a mouse capture
        [DllImportAttribute("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern bool ReleaseCapture();
        #endregion

        string sessionDuration = "25:00";   //session duration in mm:ss format
        string pauseDuration = "05:00"; //pause duration in mm:ss format
        bool breakPeriod = false;

        bool optionPlaySound = true;
        bool optionShowMessage = true;

        public KeepFocusedForm()
        {
            InitializeComponent();
        }

        private void lblMoveHandler_MouseDown(object sender, MouseEventArgs e)
        {
            // drag the form without the caption bar
            // present on left mouse button
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xa1, 0x2, 0);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string[] arr;
            arr = lblTimer.Text.Split(':');
            int mins = int.Parse(arr[0]);
            int secs = int.Parse(arr[1]);

            if (mins == 0 && secs == 0)
            {
                if (breakPeriod)
                {
                    // Break is over.
                    timer.Enabled = false;
                    breakPeriod = false;
                    lblTimer.ForeColor = Color.White;
                    if (optionPlaySound)
                        SystemSounds.Beep.Play();
                    if (optionShowMessage)
                        showMessage("Break is over");
                }
                else
                {
                    // Acitivity is over, start break
                    startPause();
                    arr = lblTimer.Text.Split(':');
                    mins = int.Parse(arr[0]);
                    secs = int.Parse(arr[1]);
                    if (optionPlaySound)
                        SystemSounds.Asterisk.Play();
                    if (optionShowMessage)
                        showMessage("Pomodoro activity finished");
                }
            }

            TimeSpan ts = new TimeSpan(0, mins, secs);
            ts = ts.Subtract(new TimeSpan(10));
            lblTimer.Text = String.Format(ts.Minutes.ToString("D2")) + ":" + String.Format(ts.Seconds.ToString("D2"));
        }

        private void KeepFocusedForm_Load(object sender, EventArgs e)
        {
            lblPlayPause.Image = global::KeepFocused.Properties.Resources.stop_Icon_White;
            lblMoveHandle.Font = new Font("Wingdings", 12.00F, FontStyle.Bold);
            OpenTaskForm();
            startTimer();
            timer.Enabled = true;
            this.Location = new Point(Settings.Default.FormX,Settings.Default.FormY);
        }

        private void startTimer()
        {
            lblTimer.ForeColor = Color.White;
            lblTimer.Text = sessionDuration;
            breakPeriod = false;
        }

        private void startPause()
        {
            lblTimer.ForeColor = Color.HotPink;
            lblTimer.Text = pauseDuration;
            breakPeriod = true;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblPlayPause_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                lblPlayPause.Image = global::KeepFocused.Properties.Resources.stop_Icon_White;
                startTimer();
                OpenTaskForm();
                timer.Enabled = true;
            }
            else
            {
                lblPlayPause.Image = global::KeepFocused.Properties.Resources.Play_Black_Small;
                timer.Enabled = false;
            }
        }

        private void lblMoveHandler_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.SizeAll;
        }

        private void lblMoveHandler_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void ChangeTextColor(Color color)
        {
            foreach(Control c in this.Controls)
                if(c is Label)
                    c.ForeColor = color;
        }

        private void ChangeBackColor(Color color)
        {
            foreach (Control c in this.Controls)
                    c.BackColor = color;
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            new frmInfo().ShowDialog();
        }

        private void OpenTaskForm()
        {
            Task taskForm = new Task();

            int maxLeftPosition = Screen.PrimaryScreen.WorkingArea.Width - (taskForm.Width + 20);
            int maxTopPosition = Screen.PrimaryScreen.WorkingArea.Height - (taskForm.Height + 20);

            if (this.Top + this.Height > maxTopPosition)
                taskForm.Top = this.Top - taskForm.Height - 30;
            else
                taskForm.Top = this.Top + 30;
            
            if (this.Left > maxLeftPosition)
                taskForm.Left = this.Right - taskForm.Width;
            else
                taskForm.Left = this.Left;

            taskForm.ShowDialog();
        }

        private void showMessage(string message)
        {
            MessageBox.Show(message, "Keep Focused", MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                            MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            //Message m = new Message(message);
            //m.ShowDialog(this);
        }

        private void moveForm(object sender, EventArgs e)
        {
            Settings.Default.FormX = this.Location.X;
            Settings.Default.FormY = this.Location.Y;
            Settings.Default.Save();
        }
    }
}
