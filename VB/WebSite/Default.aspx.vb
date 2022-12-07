Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports System.Drawing

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub grid_HtmlRowPrepared(ByVal sender As Object, ByVal e As ASPxGridViewTableRowEventArgs)
		If e.RowType <> GridViewRowType.Group Then
			Return
		End If

		If (Not grid.IsRowExpanded(e.VisibleIndex)) Then
			Return
		End If

		Dim level As Integer = grid.GetRowLevel(e.VisibleIndex)
		If e.Row.Cells.Count <= level Then
			Return
		End If

		Dim controls As ControlCollection = e.Row.Cells(level).Controls
		If controls.Count > 0 Then
			controls(0).Visible = False
		End If
	End Sub
End Class
