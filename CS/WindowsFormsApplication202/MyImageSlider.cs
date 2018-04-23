using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.CustomEditor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication202 {
    class MyImageSlider : ImageSlider, IAnyControlEdit {

        public MyImageSlider( ) {
            this.Size = new Size(200, 100);
            this.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleCenter;
        }
        protected override void OnLeave(EventArgs e) {
            base.OnLeave(e);
                UpdateEditValue();
        }
        private void UpdateEditValue() {
            if (EditValueChanged != null)
                EditValueChanged(this, EventArgs.Empty);
        }
        
        public bool AllowBitmapCache {
            get { return true; }
        }

        public bool AllowBorder {
            get { return false; }
        }

        public bool AllowClick(System.Drawing.Point point) {
            return true;
        }

        public System.Drawing.Size CalcSize(System.Drawing.Graphics g) {
            return this.Size; 
        }

        public void Draw(DevExpress.Utils.Drawing.GraphicsCache cache, AnyControlEditViewInfo viewInfo) {
            throw new NotImplementedException();
        }

        Image fEditValue = null;
        public object EditValue {
            get {
                return fEditValue;
            }
            set {
                Image itemValue = value as Image;
                if (itemValue != null) {
                    fEditValue = itemValue;
                    this.Images.Clear();
                    this.Images.Add(fEditValue);
                    this.CurrentImageIndex = 0;
                    if (ImageList != null) {
                    }
                }
            }
        }

        public event EventHandler EditValueChanged;

        public string GetDisplayText(object EditValue) {
            return EditValue == null ? string.Empty : EditValue.ToString();
        }

        public bool IsNeededKey(System.Windows.Forms.KeyEventArgs e) {
            return false;
        }

        public void SetupAsDrawControl() {
            
        }

        public void SetupAsEditControl() {
            throw new NotImplementedException();
        }

        public bool SupportsDraw {
            get { return false; }
        }

        private void InitializeComponent() {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // MyImageSlider
            // 
            this.CurrentImageIndex = -1;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
