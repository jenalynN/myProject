namespace Albertos
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.tbquantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbsize = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpizzid = new System.Windows.Forms.TextBox();
            this.tbdtp = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(39, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 26);
            this.button1.TabIndex = 54;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbtotal
            // 
            this.tbtotal.Location = new System.Drawing.Point(129, 126);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.Size = new System.Drawing.Size(21, 20);
            this.tbtotal.TabIndex = 68;
            this.tbtotal.Visible = false;
            this.tbtotal.TextChanged += new System.EventHandler(this.tbtotal_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(129, 127);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(21, 20);
            this.tbName.TabIndex = 59;
            this.tbName.Visible = false;
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(12, 126);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(21, 20);
            this.tbid.TabIndex = 58;
            this.tbid.Visible = false;
            // 
            // tbprice
            // 
            this.tbprice.Location = new System.Drawing.Point(129, 126);
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(21, 20);
            this.tbprice.TabIndex = 66;
            this.tbprice.Visible = false;
            this.tbprice.TextChanged += new System.EventHandler(this.tbprice_TextChanged);
            // 
            // tbquantity
            // 
            this.tbquantity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbquantity.Location = new System.Drawing.Point(39, 68);
            this.tbquantity.Name = "tbquantity";
            this.tbquantity.Size = new System.Drawing.Size(100, 22);
            this.tbquantity.TabIndex = 65;
            this.tbquantity.TextChanged += new System.EventHandler(this.tbquantity_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "Quantity";
            // 
            // tbsize
            // 
            this.tbsize.Location = new System.Drawing.Point(129, 126);
            this.tbsize.Name = "tbsize";
            this.tbsize.Size = new System.Drawing.Size(21, 20);
            this.tbsize.TabIndex = 63;
            this.tbsize.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(254)))), ((int)(((byte)(110)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 26);
            this.panel1.TabIndex = 69;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbpizzid
            // 
            this.tbpizzid.Location = new System.Drawing.Point(129, 127);
            this.tbpizzid.Name = "tbpizzid";
            this.tbpizzid.Size = new System.Drawing.Size(21, 20);
            this.tbpizzid.TabIndex = 70;
            this.tbpizzid.Visible = false;
            // 
            // tbdtp
            // 
            this.tbdtp.Location = new System.Drawing.Point(129, 126);
            this.tbdtp.Name = "tbdtp";
            this.tbdtp.Size = new System.Drawing.Size(21, 20);
            this.tbdtp.TabIndex = 71;
            this.tbdtp.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(170, 161);
            this.Controls.Add(this.tbdtp);
            this.Controls.Add(this.tbpizzid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbtotal);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.tbprice);
            this.Controls.Add(this.tbquantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbsize);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.TextBox tbquantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbsize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbpizzid;
        private System.Windows.Forms.TextBox tbdtp;
    }
}