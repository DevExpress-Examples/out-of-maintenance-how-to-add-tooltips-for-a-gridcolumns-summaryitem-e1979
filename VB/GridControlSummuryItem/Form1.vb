Imports Microsoft.VisualBasic
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

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
			Me.customersTableAdapter.Fill(Me.nwindDataSet.Customers)

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