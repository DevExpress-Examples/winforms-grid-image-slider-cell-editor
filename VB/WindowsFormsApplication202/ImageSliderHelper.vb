Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.CustomEditor
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication202
	Public NotInheritable Class ImageSliderHelper

		Private Sub New()
		End Sub

		Private Shared view As GridView = Nothing
		Private Shared imageList As ImageCollection = Nothing
		Private Shared canSaveFirstImage As Boolean = False
		Private Shared isFirstImageFound As Boolean = False
		Private Shared firstImage As Image = Nothing
		Private Shared currentIndex As Integer = -1

		Public Shared Sub BindImageSlider(ByVal grid As GridControl, ByVal columnFieldName As String, ByVal images As ImageCollection)
			imageList = images
			Dim repository As New RepositoryItemAnyControl()
			grid.RepositoryItems.Add(repository)
			Dim slider As New MyImageSlider()
			view = TryCast(grid.MainView, GridView)
			repository.Control = slider
			view.Columns("Image").ColumnEdit = repository
			view.Columns("Description").OptionsColumn.AllowEdit = False
			view.RowHeight = slider.Size.Height
			AddHandler view.ShownEditor, AddressOf view_ShownEditor
		End Sub

		Private Shared Sub view_ShownEditor(ByVal sender As Object, ByVal e As EventArgs)
			Dim view As GridView = TryCast(sender, GridView)
			Dim edit As AnyControlEdit = TryCast(view.ActiveEditor, AnyControlEdit)
			If edit IsNot Nothing Then
				Dim slider As MyImageSlider = TryCast(edit.Properties.Control, MyImageSlider)
				slider.ImageList = imageList
				OnEnter(slider)
				AddHandler slider.MouseClick, AddressOf slider_MouseClick
				AddHandler slider.Leave, AddressOf slider_Leave
			End If
		End Sub

		Private Shared Sub slider_Leave(ByVal sender As Object, ByVal e As EventArgs)
			Dim slider As ImageSlider = TryCast(sender, ImageSlider)
			If slider.CurrentImageIndex <> -1 AndAlso slider.ImageList IsNot Nothing AndAlso canSaveFirstImage Then
				If Not isFirstImageFound Then
					DirectCast(slider.ImageList, ImageCollection).Images.RemoveAt(0)
				End If
				view.SetRowCellValue(view.FocusedRowHandle, view.FocusedColumn, (TryCast(slider.ImageList, ImageCollection)).Images(slider.CurrentImageIndex))
			End If
		End Sub

		Private Shared Sub slider_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
			Dim slider As ImageSlider = TryCast(sender, ImageSlider)
			Dim info As ImageSliderHitInfo = slider.CalcHitInfo(e.Location)
			If (info.HitTest = ImageSliderHitTest.LeftButton OrElse info.HitTest = ImageSliderHitTest.RightButton) Then
				canSaveFirstImage = True
			End If
		End Sub

		Private Shared Sub OnEnter(ByVal slider As MyImageSlider)
			firstImage = slider.Images(0)
			isFirstImageFound = False
			If imageList IsNot Nothing Then
				For i As Integer = 0 To (CType(imageList, ImageCollection).Images.Count) - 1
					If firstImage Is CType(imageList, ImageCollection).Images(i) Then
						currentIndex = i
						isFirstImageFound = True
					End If
				Next i
				If currentIndex = -1 Then
					CType(imageList, ImageCollection).Images.Insert(0, firstImage)
					slider.CurrentImageIndex = 0
				End If
				If currentIndex <> -1 Then
					slider.CurrentImageIndex = currentIndex
				End If
			End If
		End Sub
	End Class
End Namespace
