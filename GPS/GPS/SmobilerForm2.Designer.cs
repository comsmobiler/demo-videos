using System;
using Smobiler.Core;
namespace SmobilerApplication79
{
    partial class SmobilerForm2 : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public SmobilerForm2()
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
            this.labelName = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.labelPhone = new Smobiler.Core.Controls.Label();
            this.imagePhone = new Smobiler.Core.Controls.ImageButton();
            this.checkBox1 = new Smobiler.Core.Controls.CheckBox();
            this.labelAddress = new Smobiler.Core.Controls.Label();
            this.imageNavigation = new Smobiler.Core.Controls.ImageButton();
            this.labelNavigation = new Smobiler.Core.Controls.Label();
            this.imageLocation = new Smobiler.Core.Controls.ImageButton();
            this.labelLocation = new Smobiler.Core.Controls.Label();
            // 
            // labelName
            // 
            this.labelName.DataMember = "Name";
            this.labelName.DisplayMember = "Name";
            this.labelName.FontSize = 14;
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(72)))), ((int)(((byte)(90)))));
            this.labelName.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.labelName.Location = new System.Drawing.Point(4,2);
            this.labelName.Name = "labelName";
            this.labelName.TabIndex = 2;
            this.labelName.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            // 
            // label2
            // 
            this.label2.FontSize = 10;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(86,10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24,12);
            this.label2.TabIndex = 3;
            this.label2.Text = "电话：";
            this.label2.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            // 
            // labelPhone
            // 
            this.labelPhone.DataMember = "Phone";
            this.labelPhone.DisplayMember = "Phone";
            this.labelPhone.FontSize = 10;
            this.labelPhone.ForeColor = System.Drawing.Color.Silver;
            this.labelPhone.Location = new System.Drawing.Point(110,10);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(44,12);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "label3";
            this.labelPhone.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            // 
            // imagePhone
            // 
            this.imagePhone.BackColor = System.Drawing.Color.LightGray;
            this.imagePhone.BorderRadius = 10;
            this.imagePhone.FontSize = 8;
            this.imagePhone.Location = new System.Drawing.Point(72,10);
            this.imagePhone.Name = "imagePhone";
            this.imagePhone.Padding = new Smobiler.Core.Padding(1F);
            this.imagePhone.ResourceID = "Call";
            this.imagePhone.Size = new System.Drawing.Size(12,12);
            this.imagePhone.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imagePhone.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.LightGray;
            this.checkBox1.BorderRadius = 6;
            this.checkBox1.Checked = false;
            this.checkBox1.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(72)))), ((int)(((byte)(73)))));
            this.checkBox1.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(78)))), ((int)(((byte)(93)))));
            this.checkBox1.Location = new System.Drawing.Point(6,24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(14,14);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UnCheckedBackColor = System.Drawing.Color.LightGray;
            this.checkBox1.UnCheckedColor = System.Drawing.Color.WhiteSmoke;
            // 
            // labelAddress
            // 
            this.labelAddress.DataMember = "longitude";
            this.labelAddress.DisplayMember = "Address";
            this.labelAddress.FontSize = 10;
            this.labelAddress.ForeColor = System.Drawing.Color.Gray;
            this.labelAddress.Location = new System.Drawing.Point(24,24);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(152,14);
            this.labelAddress.TabIndex = 7;
            this.labelAddress.Text = "label4";
            // 
            // imageNavigation
            // 
            this.imageNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(78)))), ((int)(((byte)(93)))));
            this.imageNavigation.BorderRadius = 6;
            this.imageNavigation.FontSize = 10;
            this.imageNavigation.Location = new System.Drawing.Point(186,6);
            this.imageNavigation.Name = "imageNavigation";
            this.imageNavigation.ResourceID = "route";
            this.imageNavigation.Size = new System.Drawing.Size(20,20);
            this.imageNavigation.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imageNavigation.TabIndex = 8;
            // 
            // labelNavigation
            // 
            this.labelNavigation.FontSize = 8;
            this.labelNavigation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.labelNavigation.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.labelNavigation.Location = new System.Drawing.Point(184,30);
            this.labelNavigation.Name = "labelNavigation";
            this.labelNavigation.Size = new System.Drawing.Size(24,10);
            this.labelNavigation.TabIndex = 9;
            this.labelNavigation.Text = "导航";
            // 
            // imageLocation
            // 
            this.imageLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(78)))), ((int)(((byte)(93)))));
            this.imageLocation.BorderRadius = 6;
            this.imageLocation.DataMember = "latitude";
            this.imageLocation.FontSize = 8;
            this.imageLocation.Location = new System.Drawing.Point(212,6);
            this.imageLocation.Name = "imageLocation";
            this.imageLocation.ResourceID = "Location";
            this.imageLocation.Size = new System.Drawing.Size(20,20);
            this.imageLocation.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imageLocation.TabIndex = 10;
            // 
            // labelLocation
            // 
            this.labelLocation.FontSize = 8;
            this.labelLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.labelLocation.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.labelLocation.Location = new System.Drawing.Point(210,30);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(24,10);
            this.labelLocation.TabIndex = 11;
            this.labelLocation.Text = "位置";
            // 
            // SmobilerForm2
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labelName,
            this.label2,
            this.labelPhone,
            this.imagePhone,
            this.checkBox1,
            this.labelAddress,
            this.imageNavigation,
            this.labelNavigation,
            this.imageLocation,
            this.labelLocation});
            this.Size = new System.Drawing.Size(240,42);
            this.Name = "SmobilerForm2";

        }
        #endregion

        private Smobiler.Core.Controls.Label labelName;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label labelPhone;
        private Smobiler.Core.Controls.ImageButton imagePhone;
        private Smobiler.Core.Controls.CheckBox checkBox1;
        private Smobiler.Core.Controls.Label labelAddress;
        private Smobiler.Core.Controls.ImageButton imageNavigation;
        private Smobiler.Core.Controls.Label labelNavigation;
        private Smobiler.Core.Controls.ImageButton imageLocation;
        private Smobiler.Core.Controls.Label labelLocation;
    }
}
