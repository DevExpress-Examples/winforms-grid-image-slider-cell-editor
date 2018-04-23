namespace WindowsFormsApplication202 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(819, 654);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("announcement_32x32.png", "images/mail/announcement_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/announcement_32x32.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "announcement_32x32.png");
            this.imageCollection1.InsertGalleryImage("attach_32x32.png", "images/mail/attach_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/attach_32x32.png"), 1);
            this.imageCollection1.Images.SetKeyName(1, "attach_32x32.png");
            this.imageCollection1.InsertGalleryImage("attachment_32x32.png", "images/mail/attachment_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/attachment_32x32.png"), 2);
            this.imageCollection1.Images.SetKeyName(2, "attachment_32x32.png");
            this.imageCollection1.InsertGalleryImage("contact_32x32.png", "images/mail/contact_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/contact_32x32.png"), 3);
            this.imageCollection1.Images.SetKeyName(3, "contact_32x32.png");
            this.imageCollection1.InsertGalleryImage("editcontact_32x32.png", "images/mail/editcontact_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/editcontact_32x32.png"), 4);
            this.imageCollection1.Images.SetKeyName(4, "editcontact_32x32.png");
            this.imageCollection1.InsertGalleryImage("editfeed_32x32.png", "images/mail/editfeed_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/editfeed_32x32.png"), 5);
            this.imageCollection1.Images.SetKeyName(5, "editfeed_32x32.png");
            this.imageCollection1.InsertGalleryImage("emailtemplate_32x32.png", "images/mail/emailtemplate_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/emailtemplate_32x32.png"), 6);
            this.imageCollection1.Images.SetKeyName(6, "emailtemplate_32x32.png");
            this.imageCollection1.InsertGalleryImage("feeds_32x32.png", "images/mail/feeds_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/feeds_32x32.png"), 7);
            this.imageCollection1.Images.SetKeyName(7, "feeds_32x32.png");
            this.imageCollection1.InsertGalleryImage("mail_32x32.png", "images/mail/mail_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/mail_32x32.png"), 8);
            this.imageCollection1.Images.SetKeyName(8, "mail_32x32.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 654);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "ImageSliderInplace";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}

