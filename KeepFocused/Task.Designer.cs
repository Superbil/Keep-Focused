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
            resources.ApplyResources(this.txtTask, "txtTask");
            this.txtTask.Name = "txtTask";
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.butOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblWhat
            // 
            resources.ApplyResources(this.lblWhat, "lblWhat");
            this.lblWhat.Name = "lblWhat";
            // 
            // lblSessionDataFile
            // 
            resources.ApplyResources(this.lblSessionDataFile, "lblSessionDataFile");
            this.lblSessionDataFile.Name = "lblSessionDataFile";
            // 
            // txtSessionDataFileName
            // 
            resources.ApplyResources(this.txtSessionDataFileName, "txtSessionDataFileName");
            this.txtSessionDataFileName.Name = "txtSessionDataFileName";
            this.txtSessionDataFileName.ReadOnly = true;
            // 
            // lblBrowse
            // 
            resources.ApplyResources(this.lblBrowse, "lblBrowse");
            this.lblBrowse.Name = "lblBrowse";
            this.lblBrowse.UseVisualStyleBackColor = true;
            // 
            // btnViewDataFile
            // 
            resources.ApplyResources(this.btnViewDataFile, "btnViewDataFile");
            this.btnViewDataFile.Name = "btnViewDataFile";
            this.btnViewDataFile.UseVisualStyleBackColor = true;
            this.btnViewDataFile.Click += new System.EventHandler(this.btnViewDataFile_Click);
            // 
            // btnChengFilePath
            // 
            resources.ApplyResources(this.btnChengFilePath, "btnChengFilePath");
            this.btnChengFilePath.Name = "btnChengFilePath";
            this.btnChengFilePath.UseVisualStyleBackColor = true;
            this.btnChengFilePath.Click += new System.EventHandler(this.btnChengFilePath_Click);
            // 
            // Task
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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