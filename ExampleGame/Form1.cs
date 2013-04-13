using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExampleGame
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent();

            exampleGame1.BottomHitCountChanged += HandleBottomHitCountChanged;
        }

        protected override bool ProcessKeyPreview (ref Message m)
        {
            exampleGame1.ProcessKeyMessage(ref m);
            return base.ProcessKeyPreview(ref m);
        }

        protected override bool ProcessCmdKey (ref Message msg, Keys keyData)
        {
            exampleGame1.ProcessKeyMessage(ref msg);
            if (checkBox1.Checked)
                return true;

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void HandleBottomHitCountChanged (object sender, EventArgs e)
        {
            textBox1.Text = exampleGame1.BottomHitCount.ToString();
        }

        private void numericUpDown1_ValueChanged (object sender, EventArgs e)
        {
            exampleGame1.SetBallCount((int)numericUpDown1.Value);
        }
    }
}
