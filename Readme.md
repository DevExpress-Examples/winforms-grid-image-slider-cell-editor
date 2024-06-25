<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128622696/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T226169)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - Use an image slider to edit cell values

This example demonstrates how to create a custom [image slider](https://docs.devexpress.com/WindowsForms/12364/controls-and-libraries/editors-and-simple-controls/image-slider) and use it within the Grid control to edit cell values. The `MyImageSlider` class implements 
`IAnyControlEdit` and inherits base functionality from the [ImageSlider](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Controls.ImageSlider) class.

```csharp
public Form1() {
    InitializeComponent();
    gridControl1.DataSource = GetData(5);
    ImageSliderHelper.BindImageSlider(gridControl1, "Image", imageCollection1);
}
```

![WinForms Data Grid - Use ImageSlider as a cell editor](https://raw.githubusercontent.com/DevExpress-Examples/how-to-use-imageslider-as-an-in-place-editor-t226169/14.2.3+/media/b065d65d-dcea-11e4-80bf-00155d62480c.png)

This technique can also be applied to the WinForms TreeList control.


## Files to Review

* [Form1.cs](./CS/WindowsFormsApplication202/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication202/Form1.vb))
* [ImageSliderHelper.cs](./CS/WindowsFormsApplication202/ImageSliderHelper.cs) (VB: [ImageSliderHelper.vb](./VB/WindowsFormsApplication202/ImageSliderHelper.vb))
* [MyImageSlider.cs](./CS/WindowsFormsApplication202/MyImageSlider.cs) (VB: [MyImageSlider.vb](./VB/WindowsFormsApplication202/MyImageSlider.vb))


## Documentation

* [Custom Editors](https://docs.devexpress.com/WindowsForms/4716/controls-and-libraries/editors-and-simple-controls/common-editor-features-and-concepts/custom-editors)
* [RepositoryItemAnyControl Class](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.CustomEditor.RepositoryItemAnyControl)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-image-slider-cell-editor&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-image-slider-cell-editor&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
