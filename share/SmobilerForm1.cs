using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerApplication18
{
    partial class SmobilerForm1 : Smobiler.Core.MobileForm
    {
        private void button1_Click(object sender, EventArgs e)
        {
            Client.Share.SendScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client.Share.SendImage(ImageQualityMode.Compressed);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Client.Share.SendURL(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Client.Share.SendText(textBox2.Text);
        }
    }
}