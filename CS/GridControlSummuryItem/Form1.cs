using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace GridControlSummuryItem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable CreateTable()
        {
            DataTable table = new DataTable();
            DataRow dataRow;

            table.Columns.Add("Prod_NO", typeof(string));
            table.Columns.Add("Prod_Name", typeof(string));
            table.Columns.Add("Order_Date", typeof(string));
            table.Columns.Add("Quantity", typeof(string));

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "101";
            dataRow["Prod_Name"] = "Product1";
            dataRow["Order_Date"] = "12/06/2012";
            dataRow["Quantity"] = "50";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "102";
            dataRow["Prod_Name"] = "Product2";
            dataRow["Order_Date"] = "15/06/2012";
            dataRow["Quantity"] = "70";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "102";
            dataRow["Prod_Name"] = "Product2";
            dataRow["Order_Date"] = "15/06/2012";
            dataRow["Quantity"] = "70";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "103";
            dataRow["Prod_Name"] = "Product3";
            dataRow["Order_Date"] = "18/06/2012";
            dataRow["Quantity"] = "30";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "104";
            dataRow["Prod_Name"] = "Product4";
            dataRow["Order_Date"] = "25/06/2012";
            dataRow["Quantity"] = "20";
            table.Rows.Add(dataRow);

            return table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridView1.Columns.Clear();
            gridControl1.DataSource = CreateTable();
            gridView1.Columns[0].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
        }

        private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (e.SelectedControl != gridControl1) return;
            ToolTipControlInfo info = null;
            GridView view = gridControl1.GetViewAt(e.ControlMousePosition) as GridView;
            if (view == null) return;
            GridHitInfo hitInfo = view.CalcHitInfo(e.ControlMousePosition);
            if (hitInfo.HitTest == GridHitTest.Footer && hitInfo.Column != null && hitInfo.Column.SummaryItem.SummaryType != DevExpress.Data.SummaryItemType.None)
            {
                object o = hitInfo.HitTest.ToString() + hitInfo.Column.ToString();
                string s = "Summary for " + hitInfo.Column.ToString();
                info = new ToolTipControlInfo(o, s);
            }
            if (info != null)
                e.Info = info;
        }
    }
}