<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128621327/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3171)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Picture Editor - Drag-and-drop images from Windows Explorer

This example demonstrates how to drag images from Windows Explorer onto the WinForms PictureEdit. The example creates a `DragDropProvider` class and calls its `EnableDragDrop` method:

```csharp
private void OnLoad(object sender, EventArgs e) {
    provider = new DragDropProvider(pictureEdit1);
    provider.EnableDragDrop();
}
```

The example also demonstrates how to drag and drop images displayed on buttons.

```csharp
private void OnSimpleButtonMouseDown(object sender, MouseEventArgs e) {
    SimpleButton btn = sender as SimpleButton;
    pictureEdit1.DoDragDrop(btn.Image, DragDropEffects.Copy);
}
```


## Files to Review

* [DragDropProvider.cs](./CS/WindowsApplication3/DragDropProvider.cs) (VB: [DragDropProvider.vb](./VB/WindowsApplication3/DragDropProvider.vb))
* [Main.cs](./CS/WindowsApplication3/Main.cs) (VB: [Main.vb](./VB/WindowsApplication3/Main.vb))
