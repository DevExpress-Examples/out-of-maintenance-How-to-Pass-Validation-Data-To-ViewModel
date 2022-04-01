This example shows how to pass validation info from the GridControl to the ViewModel. 

To pass validation info from the GridControl to the ViewModel, use the ReadOnlyDependencyPropertyBindingBehavior to bind the `TableView.HasErrors` property to a ViewModel property. Note that it is necessary to set the TableView.ErrorsWatchMode property to Cells. 

