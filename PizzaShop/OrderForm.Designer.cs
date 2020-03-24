namespace PizzaShop
{
    partial class OrderForm
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
            this.lbxDetails = new System.Windows.Forms.ListBox();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabPizzas = new System.Windows.Forms.TabPage();
            this.btnAddBBQChicken = new System.Windows.Forms.Button();
            this.btnAddPepperoni = new System.Windows.Forms.Button();
            this.btnAddQuattroSta = new System.Windows.Forms.Button();
            this.btnAddQuattroFor = new System.Windows.Forms.Button();
            this.btnAddMargheritta = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.priceBBQChicken = new System.Windows.Forms.TextBox();
            this.pricePepperoni = new System.Windows.Forms.TextBox();
            this.priceQuattroSta = new System.Windows.Forms.TextBox();
            this.priceQuattroFor = new System.Windows.Forms.TextBox();
            this.priceMargheritta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBBQChickenCrust = new System.Windows.Forms.ComboBox();
            this.amountBBQChicken = new System.Windows.Forms.NumericUpDown();
            this.cbPepperoniCrust = new System.Windows.Forms.ComboBox();
            this.amountPepperoni = new System.Windows.Forms.NumericUpDown();
            this.cbQuattroStaCrust = new System.Windows.Forms.ComboBox();
            this.amountQuattroSta = new System.Windows.Forms.NumericUpDown();
            this.cbQuattroForCrust = new System.Windows.Forms.ComboBox();
            this.amountQuattroFor = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMargherittaCrust = new System.Windows.Forms.ComboBox();
            this.amountMargheritta = new System.Windows.Forms.NumericUpDown();
            this.tabDrinks = new System.Windows.Forms.TabPage();
            this.btnAddEnergyDrink = new System.Windows.Forms.Button();
            this.btnAddIceTea = new System.Windows.Forms.Button();
            this.btnAddCola = new System.Windows.Forms.Button();
            this.btnAddSparklingWater = new System.Windows.Forms.Button();
            this.btnAddFlatWater = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.priceEnergyDrink = new System.Windows.Forms.TextBox();
            this.priceIceTea = new System.Windows.Forms.TextBox();
            this.priceCola = new System.Windows.Forms.TextBox();
            this.priceSparklingWater = new System.Windows.Forms.TextBox();
            this.priceFlatWater = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.amountEnergyDrink = new System.Windows.Forms.NumericUpDown();
            this.amountIceTea = new System.Windows.Forms.NumericUpDown();
            this.amountCola = new System.Windows.Forms.NumericUpDown();
            this.amountSparklingWater = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.amountFlatWater = new System.Windows.Forms.NumericUpDown();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnOrderNow = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabMenu.SuspendLayout();
            this.tabPizzas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountBBQChicken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountPepperoni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountQuattroSta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountQuattroFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountMargheritta)).BeginInit();
            this.tabDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountEnergyDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountIceTea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountSparklingWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountFlatWater)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxDetails
            // 
            this.lbxDetails.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxDetails.FormattingEnabled = true;
            this.lbxDetails.ItemHeight = 23;
            this.lbxDetails.Location = new System.Drawing.Point(688, 123);
            this.lbxDetails.Name = "lbxDetails";
            this.lbxDetails.Size = new System.Drawing.Size(477, 441);
            this.lbxDetails.TabIndex = 0;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabPizzas);
            this.tabMenu.Controls.Add(this.tabDrinks);
            this.tabMenu.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabMenu.Location = new System.Drawing.Point(12, 88);
            this.tabMenu.Multiline = true;
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(512, 476);
            this.tabMenu.TabIndex = 1;
            // 
            // tabPizzas
            // 
            this.tabPizzas.Controls.Add(this.label21);
            this.tabPizzas.Controls.Add(this.btnAddBBQChicken);
            this.tabPizzas.Controls.Add(this.btnAddPepperoni);
            this.tabPizzas.Controls.Add(this.btnAddQuattroSta);
            this.tabPizzas.Controls.Add(this.btnAddQuattroFor);
            this.tabPizzas.Controls.Add(this.btnAddMargheritta);
            this.tabPizzas.Controls.Add(this.label10);
            this.tabPizzas.Controls.Add(this.priceBBQChicken);
            this.tabPizzas.Controls.Add(this.pricePepperoni);
            this.tabPizzas.Controls.Add(this.priceQuattroSta);
            this.tabPizzas.Controls.Add(this.priceQuattroFor);
            this.tabPizzas.Controls.Add(this.priceMargheritta);
            this.tabPizzas.Controls.Add(this.label9);
            this.tabPizzas.Controls.Add(this.label8);
            this.tabPizzas.Controls.Add(this.label7);
            this.tabPizzas.Controls.Add(this.label6);
            this.tabPizzas.Controls.Add(this.cbBBQChickenCrust);
            this.tabPizzas.Controls.Add(this.amountBBQChicken);
            this.tabPizzas.Controls.Add(this.cbPepperoniCrust);
            this.tabPizzas.Controls.Add(this.amountPepperoni);
            this.tabPizzas.Controls.Add(this.cbQuattroStaCrust);
            this.tabPizzas.Controls.Add(this.amountQuattroSta);
            this.tabPizzas.Controls.Add(this.cbQuattroForCrust);
            this.tabPizzas.Controls.Add(this.amountQuattroFor);
            this.tabPizzas.Controls.Add(this.label3);
            this.tabPizzas.Controls.Add(this.label5);
            this.tabPizzas.Controls.Add(this.label4);
            this.tabPizzas.Controls.Add(this.label2);
            this.tabPizzas.Controls.Add(this.label1);
            this.tabPizzas.Controls.Add(this.cbMargherittaCrust);
            this.tabPizzas.Controls.Add(this.amountMargheritta);
            this.tabPizzas.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPizzas.Location = new System.Drawing.Point(4, 35);
            this.tabPizzas.Name = "tabPizzas";
            this.tabPizzas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPizzas.Size = new System.Drawing.Size(504, 437);
            this.tabPizzas.TabIndex = 0;
            this.tabPizzas.Text = "Pizzas";
            this.tabPizzas.UseVisualStyleBackColor = true;
            // 
            // btnAddBBQChicken
            // 
            this.btnAddBBQChicken.Location = new System.Drawing.Point(455, 314);
            this.btnAddBBQChicken.Name = "btnAddBBQChicken";
            this.btnAddBBQChicken.Size = new System.Drawing.Size(31, 28);
            this.btnAddBBQChicken.TabIndex = 28;
            this.btnAddBBQChicken.Text = ">";
            this.btnAddBBQChicken.UseVisualStyleBackColor = true;
            this.btnAddBBQChicken.Click += new System.EventHandler(this.btnAddBBQChicken_Click);
            // 
            // btnAddPepperoni
            // 
            this.btnAddPepperoni.Location = new System.Drawing.Point(455, 281);
            this.btnAddPepperoni.Name = "btnAddPepperoni";
            this.btnAddPepperoni.Size = new System.Drawing.Size(31, 27);
            this.btnAddPepperoni.TabIndex = 27;
            this.btnAddPepperoni.Text = ">";
            this.btnAddPepperoni.UseVisualStyleBackColor = true;
            this.btnAddPepperoni.Click += new System.EventHandler(this.btnAddPepperoni_Click);
            // 
            // btnAddQuattroSta
            // 
            this.btnAddQuattroSta.Location = new System.Drawing.Point(455, 246);
            this.btnAddQuattroSta.Name = "btnAddQuattroSta";
            this.btnAddQuattroSta.Size = new System.Drawing.Size(31, 27);
            this.btnAddQuattroSta.TabIndex = 26;
            this.btnAddQuattroSta.Text = ">";
            this.btnAddQuattroSta.UseVisualStyleBackColor = true;
            this.btnAddQuattroSta.Click += new System.EventHandler(this.btnAddQuattroSta_Click);
            // 
            // btnAddQuattroFor
            // 
            this.btnAddQuattroFor.Location = new System.Drawing.Point(455, 213);
            this.btnAddQuattroFor.Name = "btnAddQuattroFor";
            this.btnAddQuattroFor.Size = new System.Drawing.Size(31, 27);
            this.btnAddQuattroFor.TabIndex = 25;
            this.btnAddQuattroFor.Text = ">";
            this.btnAddQuattroFor.UseVisualStyleBackColor = true;
            this.btnAddQuattroFor.Click += new System.EventHandler(this.btnAddQuattroFor_Click);
            // 
            // btnAddMargheritta
            // 
            this.btnAddMargheritta.Location = new System.Drawing.Point(455, 179);
            this.btnAddMargheritta.Name = "btnAddMargheritta";
            this.btnAddMargheritta.Size = new System.Drawing.Size(31, 27);
            this.btnAddMargheritta.TabIndex = 5;
            this.btnAddMargheritta.Text = ">";
            this.btnAddMargheritta.UseVisualStyleBackColor = true;
            this.btnAddMargheritta.Click += new System.EventHandler(this.btnAddMargheritta_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Stylo", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(66, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(324, 62);
            this.label10.TabIndex = 24;
            this.label10.Text = "Pizza menu";
            // 
            // priceBBQChicken
            // 
            this.priceBBQChicken.Location = new System.Drawing.Point(383, 315);
            this.priceBBQChicken.Name = "priceBBQChicken";
            this.priceBBQChicken.ReadOnly = true;
            this.priceBBQChicken.Size = new System.Drawing.Size(66, 27);
            this.priceBBQChicken.TabIndex = 23;
            this.priceBBQChicken.Text = "€ 0.00";
            // 
            // pricePepperoni
            // 
            this.pricePepperoni.Location = new System.Drawing.Point(383, 281);
            this.pricePepperoni.Name = "pricePepperoni";
            this.pricePepperoni.ReadOnly = true;
            this.pricePepperoni.Size = new System.Drawing.Size(66, 27);
            this.pricePepperoni.TabIndex = 22;
            this.pricePepperoni.Text = "€ 0.00";
            // 
            // priceQuattroSta
            // 
            this.priceQuattroSta.Location = new System.Drawing.Point(383, 247);
            this.priceQuattroSta.Name = "priceQuattroSta";
            this.priceQuattroSta.ReadOnly = true;
            this.priceQuattroSta.Size = new System.Drawing.Size(66, 27);
            this.priceQuattroSta.TabIndex = 21;
            this.priceQuattroSta.Text = "€ 0.00";
            // 
            // priceQuattroFor
            // 
            this.priceQuattroFor.Location = new System.Drawing.Point(383, 213);
            this.priceQuattroFor.Name = "priceQuattroFor";
            this.priceQuattroFor.ReadOnly = true;
            this.priceQuattroFor.Size = new System.Drawing.Size(66, 27);
            this.priceQuattroFor.TabIndex = 20;
            this.priceQuattroFor.Text = "€ 0.00";
            // 
            // priceMargheritta
            // 
            this.priceMargheritta.Location = new System.Drawing.Point(383, 179);
            this.priceMargheritta.Name = "priceMargheritta";
            this.priceMargheritta.ReadOnly = true;
            this.priceMargheritta.Size = new System.Drawing.Size(66, 27);
            this.priceMargheritta.TabIndex = 19;
            this.priceMargheritta.Text = "€ 0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Choose crust:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pizza:";
            // 
            // cbBBQChickenCrust
            // 
            this.cbBBQChickenCrust.FormattingEnabled = true;
            this.cbBBQChickenCrust.Items.AddRange(new object[] {
            "Thin crust",
            "Thick crust",
            "Cheese filled crust"});
            this.cbBBQChickenCrust.Location = new System.Drawing.Point(143, 314);
            this.cbBBQChickenCrust.Name = "cbBBQChickenCrust";
            this.cbBBQChickenCrust.Size = new System.Drawing.Size(166, 28);
            this.cbBBQChickenCrust.TabIndex = 14;
            this.cbBBQChickenCrust.Text = "Select:";
            this.cbBBQChickenCrust.TextChanged += new System.EventHandler(this.cbBBQChickenCrust_TextChanged);
            // 
            // amountBBQChicken
            // 
            this.amountBBQChicken.Location = new System.Drawing.Point(315, 315);
            this.amountBBQChicken.Name = "amountBBQChicken";
            this.amountBBQChicken.Size = new System.Drawing.Size(62, 27);
            this.amountBBQChicken.TabIndex = 13;
            this.amountBBQChicken.ValueChanged += new System.EventHandler(this.amountBBQChicken_ValueChanged);
            // 
            // cbPepperoniCrust
            // 
            this.cbPepperoniCrust.FormattingEnabled = true;
            this.cbPepperoniCrust.Items.AddRange(new object[] {
            "Thin crust",
            "Thick crust",
            "Cheese filled crust"});
            this.cbPepperoniCrust.Location = new System.Drawing.Point(143, 280);
            this.cbPepperoniCrust.Name = "cbPepperoniCrust";
            this.cbPepperoniCrust.Size = new System.Drawing.Size(166, 28);
            this.cbPepperoniCrust.TabIndex = 12;
            this.cbPepperoniCrust.Text = "Select:";
            this.cbPepperoniCrust.TextChanged += new System.EventHandler(this.cbPepperoniCrust_TextChanged);
            // 
            // amountPepperoni
            // 
            this.amountPepperoni.Location = new System.Drawing.Point(315, 281);
            this.amountPepperoni.Name = "amountPepperoni";
            this.amountPepperoni.Size = new System.Drawing.Size(62, 27);
            this.amountPepperoni.TabIndex = 11;
            this.amountPepperoni.ValueChanged += new System.EventHandler(this.amountPepperoni_ValueChanged);
            // 
            // cbQuattroStaCrust
            // 
            this.cbQuattroStaCrust.FormattingEnabled = true;
            this.cbQuattroStaCrust.Items.AddRange(new object[] {
            "Thin crust",
            "Thick crust",
            "Cheese filled crust"});
            this.cbQuattroStaCrust.Location = new System.Drawing.Point(143, 246);
            this.cbQuattroStaCrust.Name = "cbQuattroStaCrust";
            this.cbQuattroStaCrust.Size = new System.Drawing.Size(166, 28);
            this.cbQuattroStaCrust.TabIndex = 10;
            this.cbQuattroStaCrust.Text = "Select:";
            this.cbQuattroStaCrust.TextChanged += new System.EventHandler(this.cbQuattroStaCrust_TextChanged);
            // 
            // amountQuattroSta
            // 
            this.amountQuattroSta.Location = new System.Drawing.Point(315, 247);
            this.amountQuattroSta.Name = "amountQuattroSta";
            this.amountQuattroSta.Size = new System.Drawing.Size(62, 27);
            this.amountQuattroSta.TabIndex = 9;
            this.amountQuattroSta.ValueChanged += new System.EventHandler(this.amountQuattroSta_ValueChanged);
            // 
            // cbQuattroForCrust
            // 
            this.cbQuattroForCrust.FormattingEnabled = true;
            this.cbQuattroForCrust.Items.AddRange(new object[] {
            "Thin crust",
            "Thick crust",
            "Cheese filled crust"});
            this.cbQuattroForCrust.Location = new System.Drawing.Point(143, 212);
            this.cbQuattroForCrust.Name = "cbQuattroForCrust";
            this.cbQuattroForCrust.Size = new System.Drawing.Size(166, 28);
            this.cbQuattroForCrust.TabIndex = 8;
            this.cbQuattroForCrust.Text = "Select:";
            this.cbQuattroForCrust.TextChanged += new System.EventHandler(this.cbQuattroForCrust_TextChanged);
            // 
            // amountQuattroFor
            // 
            this.amountQuattroFor.Location = new System.Drawing.Point(315, 213);
            this.amountQuattroFor.Name = "amountQuattroFor";
            this.amountQuattroFor.Size = new System.Drawing.Size(62, 27);
            this.amountQuattroFor.TabIndex = 7;
            this.amountQuattroFor.ValueChanged += new System.EventHandler(this.amountQuattroFor_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "BBQ chicken";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pepperoni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quattro stagioni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quattro formaggi ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Margheritta";
            // 
            // cbMargherittaCrust
            // 
            this.cbMargherittaCrust.FormattingEnabled = true;
            this.cbMargherittaCrust.Items.AddRange(new object[] {
            "Thin crust",
            "Thick crust",
            "Cheese filled crust"});
            this.cbMargherittaCrust.Location = new System.Drawing.Point(143, 178);
            this.cbMargherittaCrust.Name = "cbMargherittaCrust";
            this.cbMargherittaCrust.Size = new System.Drawing.Size(166, 28);
            this.cbMargherittaCrust.TabIndex = 1;
            this.cbMargherittaCrust.Text = "Select:";
            this.cbMargherittaCrust.TextChanged += new System.EventHandler(this.cbMargherittaCrust_TextChanged);
            // 
            // amountMargheritta
            // 
            this.amountMargheritta.Location = new System.Drawing.Point(315, 179);
            this.amountMargheritta.Name = "amountMargheritta";
            this.amountMargheritta.Size = new System.Drawing.Size(62, 27);
            this.amountMargheritta.TabIndex = 0;
            this.amountMargheritta.ValueChanged += new System.EventHandler(this.amountMargheritta_ValueChanged);
            // 
            // tabDrinks
            // 
            this.tabDrinks.Controls.Add(this.label22);
            this.tabDrinks.Controls.Add(this.btnAddEnergyDrink);
            this.tabDrinks.Controls.Add(this.btnAddIceTea);
            this.tabDrinks.Controls.Add(this.btnAddCola);
            this.tabDrinks.Controls.Add(this.btnAddSparklingWater);
            this.tabDrinks.Controls.Add(this.btnAddFlatWater);
            this.tabDrinks.Controls.Add(this.label11);
            this.tabDrinks.Controls.Add(this.priceEnergyDrink);
            this.tabDrinks.Controls.Add(this.priceIceTea);
            this.tabDrinks.Controls.Add(this.priceCola);
            this.tabDrinks.Controls.Add(this.priceSparklingWater);
            this.tabDrinks.Controls.Add(this.priceFlatWater);
            this.tabDrinks.Controls.Add(this.label12);
            this.tabDrinks.Controls.Add(this.label13);
            this.tabDrinks.Controls.Add(this.label15);
            this.tabDrinks.Controls.Add(this.amountEnergyDrink);
            this.tabDrinks.Controls.Add(this.amountIceTea);
            this.tabDrinks.Controls.Add(this.amountCola);
            this.tabDrinks.Controls.Add(this.amountSparklingWater);
            this.tabDrinks.Controls.Add(this.label16);
            this.tabDrinks.Controls.Add(this.label17);
            this.tabDrinks.Controls.Add(this.label18);
            this.tabDrinks.Controls.Add(this.label19);
            this.tabDrinks.Controls.Add(this.label20);
            this.tabDrinks.Controls.Add(this.amountFlatWater);
            this.tabDrinks.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabDrinks.Location = new System.Drawing.Point(4, 35);
            this.tabDrinks.Name = "tabDrinks";
            this.tabDrinks.Padding = new System.Windows.Forms.Padding(3);
            this.tabDrinks.Size = new System.Drawing.Size(504, 437);
            this.tabDrinks.TabIndex = 1;
            this.tabDrinks.Text = "Drinks";
            this.tabDrinks.UseVisualStyleBackColor = true;
            // 
            // btnAddEnergyDrink
            // 
            this.btnAddEnergyDrink.Location = new System.Drawing.Point(455, 315);
            this.btnAddEnergyDrink.Name = "btnAddEnergyDrink";
            this.btnAddEnergyDrink.Size = new System.Drawing.Size(31, 28);
            this.btnAddEnergyDrink.TabIndex = 54;
            this.btnAddEnergyDrink.Text = ">";
            this.btnAddEnergyDrink.UseVisualStyleBackColor = true;
            this.btnAddEnergyDrink.Click += new System.EventHandler(this.btnAddEnergyDrink_Click);
            // 
            // btnAddIceTea
            // 
            this.btnAddIceTea.Location = new System.Drawing.Point(455, 282);
            this.btnAddIceTea.Name = "btnAddIceTea";
            this.btnAddIceTea.Size = new System.Drawing.Size(31, 27);
            this.btnAddIceTea.TabIndex = 53;
            this.btnAddIceTea.Text = ">";
            this.btnAddIceTea.UseVisualStyleBackColor = true;
            this.btnAddIceTea.Click += new System.EventHandler(this.btnAddIceTea_Click);
            // 
            // btnAddCola
            // 
            this.btnAddCola.Location = new System.Drawing.Point(455, 247);
            this.btnAddCola.Name = "btnAddCola";
            this.btnAddCola.Size = new System.Drawing.Size(31, 27);
            this.btnAddCola.TabIndex = 52;
            this.btnAddCola.Text = ">";
            this.btnAddCola.UseVisualStyleBackColor = true;
            this.btnAddCola.Click += new System.EventHandler(this.btnAddCola_Click);
            // 
            // btnAddSparklingWater
            // 
            this.btnAddSparklingWater.Location = new System.Drawing.Point(455, 214);
            this.btnAddSparklingWater.Name = "btnAddSparklingWater";
            this.btnAddSparklingWater.Size = new System.Drawing.Size(31, 27);
            this.btnAddSparklingWater.TabIndex = 51;
            this.btnAddSparklingWater.Text = ">";
            this.btnAddSparklingWater.UseVisualStyleBackColor = true;
            this.btnAddSparklingWater.Click += new System.EventHandler(this.btnAddSparklingWater_Click);
            // 
            // btnAddFlatWater
            // 
            this.btnAddFlatWater.Location = new System.Drawing.Point(455, 180);
            this.btnAddFlatWater.Name = "btnAddFlatWater";
            this.btnAddFlatWater.Size = new System.Drawing.Size(31, 27);
            this.btnAddFlatWater.TabIndex = 50;
            this.btnAddFlatWater.Text = ">";
            this.btnAddFlatWater.UseVisualStyleBackColor = true;
            this.btnAddFlatWater.Click += new System.EventHandler(this.btnAddFlatWater_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Stylo", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(55, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(343, 62);
            this.label11.TabIndex = 49;
            this.label11.Text = "Drinks menu";
            // 
            // priceEnergyDrink
            // 
            this.priceEnergyDrink.Location = new System.Drawing.Point(383, 316);
            this.priceEnergyDrink.Name = "priceEnergyDrink";
            this.priceEnergyDrink.ReadOnly = true;
            this.priceEnergyDrink.Size = new System.Drawing.Size(66, 27);
            this.priceEnergyDrink.TabIndex = 48;
            this.priceEnergyDrink.Text = "€ 0.00";
            // 
            // priceIceTea
            // 
            this.priceIceTea.Location = new System.Drawing.Point(383, 282);
            this.priceIceTea.Name = "priceIceTea";
            this.priceIceTea.ReadOnly = true;
            this.priceIceTea.Size = new System.Drawing.Size(66, 27);
            this.priceIceTea.TabIndex = 47;
            this.priceIceTea.Text = "€ 0.00";
            // 
            // priceCola
            // 
            this.priceCola.Location = new System.Drawing.Point(383, 248);
            this.priceCola.Name = "priceCola";
            this.priceCola.ReadOnly = true;
            this.priceCola.Size = new System.Drawing.Size(66, 27);
            this.priceCola.TabIndex = 46;
            this.priceCola.Text = "€ 0.00";
            // 
            // priceSparklingWater
            // 
            this.priceSparklingWater.Location = new System.Drawing.Point(383, 214);
            this.priceSparklingWater.Name = "priceSparklingWater";
            this.priceSparklingWater.ReadOnly = true;
            this.priceSparklingWater.Size = new System.Drawing.Size(66, 27);
            this.priceSparklingWater.TabIndex = 45;
            this.priceSparklingWater.Text = "€ 0.00";
            // 
            // priceFlatWater
            // 
            this.priceFlatWater.Location = new System.Drawing.Point(383, 180);
            this.priceFlatWater.Name = "priceFlatWater";
            this.priceFlatWater.ReadOnly = true;
            this.priceFlatWater.Size = new System.Drawing.Size(66, 27);
            this.priceFlatWater.TabIndex = 44;
            this.priceFlatWater.Text = "€ 0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(383, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 20);
            this.label12.TabIndex = 43;
            this.label12.Text = "Price:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(311, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "Amount:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 20);
            this.label15.TabIndex = 40;
            this.label15.Text = "Drink:";
            // 
            // amountEnergyDrink
            // 
            this.amountEnergyDrink.Location = new System.Drawing.Point(315, 316);
            this.amountEnergyDrink.Name = "amountEnergyDrink";
            this.amountEnergyDrink.Size = new System.Drawing.Size(62, 27);
            this.amountEnergyDrink.TabIndex = 38;
            this.amountEnergyDrink.ValueChanged += new System.EventHandler(this.amountEnergyDrink_ValueChanged);
            // 
            // amountIceTea
            // 
            this.amountIceTea.Location = new System.Drawing.Point(315, 282);
            this.amountIceTea.Name = "amountIceTea";
            this.amountIceTea.Size = new System.Drawing.Size(62, 27);
            this.amountIceTea.TabIndex = 36;
            this.amountIceTea.ValueChanged += new System.EventHandler(this.amountIceTea_ValueChanged);
            // 
            // amountCola
            // 
            this.amountCola.Location = new System.Drawing.Point(315, 248);
            this.amountCola.Name = "amountCola";
            this.amountCola.Size = new System.Drawing.Size(62, 27);
            this.amountCola.TabIndex = 34;
            this.amountCola.ValueChanged += new System.EventHandler(this.amountCola_ValueChanged);
            // 
            // amountSparklingWater
            // 
            this.amountSparklingWater.Location = new System.Drawing.Point(315, 214);
            this.amountSparklingWater.Name = "amountSparklingWater";
            this.amountSparklingWater.Size = new System.Drawing.Size(62, 27);
            this.amountSparklingWater.TabIndex = 32;
            this.amountSparklingWater.ValueChanged += new System.EventHandler(this.amountSparklingWater_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 318);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 20);
            this.label16.TabIndex = 31;
            this.label16.Text = "Energy drink";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 284);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 20);
            this.label17.TabIndex = 30;
            this.label17.Text = "Ice tea";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 250);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 20);
            this.label18.TabIndex = 29;
            this.label18.Text = "Cola";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 216);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 20);
            this.label19.TabIndex = 28;
            this.label19.Text = "Sparkling water";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 182);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 20);
            this.label20.TabIndex = 27;
            this.label20.Text = "Flat water";
            // 
            // amountFlatWater
            // 
            this.amountFlatWater.Location = new System.Drawing.Point(315, 180);
            this.amountFlatWater.Name = "amountFlatWater";
            this.amountFlatWater.Size = new System.Drawing.Size(62, 27);
            this.amountFlatWater.TabIndex = 25;
            this.amountFlatWater.ValueChanged += new System.EventHandler(this.amountFlatWater_ValueChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Stylo", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(12, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1153, 49);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Hello {customer}, let\'s get started...";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(684, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 23);
            this.label14.TabIndex = 3;
            this.label14.Text = "Order details:";
            // 
            // btnOrderNow
            // 
            this.btnOrderNow.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrderNow.Location = new System.Drawing.Point(539, 497);
            this.btnOrderNow.Name = "btnOrderNow";
            this.btnOrderNow.Size = new System.Drawing.Size(131, 67);
            this.btnOrderNow.TabIndex = 4;
            this.btnOrderNow.Text = "Order Now";
            this.btnOrderNow.UseVisualStyleBackColor = true;
            this.btnOrderNow.Click += new System.EventHandler(this.btnOrderNow_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(451, 149);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 20);
            this.label21.TabIndex = 29;
            this.label21.Text = "Add";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(451, 150);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 20);
            this.label22.TabIndex = 55;
            this.label22.Text = "Add";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PizzaShop.Properties.Resources.pizzashop_background;
            this.ClientSize = new System.Drawing.Size(1177, 588);
            this.Controls.Add(this.lbxDetails);
            this.Controls.Add(this.btnOrderNow);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderForm_FormClosed);
            this.tabMenu.ResumeLayout(false);
            this.tabPizzas.ResumeLayout(false);
            this.tabPizzas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountBBQChicken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountPepperoni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountQuattroSta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountQuattroFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountMargheritta)).EndInit();
            this.tabDrinks.ResumeLayout(false);
            this.tabDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountEnergyDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountIceTea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountSparklingWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountFlatWater)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxDetails;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabPizzas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMargherittaCrust;
        private System.Windows.Forms.NumericUpDown amountMargheritta;
        private System.Windows.Forms.TabPage tabDrinks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox priceBBQChicken;
        private System.Windows.Forms.TextBox pricePepperoni;
        private System.Windows.Forms.TextBox priceQuattroSta;
        private System.Windows.Forms.TextBox priceQuattroFor;
        private System.Windows.Forms.TextBox priceMargheritta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBBQChickenCrust;
        private System.Windows.Forms.NumericUpDown amountBBQChicken;
        private System.Windows.Forms.ComboBox cbPepperoniCrust;
        private System.Windows.Forms.NumericUpDown amountPepperoni;
        private System.Windows.Forms.ComboBox cbQuattroStaCrust;
        private System.Windows.Forms.NumericUpDown amountQuattroSta;
        private System.Windows.Forms.ComboBox cbQuattroForCrust;
        private System.Windows.Forms.NumericUpDown amountQuattroFor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox priceEnergyDrink;
        private System.Windows.Forms.TextBox priceIceTea;
        private System.Windows.Forms.TextBox priceCola;
        private System.Windows.Forms.TextBox priceSparklingWater;
        private System.Windows.Forms.TextBox priceFlatWater;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown amountEnergyDrink;
        private System.Windows.Forms.NumericUpDown amountIceTea;
        private System.Windows.Forms.NumericUpDown amountCola;
        private System.Windows.Forms.NumericUpDown amountSparklingWater;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown amountFlatWater;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnOrderNow;
        private System.Windows.Forms.Button btnAddBBQChicken;
        private System.Windows.Forms.Button btnAddPepperoni;
        private System.Windows.Forms.Button btnAddQuattroSta;
        private System.Windows.Forms.Button btnAddQuattroFor;
        private System.Windows.Forms.Button btnAddMargheritta;
        private System.Windows.Forms.Button btnAddEnergyDrink;
        private System.Windows.Forms.Button btnAddIceTea;
        private System.Windows.Forms.Button btnAddCola;
        private System.Windows.Forms.Button btnAddSparklingWater;
        private System.Windows.Forms.Button btnAddFlatWater;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}