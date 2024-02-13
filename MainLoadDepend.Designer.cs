namespace SR2SaveEditor
{
    partial class MainLoadDepend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLoadDepend));
            DLLSelect = new Button();
            DLLPathPreview = new Label();
            SelectAssembly = new OpenFileDialog();
            DLLLoad = new Button();
            SuspendLayout();
            // 
            // DLLSelect
            // 
            resources.ApplyResources(DLLSelect, "DLLSelect");
            DLLSelect.Name = "DLLSelect";
            DLLSelect.UseVisualStyleBackColor = true;
            DLLSelect.Click += button1_Click;
            // 
            // DLLPathPreview
            // 
            resources.ApplyResources(DLLPathPreview, "DLLPathPreview");
            DLLPathPreview.Name = "DLLPathPreview";
            DLLPathPreview.Click += label1_Click;
            // 
            // SelectAssembly
            // 
            SelectAssembly.FileName = "SelectAssembly";
            resources.ApplyResources(SelectAssembly, "SelectAssembly");
            // 
            // DLLLoad
            // 
            resources.ApplyResources(DLLLoad, "DLLLoad");
            DLLLoad.Name = "DLLLoad";
            DLLLoad.UseVisualStyleBackColor = true;
            // 
            // MainLoadDepend
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(DLLLoad);
            Controls.Add(DLLPathPreview);
            Controls.Add(DLLSelect);
            Name = "MainLoadDepend";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DLLSelect;
        private Label DLLPathPreview;
        private OpenFileDialog SelectAssembly;
        private Button DLLLoad;
    }
}