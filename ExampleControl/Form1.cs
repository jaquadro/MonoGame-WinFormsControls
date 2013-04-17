using System.Windows.Forms;
using Microsoft.Xna.Framework;

namespace ExampleControl
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent();

            toolStripComboBox1.Items.AddRange(new object[] {
                "Blue", "Cyan", "Green", "Magenta", "Red", "Yellow"
            });
            toolStripComboBox1.SelectedIndex = 1;
        }

        private void toolStripComboBox1_TextChanged (object sender, System.EventArgs e)
        {
            selectedCellsControl1.SetColor((string)toolStripComboBox1.SelectedItem);
        }
    }
}
