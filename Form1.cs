using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCasherProgram
{
    public partial class MakePizzaScreen : Form
    {
       

        public MakePizzaScreen()
        {
            InitializeComponent();
            UpdateEveryThing();
        }
        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }
            else if (rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);

            }
            else
            {
                return Convert.ToSingle(rbLarge.Tag);

            }

        }
        float GetSelectedToppingsPrice()
        {
            float ToppingsTotalPrice = 0;
            if (chkExtraCheese.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkExtraCheese.Tag);
            }
            if (chkGreenPepper.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkGreenPepper.Tag);
            }
            if (chkMushroms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkMushroms.Tag);
            }
            if (chkOlivies.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOlivies.Tag);
            }
            if (chkOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }
            if (chkTomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTomatoes.Tag);
            }
            return ToppingsTotalPrice;
        }
        float GetSelectedCrustPrice()
        {
            if (rbThinCrust.Checked)
            {
                return Convert.ToSingle(rbThinCrust.Tag);
            }
            else
            {
                return Convert.ToSingle(rbThinkCrust.Tag);

            }
        }
        float GetTotalPrice()
        {
            return (GetSelectedCrustPrice() + GetSelectedSizePrice() + GetSelectedToppingsPrice());
        }
        void UpdateTotalPrice()
        {

            lblTotalPrice.Text = "$" + GetTotalPrice().ToString();
        }
        void UpdateSize()
        {
            UpdateTotalPrice();
            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }
            if (rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                return;

            }
            if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }

        }
        void UpdateToppings()
        {
            string sToppings = "";
            UpdateTotalPrice();
            if (chkExtraCheese.Checked)
            {
                sToppings += "Extra Cheese,";
            }
            if (chkGreenPepper.Checked)
            {
                sToppings += "GreenPepper,";
            }
            if (chkMushroms.Checked)
            {
                sToppings += "Mushroms,";
            }
            if (chkOlivies.Checked)
            {
                sToppings += "Olivies,";
            }
            if (chkOnion.Checked)
            {
                sToppings += "Onion,";
            }
            if (chkTomatoes.Checked)
            {
                sToppings += "Tomatoes";
            }
            if (sToppings == "")
            {
                lblToppings.Text = "No Toppings";
                return ;
            }
            lblToppings.Text = sToppings;
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushroms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlivies_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPepper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateSize();

        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateSize();

        }

        void UpdateCrustStatus()
        {
            UpdateTotalPrice();
            if (rbThinCrust.Checked) 
            {
                lblCrustType.Text = "Thin Crust";
            }
            else {
                lblCrustType.Text = "Think Crust";
            }

        }
        void UpdataEatingPlace()
        {
            UpdateTotalPrice();
            if (rbEatin.Checked)
            {
                lblEatingPlace.Text = "Eat in";
            }
            else
            {
                lblEatingPlace.Text = "Take Out";

            }
        }


        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustStatus();

        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustStatus();
        }

        private void rbEatin_CheckedChanged(object sender, EventArgs e)
        {
            UpdataEatingPlace();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdataEatingPlace();
        }

        


        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                chkExtraCheese.Enabled = false;
                chkGreenPepper.Enabled = false;
                chkMushroms.Enabled = false;
                chkOlivies.Enabled = false;
                chkOnion.Enabled = false;
                chkTomatoes.Enabled = false;
                rbEatin.Enabled = false;
                rbThinCrust.Enabled = false;
                rbThinkCrust.Enabled = false;
                rbTakeOut.Enabled = false;
                rbSmall.Enabled = false;
                rbMedium.Enabled = false;
                rbLarge.Enabled = false;
            }
            else
            {
                return;
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            chkExtraCheese.Enabled = true;
            chkGreenPepper.Enabled = true;
            chkMushroms.Enabled = true;
            chkOlivies.Enabled = true;
            chkOnion.Enabled = true;
            chkTomatoes.Enabled = true;
            rbEatin.Enabled = true;
            rbThinCrust.Enabled = true;
            rbThinkCrust.Enabled = true;
            rbTakeOut.Enabled = true;
            rbSmall.Enabled = true;
            rbMedium.Enabled = true;
            rbLarge.Enabled = true;

            chkExtraCheese.Checked = false;
            chkGreenPepper.Checked = false;
            chkMushroms.Checked = false;
            chkOlivies.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;
            rbEatin.Checked = true;
            rbThinCrust.Checked = true;
            rbThinkCrust.Checked = false;
            rbTakeOut.Checked = false;
            rbSmall.Checked = false;
            rbMedium.Checked = true;
            rbLarge.Checked = false;

        }
        void UpdateEveryThing()
        {
            UpdateSize();
            UpdateTotalPrice();
            UpdateToppings();
            UpdataEatingPlace();
            UpdateCrustStatus();
        }

      
    }
    
};
