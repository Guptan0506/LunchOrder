namespace LunchOrder
{
    public partial class Form1 : Form
    {

        private double mainCoursePrice = 6.95;
        private double addOnPrice = 0.75;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearTotals()
        {
            txtSubtotal.Text = "";
            txtSalesTax.Text = "";
            txtOrderTotal.Text = "";
        }

        private void ClearAddOns()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }
        private void radHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                mainCoursePrice = 6.95;
                addOnPrice = 2;
                groupBox1.Text = "Add-on items ($2/each)";
                checkBox1.Text = "Lettuce, tomato, and onions";
                checkBox2.Text = "Ketchup, mustard, and mayo";
                checkBox3.Text = "French fries";
                ClearAddOns();
                ClearTotals();
            }
        }

        private void radPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                mainCoursePrice = 5.95;
                addOnPrice = 2;
                groupBox1.Text = "Add-on items ($2/each)";
                checkBox1.Text = "Pepperoni";
                checkBox2.Text = "Sausage";
                checkBox3.Text = "Olives";
                ClearAddOns();
                ClearTotals();
            }
        }

        private void radSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                mainCoursePrice = 4.95;
                addOnPrice = 0.25;
                groupBox1.Text = "Add-on items ($2/each)";
                checkBox1.Text = "Croutons";
                checkBox2.Text = "Bacon bits";
                checkBox3.Text = "Bread sticks";
                ClearAddOns();
                ClearTotals();
            }
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            double subtotal = mainCoursePrice;

            if (checkBox1.Checked) subtotal += addOnPrice;
            if (checkBox2.Checked) subtotal += addOnPrice;
            if (checkBox3.Checked) subtotal += addOnPrice;

            double tax = subtotal * 0.0775;
            double total = subtotal + tax;

            txtSubtotal.Text = subtotal.ToString("C");
            txtSalesTax.Text = tax.ToString("C");
            txtOrderTotal.Text = total.ToString("C");
        }

        // ---------- 4. Add-on checkboxes ----------
        private void chkAddOn_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }

    }
}
