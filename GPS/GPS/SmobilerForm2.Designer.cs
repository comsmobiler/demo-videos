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
            this.labelName.FontSize = 7F;
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(72)))), ((int)(((byte)(90)))));
            this.labelName.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.labelName.Location = new Smobiler.Core.PointS(2F, 1F);
            this.labelName.Name = "labelName";
            this.labelName.TabIndex = 2;
            this.labelName.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            // 
            // label2
            // 
            this.label2.FontSize = 5F;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new Smobiler.Core.PointS(43F, 5F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.SizeF(12F, 6F);
            this.label2.TabIndex = 3;
            this.label2.Text = "电话：";
            this.label2.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            // 
            // labelPhone
            // 
            this.labelPhone.DataMember = "Phone";
            this.labelPhone.DisplayMember = "Phone";
            this.labelPhone.FontSize = 5F;
            this.labelPhone.ForeColor = System.Drawing.Color.Silver;
            this.labelPhone.Location = new Smobiler.Core.PointS(55F, 5F);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.SizeF(22F, 6F);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "label3";
            this.labelPhone.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            // 
            // imagePhone
            // 
            this.imagePhone.BackColor = System.Drawing.Color.LightGray;
            this.imagePhone.BorderRadius = 10;
            this.imagePhone.FontSize = 4F;
            this.imagePhone.Location = new Smobiler.Core.PointS(36F, 5F);
            this.imagePhone.Name = "imagePhone";
            this.imagePhone.Padding = new Smobiler.Core.Padding(1F);
            this.imagePhone.ResourceID = "Call";
            this.imagePhone.Size = new System.Drawing.SizeF(6F, 6F);
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
            this.checkBox1.Location = new Smobiler.Core.PointS(3F, 12F);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.SizeF(7F, 7F);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UnCheckedBackColor = System.Drawing.Color.LightGray;
            this.checkBox1.UnCheckedColor = System.Drawing.Color.WhiteSmoke;
            // 
            // labelAddress
            // 
            this.labelAddress.DataMember = "longitude";
            this.labelAddress.DisplayMember = "Address";
            this.labelAddress.FontSize = 5F;
            this.labelAddress.ForeColor = System.Drawing.Color.Gray;
            this.labelAddress.Location = new Smobiler.Core.PointS(12F, 12F);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.SizeF(76F, 7F);
            this.labelAddress.TabIndex = 7;
            this.labelAddress.Text = "label4";
            // 
            // imageNavigation
            // 
            this.imageNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(78)))), ((int)(((byte)(93)))));
            this.imageNavigation.BorderRadius = 6;
            this.imageNavigation.FontSize = 5F;
            this.imageNavigation.Location = new Smobiler.Core.PointS(93F, 3F);
            this.imageNavigation.Name = "imageNavigation";
            this.imageNavigation.ResourceID = "route";
            this.imageNavigation.Size = new System.Drawing.SizeF(10F, 10F);
            this.imageNavigation.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imageNavigation.TabIndex = 8;
            // 
            // labelNavigation
            // 
            this.labelNavigation.FontSize = 4F;
            this.labelNavigation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.labelNavigation.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.labelNavigation.Location = new Smobiler.Core.PointS(92F, 15F);
            this.labelNavigation.Name = "labelNavigation";
            this.labelNavigation.Size = new System.Drawing.SizeF(12F, 5F);
            this.labelNavigation.TabIndex = 9;
            this.labelNavigation.Text = "导航";
            // 
            // imageLocation
            // 
            this.imageLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(78)))), ((int)(((byte)(93)))));
            this.imageLocation.BorderRadius = 6;
            this.imageLocation.DataMember = "latitude";
            this.imageLocation.FontSize = 4F;
            this.imageLocation.Location = new Smobiler.Core.PointS(106F, 3F);
            this.imageLocation.Name = "imageLocation";
            this.imageLocation.ResourceID = "Location";
            this.imageLocation.Size = new System.Drawing.SizeF(10F, 10F);
            this.imageLocation.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imageLocation.TabIndex = 10;
            // 
            // labelLocation
            // 
            this.labelLocation.FontSize = 4F;
            this.labelLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.labelLocation.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.labelLocation.Location = new Smobiler.Core.PointS(105F, 15F);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.SizeF(12F, 5F);
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
            this.Size = new System.Drawing.Size(120, 21);
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