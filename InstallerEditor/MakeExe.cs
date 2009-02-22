using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using InstallerLib;

namespace InstallerEditor
{
    /// <summary>
    /// Summary description for MakeExe.
    /// </summary>
    public class MakeExe : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox txtBannerBitmap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBrowseBannerBitmap;
        private System.Windows.Forms.Button btBrowseConfiguration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfiguration;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btMake;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btBrowseTemplateFile;
        private System.Windows.Forms.TextBox txtTemplateFile;
        private System.Windows.Forms.CheckBox chkEmbed;
        private TextBox txtIcon;
        private Button btBrowseIcon;
        private Label label4;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public MakeExe()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btMake = new System.Windows.Forms.Button();
            this.txtBannerBitmap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btBrowseBannerBitmap = new System.Windows.Forms.Button();
            this.btBrowseConfiguration = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfiguration = new System.Windows.Forms.TextBox();
            this.btBrowseTemplateFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemplateFile = new System.Windows.Forms.TextBox();
            this.chkEmbed = new System.Windows.Forms.CheckBox();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.btBrowseIcon = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(308, 189);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Cancel";
            // 
            // btMake
            // 
            this.btMake.Location = new System.Drawing.Point(220, 189);
            this.btMake.Name = "btMake";
            this.btMake.Size = new System.Drawing.Size(75, 23);
            this.btMake.TabIndex = 1;
            this.btMake.Text = "Make";
            this.btMake.Click += new System.EventHandler(this.btMake_Click);
            // 
            // txtBannerBitmap
            // 
            this.txtBannerBitmap.Location = new System.Drawing.Point(9, 109);
            this.txtBannerBitmap.Name = "txtBannerBitmap";
            this.txtBannerBitmap.Size = new System.Drawing.Size(344, 20);
            this.txtBannerBitmap.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Banner Bitmap (optional)";
            // 
            // btBrowseBannerBitmap
            // 
            this.btBrowseBannerBitmap.Location = new System.Drawing.Point(357, 109);
            this.btBrowseBannerBitmap.Name = "btBrowseBannerBitmap";
            this.btBrowseBannerBitmap.Size = new System.Drawing.Size(24, 20);
            this.btBrowseBannerBitmap.TabIndex = 4;
            this.btBrowseBannerBitmap.Text = "...";
            this.btBrowseBannerBitmap.Click += new System.EventHandler(this.btBrowseBannerBitmap_Click);
            // 
            // btBrowseConfiguration
            // 
            this.btBrowseConfiguration.Location = new System.Drawing.Point(357, 66);
            this.btBrowseConfiguration.Name = "btBrowseConfiguration";
            this.btBrowseConfiguration.Size = new System.Drawing.Size(24, 20);
            this.btBrowseConfiguration.TabIndex = 7;
            this.btBrowseConfiguration.Text = "...";
            this.btBrowseConfiguration.Click += new System.EventHandler(this.btBrowseConfiguration_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Configuration";
            // 
            // txtConfiguration
            // 
            this.txtConfiguration.Location = new System.Drawing.Point(9, 66);
            this.txtConfiguration.Name = "txtConfiguration";
            this.txtConfiguration.Size = new System.Drawing.Size(344, 20);
            this.txtConfiguration.TabIndex = 5;
            // 
            // btBrowseTemplateFile
            // 
            this.btBrowseTemplateFile.Location = new System.Drawing.Point(357, 28);
            this.btBrowseTemplateFile.Name = "btBrowseTemplateFile";
            this.btBrowseTemplateFile.Size = new System.Drawing.Size(24, 20);
            this.btBrowseTemplateFile.TabIndex = 10;
            this.btBrowseTemplateFile.Text = "...";
            this.btBrowseTemplateFile.Click += new System.EventHandler(this.btBrowseTemplateFile_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Template dotNetInstaller.exe File";
            // 
            // txtTemplateFile
            // 
            this.txtTemplateFile.Location = new System.Drawing.Point(9, 28);
            this.txtTemplateFile.Name = "txtTemplateFile";
            this.txtTemplateFile.Size = new System.Drawing.Size(344, 20);
            this.txtTemplateFile.TabIndex = 8;
            // 
            // chkEmbed
            // 
            this.chkEmbed.AutoSize = true;
            this.chkEmbed.Location = new System.Drawing.Point(9, 189);
            this.chkEmbed.Name = "chkEmbed";
            this.chkEmbed.Size = new System.Drawing.Size(131, 17);
            this.chkEmbed.TabIndex = 11;
            this.chkEmbed.Text = "&Embed Dependencies";
            this.chkEmbed.UseVisualStyleBackColor = true;
            // 
            // txtIcon
            // 
            this.txtIcon.Location = new System.Drawing.Point(9, 147);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(344, 20);
            this.txtIcon.TabIndex = 12;
            // 
            // btBrowseIcon
            // 
            this.btBrowseIcon.Location = new System.Drawing.Point(357, 147);
            this.btBrowseIcon.Name = "btBrowseIcon";
            this.btBrowseIcon.Size = new System.Drawing.Size(24, 20);
            this.btBrowseIcon.TabIndex = 14;
            this.btBrowseIcon.Text = "...";
            this.btBrowseIcon.Click += new System.EventHandler(this.btBrowseIcon_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Icon (optional)";
            // 
            // MakeExe
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(397, 227);
            this.Controls.Add(this.txtIcon);
            this.Controls.Add(this.btBrowseIcon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btBrowseTemplateFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTemplateFile);
            this.Controls.Add(this.txtConfiguration);
            this.Controls.Add(this.txtBannerBitmap);
            this.Controls.Add(this.btBrowseConfiguration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btBrowseBannerBitmap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btMake);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.chkEmbed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeExe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeExe";
            this.Load += new System.EventHandler(this.MakeExe_Load);
            this.Closed += new System.EventHandler(this.MakeExe_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void btMake_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (System.IO.File.Exists(txtTemplateFile.Text) == false)
                    throw new ApplicationException("Template not valid");
                if (System.IO.File.Exists(txtConfiguration.Text) == false)
                    throw new ApplicationException("Configuration not valid");

                m_Configuration = txtConfiguration.Text;
                m_TemplateFile = txtTemplateFile.Text;
                m_BannerBitmapFile = txtBannerBitmap.Text;
                m_IconFile = txtIcon.Text;

                SaveFileDialog l_dg = new SaveFileDialog();
                l_dg.FileName = m_OutputFileName;
                l_dg.Filter = "Exe File (*.exe)|*.exe|All Files(*.*)|*.*";
                l_dg.DefaultExt = "exe";
                if (l_dg.ShowDialog(this) == DialogResult.OK)
                {
                    InstallerLinkerArguments args = new InstallerLinkerArguments();
                    args.banner = txtBannerBitmap.Text;
                    args.icon = txtIcon.Text;
                    args.config = txtConfiguration.Text;
                    args.output = l_dg.FileName;
                    args.template = txtTemplateFile.Text;
                    args.embed = chkEmbed.Checked;
                    InstallerLinker.CreateInstaller(args);
                    m_OutputFileName = l_dg.FileName;
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception err)
            {
                AppUtility.ShowError(this, err);
            }
        }

        private string m_OutputFileName;
        public string OutputFileName
        {
            get { return m_OutputFileName; }
            set { m_OutputFileName = value; }
        }

        private string m_TemplateFile;
        public string TemplateFile
        {
            get { return m_TemplateFile; }
            set { m_TemplateFile = value; }
        }
        private string m_BannerBitmapFile;
        public string BannerBitmapFile
        {
            get { return m_BannerBitmapFile; }
            set { m_BannerBitmapFile = value; }
        }
        private string m_IconFile;
        public string IconFile
        {
            get { return m_IconFile; }
            set { m_IconFile = value; }
        }

        private string m_Configuration;

        private void MakeExe_Load(object sender, System.EventArgs e)
        {
            txtTemplateFile.Text = m_TemplateFile;
            txtConfiguration.Text = m_Configuration;
            txtBannerBitmap.Text = m_BannerBitmapFile;
            txtIcon.Text = m_IconFile;
        }

        private void MakeExe_Closed(object sender, System.EventArgs e)
        {
        }

        private void btBrowseTemplateFile_Click(object sender, System.EventArgs e)
        {
            try
            {
                OpenFileDialog l_dg = new OpenFileDialog();
                l_dg.Filter = "Exe File (*.exe)|*.exe|All Files(*.*)|*.*";
                if (l_dg.ShowDialog(this) == DialogResult.OK)
                    txtTemplateFile.Text = l_dg.FileName;
            }
            catch (Exception err)
            {
                AppUtility.ShowError(this, err);
            }
        }

        private void btBrowseBannerBitmap_Click(object sender, System.EventArgs e)
        {
            try
            {
                OpenFileDialog l_dg = new OpenFileDialog();
                l_dg.Filter = "Bitmap File (*.bmp)|*.bmp|All Files(*.*)|*.*";
                if (l_dg.ShowDialog(this) == DialogResult.OK)
                    txtBannerBitmap.Text = l_dg.FileName;
            }
            catch (Exception err)
            {
                AppUtility.ShowError(this, err);
            }
        }

        private void btBrowseConfiguration_Click(object sender, System.EventArgs e)
        {
            try
            {
                OpenFileDialog l_dg = new OpenFileDialog();
                l_dg.Filter = "XML File (*.xml)|*.xml|All Files(*.*)|*.*";
                if (l_dg.ShowDialog(this) == DialogResult.OK)
                    txtConfiguration.Text = l_dg.FileName;
            }
            catch (Exception err)
            {
                AppUtility.ShowError(this, err);
            }
        }

        public string Configuration
        {
            get { return m_Configuration; }
            set { m_Configuration = value; }
        }

        private void btBrowseIcon_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog l_dg = new OpenFileDialog();
                l_dg.Filter = "Icon File (*.ico)|*.ico|All Files(*.*)|*.*";
                if (l_dg.ShowDialog(this) == DialogResult.OK)
                    txtIcon.Text = l_dg.FileName;
            }
            catch (Exception err)
            {
                AppUtility.ShowError(this, err);
            }
        }
    }
}
