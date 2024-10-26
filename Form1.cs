using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;
using System.Windows.Media;

namespace MakeYourPizzaWindowsApp
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        
        
        float CalculatePitzzaCrust()
        {
            float CurstPrice = 0; 
            if(rdiobtn_ThinCurst.Checked)
            {
               CurstPrice = Convert.ToSingle(rdiobtn_ThinCurst.Tag);
               return CurstPrice;
            }
            
            if (rdiobtn_BigCrust.Checked)
             CurstPrice = Convert.ToSingle(rdiobtn_BigCrust.Tag);

            return CurstPrice;
        }
        float CalculateToppingsPrice()
        {
            float ToppingsPrice = 0; 

            if(chkbx_ExtraChees.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkbx_ExtraChees.Tag);
            }
            if (chkbx_Mushrooms.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkbx_Mushrooms.Tag);
            }
            if (chkbx_GreenPeppers.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkbx_GreenPeppers.Tag);
            }
            if(chkbx_Olives.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkbx_Olives.Tag);
            }
            if (chkbx_Onion.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkbx_Onion.Tag);
            }
            if(chkbx_Tomatoes.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkbx_Tomatoes.Tag);
            }
            return ToppingsPrice;

        }

        float GetSelectedSizePrice()
        {

            if (rdiobtn_SmalPizzaSize.Checked)
            
              return Convert.ToSingle(rdiobtn_SmalPizzaSize.Tag);

            else if (rdiobtn_MeduimPizzaSize.Checked)
            {
                return Convert.ToSingle(rdiobtn_MeduimPizzaSize.Tag);

            }

            else 
            {
                return Convert.ToSingle(rdiobtn_LargePizaaSize.Tag);

            }
            
            
        }
        float CalculateTotalPrice()
         {
            return ( GetSelectedSizePrice() + CalculateToppingsPrice() + CalculatePitzzaCrust());
         }
        void UpdateCalculateTotalPrice()
        {
            lbl_ShowTotalPrice.Text = "$ " + CalculateTotalPrice().ToString();
        }
        void UpdateSizeSelected()
         {
              UpdateCalculateTotalPrice();

            if(rdiobtn_SmalPizzaSize.Checked == true )
            {
                 lbl_Show_PizzSize.Text = rdiobtn_SmalPizzaSize.Text;
            } 
            if(rdiobtn_MeduimPizzaSize.Checked == true)
            {
                lbl_Show_PizzSize.Text = rdiobtn_MeduimPizzaSize.Text;
            }
            if(rdiobtn_LargePizaaSize.Checked == true)
            {
                lbl_Show_PizzSize.Text = rdiobtn_LargePizaaSize.Text;
            }

         }
        bool UpdateCrust()
         {
             UpdateCalculateTotalPrice();

            if (rdiobtn_BigCrust.Checked == true)
            {
                lbl_ShowPizzaCrustType.Text = rdiobtn_BigCrust.Text;
               
                return true; 
            } 
            if (rdiobtn_ThinCurst.Checked == true )
            {
                lbl_ShowPizzaCrustType.Text = rdiobtn_ThinCurst.Text;
                return true;
            }
            return false;
         }

       
         void UpdateToppings()
         {

            UpdateCalculateTotalPrice();
            string Toppings = " ";
            if (chkbx_ExtraChees.Checked)
            {

                Toppings += chkbx_ExtraChees.Text + " ,";
                
            };

            if(chkbx_Mushrooms.Checked == true)
            {
                Toppings += chkbx_Mushrooms.Text + ",";
               
                
            }
            if (chkbx_GreenPeppers.Checked == true)
            {
                Toppings += chkbx_GreenPeppers.Text + ",";
                

            }
            if (chkbx_Olives.Checked == true)
            {
                Toppings += chkbx_Olives.Text + ",";
                
            }
            if (chkbx_Onion.Checked == true)
            {
                Toppings += chkbx_Onion.Text + ",";
              
            }
            if (chkbx_Tomatoes.Checked == true)
            {
                Toppings += chkbx_Tomatoes.Text + ",";
               

            }

            if( Toppings.StartsWith(",") )
            {
                Toppings = Toppings.Substring(0, Toppings.Length - 1);
            }
            lbl_Show_PizzaToppings.Text = Toppings;
         }
         void ResetForm()
         {
            btn_OrderPizza.Enabled = true;
            pnl_PizzaSIZE.Enabled = true;
            pnl_PizzaToppings.Enabled = true;
            pnl_CurstType.Enabled = true;
            pnl_WhereToEat.Enabled = true;


            // reset Toppings
            chkbx_ExtraChees.Checked = false;
            chkbx_Mushrooms.Checked = false;
            chkbx_Olives.Checked = false;
            chkbx_Tomatoes.Checked = false;
            chkbx_GreenPeppers.Checked = false;
            chkbx_Onion.Checked = false;

            //Size By defult Meduim; 
            rdiobtn_MeduimPizzaSize.Checked = true;

            // Reset Crust By Defult Thin Crust
            rdiobtn_ThinCurst.Checked = true;

            // Where To Eat By Defult OutSide
            rdiobtn_OutSideEat.Checked = true;
         }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void rdiobtn_SmalPizzaSize_CheckedChanged(object sender, EventArgs e)
        {
                 UpdateSizeSelected();
        }

        private void rdiobtn_MeduimPizzaSize_CheckedChanged(object sender, EventArgs e)
        {
                 UpdateSizeSelected();
        }

        private void rdiobtn_LargePizaaSize_CheckedChanged(object sender, EventArgs e)
        {
                 UpdateSizeSelected();
        }

        private void chkbx_ExtraChees_CheckedChanged(object sender, EventArgs e)
        {

               UpdateToppings();
        }

        private void chkbx_Mushrooms_CheckedChanged(object sender, EventArgs e)
        {
              UpdateToppings();
        }

        private void chkbx_Tomatoes_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();
        }

        private void chkbx_Onion_CheckedChanged(object sender, EventArgs e)
        {
             UpdateToppings();
        }

        private void chkbx_Olives_CheckedChanged(object sender, EventArgs e)
        {
             UpdateToppings();
        }

        private void chkbx_GreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
              UpdateToppings();
        }

        private void rdioBtn_ThinCurst_CheckedChanged(object sender, EventArgs e)
        {

                 UpdateCrust();
        }

        private void rdiobtn_BigCrust_CheckedChanged(object sender, EventArgs e)
        {
                 UpdateCrust();
        }

        private void rdiobtn_InsideEat_CheckedChanged(object sender, EventArgs e)
        {
            if(rdiobtn_InsideEat.Checked == true)
            {
                lbl_ShowWhereToEat.Text = rdiobtn_InsideEat.Text;
                return;
            }
        }

        private void rdiobtn_OutSideEat_CheckedChanged(object sender, EventArgs e)
        {
            if(rdiobtn_OutSideEat.Checked == true)
            {
                lbl_ShowWhereToEat.Text = rdiobtn_OutSideEat.Text;
                return;
            }
        }

        private void CheckOrderbtn(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order" , "Confirm" , MessageBoxButtons.OKCancel , MessageBoxIcon.Question) ==DialogResult.OK )
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_OrderPizza.Enabled = false;
                pnl_PizzaSIZE.Enabled = false;
                pnl_PizzaToppings.Enabled = false;
                pnl_CurstType.Enabled = false;
                pnl_WhereToEat.Enabled = false;


            }
        }

        private void Resetbtn(object sender, EventArgs e)
        {

            ResetForm();
          
        }

    }
}
