using System.Drawing;

namespace MakeYourPizzaWindowsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_PizzaToppings = new System.Windows.Forms.Panel();
            this.chkbx_GreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkbx_Olives = new System.Windows.Forms.CheckBox();
            this.chkbx_Onion = new System.Windows.Forms.CheckBox();
            this.chkbx_Tomatoes = new System.Windows.Forms.CheckBox();
            this.chkbx_Mushrooms = new System.Windows.Forms.CheckBox();
            this.chkbx_ExtraChees = new System.Windows.Forms.CheckBox();
            this.pnllbl_Toppings = new System.Windows.Forms.Label();
            this.pnllbl_Size = new System.Windows.Forms.Label();
            this.rdiobtn_SmalPizzaSize = new System.Windows.Forms.RadioButton();
            this.rdiobtn_MeduimPizzaSize = new System.Windows.Forms.RadioButton();
            this.rdiobtn_LargePizaaSize = new System.Windows.Forms.RadioButton();
            this.pnl_PizzaSIZE = new System.Windows.Forms.Panel();
            this.pnl_PizzaSummary = new System.Windows.Forms.Panel();
            this.lbl_ShowTotalPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_ShowWhereToEat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_ShowPizzaCrustType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Show_PizzaToppings = new System.Windows.Forms.Label();
            this.lbl_Show_PizzSize = new System.Windows.Forms.Label();
            this.lblpnl_Toppings = new System.Windows.Forms.Label();
            this.lblpnl_Size = new System.Windows.Forms.Label();
            this.lblpnl_OrderSummary = new System.Windows.Forms.Label();
            this.pnl_CurstType = new System.Windows.Forms.Panel();
            this.rdiobtn_BigCrust = new System.Windows.Forms.RadioButton();
            this.rdiobtn_ThinCurst = new System.Windows.Forms.RadioButton();
            this.lblCurstType = new System.Windows.Forms.Label();
            this.pnl_WhereToEat = new System.Windows.Forms.Panel();
            this.rdiobtn_OutSideEat = new System.Windows.Forms.RadioButton();
            this.rdiobtn_InsideEat = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_OrderPizza = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnl_PizzaToppings.SuspendLayout();
            this.pnl_PizzaSIZE.SuspendLayout();
            this.pnl_PizzaSummary.SuspendLayout();
            this.pnl_CurstType.SuspendLayout();
            this.pnl_WhereToEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(908, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "  MAKE  YOUR  PIZZA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_PizzaToppings
            // 
            this.pnl_PizzaToppings.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_PizzaToppings.Controls.Add(this.chkbx_GreenPeppers);
            this.pnl_PizzaToppings.Controls.Add(this.chkbx_Olives);
            this.pnl_PizzaToppings.Controls.Add(this.chkbx_Onion);
            this.pnl_PizzaToppings.Controls.Add(this.chkbx_Tomatoes);
            this.pnl_PizzaToppings.Controls.Add(this.chkbx_Mushrooms);
            this.pnl_PizzaToppings.Controls.Add(this.chkbx_ExtraChees);
            this.pnl_PizzaToppings.Controls.Add(this.pnllbl_Toppings);
            this.pnl_PizzaToppings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_PizzaToppings.Location = new System.Drawing.Point(230, 156);
            this.pnl_PizzaToppings.Name = "pnl_PizzaToppings";
            this.pnl_PizzaToppings.Size = new System.Drawing.Size(337, 198);
            this.pnl_PizzaToppings.TabIndex = 4;
            // 
            // chkbx_GreenPeppers
            // 
            this.chkbx_GreenPeppers.Location = new System.Drawing.Point(186, 135);
            this.chkbx_GreenPeppers.Name = "chkbx_GreenPeppers";
            this.chkbx_GreenPeppers.Size = new System.Drawing.Size(147, 24);
            this.chkbx_GreenPeppers.TabIndex = 6;
            this.chkbx_GreenPeppers.Tag = "3";
            this.chkbx_GreenPeppers.Text = "Green Peppers";
            this.chkbx_GreenPeppers.UseVisualStyleBackColor = true;
            this.chkbx_GreenPeppers.CheckedChanged += new System.EventHandler(this.chkbx_GreenPeppers_CheckedChanged);
            // 
            // chkbx_Olives
            // 
            this.chkbx_Olives.AutoSize = true;
            this.chkbx_Olives.Location = new System.Drawing.Point(186, 96);
            this.chkbx_Olives.Name = "chkbx_Olives";
            this.chkbx_Olives.Size = new System.Drawing.Size(77, 24);
            this.chkbx_Olives.TabIndex = 5;
            this.chkbx_Olives.Tag = "4";
            this.chkbx_Olives.Text = "Olives";
            this.chkbx_Olives.UseVisualStyleBackColor = false;
            this.chkbx_Olives.CheckedChanged += new System.EventHandler(this.chkbx_Olives_CheckedChanged);
            // 
            // chkbx_Onion
            // 
            this.chkbx_Onion.AutoSize = true;
            this.chkbx_Onion.Location = new System.Drawing.Point(186, 58);
            this.chkbx_Onion.Name = "chkbx_Onion";
            this.chkbx_Onion.Size = new System.Drawing.Size(77, 24);
            this.chkbx_Onion.TabIndex = 4;
            this.chkbx_Onion.Tag = "2";
            this.chkbx_Onion.Text = "Onion";
            this.chkbx_Onion.UseVisualStyleBackColor = true;
            this.chkbx_Onion.CheckedChanged += new System.EventHandler(this.chkbx_Onion_CheckedChanged);
            // 
            // chkbx_Tomatoes
            // 
            this.chkbx_Tomatoes.AutoSize = true;
            this.chkbx_Tomatoes.Location = new System.Drawing.Point(49, 135);
            this.chkbx_Tomatoes.Name = "chkbx_Tomatoes";
            this.chkbx_Tomatoes.Size = new System.Drawing.Size(106, 24);
            this.chkbx_Tomatoes.TabIndex = 3;
            this.chkbx_Tomatoes.Tag = "3";
            this.chkbx_Tomatoes.Text = "Tomatoes";
            this.chkbx_Tomatoes.UseVisualStyleBackColor = true;
            this.chkbx_Tomatoes.CheckedChanged += new System.EventHandler(this.chkbx_Tomatoes_CheckedChanged);
            // 
            // chkbx_Mushrooms
            // 
            this.chkbx_Mushrooms.AutoSize = true;
            this.chkbx_Mushrooms.Location = new System.Drawing.Point(49, 96);
            this.chkbx_Mushrooms.Name = "chkbx_Mushrooms";
            this.chkbx_Mushrooms.Size = new System.Drawing.Size(118, 24);
            this.chkbx_Mushrooms.TabIndex = 2;
            this.chkbx_Mushrooms.Tag = "2";
            this.chkbx_Mushrooms.Text = "Mushrooms";
            this.chkbx_Mushrooms.UseVisualStyleBackColor = true;
            this.chkbx_Mushrooms.CheckedChanged += new System.EventHandler(this.chkbx_Mushrooms_CheckedChanged);
            // 
            // chkbx_ExtraChees
            // 
            this.chkbx_ExtraChees.AutoSize = true;
            this.chkbx_ExtraChees.ForeColor = System.Drawing.Color.Black;
            this.chkbx_ExtraChees.Location = new System.Drawing.Point(49, 58);
            this.chkbx_ExtraChees.Name = "chkbx_ExtraChees";
            this.chkbx_ExtraChees.Size = new System.Drawing.Size(122, 24);
            this.chkbx_ExtraChees.TabIndex = 1;
            this.chkbx_ExtraChees.Tag = "3";
            this.chkbx_ExtraChees.Text = "Extra Chees";
            this.chkbx_ExtraChees.UseVisualStyleBackColor = true;
            this.chkbx_ExtraChees.CheckedChanged += new System.EventHandler(this.chkbx_ExtraChees_CheckedChanged);
            // 
            // pnllbl_Toppings
            // 
            this.pnllbl_Toppings.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnllbl_Toppings.Location = new System.Drawing.Point(44, 11);
            this.pnllbl_Toppings.Name = "pnllbl_Toppings";
            this.pnllbl_Toppings.Size = new System.Drawing.Size(100, 28);
            this.pnllbl_Toppings.TabIndex = 0;
            this.pnllbl_Toppings.Text = "Toppings";
            this.pnllbl_Toppings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnllbl_Size
            // 
            this.pnllbl_Size.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnllbl_Size.Location = new System.Drawing.Point(37, 11);
            this.pnllbl_Size.Name = "pnllbl_Size";
            this.pnllbl_Size.Size = new System.Drawing.Size(66, 28);
            this.pnllbl_Size.TabIndex = 0;
            this.pnllbl_Size.Text = "Size";
            this.pnllbl_Size.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdiobtn_SmalPizzaSize
            // 
            this.rdiobtn_SmalPizzaSize.AutoSize = true;
            this.rdiobtn_SmalPizzaSize.Location = new System.Drawing.Point(43, 58);
            this.rdiobtn_SmalPizzaSize.Name = "rdiobtn_SmalPizzaSize";
            this.rdiobtn_SmalPizzaSize.Size = new System.Drawing.Size(73, 24);
            this.rdiobtn_SmalPizzaSize.TabIndex = 1;
            this.rdiobtn_SmalPizzaSize.TabStop = true;
            this.rdiobtn_SmalPizzaSize.Tag = "15";
            this.rdiobtn_SmalPizzaSize.Text = "Small";
            this.rdiobtn_SmalPizzaSize.UseVisualStyleBackColor = true;
            this.rdiobtn_SmalPizzaSize.CheckedChanged += new System.EventHandler(this.rdiobtn_SmalPizzaSize_CheckedChanged);
            // 
            // rdiobtn_MeduimPizzaSize
            // 
            this.rdiobtn_MeduimPizzaSize.AutoSize = true;
            this.rdiobtn_MeduimPizzaSize.Location = new System.Drawing.Point(42, 96);
            this.rdiobtn_MeduimPizzaSize.Name = "rdiobtn_MeduimPizzaSize";
            this.rdiobtn_MeduimPizzaSize.Size = new System.Drawing.Size(90, 24);
            this.rdiobtn_MeduimPizzaSize.TabIndex = 2;
            this.rdiobtn_MeduimPizzaSize.TabStop = true;
            this.rdiobtn_MeduimPizzaSize.Tag = "20";
            this.rdiobtn_MeduimPizzaSize.Text = "Meduim";
            this.rdiobtn_MeduimPizzaSize.UseVisualStyleBackColor = true;
            this.rdiobtn_MeduimPizzaSize.CheckedChanged += new System.EventHandler(this.rdiobtn_MeduimPizzaSize_CheckedChanged);
            // 
            // rdiobtn_LargePizaaSize
            // 
            this.rdiobtn_LargePizaaSize.AutoSize = true;
            this.rdiobtn_LargePizaaSize.Location = new System.Drawing.Point(43, 135);
            this.rdiobtn_LargePizaaSize.Name = "rdiobtn_LargePizaaSize";
            this.rdiobtn_LargePizaaSize.Size = new System.Drawing.Size(75, 24);
            this.rdiobtn_LargePizaaSize.TabIndex = 3;
            this.rdiobtn_LargePizaaSize.TabStop = true;
            this.rdiobtn_LargePizaaSize.Tag = "25";
            this.rdiobtn_LargePizaaSize.Text = "Large";
            this.rdiobtn_LargePizaaSize.UseVisualStyleBackColor = true;
            this.rdiobtn_LargePizaaSize.CheckedChanged += new System.EventHandler(this.rdiobtn_LargePizaaSize_CheckedChanged);
            // 
            // pnl_PizzaSIZE
            // 
            this.pnl_PizzaSIZE.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_PizzaSIZE.Controls.Add(this.rdiobtn_LargePizaaSize);
            this.pnl_PizzaSIZE.Controls.Add(this.rdiobtn_MeduimPizzaSize);
            this.pnl_PizzaSIZE.Controls.Add(this.rdiobtn_SmalPizzaSize);
            this.pnl_PizzaSIZE.Controls.Add(this.pnllbl_Size);
            this.pnl_PizzaSIZE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_PizzaSIZE.Location = new System.Drawing.Point(12, 156);
            this.pnl_PizzaSIZE.Name = "pnl_PizzaSIZE";
            this.pnl_PizzaSIZE.Size = new System.Drawing.Size(200, 198);
            this.pnl_PizzaSIZE.TabIndex = 3;
            // 
            // pnl_PizzaSummary
            // 
            this.pnl_PizzaSummary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_PizzaSummary.Controls.Add(this.lbl_ShowTotalPrice);
            this.pnl_PizzaSummary.Controls.Add(this.label4);
            this.pnl_PizzaSummary.Controls.Add(this.lbl_ShowWhereToEat);
            this.pnl_PizzaSummary.Controls.Add(this.label3);
            this.pnl_PizzaSummary.Controls.Add(this.lbl_ShowPizzaCrustType);
            this.pnl_PizzaSummary.Controls.Add(this.label2);
            this.pnl_PizzaSummary.Controls.Add(this.lbl_Show_PizzaToppings);
            this.pnl_PizzaSummary.Controls.Add(this.lbl_Show_PizzSize);
            this.pnl_PizzaSummary.Controls.Add(this.lblpnl_Toppings);
            this.pnl_PizzaSummary.Controls.Add(this.lblpnl_Size);
            this.pnl_PizzaSummary.Controls.Add(this.lblpnl_OrderSummary);
            this.pnl_PizzaSummary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_PizzaSummary.Location = new System.Drawing.Point(591, 156);
            this.pnl_PizzaSummary.Name = "pnl_PizzaSummary";
            this.pnl_PizzaSummary.Size = new System.Drawing.Size(438, 373);
            this.pnl_PizzaSummary.TabIndex = 4;
            // 
            // lbl_ShowTotalPrice
            // 
            this.lbl_ShowTotalPrice.BackColor = System.Drawing.Color.White;
            this.lbl_ShowTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_ShowTotalPrice.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_ShowTotalPrice.Location = new System.Drawing.Point(156, 267);
            this.lbl_ShowTotalPrice.Name = "lbl_ShowTotalPrice";
            this.lbl_ShowTotalPrice.Size = new System.Drawing.Size(100, 45);
            this.lbl_ShowTotalPrice.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(27, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Price ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ShowWhereToEat
            // 
            this.lbl_ShowWhereToEat.Location = new System.Drawing.Point(159, 230);
            this.lbl_ShowWhereToEat.Name = "lbl_ShowWhereToEat";
            this.lbl_ShowWhereToEat.Size = new System.Drawing.Size(61, 26);
            this.lbl_ShowWhereToEat.TabIndex = 8;
            this.lbl_ShowWhereToEat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(27, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Where To Eat ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ShowPizzaCrustType
            // 
            this.lbl_ShowPizzaCrustType.ForeColor = System.Drawing.Color.Black;
            this.lbl_ShowPizzaCrustType.Location = new System.Drawing.Point(143, 178);
            this.lbl_ShowPizzaCrustType.Name = "lbl_ShowPizzaCrustType";
            this.lbl_ShowPizzaCrustType.Size = new System.Drawing.Size(92, 29);
            this.lbl_ShowPizzaCrustType.TabIndex = 6;
            this.lbl_ShowPizzaCrustType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(27, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Curst Type ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Show_PizzaToppings
            // 
            this.lbl_Show_PizzaToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_Show_PizzaToppings.ForeColor = System.Drawing.Color.Black;
            this.lbl_Show_PizzaToppings.Location = new System.Drawing.Point(27, 135);
            this.lbl_Show_PizzaToppings.Name = "lbl_Show_PizzaToppings";
            this.lbl_Show_PizzaToppings.Size = new System.Drawing.Size(395, 43);
            this.lbl_Show_PizzaToppings.TabIndex = 4;
            this.lbl_Show_PizzaToppings.Text = "No Topping";
            // 
            // lbl_Show_PizzSize
            // 
            this.lbl_Show_PizzSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_Show_PizzSize.Location = new System.Drawing.Point(93, 58);
            this.lbl_Show_PizzSize.Name = "lbl_Show_PizzSize";
            this.lbl_Show_PizzSize.Size = new System.Drawing.Size(90, 24);
            this.lbl_Show_PizzSize.TabIndex = 3;
            // 
            // lblpnl_Toppings
            // 
            this.lblpnl_Toppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblpnl_Toppings.Location = new System.Drawing.Point(27, 96);
            this.lblpnl_Toppings.Name = "lblpnl_Toppings";
            this.lblpnl_Toppings.Size = new System.Drawing.Size(88, 24);
            this.lblpnl_Toppings.TabIndex = 2;
            this.lblpnl_Toppings.Text = "Toppings :";
            this.lblpnl_Toppings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblpnl_Size
            // 
            this.lblpnl_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblpnl_Size.Location = new System.Drawing.Point(27, 58);
            this.lblpnl_Size.Name = "lblpnl_Size";
            this.lblpnl_Size.Size = new System.Drawing.Size(64, 22);
            this.lblpnl_Size.TabIndex = 1;
            this.lblpnl_Size.Text = "Size :";
            // 
            // lblpnl_OrderSummary
            // 
            this.lblpnl_OrderSummary.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpnl_OrderSummary.Location = new System.Drawing.Point(11, 11);
            this.lblpnl_OrderSummary.Name = "lblpnl_OrderSummary";
            this.lblpnl_OrderSummary.Size = new System.Drawing.Size(162, 28);
            this.lblpnl_OrderSummary.TabIndex = 0;
            this.lblpnl_OrderSummary.Text = "Order Summary";
            this.lblpnl_OrderSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_CurstType
            // 
            this.pnl_CurstType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_CurstType.Controls.Add(this.rdiobtn_BigCrust);
            this.pnl_CurstType.Controls.Add(this.rdiobtn_ThinCurst);
            this.pnl_CurstType.Controls.Add(this.lblCurstType);
            this.pnl_CurstType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_CurstType.Location = new System.Drawing.Point(12, 375);
            this.pnl_CurstType.Name = "pnl_CurstType";
            this.pnl_CurstType.Size = new System.Drawing.Size(200, 144);
            this.pnl_CurstType.TabIndex = 4;
            // 
            // rdiobtn_BigCrust
            // 
            this.rdiobtn_BigCrust.AutoSize = true;
            this.rdiobtn_BigCrust.Location = new System.Drawing.Point(43, 96);
            this.rdiobtn_BigCrust.Name = "rdiobtn_BigCrust";
            this.rdiobtn_BigCrust.Size = new System.Drawing.Size(99, 24);
            this.rdiobtn_BigCrust.TabIndex = 2;
            this.rdiobtn_BigCrust.TabStop = true;
            this.rdiobtn_BigCrust.Tag = "15";
            this.rdiobtn_BigCrust.Text = "Big Crust";
            this.rdiobtn_BigCrust.UseVisualStyleBackColor = true;
            this.rdiobtn_BigCrust.CheckedChanged += new System.EventHandler(this.rdiobtn_BigCrust_CheckedChanged);
            // 
            // rdiobtn_ThinCurst
            // 
            this.rdiobtn_ThinCurst.AutoSize = true;
            this.rdiobtn_ThinCurst.Location = new System.Drawing.Point(43, 58);
            this.rdiobtn_ThinCurst.Name = "rdiobtn_ThinCurst";
            this.rdiobtn_ThinCurst.Size = new System.Drawing.Size(106, 24);
            this.rdiobtn_ThinCurst.TabIndex = 1;
            this.rdiobtn_ThinCurst.TabStop = true;
            this.rdiobtn_ThinCurst.Tag = "10";
            this.rdiobtn_ThinCurst.Text = "Thin Crust";
            this.rdiobtn_ThinCurst.UseVisualStyleBackColor = true;
            this.rdiobtn_ThinCurst.CheckedChanged += new System.EventHandler(this.rdioBtn_ThinCurst_CheckedChanged);
            // 
            // lblCurstType
            // 
            this.lblCurstType.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurstType.Location = new System.Drawing.Point(37, 11);
            this.lblCurstType.Name = "lblCurstType";
            this.lblCurstType.Size = new System.Drawing.Size(111, 28);
            this.lblCurstType.TabIndex = 0;
            this.lblCurstType.Text = "Curst Type";
            this.lblCurstType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_WhereToEat
            // 
            this.pnl_WhereToEat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_WhereToEat.Controls.Add(this.rdiobtn_OutSideEat);
            this.pnl_WhereToEat.Controls.Add(this.rdiobtn_InsideEat);
            this.pnl_WhereToEat.Controls.Add(this.label5);
            this.pnl_WhereToEat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_WhereToEat.Location = new System.Drawing.Point(230, 375);
            this.pnl_WhereToEat.Name = "pnl_WhereToEat";
            this.pnl_WhereToEat.Size = new System.Drawing.Size(333, 120);
            this.pnl_WhereToEat.TabIndex = 5;
            // 
            // rdiobtn_OutSideEat
            // 
            this.rdiobtn_OutSideEat.AutoSize = true;
            this.rdiobtn_OutSideEat.Location = new System.Drawing.Point(186, 58);
            this.rdiobtn_OutSideEat.Name = "rdiobtn_OutSideEat";
            this.rdiobtn_OutSideEat.Size = new System.Drawing.Size(96, 24);
            this.rdiobtn_OutSideEat.TabIndex = 2;
            this.rdiobtn_OutSideEat.TabStop = true;
            this.rdiobtn_OutSideEat.Tag = "0";
            this.rdiobtn_OutSideEat.Text = "Out Side";
            this.rdiobtn_OutSideEat.UseVisualStyleBackColor = true;
            this.rdiobtn_OutSideEat.CheckedChanged += new System.EventHandler(this.rdiobtn_OutSideEat_CheckedChanged);
            // 
            // rdiobtn_InsideEat
            // 
            this.rdiobtn_InsideEat.AutoSize = true;
            this.rdiobtn_InsideEat.Location = new System.Drawing.Point(49, 58);
            this.rdiobtn_InsideEat.Name = "rdiobtn_InsideEat";
            this.rdiobtn_InsideEat.Size = new System.Drawing.Size(84, 24);
            this.rdiobtn_InsideEat.TabIndex = 1;
            this.rdiobtn_InsideEat.TabStop = true;
            this.rdiobtn_InsideEat.Tag = "2";
            this.rdiobtn_InsideEat.Text = "In Side";
            this.rdiobtn_InsideEat.UseVisualStyleBackColor = true;
            this.rdiobtn_InsideEat.CheckedChanged += new System.EventHandler(this.rdiobtn_InsideEat_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Where To Eat";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_OrderPizza
            // 
            this.btn_OrderPizza.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_OrderPizza.Location = new System.Drawing.Point(247, 501);
            this.btn_OrderPizza.Name = "btn_OrderPizza";
            this.btn_OrderPizza.Size = new System.Drawing.Size(109, 42);
            this.btn_OrderPizza.TabIndex = 6;
            this.btn_OrderPizza.Text = "Order Pizza";
            this.btn_OrderPizza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OrderPizza.UseVisualStyleBackColor = false;
            this.btn_OrderPizza.Click += new System.EventHandler(this.CheckOrderbtn);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(416, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Reast ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Resetbtn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1041, 603);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_OrderPizza);
            this.Controls.Add(this.pnl_WhereToEat);
            this.Controls.Add(this.pnl_CurstType);
            this.Controls.Add(this.pnl_PizzaSummary);
            this.Controls.Add(this.pnl_PizzaToppings);
            this.Controls.Add(this.pnl_PizzaSIZE);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_PizzaToppings.ResumeLayout(false);
            this.pnl_PizzaToppings.PerformLayout();
            this.pnl_PizzaSIZE.ResumeLayout(false);
            this.pnl_PizzaSIZE.PerformLayout();
            this.pnl_PizzaSummary.ResumeLayout(false);
            this.pnl_CurstType.ResumeLayout(false);
            this.pnl_CurstType.PerformLayout();
            this.pnl_WhereToEat.ResumeLayout(false);
            this.pnl_WhereToEat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_PizzaToppings;
        private System.Windows.Forms.Label pnllbl_Toppings;
        private System.Windows.Forms.Label pnllbl_Size;
        private System.Windows.Forms.RadioButton rdiobtn_SmalPizzaSize;
        private System.Windows.Forms.RadioButton rdiobtn_MeduimPizzaSize;
        private System.Windows.Forms.RadioButton rdiobtn_LargePizaaSize;
        private System.Windows.Forms.Panel pnl_PizzaSIZE;
        private System.Windows.Forms.Panel pnl_PizzaSummary;
        private System.Windows.Forms.Label lblpnl_OrderSummary;
        private System.Windows.Forms.Label lblpnl_Size;
        private System.Windows.Forms.Label lbl_Show_PizzaToppings;
        private System.Windows.Forms.Label lbl_Show_PizzSize;
        private System.Windows.Forms.Label lblpnl_Toppings;
        private System.Windows.Forms.CheckBox chkbx_Mushrooms;
        private System.Windows.Forms.CheckBox chkbx_ExtraChees;
        private System.Windows.Forms.CheckBox chkbx_Tomatoes;
        private System.Windows.Forms.CheckBox chkbx_Olives;
        private System.Windows.Forms.CheckBox chkbx_Onion;
        private System.Windows.Forms.CheckBox chkbx_GreenPeppers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ShowWhereToEat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_ShowPizzaCrustType;
        private System.Windows.Forms.Panel pnl_CurstType;
        private System.Windows.Forms.RadioButton rdiobtn_BigCrust;
        private System.Windows.Forms.RadioButton rdiobtn_ThinCurst;
        private System.Windows.Forms.Label lblCurstType;
        private System.Windows.Forms.Panel pnl_WhereToEat;
        private System.Windows.Forms.RadioButton rdiobtn_OutSideEat;
        private System.Windows.Forms.RadioButton rdiobtn_InsideEat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_ShowTotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_OrderPizza;
        private System.Windows.Forms.Button button2;
    }
}

