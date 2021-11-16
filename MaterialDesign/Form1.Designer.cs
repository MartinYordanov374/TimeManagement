
namespace MaterialDesign
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DataButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.GraphicButton = new MaterialSkin.Controls.MaterialButton();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialTabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.tabPage4);
            this.materialTabControl2.Controls.Add(this.tabPage5);
            this.materialTabControl2.Controls.Add(this.tabPage6);
            this.materialTabControl2.Depth = 0;
            resources.ApplyResources(this.materialTabControl2, "materialTabControl2");
            this.materialTabControl2.ImageList = this.imageList2;
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Multiline = true;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.materialComboBox1);
            this.tabPage4.Controls.Add(this.DataButton);
            this.tabPage4.Controls.Add(this.materialLabel2);
            this.tabPage4.Controls.Add(this.materialLabel1);
            this.tabPage4.Controls.Add(this.materialTextBox1);
            this.tabPage4.Controls.Add(this.GraphicButton);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            // 
            // DataButton
            // 
            resources.ApplyResources(this.DataButton, "DataButton");
            this.DataButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DataButton.Depth = 0;
            this.DataButton.HighEmphasis = true;
            this.DataButton.Icon = null;
            this.DataButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DataButton.Name = "DataButton";
            this.DataButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DataButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DataButton.UseAccentColor = false;
            this.DataButton.UseVisualStyleBackColor = true;
            this.DataButton.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialLabel2
            // 
            resources.ApplyResources(this.materialLabel2, "materialLabel2");
            this.materialLabel2.Depth = 0;
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            resources.ApplyResources(this.materialTextBox1, "materialTextBox1");
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // GraphicButton
            // 
            resources.ApplyResources(this.GraphicButton, "GraphicButton");
            this.GraphicButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.GraphicButton.Depth = 0;
            this.GraphicButton.HighEmphasis = true;
            this.GraphicButton.Icon = null;
            this.GraphicButton.ImageList = this.imageList2;
            this.GraphicButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.GraphicButton.Name = "GraphicButton";
            this.GraphicButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.GraphicButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.GraphicButton.UseAccentColor = false;
            this.GraphicButton.UseVisualStyleBackColor = true;
            this.GraphicButton.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "baseline_home_black_24dp.png");
            this.imageList2.Images.SetKeyName(1, "baseline_info_black_24dp.png");
            this.imageList2.Images.SetKeyName(2, "baseline_leaderboard_black_24dp.png");
            // 
            // tabPage5
            // 
            resources.ApplyResources(this.tabPage5, "tabPage5");
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            resources.ApplyResources(this.tabPage6, "tabPage6");
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            resources.ApplyResources(this.materialComboBox1, "materialComboBox1");
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Items.AddRange(new object[] {
            resources.GetString("materialComboBox1.Items"),
            resources.GetString("materialComboBox1.Items1"),
            resources.GetString("materialComboBox1.Items2"),
            resources.GetString("materialComboBox1.Items3"),
            resources.GetString("materialComboBox1.Items4"),
            resources.GetString("materialComboBox1.Items5"),
            resources.GetString("materialComboBox1.Items6")});
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.StartIndex = 0;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.materialTabControl2);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl2;
            this.Name = "Form1";
            this.materialTabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

     
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ImageList imageList2;
        private MaterialSkin.Controls.MaterialButton GraphicButton;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton DataButton;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
    }
}

