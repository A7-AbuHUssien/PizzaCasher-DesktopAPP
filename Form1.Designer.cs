namespace PizzaCasherProgram
{
    partial class MakePizzaScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakePizzaScreen));
            this.gbPizzaSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPepper = new System.Windows.Forms.CheckBox();
            this.chkOlivies = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushroms = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThinkCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.rbEatingPlace = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatin = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblStaticTotalPrice = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblEatingPlace = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblStaticPlace = new System.Windows.Forms.Label();
            this.lblStaticCrustType = new System.Windows.Forms.Label();
            this.lblStaticTopings = new System.Windows.Forms.Label();
            this.lblStaticSize = new System.Windows.Forms.Label();
            this.txtboxOrderSummary = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gbPizzaSize.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.rbEatingPlace.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPizzaSize
            // 
            this.gbPizzaSize.BackColor = System.Drawing.Color.Transparent;
            this.gbPizzaSize.Controls.Add(this.rbLarge);
            this.gbPizzaSize.Controls.Add(this.rbMedium);
            this.gbPizzaSize.Controls.Add(this.rbSmall);
            this.gbPizzaSize.ForeColor = System.Drawing.Color.Coral;
            this.gbPizzaSize.Location = new System.Drawing.Point(401, 30);
            this.gbPizzaSize.Name = "gbPizzaSize";
            this.gbPizzaSize.Size = new System.Drawing.Size(161, 108);
            this.gbPizzaSize.TabIndex = 0;
            this.gbPizzaSize.TabStop = false;
            this.gbPizzaSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(14, 80);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(63, 20);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Checked = true;
            this.rbMedium.Location = new System.Drawing.Point(14, 54);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(76, 20);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "30";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.ForeColor = System.Drawing.Color.Coral;
            this.rbSmall.Location = new System.Drawing.Point(14, 28);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(62, 20);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.chkGreenPepper);
            this.gbToppings.Controls.Add(this.chkOlivies);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkMushroms);
            this.gbToppings.Controls.Add(this.chkExtraCheese);
            this.gbToppings.ForeColor = System.Drawing.Color.Coral;
            this.gbToppings.Location = new System.Drawing.Point(579, 30);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(278, 108);
            this.gbToppings.TabIndex = 1;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkGreenPepper
            // 
            this.chkGreenPepper.AutoSize = true;
            this.chkGreenPepper.Location = new System.Drawing.Point(139, 75);
            this.chkGreenPepper.Name = "chkGreenPepper";
            this.chkGreenPepper.Size = new System.Drawing.Size(114, 20);
            this.chkGreenPepper.TabIndex = 5;
            this.chkGreenPepper.Tag = "5";
            this.chkGreenPepper.Text = "Green Pepper";
            this.chkGreenPepper.UseVisualStyleBackColor = true;
            this.chkGreenPepper.CheckedChanged += new System.EventHandler(this.chkGreenPepper_CheckedChanged);
            // 
            // chkOlivies
            // 
            this.chkOlivies.AutoSize = true;
            this.chkOlivies.Location = new System.Drawing.Point(139, 49);
            this.chkOlivies.Name = "chkOlivies";
            this.chkOlivies.Size = new System.Drawing.Size(70, 20);
            this.chkOlivies.TabIndex = 4;
            this.chkOlivies.Tag = "5";
            this.chkOlivies.Text = "Olivies";
            this.chkOlivies.UseVisualStyleBackColor = true;
            this.chkOlivies.CheckedChanged += new System.EventHandler(this.chkOlivies_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(139, 24);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(64, 20);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(17, 75);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(91, 20);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushroms
            // 
            this.chkMushroms.AutoSize = true;
            this.chkMushroms.Location = new System.Drawing.Point(17, 49);
            this.chkMushroms.Name = "chkMushroms";
            this.chkMushroms.Size = new System.Drawing.Size(91, 20);
            this.chkMushroms.TabIndex = 1;
            this.chkMushroms.Tag = "5";
            this.chkMushroms.Text = "Mushroms";
            this.chkMushroms.UseVisualStyleBackColor = true;
            this.chkMushroms.CheckedChanged += new System.EventHandler(this.chkMushroms_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(17, 24);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(106, 20);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Tag = "5";
            this.chkExtraCheese.Text = "ExtraCheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.BackColor = System.Drawing.Color.Transparent;
            this.gbCrustType.Controls.Add(this.rbThinkCrust);
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.ForeColor = System.Drawing.Color.Coral;
            this.gbCrustType.Location = new System.Drawing.Point(401, 156);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(202, 85);
            this.gbCrustType.TabIndex = 2;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThinkCrust
            // 
            this.rbThinkCrust.AutoSize = true;
            this.rbThinkCrust.Location = new System.Drawing.Point(14, 54);
            this.rbThinkCrust.Name = "rbThinkCrust";
            this.rbThinkCrust.Size = new System.Drawing.Size(94, 20);
            this.rbThinkCrust.TabIndex = 1;
            this.rbThinkCrust.Tag = "10";
            this.rbThinkCrust.Text = "Think Crust";
            this.rbThinkCrust.UseVisualStyleBackColor = true;
            this.rbThinkCrust.CheckedChanged += new System.EventHandler(this.rbThinkCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Checked = true;
            this.rbThinCrust.ForeColor = System.Drawing.Color.Coral;
            this.rbThinCrust.Location = new System.Drawing.Point(14, 28);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(87, 20);
            this.rbThinCrust.TabIndex = 0;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // rbEatingPlace
            // 
            this.rbEatingPlace.BackColor = System.Drawing.Color.Transparent;
            this.rbEatingPlace.Controls.Add(this.rbTakeOut);
            this.rbEatingPlace.Controls.Add(this.rbEatin);
            this.rbEatingPlace.ForeColor = System.Drawing.Color.Coral;
            this.rbEatingPlace.Location = new System.Drawing.Point(401, 260);
            this.rbEatingPlace.Name = "rbEatingPlace";
            this.rbEatingPlace.Size = new System.Drawing.Size(202, 85);
            this.rbEatingPlace.TabIndex = 3;
            this.rbEatingPlace.TabStop = false;
            this.rbEatingPlace.Text = "Eating Place";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(14, 54);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(83, 20);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.Tag = "0";
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatin
            // 
            this.rbEatin.AutoSize = true;
            this.rbEatin.Checked = true;
            this.rbEatin.ForeColor = System.Drawing.Color.Coral;
            this.rbEatin.Location = new System.Drawing.Point(14, 28);
            this.rbEatin.Name = "rbEatin";
            this.rbEatin.Size = new System.Drawing.Size(61, 20);
            this.rbEatin.TabIndex = 0;
            this.rbEatin.TabStop = true;
            this.rbEatin.Tag = "5";
            this.rbEatin.Text = "Eat in";
            this.rbEatin.UseVisualStyleBackColor = true;
            this.rbEatin.CheckedChanged += new System.EventHandler(this.rbEatin_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Green;
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOrder.Location = new System.Drawing.Point(401, 370);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(98, 46);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Green;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReset.Location = new System.Drawing.Point(505, 370);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 46);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.BackColor = System.Drawing.Color.Aquamarine;
            this.gbOrderSummary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbOrderSummary.BackgroundImage")));
            this.gbOrderSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbOrderSummary.Controls.Add(this.lblTotalPrice);
            this.gbOrderSummary.Controls.Add(this.lblStaticTotalPrice);
            this.gbOrderSummary.Controls.Add(this.lblToppings);
            this.gbOrderSummary.Controls.Add(this.lblEatingPlace);
            this.gbOrderSummary.Controls.Add(this.lblCrustType);
            this.gbOrderSummary.Controls.Add(this.lblSize);
            this.gbOrderSummary.Controls.Add(this.lblStaticPlace);
            this.gbOrderSummary.Controls.Add(this.lblStaticCrustType);
            this.gbOrderSummary.Controls.Add(this.lblStaticTopings);
            this.gbOrderSummary.Controls.Add(this.lblStaticSize);
            this.gbOrderSummary.Controls.Add(this.txtboxOrderSummary);
            this.gbOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbOrderSummary.Location = new System.Drawing.Point(658, 156);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(366, 300);
            this.gbOrderSummary.TabIndex = 6;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Beige;
            this.lblTotalPrice.Location = new System.Drawing.Point(165, 235);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(24, 25);
            this.lblTotalPrice.TabIndex = 10;
            this.lblTotalPrice.Text = "0";
            // 
            // lblStaticTotalPrice
            // 
            this.lblStaticTotalPrice.AutoSize = true;
            this.lblStaticTotalPrice.BackColor = System.Drawing.Color.Beige;
            this.lblStaticTotalPrice.Location = new System.Drawing.Point(25, 235);
            this.lblStaticTotalPrice.Name = "lblStaticTotalPrice";
            this.lblStaticTotalPrice.Size = new System.Drawing.Size(129, 25);
            this.lblStaticTotalPrice.TabIndex = 9;
            this.lblStaticTotalPrice.Text = "Total Price: ";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.BackColor = System.Drawing.Color.Beige;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblToppings.Location = new System.Drawing.Point(27, 132);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(28, 15);
            this.lblToppings.TabIndex = 8;
            this.lblToppings.Text = "       ";
            // 
            // lblEatingPlace
            // 
            this.lblEatingPlace.AutoSize = true;
            this.lblEatingPlace.BackColor = System.Drawing.Color.Beige;
            this.lblEatingPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEatingPlace.Location = new System.Drawing.Point(163, 201);
            this.lblEatingPlace.Name = "lblEatingPlace";
            this.lblEatingPlace.Size = new System.Drawing.Size(28, 18);
            this.lblEatingPlace.TabIndex = 7;
            this.lblEatingPlace.Text = "     ";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.BackColor = System.Drawing.Color.Beige;
            this.lblCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.Location = new System.Drawing.Point(165, 164);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(28, 18);
            this.lblCrustType.TabIndex = 6;
            this.lblCrustType.Text = "     ";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Beige;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(93, 51);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(0, 18);
            this.lblSize.TabIndex = 5;
            // 
            // lblStaticPlace
            // 
            this.lblStaticPlace.AutoSize = true;
            this.lblStaticPlace.BackColor = System.Drawing.Color.Beige;
            this.lblStaticPlace.Location = new System.Drawing.Point(25, 201);
            this.lblStaticPlace.Name = "lblStaticPlace";
            this.lblStaticPlace.Size = new System.Drawing.Size(146, 25);
            this.lblStaticPlace.TabIndex = 4;
            this.lblStaticPlace.Text = "Eating Place: ";
            // 
            // lblStaticCrustType
            // 
            this.lblStaticCrustType.AutoSize = true;
            this.lblStaticCrustType.BackColor = System.Drawing.Color.Beige;
            this.lblStaticCrustType.Location = new System.Drawing.Point(25, 164);
            this.lblStaticCrustType.Name = "lblStaticCrustType";
            this.lblStaticCrustType.Size = new System.Drawing.Size(132, 25);
            this.lblStaticCrustType.TabIndex = 3;
            this.lblStaticCrustType.Text = "Crust Type: ";
            // 
            // lblStaticTopings
            // 
            this.lblStaticTopings.AutoSize = true;
            this.lblStaticTopings.BackColor = System.Drawing.Color.Beige;
            this.lblStaticTopings.Location = new System.Drawing.Point(25, 97);
            this.lblStaticTopings.Name = "lblStaticTopings";
            this.lblStaticTopings.Size = new System.Drawing.Size(109, 25);
            this.lblStaticTopings.TabIndex = 2;
            this.lblStaticTopings.Text = "Toppings:";
            // 
            // lblStaticSize
            // 
            this.lblStaticSize.AutoSize = true;
            this.lblStaticSize.BackColor = System.Drawing.Color.Beige;
            this.lblStaticSize.Location = new System.Drawing.Point(25, 51);
            this.lblStaticSize.Name = "lblStaticSize";
            this.lblStaticSize.Size = new System.Drawing.Size(62, 25);
            this.lblStaticSize.TabIndex = 1;
            this.lblStaticSize.Text = "Size:";
            // 
            // txtboxOrderSummary
            // 
            this.txtboxOrderSummary.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtboxOrderSummary.Location = new System.Drawing.Point(15, 36);
            this.txtboxOrderSummary.Multiline = true;
            this.txtboxOrderSummary.Name = "txtboxOrderSummary";
            this.txtboxOrderSummary.ReadOnly = true;
            this.txtboxOrderSummary.Size = new System.Drawing.Size(317, 242);
            this.txtboxOrderSummary.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DarkGreen;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(1039, 399);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 56);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // MakePizzaScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1173, 503);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.rbEatingPlace);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbPizzaSize);
            this.Name = "MakePizzaScreen";
            this.Text = "Make Your Pizza";
            this.gbPizzaSize.ResumeLayout(false);
            this.gbPizzaSize.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.rbEatingPlace.ResumeLayout(false);
            this.rbEatingPlace.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbPizzaSize;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkOlivies;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushroms;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkGreenPepper;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThinkCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox rbEatingPlace;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatin;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.TextBox txtboxOrderSummary;
        private System.Windows.Forms.Label lblStaticPlace;
        private System.Windows.Forms.Label lblStaticCrustType;
        private System.Windows.Forms.Label lblStaticTopings;
        private System.Windows.Forms.Label lblStaticSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblEatingPlace;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblStaticTotalPrice;
        private System.Windows.Forms.Button btnPrint;
    }
}

