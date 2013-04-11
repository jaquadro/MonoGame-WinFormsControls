//-----------------------------------------------------------------------------
// MainForm.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------

using System.Windows.Forms;

namespace WinFormsTemplate
{
    // System.Drawing and the XNA Framework both define Color types.
    // To avoid conflicts, we define shortcut names for them both.
    using GdiColor = System.Drawing.Color;
    using XnaColor = Microsoft.Xna.Framework.Color;

    
    /// <summary>
    /// Custom form provides the main user interface for the program.
    /// In this sample we used the designer to add a splitter pane to the form,
    /// which contains a SpriteFontControl and a SpinningTriangleControl.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            vertexColor1.SelectedIndex = 1;
            vertexColor2.SelectedIndex = 2;
            vertexColor3.SelectedIndex = 4;

            vertexColor1b.SelectedIndex = 7;
            vertexColor2b.SelectedIndex = 5;
            vertexColor3b.SelectedIndex = 6;

            clearColor1.SelectedIndex = 3;
            clearColor2.SelectedIndex = 8;
        }


        /// <summary>
        /// Event handler updates the spinning triangle control when
        /// one of the three vertex color combo boxes is altered.
        /// </summary>
        void vertexColor_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Which vertex was changed?
            int vertexIndex;

            if (sender == vertexColor1 || sender == vertexColor1b)
                vertexIndex = 0;
            else if (sender == vertexColor2 || sender == vertexColor2b)
                vertexIndex = 1;
            else if (sender == vertexColor3 || sender == vertexColor3b)
                vertexIndex = 2;
            else
                return;

            // Which color was selected?
            ComboBox combo = (ComboBox)sender;

            string colorName = combo.SelectedItem.ToString();

            GdiColor gdiColor = GdiColor.FromName(colorName);

            XnaColor xnaColor = new XnaColor(gdiColor.R, gdiColor.G, gdiColor.B);

            // Update the spinning triangle control with the new color.
            if (sender == vertexColor1 || sender == vertexColor2 || sender == vertexColor3)
                spinningTriangleControl.Vertices[vertexIndex].Color = xnaColor;
            else
                spinningTriangleControl1.Vertices[vertexIndex].Color = xnaColor;
        }

        private void clearColor1_SelectedIndexChanged (object sender, System.EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            string colorName = combo.SelectedItem.ToString();
            GdiColor gdiColor = GdiColor.FromName(colorName);
            XnaColor xnaColor = new XnaColor(gdiColor.R, gdiColor.G, gdiColor.B);

            spinningTriangleControl.ClearColor = xnaColor;
        }

        private void clearColor2_SelectedIndexChanged (object sender, System.EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            string colorName = combo.SelectedItem.ToString();
            GdiColor gdiColor = GdiColor.FromName(colorName);
            XnaColor xnaColor = new XnaColor(gdiColor.R, gdiColor.G, gdiColor.B);

            spinningTriangleControl1.ClearColor = xnaColor;
        }

        // For each GraphicsDeviceControl instance that you want to respond to input, call its
        // public-facing ProcessKeyMessage method.

        protected override bool ProcessKeyPreview (ref Message m)
        {
            spinningTriangleControl.ProcessKeyMessage(ref m);
            return base.ProcessKeyPreview(ref m);
        }
    }
}
