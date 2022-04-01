<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/476641909/21.1.5%2B)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainViewModel.cs](./CS/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/MainViewModel.vb))
* [Task.cs](./CS/Task.cs) (VB: [Task.vb](./VB/Task.vb))
* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
<!-- default file list end -->
# How to: Pass Validation Info from the GridControl to a ViewModel

To pass validation info from the **GridControl** to a ViewModel, use the [ReadOnlyDependencyPropertyBindingBehavior](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ReadOnlyDependencyPropertyBindingBehavior) to bind the view's [HasErrors](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.HasErrors) property to a ViewModel property. Note that it is necessary to set the view's [ErrorsWatchMode](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.ErrorsWatchMode) property to **Cells**. 
