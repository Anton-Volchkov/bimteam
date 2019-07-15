using bimteam.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace bimteam
{
    public partial class Form3 : Form
    {

        Logic.View _view;
        List<Logic.View> _views;
        
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(int id , List<Logic.View> views)
        {
            InitializeComponent();
            _views = views;
            var v = _views.FirstOrDefault(x => x.ID == id);

            if (v == null)
            {
                _view = new Logic.View();
                _views.Add(_view);
            }
            else
            _view = v;

            _view.ID = id;

            if (! string.IsNullOrWhiteSpace(_view.Text))
            {
                richTextBox1.Text = _view.Text;
            }

            if (! string.IsNullOrWhiteSpace(_view.Text))
            {
                pictureBox1.Image = Image.FromFile(_view.PhotoPath) ?? Image.FromFile("");
            }
         
        }
   
        private void Button1_Click(object sender, EventArgs e)
        {
            string path;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;

                pictureBox1.Image = System.Drawing.Image.FromFile(path);

                _view.PhotoPath = path;
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4(_view);

            fr4.ShowDialog();

            _view.BatFiles = fr4.BatFiles;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            _view.Text = richTextBox1.Text;

            var binFormatter = new BinaryFormatter();


            if (File.Exists(@"groups.bin"))
            {
                File.Delete(@"groups.bin");
            }

            using (var file = new FileStream("groups.bin", FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(file, _views);
            }

            MessageBox.Show("Информация сохранена!");

        }
    }
}
