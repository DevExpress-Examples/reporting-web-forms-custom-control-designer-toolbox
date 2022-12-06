Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks

Namespace CustomReportControlSample.PredefinedReports
	Public NotInheritable Class ReportsFactory

		Private Sub New()
		End Sub

		Shared Sub New()
			Reports.Add("TestReport", Function() New TestReport())
		End Sub
		Public Shared Reports As New Dictionary(Of String, Func(Of XtraReport))()
	End Class
End Namespace
