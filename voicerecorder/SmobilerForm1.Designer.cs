using Smobiler.Core;

namespace voicerecorder
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
            this.voiceRecorderButton1 = new Smobiler.Core.Controls.VoiceRecorderButton();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            // 
            // voiceRecorderButton1
            // 
            this.voiceRecorderButton1.FontSize = 8F;
            this.voiceRecorderButton1.Location = new Smobiler.Core.PointS(14F, 59F);
            this.voiceRecorderButton1.Name = "voiceRecorderButton1";
            this.voiceRecorderButton1.ResourceID = "record";
            this.voiceRecorderButton1.Size = new System.Drawing.SizeF(40F, 40F);
            this.voiceRecorderButton1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.voiceRecorderButton1.TabIndex = 9;
            this.voiceRecorderButton1.Text = "录音";
            this.voiceRecorderButton1.RecordedAudio += new Smobiler.Core.VoiceRecorderOnlineCallBackHandler(this.voiceRecorderButton1_RecordedAudio);
            // 
            // imageButton1
            // 
            this.imageButton1.FontSize = 8F;
            this.imageButton1.Location = new Smobiler.Core.PointS(62F, 59F);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "play";
            this.imageButton1.Size = new System.Drawing.SizeF(40F, 40F);
            this.imageButton1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imageButton1.TabIndex = 10;
            this.imageButton1.Text = "播放";
            this.imageButton1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.imageButton1_Click);
            // 
            // SmobilerForm1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.voiceRecorderButton1,
            this.imageButton1});

        }
        #endregion

        private Smobiler.Core.Controls.VoiceRecorderButton voiceRecorderButton1;
        private Smobiler.Core.Controls.ImageButton imageButton1;
    }
}