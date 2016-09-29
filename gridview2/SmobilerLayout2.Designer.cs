using System;
using Smobiler.Core;
namespace gridview2
{
    partial class SmobilerLayout2 : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public SmobilerLayout2()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.datePicker1 = new Smobiler.Core.Controls.DatePicker();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.textBox2 = new Smobiler.Core.Controls.TextBox();
            this.checkBox1 = new Smobiler.Core.Controls.CheckBox();
            // 
            // image1
            // 
            this.image1.DataMember = "Type";
            this.image1.DisplayMember = "Type";
            this.image1.Location = new System.Drawing.Point(10,4);
            this.image1.Name = "image1";
            this.image1.ResourceID = "Type";
            this.image1.Size = new System.Drawing.Size(20,20);
            this.image1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.DataMember = "TypeName";
            this.label1.DisplayMember = "TypeName";
            this.label1.FontSize = 8;
            this.label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(0,24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40,16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.FontSize = 18;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(44,4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10,20);
            this.label2.TabIndex = 4;
            this.label2.Text = "£¤";
            // 
            // textBox1
            // 
            this.textBox1.Border = new Smobiler.Core.Border(0);
            this.textBox1.DataMember = "Money";
            this.textBox1.DisplayMember = "Money";
            this.textBox1.FontSize = 18;
            this.textBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.textBox1.Location = new System.Drawing.Point(54,4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50,20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "textBox1";
            // 
            // datePicker1
            // 
            this.datePicker1.DataMember = "Date";
            this.datePicker1.DisplayMember = "Date";
            this.datePicker1.FontSize = 10;
            this.datePicker1.ForeColor = System.Drawing.Color.DimGray;
            this.datePicker1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.datePicker1.Location = new System.Drawing.Point(54,26);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(50,14);
            this.datePicker1.TabIndex = 6;
            this.datePicker1.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // label3
            // 
            this.label3.FontSize = 8;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(110,0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20,40);
            this.label3.TabIndex = 7;
            this.label3.Text = "±¸×¢£º";
            // 
            // textBox2
            // 
            this.textBox2.Border = new Smobiler.Core.Border(0);
            this.textBox2.DataMember = "Memo";
            this.textBox2.DisplayMember = "Memo";
            this.textBox2.FontSize = 10;
            this.textBox2.ForeColor = System.Drawing.Color.DimGray;
            this.textBox2.Location = new System.Drawing.Point(130,0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80,40);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "textBox2";
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Gray;
            this.checkBox1.BorderRadius = 6;
            this.checkBox1.Checked = false;
            this.checkBox1.CheckedBackColor = System.Drawing.Color.Tomato;
            this.checkBox1.CheckedColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(220,12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(16,16);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.UnCheckedColor = System.Drawing.Color.DarkGray;
            // 
            // SmobilerLayout2
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.label1,
            this.label2,
            this.textBox1,
            this.datePicker1,
            this.label3,
            this.textBox2,
            this.checkBox1});
            this.Size = new System.Drawing.Size(240,40);
            this.Name = "SmobilerLayout2";

        }
        #endregion

        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.DatePicker datePicker1;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.TextBox textBox2;
        private Smobiler.Core.Controls.CheckBox checkBox1;
    }
}
