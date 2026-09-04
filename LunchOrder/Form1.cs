using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LunchOrder
{
    public partial class Form1 : Form
    {

        private double mainCoursePrice = 6.95;
        private double addOnPrice = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void ClearTotals()
        {
            txtSubtotal.Text = "";
            txtSalesTax.Text = "";
            txtOrderTotal.Text = "";
        }

        private void ClearAddOns()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
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


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                mainCoursePrice = 4.95;
                addOnPrice = 2;
                groupBox1.Text = "Add-on items ($2/each)";
                checkBox1.Text = "Croutons";
                checkBox2.Text = "Bacon bits";
                checkBox3.Text = "Bread sticks";
                ClearAddOns();
                ClearTotals();
            }
        }


        private void btnPlaceOrder_Click_1(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
