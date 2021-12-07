﻿
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
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.DataButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.GraphicButton = new MaterialSkin.Controls.MaterialButton();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
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
            this.tabPage4.Controls.Add(this.materialLabel2);
            this.tabPage4.Controls.Add(this.materialSwitch1);
            this.tabPage4.Controls.Add(this.DataButton);
            this.tabPage4.Controls.Add(this.materialLabel1);
            this.tabPage4.Controls.Add(this.materialTextBox1);
            this.tabPage4.Controls.Add(this.GraphicButton);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // materialSwitch1
            // 
            resources.ApplyResources(this.materialSwitch1, "materialSwitch1");
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.UseVisualStyleBackColor = true;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
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
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.materialButton1);
            this.tabPage5.Controls.Add(this.materialTextBox2);
            this.tabPage5.Controls.Add(this.checkedListBox1);
            resources.ApplyResources(this.tabPage5, "tabPage5");
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialButton1
            // 
            resources.ApplyResources(this.materialButton1, "materialButton1");
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            resources.ApplyResources(this.materialTextBox2, "materialTextBox2");
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            resources.ApplyResources(this.checkedListBox1, "checkedListBox1");
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // tabPage6
            // 
            resources.ApplyResources(this.tabPage6, "tabPage6");
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            resources.ApplyResources(this.materialLabel2, "materialLabel2");
            this.materialLabel2.Depth = 0;
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.materialTabControl2);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl2;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.materialTabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
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
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton DataButton;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}

