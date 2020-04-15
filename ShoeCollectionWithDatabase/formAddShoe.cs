using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShoeCollectionWithDatabase
{
    public partial class formAddShoe : Form
    {
        public formAddShoe()
        {
            InitializeComponent();
        }

        private void buttonAddShoe_Click(object sender, EventArgs e)
        {
            try
            {
                string brand = cbBrand.SelectedValue.ToString();
                decimal size = decimal.Parse(cbSize.SelectedItem.ToString());

                Shoe tempShoe = new Shoe
                {
                    Brand = brand,
                    Model = tbModel.Text.ToString(),
                    Colorway = tbColorway.Text.ToString(),
                    Size = size,
                };

                try
                { 
                    ShoeDB.AddShoe(tempShoe);
                    MessageBox.Show("The shoe was added successfully");
                }

                catch
                {
                    MessageBox.Show("Error adding shoe");
                }
            }
            catch
            {
                MessageBox.Show("Fill all the fields properly");
            }
        }

        private void formAddShoe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'brandsDataSet.Brands' table. You can move, or remove it, as needed.
            this.brandsTableAdapter.Fill(this.brandsDataSet.Brands);

        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
