Imports System.ComponentModel

Namespace DXSample

    Public Class Task
        Implements IDataErrorInfo

        Public Property TaskName As String

        Public Property StartDate As Date

        Public Property EndDate As Date

        Private ReadOnly Property [Error] As String Implements IDataErrorInfo.[Error]
            Get
                Return If(StartDate > EndDate, "Either Start Date or End Date should be corrected.", Nothing)
            End Get
        End Property

        Private ReadOnly Property Item(ByVal columnName As String) As String Implements IDataErrorInfo.Item
            Get
                Select Case columnName
                    Case NameOf(Task.StartDate)
                        If StartDate > EndDate Then Return "Start Date must be less than End Date"
                    Case NameOf(Task.EndDate)
                        If StartDate > EndDate Then Return "End Date must be greater than Start Date"
                    Case NameOf(Task.TaskName)
                        If String.IsNullOrEmpty(TaskName) Then Return "Enter a task name"
                End Select

                Return Nothing
            End Get
        End Property
    End Class
End Namespace
