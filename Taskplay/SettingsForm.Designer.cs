namespace Taskplay
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.checkBoxAutorun = new System.Windows.Forms.CheckBox();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.labelContribute = new System.Windows.Forms.Label();
            this.labelSuggestions = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelTaskplay = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Controls.Add(this.tabPageGeneral);
            this.tabControl.Controls.Add(this.tabPageAbout);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // tabPageGeneral
            // 
            resources.ApplyResources(this.tabPageGeneral, "tabPageGeneral");
            this.tabPageGeneral.Controls.Add(this.checkBoxAutorun);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutorun
            // 
            resources.ApplyResources(this.checkBoxAutorun, "checkBoxAutorun");
            this.checkBoxAutorun.Name = "checkBoxAutorun";
            this.checkBoxAutorun.UseVisualStyleBackColor = true;
            // 
            // tabPageAbout
            // 
            resources.ApplyResources(this.tabPageAbout, "tabPageAbout");
            this.tabPageAbout.Controls.Add(this.linkLabelGitHub);
            this.tabPageAbout.Controls.Add(this.labelContribute);
            this.tabPageAbout.Controls.Add(this.labelSuggestions);
            this.tabPageAbout.Controls.Add(this.labelVersion);
            this.tabPageAbout.Controls.Add(this.labelTaskplay);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // linkLabelGitHub
            // 
            resources.ApplyResources(this.linkLabelGitHub, "linkLabelGitHub");
            this.linkLabelGitHub.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelGitHub.LinkColor = System.Drawing.Color.SpringGreen;
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.VisitedLinkColor = System.Drawing.Color.SpringGreen;
            this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
            // 
            // labelContribute
            // 
            resources.ApplyResources(this.labelContribute, "labelContribute");
            this.labelContribute.Name = "labelContribute";
            // 
            // labelSuggestions
            // 
            resources.ApplyResources(this.labelSuggestions, "labelSuggestions");
            this.labelSuggestions.Name = "labelSuggestions";
            // 
            // labelVersion
            // 
            resources.ApplyResources(this.labelVersion, "labelVersion");
            this.labelVersion.Name = "labelVersion";
            // 
            // labelTaskplay
            // 
            resources.ApplyResources(this.labelTaskplay, "labelTaskplay");
            this.labelTaskplay.Name = "labelTaskplay";
            // 
            // buttonApply
            // 
            resources.ApplyResources(this.buttonApply, "buttonApply");
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            resources.ApplyResources(this.buttonOK, "buttonOK");
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.buttonOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.buttonCancel;
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.CheckBox checkBoxAutorun;
        private System.Windows.Forms.Label labelTaskplay;
        private System.Windows.Forms.Label labelContribute;
        private System.Windows.Forms.Label labelSuggestions;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}