using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            rdoFruitSalad.Checked = false;
            rdoPastaSalad.Checked = false;
            rdoFruitJuice.Checked = false;
            rdoCupCake.Checked = false;
            rdoShortCake.Checked = false;
            rdoSmoothie.Checked = false;

            textBox1.Text = "";
            txtSaladQty.Text = "";
            textBox3.Text = "";
            txtDrinkQty.Text = "";
            textBox5.Text = "";
            txtDessertQty.Text = "";

            lblDesserts.Text = "";
            lblDrinks.Text = "";
            lblSalad.Text = "";


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void BtnExitClick_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdoFruitSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFruitSalad.Checked)
            {
                textBox1.Text = "$9.95";
                lblSalad.Text = "Selection: Fruit Salad";
            }
        }

        private void rdoPastaSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPastaSalad.Checked)
            {
                textBox1.Text = "$12.00";
                lblSalad.Text = "Selection: Pasta Salad";
            }
        }

        private void rdoSmoothie_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSmoothie.Checked)
            {
                textBox3.Text = "$4.95";
                lblDrinks.Text = "Selection: Smoothie";
            }
        }

        private void rdoFruitJuice_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFruitJuice.Checked)
            {
                textBox3.Text = "$3.95";
                lblDrinks.Text = "Selection: Fruit Juice";
            }
        }

        private void rdoCupCake_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCupCake.Checked)
            {
                textBox5.Text = "$3.00";
                lblDesserts.Text = "Selection: Cup Cake";
            }
        }

        private void rdoShortCake_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoShortCake.Checked)
            {
                textBox5.Text = "$6.00";
                lblDesserts.Text = "Selection: Short Cake";
            }
           
        }

        private void lblSalad_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblCalculate_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            //salad price
            double SaladPrice = 0;
            if(rdoFruitSalad.Checked == false && rdoPastaSalad.Checked == false)
            {
                MessageBox.Show("You must select a salad!");
                return;
            }
            else if(rdoFruitSalad.Checked == true)
            {
                SaladPrice = 9.95;
            }
            else if (rdoPastaSalad.Checked == true)
            {
                SaladPrice = 12.00;
            }
            //drink price
            double DrinkPrice = 0;
            if(rdoSmoothie.Checked == false && rdoFruitJuice.Checked == false)
            {
                MessageBox.Show("You must select a drink!");
                return;
            }
            else if(rdoSmoothie.Checked == true)
            {
                DrinkPrice = 4.95;
            }
            else if(rdoFruitJuice.Checked == true)
            {
                DrinkPrice = 3.95;
            }
            //dessert price
            double DessertPrice = 0;
            if (rdoCupCake.Checked == false && rdoShortCake.Checked == false)
            {
                MessageBox.Show("You must select a dessert!");
                return;
            }
            else if (rdoCupCake.Checked == true)
            {
                DessertPrice = 3.00;
            }
            else if (rdoShortCake.Checked == true)
            {
                DessertPrice = 6.00;
            }
            //salad qty
            int SaladQty = 0;
            if(int.TryParse(txtSaladQty.Text, out SaladQty) == false)
            {
                MessageBox.Show("Please enter a number for salad quantity!");
                return;
            }
            //drink qty
            int DrinkQty = 0;
            if(int.TryParse(txtDrinkQty.Text, out DrinkQty) == false)
            {
                MessageBox.Show("Please enter a number for drink quantity!");
                return;
            }
            //dessert qty
            int DessertQty = 0;
            if(int.TryParse(txtDessertQty.Text, out DessertQty) == false)
            {
                MessageBox.Show("Please enter a number for dessert quantity!");
                return;
            }

            double Total = (SaladPrice * SaladQty) + (DrinkPrice * DrinkQty) + (DessertPrice * DessertQty);
            int TotalQty = SaladQty + DrinkQty + DessertQty;
            lblCalculate.Text =
                "Total Amount Due: " + Total.ToString("C") + System.Environment.NewLine +
                "Total Items: " + TotalQty.ToString("F0");
        }
    }
}
