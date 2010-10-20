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
            this.txtTask.AccessibleDescription = null;
            this.txtTask.AccessibleName = null;
            resources.ApplyResources(this.txtTask, "txtTask");
            this.txtTask.BackgroundImage = null;
            this.txtTask.Font = null;
            this.txtTask.Name = "txtTask";
            // 
            // btnOK
            // 
            this.btnOK.AccessibleDescription = null;
            this.btnOK.AccessibleName = null;
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.BackgroundImage = null;
            this.btnOK.Font = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.butOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleDescription = null;
            this.btnClose.AccessibleName = null;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.BackgroundImage = null;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = null;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblWhat
            // 
            this.lblWhat.AccessibleDescription = null;
            this.lblWhat.AccessibleName = null;
            resources.ApplyResources(this.lblWhat, "lblWhat");
            this.lblWhat.Name = "lblWhat";
            // 
            // lblSessionDataFile
            // 
            this.lblSessionDataFile.AccessibleDescription = null;
            this.lblSessionDataFile.AccessibleName = null;
            resources.ApplyResources(this.lblSessionDataFile, "lblSessionDataFile");
            this.lblSessionDataFile.Font = null;
            this.lblSessionDataFile.Name = "lblSessionDataFile";
            // 
            // txtSessionDataFileName
            // 
            this.txtSessionDataFileName.AccessibleDescription = null;
            this.txtSessionDataFileName.AccessibleName = null;
            resources.ApplyResources(this.txtSessionDataFileName, "txtSessionDataFileName");
            this.txtSessionDataFileName.BackgroundImage = null;
            this.txtSessionDataFileName.Font = null;
            this.txtSessionDataFileName.Name = "txtSessionDataFileName";
            this.txtSessionDataFileName.ReadOnly = true;
            // 
            // lblBrowse
            // 
            this.lblBrowse.AccessibleDescription = null;
            this.lblBrowse.AccessibleName = null;
            resources.ApplyResources(this.lblBrowse, "lblBrowse");
            this.lblBrowse.BackgroundImage = null;
            this.lblBrowse.Font = null;
            this.lblBrowse.Name = "lblBrowse";
            this.lblBrowse.UseVisualStyleBackColor = true;
            // 
            // btnViewDataFile
            // 
            this.btnViewDataFile.AccessibleDescription = null;
            this.btnViewDataFile.AccessibleName = null;
            resources.ApplyResources(this.btnViewDataFile, "btnViewDataFile");
            this.btnViewDataFile.BackgroundImage = null;
            this.btnViewDataFile.Font = null;
            this.btnViewDataFile.Name = "btnViewDataFile";
            this.btnViewDataFile.UseVisualStyleBackColor = true;
            this.btnViewDataFile.Click += new System.EventHandler(this.btnViewDataFile_Click);
            // 
            // btnChengFilePath
            // 
            this.btnChengFilePath.AccessibleDescription = null;
            this.btnChengFilePath.AccessibleName = null;
            resources.ApplyResources(this.btnChengFilePath, "btnChengFilePath");
            this.btnChengFilePath.BackgroundImage = null;
            this.btnChengFilePath.Font = null;
            this.btnChengFilePath.Name = "btnChengFilePath";
            this.btnChengFilePath.UseVisualStyleBackColor = true;
            this.btnChengFilePath.Click += new System.EventHandler(this.btnChengFilePath_Click);
            // 
            // Task
            // 
            this.AcceptButton = this.btnOK;
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.CancelButton = this.btnClose;
            this.Controls.Add(this.btnChengFilePath);
            this.Controls.Add(this.btnViewDataFile);
            this.Controls.Add(this.lblBrowse);
            this.Controls.Add(this.txtSessionDataFileName);
            this.Controls.Add(this.lblSessionDataFile);
            this.Controls.Add(this.lblWhat);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtTask);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Task";
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