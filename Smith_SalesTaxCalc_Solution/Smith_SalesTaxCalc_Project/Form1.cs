using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Smith_SalesTaxCalc_Project
{
    public partial class BillyForm : Form
    {
       
        public BillyForm()
        {
            InitializeComponent();
        }
        class cTax
        {
            public double item1;
            public double LTaxRate = 0.86;
            public double GetAmount()
            {
                return item1;
            }

            public double cFindTax(double cAmount)
            {
                double FindTax = cAmount - (cAmount * LTaxRate);
                return FindTax;
            }
        }
        private void BillyText_TextChanged(object sender, EventArgs e)
        {

        }

        private void BillyForm_Load(object sender, EventArgs e)
        {
            chWarrantyBox.SelectedIndex = 0;
            chStateBox.SelectedIndex = 0;
        }

        private void BasePriceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void WarrantyText_TextChanged(object sender, EventArgs e)
        {

        }

        private void StateText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LBasePriceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LTotalCost_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            chWarrantyBox.SelectedIndex = 0;
            chStateBox.SelectedIndex = 0;
            
        }

        private void chStateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void chWarrantyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            cTax Tax = new cTax();


        }
    }
}
