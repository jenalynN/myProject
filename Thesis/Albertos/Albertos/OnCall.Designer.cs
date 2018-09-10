namespace Albertos
{
    partial class OnCall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnCall));
            this.LVPizzaList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.LVCustomer = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btcancel = new System.Windows.Forms.Button();
            this.btconfirm = new System.Windows.Forms.Button();
            this.tbCoNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.tbquantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbsize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDateOrdered = new System.Windows.Forms.DateTimePicker();
            this.rbDineIn = new System.Windows.Forms.RadioButton();
            this.rbOncall = new System.Windows.Forms.RadioButton();
            this.tbid = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.btHome = new System.Windows.Forms.Button();
            this.textBoxpizzaid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LVPizzaList
            // 
            this.LVPizzaList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.LVPizzaList.Enabled = false;
            this.LVPizzaList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVPizzaList.FullRowSelect = true;
            this.LVPizzaList.GridLines = true;
            this.LVPizzaList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LVPizzaList.Location = new System.Drawing.Point(34, 191);
            this.LVPizzaList.Name = "LVPizzaList";
            this.LVPizzaList.Size = new System.Drawing.Size(333, 419);
            this.LVPizzaList.TabIndex = 0;
            this.LVPizzaList.TileSize = new System.Drawing.Size(5, 5);
            this.LVPizzaList.UseCompatibleStateImageBehavior = false;
            this.LVPizzaList.View = System.Windows.Forms.View.Details;
            this.LVPizzaList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LVPizzaList_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 204;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pizza List";
            // 
            // LVCustomer
            // 
            this.LVCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader10,
            this.columnHeader6,
            this.columnHeader9});
            this.LVCustomer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVCustomer.FullRowSelect = true;
            this.LVCustomer.GridLines = true;
            this.LVCustomer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LVCustomer.Location = new System.Drawing.Point(652, 191);
            this.LVCustomer.Name = "LVCustomer";
            this.LVCustomer.Size = new System.Drawing.Size(420, 419);
            this.LVCustomer.TabIndex = 34;
            this.LVCustomer.UseCompatibleStateImageBehavior = false;
            this.LVCustomer.View = System.Windows.Forms.View.Details;
            this.LVCustomer.SelectedIndexChanged += new System.EventHandler(this.LVCustomer_SelectedIndexChanged);
            this.LVCustomer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LVCustomer_MouseDoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "idOrder";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Pizza Name";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 132;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Size";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Price";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 84;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Quantity";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 71;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Total";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 68;
            // 
            // btcancel
            // 
            this.btcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancel.Location = new System.Drawing.Point(951, 616);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(121, 29);
            this.btcancel.TabIndex = 35;
            this.btcancel.Text = "Cancel Order";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // btconfirm
            // 
            this.btconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btconfirm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconfirm.Location = new System.Drawing.Point(951, 651);
            this.btconfirm.Name = "btconfirm";
            this.btconfirm.Size = new System.Drawing.Size(121, 29);
            this.btconfirm.TabIndex = 36;
            this.btconfirm.Text = "Confirm Order";
            this.btconfirm.UseVisualStyleBackColor = true;
            this.btconfirm.Click += new System.EventHandler(this.btconfirm_Click);
            // 
            // tbCoNum
            // 
            this.tbCoNum.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCoNum.Location = new System.Drawing.Point(138, 57);
            this.tbCoNum.Name = "tbCoNum";
            this.tbCoNum.Size = new System.Drawing.Size(169, 22);
            this.tbCoNum.TabIndex = 43;
            this.tbCoNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCoNum_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Contact Number";
            // 
            // tbCName
            // 
            this.tbCName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCName.Location = new System.Drawing.Point(138, 19);
            this.tbCName.Name = "tbCName";
            this.tbCName.Size = new System.Drawing.Size(169, 22);
            this.tbCName.TabIndex = 41;
            this.tbCName.TextChanged += new System.EventHandler(this.tbCName_TextChanged);
            this.tbCName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCName_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Customer Address";
            // 
            // tbCAddress
            // 
            this.tbCAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCAddress.Location = new System.Drawing.Point(138, 92);
            this.tbCAddress.Name = "tbCAddress";
            this.tbCAddress.Size = new System.Drawing.Size(169, 22);
            this.tbCAddress.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Price";
            // 
            // tbprice
            // 
            this.tbprice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbprice.Location = new System.Drawing.Point(170, 348);
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(100, 23);
            this.tbprice.TabIndex = 52;
            this.tbprice.TextChanged += new System.EventHandler(this.tbprice_TextChanged);
            // 
            // tbquantity
            // 
            this.tbquantity.BackColor = System.Drawing.Color.White;
            this.tbquantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbquantity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbquantity.Location = new System.Drawing.Point(39, 84);
            this.tbquantity.Name = "tbquantity";
            this.tbquantity.Size = new System.Drawing.Size(100, 23);
            this.tbquantity.TabIndex = 51;
            this.tbquantity.TextChanged += new System.EventHandler(this.tbquantity_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Quantity";
            // 
            // tbsize
            // 
            this.tbsize.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsize.Location = new System.Drawing.Point(170, 308);
            this.tbsize.Name = "tbsize";
            this.tbsize.Size = new System.Drawing.Size(100, 23);
            this.tbsize.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "Order ID";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(170, 266);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 23);
            this.tbName.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(821, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 29);
            this.button1.TabIndex = 55;
            this.button1.Text = "Remove Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbtotal
            // 
            this.tbtotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtotal.Location = new System.Drawing.Point(170, 397);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.Size = new System.Drawing.Size(100, 23);
            this.tbtotal.TabIndex = 56;
            this.tbtotal.TextChanged += new System.EventHandler(this.tbtotal_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(91, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 17);
            this.label11.TabIndex = 57;
            this.label11.Text = "Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(743, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 17);
            this.label12.TabIndex = 59;
            this.label12.Text = "Date of Order";
            // 
            // dtpDateOrdered
            // 
            this.dtpDateOrdered.CustomFormat = "yyyy-MM-dd";
            this.dtpDateOrdered.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOrdered.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOrdered.Location = new System.Drawing.Point(846, 31);
            this.dtpDateOrdered.Name = "dtpDateOrdered";
            this.dtpDateOrdered.Size = new System.Drawing.Size(200, 23);
            this.dtpDateOrdered.TabIndex = 60;
            // 
            // rbDineIn
            // 
            this.rbDineIn.AutoSize = true;
            this.rbDineIn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDineIn.Location = new System.Drawing.Point(47, 17);
            this.rbDineIn.Name = "rbDineIn";
            this.rbDineIn.Size = new System.Drawing.Size(70, 21);
            this.rbDineIn.TabIndex = 62;
            this.rbDineIn.TabStop = true;
            this.rbDineIn.Text = "Dine-In";
            this.rbDineIn.UseVisualStyleBackColor = true;
            this.rbDineIn.CheckedChanged += new System.EventHandler(this.rbDineIn_CheckedChanged);
            // 
            // rbOncall
            // 
            this.rbOncall.AutoSize = true;
            this.rbOncall.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOncall.Location = new System.Drawing.Point(123, 17);
            this.rbOncall.Name = "rbOncall";
            this.rbOncall.Size = new System.Drawing.Size(75, 21);
            this.rbOncall.TabIndex = 63;
            this.rbOncall.TabStop = true;
            this.rbOncall.Text = "On-Call";
            this.rbOncall.UseVisualStyleBackColor = true;
            this.rbOncall.CheckedChanged += new System.EventHandler(this.rbOncall_CheckedChanged);
            // 
            // tbid
            // 
            this.tbid.Enabled = false;
            this.tbid.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbid.Location = new System.Drawing.Point(108, 15);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(31, 23);
            this.tbid.TabIndex = 44;
            this.tbid.TextChanged += new System.EventHandler(this.tbid_TextChanged);
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(34, 656);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(41, 20);
            this.textBoxid.TabIndex = 65;
            this.textBoxid.Visible = false;
            // 
            // btHome
            // 
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.Location = new System.Drawing.Point(821, 651);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(124, 29);
            this.btHome.TabIndex = 66;
            this.btHome.Text = "Home";
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // textBoxpizzaid
            // 
            this.textBoxpizzaid.Location = new System.Drawing.Point(81, 656);
            this.textBoxpizzaid.Name = "textBoxpizzaid";
            this.textBoxpizzaid.Size = new System.Drawing.Size(45, 20);
            this.textBoxpizzaid.TabIndex = 68;
            this.textBoxpizzaid.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(649, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 16);
            this.label10.TabIndex = 70;
            this.label10.Text = "Customer Order List";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1114, 767);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 71;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCoNum);
            this.groupBox1.Controls.Add(this.tbCName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbCAddress);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(32, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 124);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.tbquantity);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbid);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(398, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 174);
            this.panel2.TabIndex = 74;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(128, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 26);
            this.button3.TabIndex = 66;
            this.button3.Text = "Order";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Color = System.Drawing.SystemColors.ControlText;
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // OnCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1085, 688);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LVPizzaList);
            this.Controls.Add(this.rbDineIn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LVCustomer);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btconfirm);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.btHome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxpizzaid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpDateOrdered);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rbOncall);
            this.Controls.Add(this.tbtotal);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbsize);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(180, 50);
            this.Name = "OnCall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "OnCall";
            this.Load += new System.EventHandler(this.Order1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LVPizzaList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LVCustomer;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Button btconfirm;
        private System.Windows.Forms.TextBox tbCoNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.TextBox tbquantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbsize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDateOrdered;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.RadioButton rbDineIn;
        private System.Windows.Forms.RadioButton rbOncall;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.TextBox textBoxpizzaid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}