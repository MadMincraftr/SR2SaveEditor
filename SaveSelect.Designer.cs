namespace SR2SaveEditor
{
    partial class SaveSelect
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveSelect));
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            OpenSAVFile = new OpenFileDialog();
            SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Cursor = Cursors.Cross;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            resources.ApplyResources(linkLabel1, "linkLabel1");
            linkLabel1.LinkColor = Color.Cyan;
            linkLabel1.Name = "linkLabel1";
            linkLabel1.TabStop = true;
            // 
            // OpenSAVFile
            // 
            OpenSAVFile.FileName = "openFileDialog1";
            resources.ApplyResources(OpenSAVFile, "OpenSAVFile");
            // 
            // SaveSelect
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Name = "SaveSelect";
            Load += SaveSelect_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private LinkLabel linkLabel1;
        private OpenFileDialog OpenSAVFile;
    }
}
