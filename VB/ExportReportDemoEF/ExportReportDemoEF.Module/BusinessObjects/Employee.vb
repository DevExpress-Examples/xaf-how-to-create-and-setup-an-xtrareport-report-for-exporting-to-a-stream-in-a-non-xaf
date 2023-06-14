Imports DevExpress.Persistent.Base
Imports System.ComponentModel

Namespace ExportReportDemoEF.Module.BusinessObjects

    <DefaultClassOptions>
    Public Class Employee

        <Browsable(False)>
        Public Property ID As Integer

        <VisibleInListView(False)>
        Public Property FirstName As String

        <VisibleInListView(False)>
        Public Property LastName As String

        Public ReadOnly Property FullName As String
            Get
                Return String.Format("{0} {1}", FirstName, LastName)
            End Get
        End Property

        Public Property Position As String
    End Class
End Namespace
