using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace voicerecorder
{
    partial class SmobilerForm1 : Smobiler.Core.MobileForm
    {
        private string curdir = System.AppDomain.CurrentDomain.BaseDirectory;
        private void voiceRecorderButton1_RecordedAudio(object sender, BinaryData e)
        {
            e.SaveFile("voice.amr", curdir);
        }

        private void imageButton1_Click(object sender, EventArgs e)
        {
            this.PlayVoice("voice.amr", curdir);
        }
    }
}