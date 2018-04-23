Namespace WindowsFormsApplication202
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridView1
			' 
			Me.gridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gridView1.Appearance.Row.Options.UseFont = True
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(819, 654)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageSize = New System.Drawing.Size(32, 32)
			Me.imageCollection1.ImageStream = (DirectCast(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection1.InsertGalleryImage("announcement_32x32.png", "images/mail/announcement_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/announcement_32x32.png"), 0)
			Me.imageCollection1.Images.SetKeyName(0, "announcement_32x32.png")
			Me.imageCollection1.InsertGalleryImage("attach_32x32.png", "images/mail/attach_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/attach_32x32.png"), 1)
			Me.imageCollection1.Images.SetKeyName(1, "attach_32x32.png")
			Me.imageCollection1.InsertGalleryImage("attachment_32x32.png", "images/mail/attachment_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/attachment_32x32.png"), 2)
			Me.imageCollection1.Images.SetKeyName(2, "attachment_32x32.png")
			Me.imageCollection1.InsertGalleryImage("contact_32x32.png", "images/mail/contact_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/contact_32x32.png"), 3)
			Me.imageCollection1.Images.SetKeyName(3, "contact_32x32.png")
			Me.imageCollection1.InsertGalleryImage("editcontact_32x32.png", "images/mail/editcontact_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/editcontact_32x32.png"), 4)
			Me.imageCollection1.Images.SetKeyName(4, "editcontact_32x32.png")
			Me.imageCollection1.InsertGalleryImage("editfeed_32x32.png", "images/mail/editfeed_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/editfeed_32x32.png"), 5)
			Me.imageCollection1.Images.SetKeyName(5, "editfeed_32x32.png")
			Me.imageCollection1.InsertGalleryImage("emailtemplate_32x32.png", "images/mail/emailtemplate_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/emailtemplate_32x32.png"), 6)
			Me.imageCollection1.Images.SetKeyName(6, "emailtemplate_32x32.png")
			Me.imageCollection1.InsertGalleryImage("feeds_32x32.png", "images/mail/feeds_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/feeds_32x32.png"), 7)
			Me.imageCollection1.Images.SetKeyName(7, "feeds_32x32.png")
			Me.imageCollection1.InsertGalleryImage("mail_32x32.png", "images/mail/mail_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/mail_32x32.png"), 8)
			Me.imageCollection1.Images.SetKeyName(8, "mail_32x32.png")
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(819, 654)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "ImageSliderInplace"
			DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private imageCollection1 As DevExpress.Utils.ImageCollection
	End Class
End Namespace

