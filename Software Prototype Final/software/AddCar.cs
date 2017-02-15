using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software
{
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }
        private void frmRegStock_Load(object sender, EventArgs e)
        {
            txtStockNo.Text = Stock.nextStockNo().ToString("00000");
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            //validate data

            //instantiate Stock Object
            Stock myStock = new Stock(Convert.ToInt32(txtStockNo.Text), txtDescription.Text, Convert.ToDecimal(txtCostPrice.Text), Convert.ToDecimal(txtSalePrice.Text), Convert.ToInt32(txtQty.Text));

            //INSERT Stock record into stock table
            myStock.newStock();

            //Display confirmation message
            MessageBox.Show("Stock " + txtStockNo.Text + " Registered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            txtDescription.Text = "";
            txtCostPrice.Text = "";
            txtSalePrice.Text = "";
            txtQty.Text = "";

            txtStockNo.Text = Stock.nextStockNo().ToString("00000");
            txtDescription.Focus();
        }
    }
}
