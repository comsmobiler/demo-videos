using Smobiler.Core;

namespace phone
{
    partial class SmobilerForm1 : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        public SmobilerForm1()
            : base()
        {
            //This call is required by the SmobilerForm Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.phoneButton1 = new Smobiler.Core.Controls.PhoneButton();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.phoneButton2 = new Smobiler.Core.Controls.PhoneButton();
            this.phoneButton3 = new Smobiler.Core.Controls.PhoneButton();
            this.phoneButton4 = new Smobiler.Core.Controls.PhoneButton();
            this.phoneButton5 = new Smobiler.Core.Controls.PhoneButton();
            // 
            // phoneButton1
            // 
            this.phoneButton1.FontSize = 16F;
            this.phoneButton1.Location = new System.Drawing.Point(8, 16);
            this.phoneButton1.Name = "phoneButton1";
            this.phoneButton1.ResourceID = "contacts";
            this.phoneButton1.Size = new System.Drawing.Size(80, 80);
            this.phoneButton1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.phoneButton1.TabIndex = 2;
            this.phoneButton1.Text = "通讯录";
            // 
            // label1
            // 
            this.label1.FontSize = 10F;
            this.label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(108, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "关键联系人";
            // 
            // phoneButton2
            // 
            this.phoneButton2.FontSize = 8F;
            this.phoneButton2.Location = new System.Drawing.Point(96, 48);
            this.phoneButton2.Name = "phoneButton2";
            this.phoneButton2.PhoneNumber = "1234561111";
            this.phoneButton2.ResourceID = "Dave";
            this.phoneButton2.Size = new System.Drawing.Size(30, 40);
            this.phoneButton2.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.phoneButton2.TabIndex = 4;
            this.phoneButton2.Text = "Dave";
            // 
            // phoneButton3
            // 
            this.phoneButton3.FontSize = 8F;
            this.phoneButton3.Location = new System.Drawing.Point(134, 48);
            this.phoneButton3.Name = "phoneButton3";
            this.phoneButton3.PhoneNumber = "1234563333";
            this.phoneButton3.ResourceID = "Jorge";
            this.phoneButton3.Size = new System.Drawing.Size(30, 40);
            this.phoneButton3.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.phoneButton3.TabIndex = 5;
            this.phoneButton3.Text = "Jorge";
            // 
            // phoneButton4
            // 
            this.phoneButton4.FontSize = 8F;
            this.phoneButton4.Location = new System.Drawing.Point(172, 48);
            this.phoneButton4.Name = "phoneButton4";
            this.phoneButton4.PhoneNumber = "1234564444";
            this.phoneButton4.ResourceID = "Kevin";
            this.phoneButton4.Size = new System.Drawing.Size(30, 40);
            this.phoneButton4.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.phoneButton4.TabIndex = 6;
            this.phoneButton4.Text = "Kevin";
            // 
            // phoneButton5
            // 
            this.phoneButton5.FontSize = 8F;
            this.phoneButton5.Location = new System.Drawing.Point(206, 48);
            this.phoneButton5.Name = "phoneButton5";
            this.phoneButton5.PhoneNumber = "1234568888";
            this.phoneButton5.ResourceID = "Tim";
            this.phoneButton5.Size = new System.Drawing.Size(30, 40);
            this.phoneButton5.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.phoneButton5.TabIndex = 7;
            this.phoneButton5.Text = "Tim";
            // 
            // SmobilerForm1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.phoneButton1,
            this.label1,
            this.phoneButton2,
            this.phoneButton3,
            this.phoneButton4,
            this.phoneButton5});
            this.Name = "SmobilerForm1";

        }
        #endregion

        private Smobiler.Core.Controls.PhoneButton phoneButton1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.PhoneButton phoneButton2;
        private Smobiler.Core.Controls.PhoneButton phoneButton3;
        private Smobiler.Core.Controls.PhoneButton phoneButton4;
        private Smobiler.Core.Controls.PhoneButton phoneButton5;
    }
}
