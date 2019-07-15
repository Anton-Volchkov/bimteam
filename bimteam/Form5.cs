using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bimteam
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        Logic.View _view;

        public Form5(Logic.View view)
        {
            InitializeComponent();

            _view = view;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            circularProgressBar1.Maximum = 1;
            circularProgressBar1.Value = 0;

            var v = _view.BatFiles.Where(x => x.Seccion == comboBox1.SelectedItem.ToString());

            listBox1.Items.Clear();
             foreach (var item in v)
             {
               listBox1.Items.Add(item.FileName);
             }
          
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(_view.PhotoPath);
            richTextBox1.Text = _view.Text;
            circularProgressBar1.Value = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           var v = _view.BatFiles.Where(x => x.Seccion == comboBox1.Text);

            circularProgressBar1.Maximum = v.Count();
            foreach (var item in v)
            {
                ++circularProgressBar1.Value;
                Task.Run(() => {
                    
                    using (Process myProcess = new Process())
                    {
                        myProcess.StartInfo.UseShellExecute = false;
                        // You can start any process, HelloWorld is a do-nothing example.
                        myProcess.StartInfo.FileName = item.Path;
                        myProcess.StartInfo.CreateNoWindow = false;
                        myProcess.Start();
                        // This code assumes the process you are starting will terminate itself. 
                        // Given that is is started without a window so you cannot terminate it 
                        // on the desktop, it must terminate itself or you can do it programmatically
                        // from this application using the Kill method.
                    }
                });
            }
            MessageBox.Show("Все файлы были запущены!");
            circularProgressBar1.Value = 0;

        }
    }
}
