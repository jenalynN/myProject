namespace LoginModule.cs
{
    partial class NewCategory
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
            this.tbcatname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAddCat = new MaterialSkin.Controls.MaterialFlatButton();
            this.cbBrandP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btcancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // tbcatname
            // 
            this.tbcatname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcatname.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcatname.Location = new System.Drawing.Point(225, 153);
            this.tbcatname.MaxLength = 30;
            this.tbcatname.Name = "tbcatname";
            this.tbcatname.Size = new System.Drawing.Size(222, 26);
            this.tbcatname.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 23);
            this.label4.TabIndex = 85;
            this.label4.Text = "Category Name: ";
            // 
            // btAddCat
            // 
            this.btAddCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddCat.AutoSize = true;
            this.btAddCat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAddCat.Depth = 0;
            this.btAddCat.Icon = null;
            this.btAddCat.Location = new System.Drawing.Point(293, 230);
            this.btAddCat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAddCat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAddCat.Name = "btAddCat";
            this.btAddCat.Primary = false;
            this.btAddCat.Size = new System.Drawing.Size(154, 36);
            this.btAddCat.TabIndex = 87;
            this.btAddCat.Text = "Add New Category";
            this.btAddCat.UseVisualStyleBackColor = true;
            this.btAddCat.Click += new System.EventHandler(this.btAddCat_Click);
            // 
            // cbBrandP
            // 
            this.cbBrandP.BackColor = System.Drawing.Color.White;
            this.cbBrandP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrandP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBrandP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrandP.FormattingEnabled = true;
            this.cbBrandP.Location = new System.Drawing.Point(224, 103);
            this.cbBrandP.Name = "cbBrandP";
            this.cbBrandP.Size = new System.Drawing.Size(223, 33);
            this.cbBrandP.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 89;
            this.label1.Text = "Brand Partner: ";
            // 
            // btcancel
            // 
            this.btcancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btcancel.AutoSize = true;
            this.btcancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btcancel.Depth = 0;
            this.btcancel.Icon = null;
            this.btcancel.Location = new System.Drawing.Point(212, 230);
            this.btcancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btcancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btcancel.Name = "btcancel";
            this.btcancel.Primary = false;
            this.btcancel.Size = new System.Drawing.Size(73, 36);
            this.btcancel.TabIndex = 90;
            this.btcancel.Text = "Cancel";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // NewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 291);
            this.ControlBox = false;
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBrandP);
            this.Controls.Add(this.btAddCat);
            this.Controls.Add(this.tbcatname);
            this.Controls.Add(this.label4);
            this.Name = "NewCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCategory";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbcatname;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialFlatButton btAddCat;
        private System.Windows.Forms.ComboBox cbBrandP;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton btcancel;
    }
}