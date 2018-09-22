namespace EvaluationSystem
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Course ID No.";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Course";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Course Description";
            this.columnHeader3.Width = 120;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(19, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(377, 230);
            this.listView1.TabIndex = 119;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.CustomBackground = false;
            this.metroLabel18.CustomForeColor = false;
            this.metroLabel18.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel18.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel18.Location = new System.Drawing.Point(448, 51);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(101, 25);
            this.metroLabel18.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel18.StyleManager = null;
            this.metroLabel18.TabIndex = 134;
            this.metroLabel18.Text = "Add Course";
            this.metroLabel18.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel18.UseStyleColors = true;
            this.metroLabel18.Click += new System.EventHandler(this.metroLabel18_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(410, 51);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 32);
            this.pictureBox7.TabIndex = 135;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.CustomBackground = false;
            this.metroLabel19.CustomForeColor = false;
            this.metroLabel19.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel19.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel19.Location = new System.Drawing.Point(448, 89);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(118, 25);
            this.metroLabel19.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel19.StyleManager = null;
            this.metroLabel19.TabIndex = 136;
            this.metroLabel19.Text = "Delete Course";
            this.metroLabel19.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel19.UseStyleColors = true;
            this.metroLabel19.Click += new System.EventHandler(this.metroLabel19_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(410, 89);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 32);
            this.pictureBox8.TabIndex = 137;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = false;
            this.metroLabel4.CustomForeColor = false;
            this.metroLabel4.Enabled = false;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel4.Location = new System.Drawing.Point(401, 16);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel4.StyleManager = null;
            this.metroLabel4.TabIndex = 140;
            this.metroLabel4.Text = "Course ID";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.CustomBackground = false;
            this.metroTextBox2.CustomForeColor = false;
            this.metroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.metroTextBox2.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.metroTextBox2.Location = new System.Drawing.Point(470, 12);
            this.metroTextBox2.Multiline = false;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.Size = new System.Drawing.Size(96, 23);
            this.metroTextBox2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTextBox2.StyleManager = null;
            this.metroTextBox2.TabIndex = 141;
            this.metroTextBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox2.UseStyleColors = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = false;
            this.metroButton1.Location = new System.Drawing.Point(401, 241);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(183, 30);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 142;
            this.metroButton1.Text = "Ok";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 302);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.listView1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form4";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listView1;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private System.Windows.Forms.PictureBox pictureBox7;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private System.Windows.Forms.PictureBox pictureBox8;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroButton metroButton1;

    }
}