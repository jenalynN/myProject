namespace EvaluationSystem
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader52 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader53 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader54 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader55 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader56 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filter_data = new MetroFramework.Controls.MetroTextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader32,
            this.columnHeader52,
            this.columnHeader53,
            this.columnHeader54,
            this.columnHeader55,
            this.columnHeader56,
            this.columnHeader1});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(19, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(704, 354);
            this.listView1.TabIndex = 120;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "Id";
            // 
            // columnHeader52
            // 
            this.columnHeader52.Text = "Subject";
            this.columnHeader52.Width = 154;
            // 
            // columnHeader53
            // 
            this.columnHeader53.Text = "Room";
            this.columnHeader53.Width = 173;
            // 
            // columnHeader54
            // 
            this.columnHeader54.Text = "Time Start";
            this.columnHeader54.Width = 99;
            // 
            // columnHeader55
            // 
            this.columnHeader55.Text = "Time End";
            this.columnHeader55.Width = 113;
            // 
            // columnHeader56
            // 
            this.columnHeader56.Text = "Instructor";
            // 
            // filter_data
            // 
            this.filter_data.CustomBackground = false;
            this.filter_data.CustomForeColor = false;
            this.filter_data.Enabled = false;
            this.filter_data.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.filter_data.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.filter_data.Location = new System.Drawing.Point(19, 45);
            this.filter_data.Multiline = false;
            this.filter_data.Name = "filter_data";
            this.filter_data.SelectedText = "";
            this.filter_data.Size = new System.Drawing.Size(73, 23);
            this.filter_data.Style = MetroFramework.MetroColorStyle.Black;
            this.filter_data.StyleManager = null;
            this.filter_data.TabIndex = 150;
            this.filter_data.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.filter_data.UseStyleColors = false;
            this.filter_data.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Instructor Id";
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = false;
            this.metroButton1.Location = new System.Drawing.Point(520, 432);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(203, 48);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 151;
            this.metroButton1.Text = "Okay";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 503);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.filter_data);
            this.Controls.Add(this.listView1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form3";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.ColumnHeader columnHeader52;
        private System.Windows.Forms.ColumnHeader columnHeader53;
        private System.Windows.Forms.ColumnHeader columnHeader54;
        private System.Windows.Forms.ColumnHeader columnHeader55;
        private System.Windows.Forms.ColumnHeader columnHeader56;
        private MetroFramework.Controls.MetroTextBox filter_data;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}