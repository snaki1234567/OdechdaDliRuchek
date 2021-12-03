using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Data.SqlClient;
namespace OdechdaDliRuchek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odechdaDliRushekDataSet.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.odechdaDliRushekDataSet.Material);
            using (Model1 db = new Model1())
            {

                // Отложенный запрос
                var materials = db.Material;
                int count = 1;
                // Извлечь всех заказчиков и отобразить их имена в консоли
                foreach (Material materialObj in materials)
                {
                    InitializeMyGroupBox(30, -40 + 100 * count, materialObj.Title, materialObj.MinCount, materialObj.Unit, materialObj.ID, materialObj.Image);
                    count++;
                }
            }
        }
        private void InitializeMyGroupBox(int x, int y, string Title, double minCoin, String Unit, int CountInStock, String image_path)
        {
            // Create and initialize a GroupBox and a Button control.

             
            GroupBox groupBox1 = new GroupBox();

            // Create image.
            if (image_path == null || image_path.Equals("")) image_path = "C:/Users/Stud305/source/repos/ConsoleApplication13/materials/picture.png";
            else image_path = "C:/Users/Stud305/source/repos/ConsoleApplication13/materials/" + image_path.Substring(11);
            Image newImage = Image.FromFile(image_path);

            PictureBox picture = new PictureBox();
            picture.Image = newImage;
            picture.Location = new Point(1, 28);
            picture.Width = 200;
            picture.SizeMode = PictureBoxSizeMode.Zoom;

            //TODO get material type
            Label lb_title = new Label();
            lb_title.Text = "Тип материала | " + Title;
            lb_title.Location = new Point(200, 13);
            lb_title.Width = 230;

            //TODO min quontity
            Label lb_countInPack = new Label();
            lb_countInPack.Text = "Минимальное количество: " + minCoin.ToString() ;
            lb_countInPack.Location = new Point(200, 35);
            lb_countInPack.Width = 250;

            //TODO rename
            Label lb_unit = new Label();
            lb_unit.Text = "Поставщики: SOMETEXT";
            lb_unit.Location = new Point(200, 60);
            lb_unit.Width = 250;

            Label lb_countInStock = new Label();
            lb_countInStock.Text = "Остаток: " + CountInStock.ToString();
            lb_countInStock.Location = new Point(550, 13);
            lb_countInStock.Width = 120;

            groupBox1.Height = 100;
            groupBox1.Width = 700;

            // Add the Button to the GroupBox.
            groupBox1.Controls.Add(lb_title);
            groupBox1.Controls.Add(lb_countInPack);
            groupBox1.Controls.Add(lb_unit);
            groupBox1.Controls.Add(lb_countInStock);
            groupBox1.Controls.Add(picture);

            groupBox1.Location = new Point(x, y);

            // Add the GroupBox to the Form.
            flowLayoutPanel1.Controls.Add(groupBox1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        materialBindingSource.Sort = "[id] DESC";
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

