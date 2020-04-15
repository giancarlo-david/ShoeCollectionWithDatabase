using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeCollectionWithDatabase
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            List<Shoe> shoeList = ShoeDB.GetAllShoes();
            dgvShoes.DataSource = shoeList;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvShoes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string brand = dgvShoes.CurrentRow.Cells[0].Value.ToString();
                string model = dgvShoes.CurrentRow.Cells[1].Value.ToString();
                string colorway = dgvShoes.CurrentRow.Cells[2].Value.ToString();
                decimal size = (decimal)dgvShoes.CurrentRow.Cells[3].Value;


                Shoe tempShoe = ShoeDB.GetShoe(brand, model, colorway, size);

                if (tempShoe != null)
                {
                    tbCurrentShoe.Text = tempShoe.ToString();
                }

                else
                {
                    MessageBox.Show("That shoe is not valid now");
                }
            }
            catch
            {
                MessageBox.Show("Please select a valid shoe");
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string brand = dgvShoes.CurrentRow.Cells[0].Value.ToString();
                string model = dgvShoes.CurrentRow.Cells[1].Value.ToString();
                string colorway = dgvShoes.CurrentRow.Cells[2].Value.ToString();
                decimal size = (decimal)dgvShoes.CurrentRow.Cells[3].Value;

                Shoe tempShoe = ShoeDB.GetShoe(brand, model, colorway, size);

                DialogResult dialog = MessageBox.Show("Are you sure you want to delete " + tempShoe.ToString() + "?",
                    "Verify", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    ShoeDB.DeleteShoe(tempShoe);
                    MessageBox.Show("The shoe was removed successfully!");
                    this.DialogResult = DialogResult.OK;

                    List<Shoe> shoeList = ShoeDB.GetAllShoes();
                    dgvShoes.DataSource = shoeList;
                }
            }

            catch
            {
                MessageBox.Show("There is no shoe to remove there");
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            formAddShoe form = new formAddShoe();
            DialogResult r = form.ShowDialog();
            
            if (r == DialogResult.OK)
            {
                List<Shoe> shoeList = ShoeDB.GetAllShoes();
                dgvShoes.DataSource = shoeList;
            }
        }
    }
}
