Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.ComponentModel.Design
Imports DevExpress.XtraBars
Imports DevExpress.XtraReports.UserDesigner
' ...

Namespace FieldList_UpdateDataSource
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Const xmlPath As String = "..\..\Cars.xml"

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			xrDesignPanel1.ExecCommand(ReportCommand.NewReport)
		End Sub

		Private Sub commandBarItem46_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barButtonItem1.ItemClick
			BindReportToData()
		End Sub

		#Region "#UpdateFieldList"
		Private Sub BindReportToData()
			If xrDesignPanel1.Report Is Nothing Then
				Return
			End If
			 ' Create a data source and bind it to a report.
			xrDesignPanel1.Report.DataSource = CreateDataSource()

			' Update the Field List.
			Dim fieldList As FieldListDockPanel = CType(xrDesignDockManager1(DesignDockPanelType.FieldList), FieldListDockPanel)
			Dim host As IDesignerHost = CType(xrDesignPanel1.GetService(GetType(IDesignerHost)), IDesignerHost)
			fieldList.UpdateDataSource(host)
		End Sub
		#End Region ' #UpdateFieldList

		Private Function CreateDataSource() As ArrayList
			' Create a list.
			Dim list As New ArrayList()

			' Populate the list with records.
			list.Add(New Record(1, "Jane", 19))
			list.Add(New Record(2, "Joe", 30))
			list.Add(New Record(3, "Bill", 15))
			list.Add(New Record(4, "Michael", 42))

			Return list
		End Function

	End Class
End Namespace