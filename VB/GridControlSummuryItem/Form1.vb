Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace GridControlSummuryItem
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Function CreateTable() As DataTable
			Dim table As New DataTable()
			Dim dataRow As DataRow

			table.Columns.Add("Prod_NO", GetType(String))
			table.Columns.Add("Prod_Name", GetType(String))
			table.Columns.Add("Order_Date", GetType(String))
			table.Columns.Add("Quantity", GetType(String))

			dataRow = table.NewRow()
			dataRow("Prod_NO") = "101"
			dataRow("Prod_Name") = "Product1"
			dataRow("Order_Date") = "12/06/2012"
			dataRow("Quantity") = "50"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("Prod_NO") = "102"
			dataRow("Prod_Name") = "Product2"
			dataRow("Order_Date") = "15/06/2012"
			dataRow("Quantity") = "70"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("Prod_NO") = "102"
			dataRow("Prod_Name") = "Product2"
			dataRow("Order_Date") = "15/06/2012"
			dataRow("Quantity") = "70"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("Prod_NO") = "103"
			dataRow("Prod_Name") = "Product3"
			dataRow("Order_Date") = "18/06/2012"
			dataRow("Quantity") = "30"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("Prod_NO") = "104"
			dataRow("Prod_Name") = "Product4"
			dataRow("Order_Date") = "25/06/2012"
			dataRow("Quantity") = "20"
			table.Rows.Add(dataRow)

			Return table
		End Function

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			gridView1.Columns.Clear()
			gridControl1.DataSource = CreateTable()
			gridView1.Columns(0).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
		End Sub

		Private Sub toolTipController1_GetActiveObjectInfo(ByVal sender As Object, ByVal e As DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs) Handles toolTipController1.GetActiveObjectInfo
			If e.SelectedControl IsNot gridControl1 Then
				Return
			End If
			Dim info As ToolTipControlInfo = Nothing
			Dim view As GridView = TryCast(gridControl1.GetViewAt(e.ControlMousePosition), GridView)
			If view Is Nothing Then
				Return
			End If
			Dim hitInfo As GridHitInfo = view.CalcHitInfo(e.ControlMousePosition)
			If hitInfo.HitTest = GridHitTest.Footer AndAlso hitInfo.Column IsNot Nothing AndAlso hitInfo.Column.SummaryItem.SummaryType <> DevExpress.Data.SummaryItemType.None Then
				Dim o As Object = hitInfo.HitTest.ToString() & hitInfo.Column.ToString()
				Dim s As String = "Summary for " & hitInfo.Column.ToString()
				info = New ToolTipControlInfo(o, s)
			End If
			If info IsNot Nothing Then
				e.Info = info
			End If
		End Sub
	End Class
End Namespace