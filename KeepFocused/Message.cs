using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KeepFocused
{
    public partial class Message : Form
    {
        public Message(string message)
        {
            InitializeComponent();
            labelMessage.Text = message;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
