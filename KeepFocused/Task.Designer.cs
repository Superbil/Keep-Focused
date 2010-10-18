namespace KeepFocused
{
    partial class Task
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task));
            this.txtTask = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblWhat = new System.Windows.Forms.Label();
            this.lblSessionDataFile = new System.Windows.Forms.Label();
            this.txtSessionDataFileName = new System.Windows.Forms.TextBox();
            this.lblBrowse = new System.Windows.Forms.Button();
            this.btnViewDataFile = new System.Windows.Forms.Button();
            this.btnChengFilePath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(7, 36);
            this.txtTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTask.Multiline = true;
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(535, 115);
            this.txtTask.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(378, 199);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 28);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.butOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(461, 199);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblWhat
            // 
            this.lblWhat.AutoSize = true;
            this.lblWhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhat.Location = new System.Drawing.Point(3, 16);
            this.lblWhat.Name = "lblWhat";
            this.lblWhat.Size = new System.Drawing.Size(189, 13);
            this.lblWhat.TabIndex = 3;
            this.lblWhat.Text = "&What you will do in this session:";
            // 
            // lblSessionDataFile
            // 
            this.lblSessionDataFile.AutoSize = true;
            this.lblSessionDataFile.Location = new System.Drawing.Point(3, 170);
            this.lblSessionDataFile.Name = "lblSessionDataFile";
            this.lblSessionDataFile.Size = new System.Drawing.Size(140, 16);
            this.lblSessionDataFile.TabIndex = 4;
            this.lblSessionDataFile.Text = "Session Data File Name";
            // 
            // txtSessionDataFileName
            // 
            this.txtSessionDataFileName.Location = new System.Drawing.Point(164, 166);
            this.txtSessionDataFileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSessionDataFileName.Name = "txtSessionDataFileName";
            this.txtSessionDataFileName.ReadOnly = true;
            this.txtSessionDataFileName.Size = new System.Drawing.Size(343, 23);
            this.txtSessionDataFileName.TabIndex = 5;
            // 
            // lblBrowse
            // 
            this.lblBrowse.Location = new System.Drawing.Point(514, 164);
            this.lblBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblBrowse.Name = "lblBrowse";
            this.lblBrowse.Size = new System.Drawing.Size(26, 28);
            this.lblBrowse.TabIndex = 6;
            this.lblBrowse.Text = "...";
            this.lblBrowse.UseVisualStyleBackColor = true;
            // 
            // btnViewDataFile
            // 
            this.btnViewDataFile.Location = new System.Drawing.Point(7, 199);
            this.btnViewDataFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewDataFile.Name = "btnViewDataFile";
            this.btnViewDataFile.Size = new System.Drawing.Size(161, 28);
            this.btnViewDataFile.TabIndex = 7;
            this.btnViewDataFile.Text = "&View Session Data File";
            this.btnViewDataFile.UseVisualStyleBackColor = true;
            this.btnViewDataFile.Click += new System.EventHandler(this.btnViewDataFile_Click);
            // 
            // btnChengFilePath
            // 
            this.btnChengFilePath.Location = new System.Drawing.Point(175, 199);
            this.btnChengFilePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChengFilePath.Name = "btnChengFilePath";
            this.btnChengFilePath.Size = new System.Drawing.Size(161, 28);
            this.btnChengFilePath.TabIndex = 8;
            this.btnChengFilePath.Text = "&Change File Path";
            this.btnChengFilePath.UseVisualStyleBackColor = true;
            this.btnChengFilePath.Click += new System.EventHandler(this.btnChengFilePath_Click);
            // 
            // Task
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(547, 240);
            this.Controls.Add(this.btnChengFilePath);
            this.Controls.Add(this.btnViewDataFile);
            this.Controls.Add(this.lblBrowse);
            this.Controls.Add(this.txtSessionDataFileName);
            this.Controls.Add(this.lblSessionDataFile);
            this.Controls.Add(this.lblWhat);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Task";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keep Focused";
            this.Load += new System.EventHandler(this.Task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblWhat;
        private System.Windows.Forms.Label lblSessionDataFile;
        private System.Windows.Forms.TextBox txtSessionDataFileName;
        private System.Windows.Forms.Button lblBrowse;
        private System.Windows.Forms.Button btnViewDataFile;
        private System.Windows.Forms.Button btnChengFilePath;
    }
}