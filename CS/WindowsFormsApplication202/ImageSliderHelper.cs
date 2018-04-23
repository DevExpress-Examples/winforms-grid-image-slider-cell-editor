using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.CustomEditor;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication202 {
    static public class ImageSliderHelper {
        static GridView view = null;
        static ImageCollection imageList = null;
        static bool canSaveFirstImage = false;
        static bool isFirstImageFound = false;
        static Image firstImage = null;
        static int currentIndex = -1;

        public static void BindImageSlider(GridControl grid, string columnFieldName, ImageCollection images) {
            imageList = images;
            RepositoryItemAnyControl repository = new RepositoryItemAnyControl();
            grid.RepositoryItems.Add(repository);
            MyImageSlider slider = new MyImageSlider();
            view = grid.MainView as GridView;
            repository.Control = slider;
            view.Columns["Image"].ColumnEdit = repository;
            view.Columns["Description"].OptionsColumn.AllowEdit = false;
            view.RowHeight = slider.Size.Height;
            view.ShownEditor += view_ShownEditor;
        }

        private static void view_ShownEditor(object sender, EventArgs e) {
            GridView view = sender as GridView;
            AnyControlEdit edit = view.ActiveEditor as AnyControlEdit;
            if (edit != null) {
                MyImageSlider slider = edit.Properties.Control as MyImageSlider;
                slider.ImageList = imageList;
                OnEnter(slider);
                slider.MouseClick += slider_MouseClick;
                slider.Leave += slider_Leave;
            }
        }

        static void slider_Leave(object sender, EventArgs e) {
            ImageSlider slider = sender as ImageSlider;
            if (slider.CurrentImageIndex != -1 && slider.ImageList != null && canSaveFirstImage) {
                if (!isFirstImageFound) {
                    ((ImageCollection)slider.ImageList).Images.RemoveAt(0);
                }
                view.SetRowCellValue(view.FocusedRowHandle, view.FocusedColumn, (slider.ImageList as ImageCollection).Images[slider.CurrentImageIndex]);
            }
        }

        static void slider_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e) {
            ImageSlider slider = sender as ImageSlider;
            ImageSliderHitInfo info = slider.CalcHitInfo(e.Location);
            if ((info.HitTest == ImageSliderHitTest.LeftButton || info.HitTest == ImageSliderHitTest.RightButton))
                canSaveFirstImage = true;
        }

        static void OnEnter(MyImageSlider slider) {
            firstImage = slider.Images[0];
            isFirstImageFound = false;
            if (imageList != null) {
                for (int i = 0; i < ((ImageCollection)imageList).Images.Count; i++) {
                    if (firstImage == ((ImageCollection)imageList).Images[i]) {
                        currentIndex = i;
                        isFirstImageFound = true;
                    }
                }
                if (currentIndex == -1) {
                    ((ImageCollection)imageList).Images.Insert(0, firstImage);
                    slider.CurrentImageIndex = 0;
                }
                if (currentIndex != -1) {
                    slider.CurrentImageIndex = currentIndex;
                }
            }
        }
    }
}
