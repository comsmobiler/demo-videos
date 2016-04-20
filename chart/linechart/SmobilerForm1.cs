using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace linechart
{
    partial class SmobilerForm1 : Smobiler.Core.MobileForm
    {
        private void SmobilerForm1_Load(object sender, EventArgs e)
        {
            this.tblDOMAYSalesInfoTableAdapter.Fill(smobilerChartDemoDataSet.tblDOMAYSalesInfo);
            this.lineChart1.DataBind();
        }
    }
}