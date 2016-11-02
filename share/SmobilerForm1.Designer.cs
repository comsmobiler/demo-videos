using Smobiler.Core;

namespace SmobilerApplication18
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
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.button3 = new Smobiler.Core.Controls.Button();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.textBox2 = new Smobiler.Core.Controls.TextBox();
            this.button4 = new Smobiler.Core.Controls.Button();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.BorderRadius = 2;
            this.button1.Location = new System.Drawing.Point(101, 12);
            this.button1.Name = "button1";
            this.button1.TabIndex = 2;
            this.button1.Text = "截屏分享";
            this.button1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.BorderRadius = 2;
            this.button2.Location = new System.Drawing.Point(202, 12);
            this.button2.Name = "button2";
            this.button2.TabIndex = 3;
            this.button2.Text = "图片分享";
            this.button2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "链接分享：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 40);
            this.textBox1.TabIndex = 5;
            this.textBox1.WaterMarkText = "请输入要分享的链接";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button3.Location = new System.Drawing.Point(260, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "分享";
            this.button3.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "文本分享：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 40);
            this.textBox2.TabIndex = 8;
            this.textBox2.WaterMarkText = "请输入要分享的文本";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button4.Location = new System.Drawing.Point(260, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 9;
            this.button4.Text = "分享";
            this.button4.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.button4_Click);
            // 
            // SmobilerForm1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button1,
            this.button2,
            this.label1,
            this.textBox1,
            this.button3,
            this.label2,
            this.textBox2,
            this.button4});
            this.Name = "SmobilerForm1";

        }
        #endregion

        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Button button2;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.Button button3;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.TextBox textBox2;
        private Smobiler.Core.Controls.Button button4;
    }
}