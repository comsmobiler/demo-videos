using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Threading;
using Smobiler.Core.ManagedThreading;



namespace GPS
{
    partial class SmobilerForm1 : Smobiler.Core.MobileForm
    {
        List<string>listAddress= new List<string>();
        private void SmobilerForm1_Load(object sender, EventArgs e)
        {
            tblDealerTableAdapter.Fill(smobilerDemoDealerDataSet.tblDealer);
            gridView1.DataBind();
            GetGpsInfo();
        }
        private void GetGpsInfo()
        {
            System.Timers.Timer timerobj = new System.Timers.Timer(10000);
            MobileManagedTimer managedtimerobj = new MobileManagedTimer(timerobj, "");
            timerobj.Interval = 30 * 1000;
            timerobj.Elapsed += (s, e1) =>
            {
                MobileManagedThreadBase.SetTimerThreadManaged(this.Client.SessionID);
                this.gps1.GetGps((object sender1, GPSData e) =>
                {
                    if (e.ErrorInfo.Length <= 0 && !e.Longitude.Equals(0) && !e.Latitude.Equals(0))
                    {
                        listAddress.Add(e.Longitude.ToString() + "/" + e.Latitude.ToString());

                    }
                });
            };
            timerobj.Enabled = true;
            timerobj.Start();
        }

        private void gridView1_ItemClick(object sender, GridViewCellItemEventArgs e)
        {
            decimal latitude = Convert.ToDecimal(e.Cell.Items["imageLocation"].Value);
            decimal longitude = Convert.ToDecimal(e.Cell.Items["labelAddress"].Value);
            switch (e.CellItem.Name)
            {
                case "imagePhone":
                        this.TelCall(e.Cell.Items["labelPhone"].DefaultValue.ToString());
                    break;
                case "imageNavigation":
                    this.gps1.GetGps((object sender1, GPSData GPSData) =>
                    {
                        if (GPSData.ErrorInfo.Length <= 0 && !GPSData.Longitude.Equals(0))
                        {
                            GeoPoint start = GeoPoint.Create(GPSData.Longitude, GPSData.Latitude);
                            GeoPoint stop = GeoPoint.Create(longitude, latitude);
                            this.ShowMapRoute(start, stop);
                        }
                    });
                    break;
                case "imageLocation":
                    string Adressinfo = e.Cell.Items["labelAddress"].DefaultValue.ToString();
                    this.ShowMap(latitude, longitude, Adressinfo);
                    break;
            }
        }

        private void SmobilerForm1_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            switch (e.Name)
            {
                case "ShowPicked":
                    List<GeoTag> tags1 = new List<GeoTag>();
                    int Rn = 0;
                    foreach (GridViewRow rowItem in gridView1.Rows)
                    {
                        bool isR = (bool)rowItem.Cell.Items["checkBox1"].DefaultValue;
                        if (isR)
                        {
                            Rn += 1;
                        }
                    }
                    if (Rn>0)
                    {
                        foreach (GridViewRow rowItem in gridView1.Rows)
                        {
                            bool isR = (bool)rowItem.Cell.Items["checkBox1"].DefaultValue;
                            if (isR)
                            {
                                decimal latitude = Convert.ToDecimal(rowItem.Cell.Items["imageLocation"].Value);
                                decimal longitude = Convert.ToDecimal(rowItem.Cell.Items["labelAddress"].Value);
                                string address = rowItem.Cell.Items["labelAddress"].DefaultValue.ToString();
                                tags1.Add(GeoTag.Create(longitude, latitude, address));
                            }
                        }
                        this.ShowMapTags(tags1.ToArray());
                        break;
                    }
                    else
                    {
                        MessageBox.Show("请至少选择一个地点");
                            break;
                    }
                case "MyLocation":
                    this.gps2.GetGps((object sender1, GPSData GPSData)=>
                    {
                        if (GPSData.ErrorInfo.Length <= 0 && !GPSData.Longitude.Equals(0) && !GPSData.Latitude.Equals(0))
                        {
                            this.ShowMap(GPSData.Latitude,GPSData.Longitude,GPSData.Location);
                        }
                    });
                    break;
                case "ShowRoute":
                    if (listAddress.Count>0)
                    {
                        string firstAddress = listAddress[0];
                        GeoPoint start = new GeoPoint(Convert.ToDecimal(firstAddress.Split('/')[0]),Convert.ToDecimal(firstAddress.Split('/')[1]));
                        GeoPoint lastPoint = start;
                        List<GeoRoute> routes = new List<GeoRoute>();
                        foreach (string addressinfo in listAddress)
                        {
                            GeoRoute route = new GeoRoute();
                            route.Add(lastPoint);
                            decimal longitude = Convert.ToDecimal(addressinfo.Split('/')[0]);
                            decimal latitude = Convert.ToDecimal(addressinfo.Split('/')[1]);
                            route.Add(longitude, latitude);
                            lastPoint = new GeoPoint(longitude, latitude);
                            routes.Add(route);
                        }
                        this.ShowMapRoute(start, lastPoint, routes.ToArray());
                    }
                    break;
            }
        }


    }
}