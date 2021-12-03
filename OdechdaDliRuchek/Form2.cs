using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdechdaDliRuchek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odechdaDliRushekDataSet.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.odechdaDliRushekDataSet.Material);

        }

        private void materialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.odechdaDliRushekDataSet);

        }

        private void iDLabel_Click(object sender, EventArgs e)
        {

        }

        private void iDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void imageLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
