Imports DevExpress.Utils
Imports DevExpress.XtraEditors.CustomEditor
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsFormsApplication202
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
            gridControl1.DataSource = GetData(5)
			ImageSliderHelper.BindImageSlider(gridControl1, "Image", imageCollection1)
		End Sub
		Private Function GetData(ByVal rows As Integer) As DataTable
			Dim dt As New DataTable()
			dt.Columns.Add("Description", GetType(String))
			dt.Columns.Add("Image", GetType(Image))
            For i As Integer = 0 To rows - 1
                dt.Rows.Add(i.ToString(), imageCollection1.Images(i))
            Next i
			Return dt
		End Function
	End Class
End Namespace
