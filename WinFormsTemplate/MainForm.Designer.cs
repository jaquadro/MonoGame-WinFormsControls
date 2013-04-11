namespace WinFormsTemplate
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.clearColor1 = new System.Windows.Forms.ComboBox();
            this.vertexColor3 = new System.Windows.Forms.ComboBox();
            this.vertexColor2 = new System.Windows.Forms.ComboBox();
            this.vertexColor1 = new System.Windows.Forms.ComboBox();
            this.clearColor2 = new System.Windows.Forms.ComboBox();
            this.vertexColor3b = new System.Windows.Forms.ComboBox();
            this.vertexColor2b = new System.Windows.Forms.ComboBox();
            this.vertexColor1b = new System.Windows.Forms.ComboBox();
            this.spinningTriangleControl = new WinFormsTemplate.SpinningTriangleControl();
            this.spinningTriangleControl1 = new WinFormsTemplate.SpinningTriangleControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.clearColor1);
            this.splitContainer1.Panel1.Controls.Add(this.vertexColor3);
            this.splitContainer1.Panel1.Controls.Add(this.vertexColor2);
            this.splitContainer1.Panel1.Controls.Add(this.vertexColor1);
            this.splitContainer1.Panel1.Controls.Add(this.spinningTriangleControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.clearColor2);
            this.splitContainer1.Panel2.Controls.Add(this.vertexColor3b);
            this.splitContainer1.Panel2.Controls.Add(this.vertexColor2b);
            this.splitContainer1.Panel2.Controls.Add(this.vertexColor1b);
            this.splitContainer1.Panel2.Controls.Add(this.spinningTriangleControl1);
            this.splitContainer1.Size = new System.Drawing.Size(792, 573);
            this.splitContainer1.SplitterDistance = 396;
            this.splitContainer1.TabIndex = 0;
            // 
            // clearColor1
            // 
            this.clearColor1.DropDownHeight = 500;
            this.clearColor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clearColor1.FormattingEnabled = true;
            this.clearColor1.IntegralHeight = false;
            this.clearColor1.Items.AddRange(new object[] {
            "BurlyWood",
            "Chartreuse",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Firebrick",
            "Fuchsia",
            "Goldenrod",
            "Indigo",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato"});
            this.clearColor1.Location = new System.Drawing.Point(286, 549);
            this.clearColor1.Name = "clearColor1";
            this.clearColor1.Size = new System.Drawing.Size(103, 21);
            this.clearColor1.TabIndex = 8;
            this.clearColor1.SelectedIndexChanged += new System.EventHandler(this.clearColor1_SelectedIndexChanged);
            // 
            // vertexColor3
            // 
            this.vertexColor3.DropDownHeight = 500;
            this.vertexColor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vertexColor3.FormattingEnabled = true;
            this.vertexColor3.IntegralHeight = false;
            this.vertexColor3.Items.AddRange(new object[] {
            "BurlyWood",
            "Chartreuse",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Firebrick",
            "Fuchsia",
            "Goldenrod",
            "Indigo",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato"});
            this.vertexColor3.Location = new System.Drawing.Point(255, 12);
            this.vertexColor3.Name = "vertexColor3";
            this.vertexColor3.Size = new System.Drawing.Size(103, 21);
            this.vertexColor3.TabIndex = 3;
            this.vertexColor3.SelectedIndexChanged += new System.EventHandler(this.vertexColor_SelectedIndexChanged);
            // 
            // vertexColor2
            // 
            this.vertexColor2.DropDownHeight = 500;
            this.vertexColor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vertexColor2.FormattingEnabled = true;
            this.vertexColor2.IntegralHeight = false;
            this.vertexColor2.Items.AddRange(new object[] {
            "BurlyWood",
            "Chartreuse",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Firebrick",
            "Fuchsia",
            "Goldenrod",
            "Indigo",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato"});
            this.vertexColor2.Location = new System.Drawing.Point(146, 12);
            this.vertexColor2.Name = "vertexColor2";
            this.vertexColor2.Size = new System.Drawing.Size(103, 21);
            this.vertexColor2.TabIndex = 2;
            this.vertexColor2.SelectedIndexChanged += new System.EventHandler(this.vertexColor_SelectedIndexChanged);
            // 
            // vertexColor1
            // 
            this.vertexColor1.DropDownHeight = 500;
            this.vertexColor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vertexColor1.FormattingEnabled = true;
            this.vertexColor1.IntegralHeight = false;
            this.vertexColor1.Items.AddRange(new object[] {
            "BurlyWood",
            "Chartreuse",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Firebrick",
            "Fuchsia",
            "Goldenrod",
            "Indigo",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato"});
            this.vertexColor1.Location = new System.Drawing.Point(37, 12);
            this.vertexColor1.Name = "vertexColor1";
            this.vertexColor1.Size = new System.Drawing.Size(103, 21);
            this.vertexColor1.TabIndex = 1;
            this.vertexColor1.SelectedIndexChanged += new System.EventHandler(this.vertexColor_SelectedIndexChanged);
            // 
            // clearColor2
            // 
            this.clearColor2.DropDownHeight = 500;
            this.clearColor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clearColor2.FormattingEnabled = true;
            this.clearColor2.IntegralHeight = false;
            this.clearColor2.Items.AddRange(new object[] {
            "BurlyWood",
            "Chartreuse",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Firebrick",
            "Fuchsia",
            "Goldenrod",
            "Indigo",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato"});
            this.clearColor2.Location = new System.Drawing.Point(286, 549);
            this.clearColor2.Name = "clearColor2";
            this.clearColor2.Size = new System.Drawing.Size(103, 21);
            this.clearColor2.TabIndex = 7;
            this.clearColor2.SelectedIndexChanged += new System.EventHandler(this.clearColor2_SelectedIndexChanged);
            // 
            // vertexColor3b
            // 
            this.vertexColor3b.DropDownHeight = 500;
            this.vertexColor3b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vertexColor3b.FormattingEnabled = true;
            this.vertexColor3b.IntegralHeight = false;
            this.vertexColor3b.Items.AddRange(new object[] {
            "BurlyWood",
            "Chartreuse",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Firebrick",
            "Fuchsia",
            "Goldenrod",
            "Indigo",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato"});
            this.vertexColor3b.Location = new System.Drawing.Point(260, 12);
            this.vertexColor3b.Name = "vertexColor3b";
            this.vertexColor3b.Size = new System.Drawing.Size(103, 21);
            this.vertexColor3b.TabIndex = 6;
            this.vertexColor3b.SelectedIndexChanged += new System.EventHandler(this.vertexColor_SelectedIndexChanged);
            // 
            // vertexColor2b
            // 
            this.vertexColor2b.DropDownHeight = 500;
            this.vertexColor2b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vertexColor2b.FormattingEnabled = true;
            this.vertexColor2b.IntegralHeight = false;
            this.vertexColor2b.Items.AddRange(new object[] {
            "BurlyWood",
            "Chartreuse",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Firebrick",
            "Fuchsia",
            "Goldenrod",
            "Indigo",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato"});
            this.vertexColor2b.Location = new System.Drawing.Point(151, 12);
            this.vertexColor2b.Name = "vertexColor2b";
            this.vertexColor2b.Size = new System.Drawing.Size(103, 21);
            this.vertexColor2b.TabIndex = 5;
            this.vertexColor2b.SelectedIndexChanged += new System.EventHandler(this.vertexColor_SelectedIndexChanged);
            // 
            // vertexColor1b
            // 
            this.vertexColor1b.DropDownHeight = 500;
            this.vertexColor1b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vertexColor1b.FormattingEnabled = true;
            this.vertexColor1b.IntegralHeight = false;
            this.vertexColor1b.Items.AddRange(new object[] {
            "BurlyWood",
            "Chartreuse",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Firebrick",
            "Fuchsia",
            "Goldenrod",
            "Indigo",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato"});
            this.vertexColor1b.Location = new System.Drawing.Point(42, 12);
            this.vertexColor1b.Name = "vertexColor1b";
            this.vertexColor1b.Size = new System.Drawing.Size(103, 21);
            this.vertexColor1b.TabIndex = 4;
            this.vertexColor1b.SelectedIndexChanged += new System.EventHandler(this.vertexColor_SelectedIndexChanged);
            // 
            // spinningTriangleControl
            // 
            this.spinningTriangleControl.BackColor = System.Drawing.Color.Black;
            this.spinningTriangleControl.ClearColor = ((Microsoft.Xna.Framework.Color)(resources.GetObject("spinningTriangleControl.ClearColor")));
            this.spinningTriangleControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spinningTriangleControl.Location = new System.Drawing.Point(0, 0);
            this.spinningTriangleControl.Name = "spinningTriangleControl";
            this.spinningTriangleControl.Size = new System.Drawing.Size(396, 573);
            this.spinningTriangleControl.TabIndex = 0;
            this.spinningTriangleControl.VSync = false;
            // 
            // spinningTriangleControl1
            // 
            this.spinningTriangleControl1.BackColor = System.Drawing.Color.Black;
            this.spinningTriangleControl1.ClearColor = ((Microsoft.Xna.Framework.Color)(resources.GetObject("spinningTriangleControl1.ClearColor")));
            this.spinningTriangleControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spinningTriangleControl1.Location = new System.Drawing.Point(0, 0);
            this.spinningTriangleControl1.Name = "spinningTriangleControl1";
            this.spinningTriangleControl1.Size = new System.Drawing.Size(392, 573);
            this.spinningTriangleControl1.TabIndex = 1;
            this.spinningTriangleControl1.VSync = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "WinForms Graphics Device";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private SpinningTriangleControl spinningTriangleControl;
        private System.Windows.Forms.ComboBox vertexColor1;
        private System.Windows.Forms.ComboBox vertexColor3;
        private System.Windows.Forms.ComboBox vertexColor2;
        private System.Windows.Forms.ComboBox vertexColor3b;
        private System.Windows.Forms.ComboBox vertexColor2b;
        private System.Windows.Forms.ComboBox vertexColor1b;
        private SpinningTriangleControl spinningTriangleControl1;
        private System.Windows.Forms.ComboBox clearColor2;
        private System.Windows.Forms.ComboBox clearColor1;
    }
}

