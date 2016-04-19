using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace piechart
{
    partial class SmobilerForm1 : Smobiler.Core.MobileForm
    {
        private void SmobilerForm1_Load(object sender, EventArgs e)
        {
            this.salesInfoTotalTableAdapter.Fill(smobilerChartDemoDataSet.SalesInfoTotal);
            this.pieChart1.DataBind();
        }
    }
}