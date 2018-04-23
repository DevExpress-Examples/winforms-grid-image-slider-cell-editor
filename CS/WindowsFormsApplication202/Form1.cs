using DevExpress.Utils;
using DevExpress.XtraEditors.CustomEditor;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication202 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            gridControl1.DataSource = GetData(5);
            ImageSliderHelper.BindImageSlider(gridControl1, "Image", imageCollection1);
        }
        DataTable GetData(int rows) {
            DataTable dt = new DataTable();
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("Image", typeof(Image));
            for (int i = 0; i < rows; i++) {
                dt.Rows.Add(i.ToString(), imageCollection1.Images[i]);
            }
            return dt;
        }
    }
}
