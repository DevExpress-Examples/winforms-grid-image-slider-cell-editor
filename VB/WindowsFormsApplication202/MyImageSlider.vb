Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.CustomEditor
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication202
	Friend Class MyImageSlider
		Inherits ImageSlider
		Implements IAnyControlEdit

		Public Sub New()
			Me.Size = New Size(200, 100)
			Me.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleCenter
		End Sub
		Protected Overrides Sub OnLeave(ByVal e As EventArgs)
			MyBase.OnLeave(e)
				UpdateEditValue()
		End Sub
		Private Sub UpdateEditValue()
			RaiseEvent EditValueChanged(Me, EventArgs.Empty)
		End Sub

		Public ReadOnly Property AllowBitmapCache() As Boolean Implements IAnyControlEdit.AllowBitmapCache
			Get
				Return True
			End Get
		End Property

		Public ReadOnly Property AllowBorder() As Boolean Implements IAnyControlEdit.AllowBorder
			Get
				Return False
			End Get
		End Property

		Public Function AllowClick(ByVal point As System.Drawing.Point) As Boolean Implements IAnyControlEdit.AllowClick
			Return True
		End Function

		Public Function CalcSize(ByVal g As System.Drawing.Graphics) As System.Drawing.Size Implements IAnyControlEdit.CalcSize
			Return Me.Size
		End Function

		Public Sub Draw(ByVal cache As DevExpress.Utils.Drawing.GraphicsCache, ByVal viewInfo As AnyControlEditViewInfo) Implements IAnyControlEdit.Draw
			Throw New NotImplementedException()
		End Sub

		Private fEditValue As Image = Nothing
		Public Property EditValue() As Object Implements IAnyControlEdit.EditValue
			Get
				Return fEditValue
			End Get
			Set(ByVal value As Object)
				Dim itemValue As Image = TryCast(value, Image)
				If itemValue IsNot Nothing Then
					fEditValue = itemValue
					Me.Images.Clear()
					Me.Images.Add(fEditValue)
					Me.CurrentImageIndex = 0
					If ImageList IsNot Nothing Then
					End If
				End If
			End Set
		End Property

		Public Event EditValueChanged As EventHandler Implements IAnyControlEdit.EditValueChanged

		Public Function GetDisplayText(ByVal EditValue As Object) As String Implements IAnyControlEdit.GetDisplayText
			Return If(EditValue Is Nothing, String.Empty, EditValue.ToString())
		End Function

		Public Function IsNeededKey(ByVal e As System.Windows.Forms.KeyEventArgs) As Boolean Implements IAnyControlEdit.IsNeededKey
			Return False
		End Function

		Public Sub SetupAsDrawControl() Implements IAnyControlEdit.SetupAsDrawControl

		End Sub

		Public Sub SetupAsEditControl() Implements IAnyControlEdit.SetupAsEditControl
			Throw New NotImplementedException()
		End Sub

		Public ReadOnly Property SupportsDraw() As Boolean Implements IAnyControlEdit.SupportsDraw
			Get
				Return False
			End Get
		End Property

		Private Sub InitializeComponent()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' MyImageSlider
			' 
			Me.CurrentImageIndex = -1
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
	End Class
End Namespace
