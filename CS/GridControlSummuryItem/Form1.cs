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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.nwindDataSet.Customers);

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