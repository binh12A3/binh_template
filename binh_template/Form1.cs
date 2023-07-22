using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binh_template
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // bo tròn 4 góc
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg_im = new OpenFileDialog();
                //dlg_im.Filter = "Excel File|*.xls;*.xlsx;*.xlsm";
                //dlg_im.Filter = "Text|*.txt|All|*.*";

                if (dlg_im.ShowDialog() == DialogResult.OK)
                {
                    textBoxPath.Text = dlg_im.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = Environment.CurrentDirectory;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string newRef = Helper.newReference("ID");
            textBoxPath.Text = newRef;

            string str = "AnhYeuEm";
            Console.WriteLine("==>" + str.Between("Anh", "Em"));

            progressBar1.Value = 50;

            MessageBox.Show("Done");
        }
    }
}
