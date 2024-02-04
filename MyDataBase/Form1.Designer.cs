namespace MyDataBase
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.LoadStorageButton = new System.Windows.Forms.Button();
            this.LoadGoodsButton = new System.Windows.Forms.Button();
            this.GoodOrderNameButton = new System.Windows.Forms.Button();
            this.GoodOrgerCostButton = new System.Windows.Forms.Button();
            this.GoodsInCountButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameGoodTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CostGoodTextBox = new System.Windows.Forms.TextBox();
            this.GoodAddButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GoodDeleteButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.GoodCostEdit = new System.Windows.Forms.TextBox();
            this.GoodEditButton = new System.Windows.Forms.Button();
            this.StorageDeleteButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.StorageAddButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CorpEditButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CorpAddButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.ContractAddButton = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.LoadContractButton = new System.Windows.Forms.Button();
            this.LoadCorpsButton = new System.Windows.Forms.Button();
            this.ContractOrderCostButton = new System.Windows.Forms.Button();
            this.CorpsOrderNameButton = new System.Windows.Forms.Button();
            this.StorageFullButton = new System.Windows.Forms.Button();
            this.StorageFreeButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.MaxCostText = new System.Windows.Forms.Label();
            this.AvgCostText = new System.Windows.Forms.Label();
            this.totalCostText = new System.Windows.Forms.Label();
            this.GoodNameDelCB = new System.Windows.Forms.ComboBox();
            this.GoodNameEditCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CorpNameEditCB = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(13, 380);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(863, 534);
            this.dataGridView.TabIndex = 0;
            // 
            // LoadStorageButton
            // 
            this.LoadStorageButton.Location = new System.Drawing.Point(13, 12);
            this.LoadStorageButton.Name = "LoadStorageButton";
            this.LoadStorageButton.Size = new System.Drawing.Size(189, 66);
            this.LoadStorageButton.TabIndex = 1;
            this.LoadStorageButton.Text = "Склад";
            this.LoadStorageButton.UseVisualStyleBackColor = true;
            this.LoadStorageButton.Click += new System.EventHandler(this.LoadStorageButton_Click);
            // 
            // LoadGoodsButton
            // 
            this.LoadGoodsButton.Location = new System.Drawing.Point(208, 12);
            this.LoadGoodsButton.Name = "LoadGoodsButton";
            this.LoadGoodsButton.Size = new System.Drawing.Size(189, 66);
            this.LoadGoodsButton.TabIndex = 2;
            this.LoadGoodsButton.Text = "Товары";
            this.LoadGoodsButton.UseVisualStyleBackColor = true;
            this.LoadGoodsButton.Click += new System.EventHandler(this.LoadGoodsButton_Click);
            // 
            // GoodOrderNameButton
            // 
            this.GoodOrderNameButton.Location = new System.Drawing.Point(208, 84);
            this.GoodOrderNameButton.Name = "GoodOrderNameButton";
            this.GoodOrderNameButton.Size = new System.Drawing.Size(189, 32);
            this.GoodOrderNameButton.TabIndex = 3;
            this.GoodOrderNameButton.Text = "По алфавиту";
            this.GoodOrderNameButton.UseVisualStyleBackColor = true;
            this.GoodOrderNameButton.Click += new System.EventHandler(this.GoodOrderNameButton_Click);
            // 
            // GoodOrgerCostButton
            // 
            this.GoodOrgerCostButton.Location = new System.Drawing.Point(208, 122);
            this.GoodOrgerCostButton.Name = "GoodOrgerCostButton";
            this.GoodOrgerCostButton.Size = new System.Drawing.Size(189, 32);
            this.GoodOrgerCostButton.TabIndex = 4;
            this.GoodOrgerCostButton.Text = "По цене";
            this.GoodOrgerCostButton.UseVisualStyleBackColor = true;
            this.GoodOrgerCostButton.Click += new System.EventHandler(this.GoodOrgerCostButton_Click);
            // 
            // GoodsInCountButton
            // 
            this.GoodsInCountButton.Location = new System.Drawing.Point(208, 160);
            this.GoodsInCountButton.Name = "GoodsInCountButton";
            this.GoodsInCountButton.Size = new System.Drawing.Size(189, 32);
            this.GoodsInCountButton.TabIndex = 5;
            this.GoodsInCountButton.Text = "В наличии";
            this.GoodsInCountButton.UseVisualStyleBackColor = true;
            this.GoodsInCountButton.Click += new System.EventHandler(this.GoodsInCountButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(884, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Добавление товара:";
            // 
            // NameGoodTextBox
            // 
            this.NameGoodTextBox.Location = new System.Drawing.Point(999, 37);
            this.NameGoodTextBox.Name = "NameGoodTextBox";
            this.NameGoodTextBox.Size = new System.Drawing.Size(95, 26);
            this.NameGoodTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(884, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Имя товара:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(884, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Цена:";
            // 
            // CostGoodTextBox
            // 
            this.CostGoodTextBox.Location = new System.Drawing.Point(999, 65);
            this.CostGoodTextBox.Name = "CostGoodTextBox";
            this.CostGoodTextBox.Size = new System.Drawing.Size(95, 26);
            this.CostGoodTextBox.TabIndex = 9;
            // 
            // GoodAddButton
            // 
            this.GoodAddButton.Location = new System.Drawing.Point(884, 97);
            this.GoodAddButton.Name = "GoodAddButton";
            this.GoodAddButton.Size = new System.Drawing.Size(210, 32);
            this.GoodAddButton.TabIndex = 11;
            this.GoodAddButton.Text = "Добавить";
            this.GoodAddButton.UseVisualStyleBackColor = true;
            this.GoodAddButton.Click += new System.EventHandler(this.GoodAddButton_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(884, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Имя товара:";
            // 
            // GoodDeleteButton
            // 
            this.GoodDeleteButton.Location = new System.Drawing.Point(884, 181);
            this.GoodDeleteButton.Name = "GoodDeleteButton";
            this.GoodDeleteButton.Size = new System.Drawing.Size(210, 32);
            this.GoodDeleteButton.TabIndex = 14;
            this.GoodDeleteButton.Text = "Удалить";
            this.GoodDeleteButton.UseVisualStyleBackColor = true;
            this.GoodDeleteButton.Click += new System.EventHandler(this.GoodDeleteButton_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(884, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Цена:";
            // 
            // GoodCostEdit
            // 
            this.GoodCostEdit.Location = new System.Drawing.Point(999, 277);
            this.GoodCostEdit.Name = "GoodCostEdit";
            this.GoodCostEdit.Size = new System.Drawing.Size(95, 26);
            this.GoodCostEdit.TabIndex = 19;
            // 
            // GoodEditButton
            // 
            this.GoodEditButton.Location = new System.Drawing.Point(884, 309);
            this.GoodEditButton.Name = "GoodEditButton";
            this.GoodEditButton.Size = new System.Drawing.Size(210, 32);
            this.GoodEditButton.TabIndex = 21;
            this.GoodEditButton.Text = "Изменить";
            this.GoodEditButton.UseVisualStyleBackColor = true;
            this.GoodEditButton.Click += new System.EventHandler(this.GoodEditButton_Click);
            // 
            // StorageDeleteButton
            // 
            this.StorageDeleteButton.Location = new System.Drawing.Point(1100, 181);
            this.StorageDeleteButton.Name = "StorageDeleteButton";
            this.StorageDeleteButton.Size = new System.Drawing.Size(210, 32);
            this.StorageDeleteButton.TabIndex = 30;
            this.StorageDeleteButton.Text = "Удалить";
            this.StorageDeleteButton.UseVisualStyleBackColor = true;
            this.StorageDeleteButton.Click += new System.EventHandler(this.StorageDeleteButton_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(1100, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 28);
            this.label11.TabIndex = 29;
            this.label11.Text = "ID полки:";
            // 
            // StorageAddButton
            // 
            this.StorageAddButton.Location = new System.Drawing.Point(1100, 97);
            this.StorageAddButton.Name = "StorageAddButton";
            this.StorageAddButton.Size = new System.Drawing.Size(210, 32);
            this.StorageAddButton.TabIndex = 27;
            this.StorageAddButton.Text = "Добавить";
            this.StorageAddButton.UseVisualStyleBackColor = true;
            this.StorageAddButton.Click += new System.EventHandler(this.StorageAddButton_Click);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(1100, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 28);
            this.label12.TabIndex = 26;
            this.label12.Text = "ID Контракта:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(1100, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 28);
            this.label13.TabIndex = 24;
            this.label13.Text = "Имя товара:";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(1100, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(210, 28);
            this.label14.TabIndex = 22;
            this.label14.Text = "Добавление на склад:";
            // 
            // CorpEditButton
            // 
            this.CorpEditButton.Location = new System.Drawing.Point(1534, 233);
            this.CorpEditButton.Name = "CorpEditButton";
            this.CorpEditButton.Size = new System.Drawing.Size(210, 32);
            this.CorpEditButton.TabIndex = 69;
            this.CorpEditButton.Text = "Изменить";
            this.CorpEditButton.UseVisualStyleBackColor = true;
            this.CorpEditButton.Click += new System.EventHandler(this.CorpEditButton_Click);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(1534, 204);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 28);
            this.label15.TabIndex = 68;
            this.label15.Text = "почта:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1649, 201);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(95, 26);
            this.textBox7.TabIndex = 67;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(1534, 176);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 28);
            this.label16.TabIndex = 66;
            this.label16.Text = "Название:";
            // 
            // CorpAddButton
            // 
            this.CorpAddButton.Location = new System.Drawing.Point(1534, 97);
            this.CorpAddButton.Name = "CorpAddButton";
            this.CorpAddButton.Size = new System.Drawing.Size(210, 32);
            this.CorpAddButton.TabIndex = 59;
            this.CorpAddButton.Text = "Добавить";
            this.CorpAddButton.UseVisualStyleBackColor = true;
            this.CorpAddButton.Click += new System.EventHandler(this.CorpAddButton_Click);
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(1534, 68);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 28);
            this.label19.TabIndex = 58;
            this.label19.Text = "Почта:";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(1649, 65);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(95, 26);
            this.textBox11.TabIndex = 57;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(1534, 40);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 28);
            this.label20.TabIndex = 56;
            this.label20.Text = "Название:";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(1649, 37);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(95, 26);
            this.textBox12.TabIndex = 55;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(1534, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(210, 28);
            this.label21.TabIndex = 54;
            this.label21.Text = "Добавление поставщика:";
            // 
            // ContractAddButton
            // 
            this.ContractAddButton.Location = new System.Drawing.Point(1318, 122);
            this.ContractAddButton.Name = "ContractAddButton";
            this.ContractAddButton.Size = new System.Drawing.Size(210, 32);
            this.ContractAddButton.TabIndex = 43;
            this.ContractAddButton.Text = "Добавить";
            this.ContractAddButton.UseVisualStyleBackColor = true;
            this.ContractAddButton.Click += new System.EventHandler(this.ContractAddButton_Click);
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(1318, 68);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(109, 28);
            this.label26.TabIndex = 42;
            this.label26.Text = "Поставщик:";
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(1318, 40);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(109, 28);
            this.label27.TabIndex = 40;
            this.label27.Text = "Имя товара:";
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(1318, 9);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(210, 28);
            this.label28.TabIndex = 38;
            this.label28.Text = "Добавление контракта:";
            // 
            // LoadContractButton
            // 
            this.LoadContractButton.Location = new System.Drawing.Point(403, 12);
            this.LoadContractButton.Name = "LoadContractButton";
            this.LoadContractButton.Size = new System.Drawing.Size(189, 66);
            this.LoadContractButton.TabIndex = 70;
            this.LoadContractButton.Text = "Контракты";
            this.LoadContractButton.UseVisualStyleBackColor = true;
            this.LoadContractButton.Click += new System.EventHandler(this.LoadContractButton_Click);
            // 
            // LoadCorpsButton
            // 
            this.LoadCorpsButton.Location = new System.Drawing.Point(598, 12);
            this.LoadCorpsButton.Name = "LoadCorpsButton";
            this.LoadCorpsButton.Size = new System.Drawing.Size(189, 66);
            this.LoadCorpsButton.TabIndex = 71;
            this.LoadCorpsButton.Text = "Поставщики";
            this.LoadCorpsButton.UseVisualStyleBackColor = true;
            this.LoadCorpsButton.Click += new System.EventHandler(this.LoadCorpsButton_Click_1);
            // 
            // ContractOrderCostButton
            // 
            this.ContractOrderCostButton.Location = new System.Drawing.Point(403, 84);
            this.ContractOrderCostButton.Name = "ContractOrderCostButton";
            this.ContractOrderCostButton.Size = new System.Drawing.Size(189, 32);
            this.ContractOrderCostButton.TabIndex = 72;
            this.ContractOrderCostButton.Text = "По цене";
            this.ContractOrderCostButton.UseVisualStyleBackColor = true;
            this.ContractOrderCostButton.Click += new System.EventHandler(this.ContractOrderCostButton_Click);
            // 
            // CorpsOrderNameButton
            // 
            this.CorpsOrderNameButton.Location = new System.Drawing.Point(598, 84);
            this.CorpsOrderNameButton.Name = "CorpsOrderNameButton";
            this.CorpsOrderNameButton.Size = new System.Drawing.Size(189, 32);
            this.CorpsOrderNameButton.TabIndex = 73;
            this.CorpsOrderNameButton.Text = "По алфавиту";
            this.CorpsOrderNameButton.UseVisualStyleBackColor = true;
            this.CorpsOrderNameButton.Click += new System.EventHandler(this.CorpsOrderNameButton_Click);
            // 
            // StorageFullButton
            // 
            this.StorageFullButton.Location = new System.Drawing.Point(13, 84);
            this.StorageFullButton.Name = "StorageFullButton";
            this.StorageFullButton.Size = new System.Drawing.Size(189, 32);
            this.StorageFullButton.TabIndex = 74;
            this.StorageFullButton.Text = "Заполненные";
            this.StorageFullButton.UseVisualStyleBackColor = true;
            this.StorageFullButton.Click += new System.EventHandler(this.StorageFullButton_Click);
            // 
            // StorageFreeButton
            // 
            this.StorageFreeButton.Location = new System.Drawing.Point(13, 122);
            this.StorageFreeButton.Name = "StorageFreeButton";
            this.StorageFreeButton.Size = new System.Drawing.Size(189, 32);
            this.StorageFreeButton.TabIndex = 75;
            this.StorageFreeButton.Text = "Пустые";
            this.StorageFreeButton.UseVisualStyleBackColor = true;
            this.StorageFreeButton.Click += new System.EventHandler(this.StorageFreeButton_Click);
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(1318, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 28);
            this.label18.TabIndex = 77;
            this.label18.Text = "Цена:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(1433, 94);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(95, 26);
            this.textBox10.TabIndex = 76;
            // 
            // MaxCostText
            // 
            this.MaxCostText.Location = new System.Drawing.Point(13, 204);
            this.MaxCostText.Name = "MaxCostText";
            this.MaxCostText.Size = new System.Drawing.Size(303, 28);
            this.MaxCostText.TabIndex = 78;
            this.MaxCostText.Text = "Максимальная цена:";
            // 
            // AvgCostText
            // 
            this.AvgCostText.Location = new System.Drawing.Point(13, 232);
            this.AvgCostText.Name = "AvgCostText";
            this.AvgCostText.Size = new System.Drawing.Size(303, 28);
            this.AvgCostText.TabIndex = 79;
            this.AvgCostText.Text = "Средняя цена:";
            // 
            // totalCostText
            // 
            this.totalCostText.Location = new System.Drawing.Point(13, 260);
            this.totalCostText.Name = "totalCostText";
            this.totalCostText.Size = new System.Drawing.Size(384, 28);
            this.totalCostText.TabIndex = 80;
            this.totalCostText.Text = "Общая стоимость товаров:";
            // 
            // GoodNameDelCB
            // 
            this.GoodNameDelCB.FormattingEnabled = true;
            this.GoodNameDelCB.Location = new System.Drawing.Point(997, 149);
            this.GoodNameDelCB.Name = "GoodNameDelCB";
            this.GoodNameDelCB.Size = new System.Drawing.Size(97, 28);
            this.GoodNameDelCB.TabIndex = 81;
            // 
            // GoodNameEditCB
            // 
            this.GoodNameEditCB.FormattingEnabled = true;
            this.GoodNameEditCB.Location = new System.Drawing.Point(997, 243);
            this.GoodNameEditCB.Name = "GoodNameEditCB";
            this.GoodNameEditCB.Size = new System.Drawing.Size(84, 28);
            this.GoodNameEditCB.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(884, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 28);
            this.label5.TabIndex = 82;
            this.label5.Text = "Имя товара:";
            // 
            // CorpNameEditCB
            // 
            this.CorpNameEditCB.FormattingEnabled = true;
            this.CorpNameEditCB.Location = new System.Drawing.Point(1649, 173);
            this.CorpNameEditCB.Name = "CorpNameEditCB";
            this.CorpNameEditCB.Size = new System.Drawing.Size(95, 28);
            this.CorpNameEditCB.TabIndex = 84;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1433, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 28);
            this.comboBox1.TabIndex = 85;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1433, 65);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(95, 28);
            this.comboBox2.TabIndex = 86;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(1215, 32);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(95, 28);
            this.comboBox3.TabIndex = 87;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(1215, 63);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(95, 28);
            this.comboBox4.TabIndex = 88;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(1215, 152);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(95, 28);
            this.comboBox5.TabIndex = 89;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1756, 928);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CorpNameEditCB);
            this.Controls.Add(this.GoodNameEditCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GoodNameDelCB);
            this.Controls.Add(this.totalCostText);
            this.Controls.Add(this.AvgCostText);
            this.Controls.Add(this.MaxCostText);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.StorageFreeButton);
            this.Controls.Add(this.StorageFullButton);
            this.Controls.Add(this.CorpsOrderNameButton);
            this.Controls.Add(this.ContractOrderCostButton);
            this.Controls.Add(this.LoadCorpsButton);
            this.Controls.Add(this.LoadContractButton);
            this.Controls.Add(this.CorpEditButton);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.CorpAddButton);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.ContractAddButton);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.StorageDeleteButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.StorageAddButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.GoodEditButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GoodCostEdit);
            this.Controls.Add(this.GoodDeleteButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GoodAddButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CostGoodTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameGoodTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoodsInCountButton);
            this.Controls.Add(this.GoodOrgerCostButton);
            this.Controls.Add(this.GoodOrderNameButton);
            this.Controls.Add(this.LoadGoodsButton);
            this.Controls.Add(this.LoadStorageButton);
            this.Controls.Add(this.dataGridView);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Коковин В.А. ЛР 3, 4, 5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBox5;

        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;

        private System.Windows.Forms.ComboBox CorpNameEditCB;

        private System.Windows.Forms.ComboBox GoodNameDelCB;
        private System.Windows.Forms.ComboBox GoodNameEditCB;

        private System.Windows.Forms.Label totalCostText;

        private System.Windows.Forms.Label MaxCostText;
        private System.Windows.Forms.Label AvgCostText;

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox10;

        private System.Windows.Forms.Button LoadContractButton;
        private System.Windows.Forms.Button LoadCorpsButton;
        private System.Windows.Forms.Button ContractOrderCostButton;
        private System.Windows.Forms.Button CorpsOrderNameButton;
        private System.Windows.Forms.Button StorageFullButton;
        private System.Windows.Forms.Button StorageFreeButton;

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button CorpEditButton;
        private System.Windows.Forms.Button CorpAddButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button ContractAddButton;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;

        private System.Windows.Forms.Button StorageDeleteButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button StorageAddButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GoodCostEdit;
        private System.Windows.Forms.Button GoodEditButton;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GoodDeleteButton;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameGoodTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CostGoodTextBox;
        private System.Windows.Forms.Button GoodAddButton;

        private System.Windows.Forms.Button GoodsInCountButton;

        private System.Windows.Forms.Button GoodOrgerCostButton;

        private System.Windows.Forms.Button GoodOrderNameButton;

        private System.Windows.Forms.Button LoadGoodsButton;

        private System.Windows.Forms.Button LoadStorageButton;

        private System.Windows.Forms.DataGridView dataGridView;

        #endregion
    }
}