using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_About_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.Show();
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] data = File.ReadAllBytes(openFileDialog.FileName);
                    textBox_Input.Text = "Хэш вычеслен для файла: " + openFileDialog.FileName;

                    Culculate(data);
                }
            }
        }

        private void button_Culс_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.ASCII.GetBytes(textBox_Input.Text);

            Culculate(data);
        }

        private void Culculate(byte [] data)
        {
            textBox_Result.Text = MD5.Calculate(data).ToUpper();
        }
    }
}
