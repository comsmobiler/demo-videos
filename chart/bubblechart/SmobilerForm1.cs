using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace bubblechart
{
    partial class SmobilerForm1 : Smobiler.Core.MobileForm
    {
        private void SmobilerForm1_Load(object sender, EventArgs e)
        {
            this.tblProfitInfoTableAdapter.Fill(smobilerChartDemoDataSet.tblProfitInfo);
            this.bubbleChart1.DataBind();
        }
    }
}