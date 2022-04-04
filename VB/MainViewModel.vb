Imports System
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.Xpf

Namespace DXSample

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Property HasErrors As Boolean
            Get
                Return GetValue(Of Boolean)()
            End Get

            Set(ByVal value As Boolean)
                SetValue(value)
            End Set
        End Property

        Public ReadOnly Property TaskList As ObservableCollection(Of Task)

        Public Sub New()
            TaskList = New ObservableCollection(Of Task) From {New Task() With {.TaskName = "Complete Project A", .StartDate = New DateTime(2009, 7, 17), .EndDate = New DateTime(2009, 7, 10)}, New Task() With {.TaskName = "Test Website", .StartDate = New DateTime(2009, 7, 10), .EndDate = New DateTime(2009, 7, 12)}, New Task() With {.TaskName = String.Empty, .StartDate = New DateTime(2009, 7, 4), .EndDate = New DateTime(2009, 7, 6)}}
        End Sub

        <Command>
        Public Sub ValidateRow(ByVal args As RowValidationArgs)
            args.Result = GetValidationErrorInfo(CType(args.Item, Task))
        End Sub

        Private Shared Function GetValidationErrorInfo(ByVal task As Task) As ValidationErrorInfo
            If task.StartDate > task.EndDate Then Return New ValidationErrorInfo("Start Date must be less than End Date")
            If String.IsNullOrEmpty(task.TaskName) Then Return New ValidationErrorInfo("Enter a task name")
            Return Nothing
        End Function

        <Command>
        Public Sub InvalidRow(ByVal args As InvalidRowExceptionArgs)
            args.ExceptionMode = ExceptionMode.NoAction
        End Sub
    End Class
End Namespace
