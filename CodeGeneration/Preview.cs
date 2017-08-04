using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGeneration
{
    public partial class Preview : Form
    {
        public Preview(string file)
        {
            InitializeComponent();
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                this.syntaxTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }

        }
        public Preview()
        {
            InitializeComponent();
        }

        private void 点击复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(syntaxTextBox1.Text);
            MessageBox.Show("复制成功");
        }
    }
}
