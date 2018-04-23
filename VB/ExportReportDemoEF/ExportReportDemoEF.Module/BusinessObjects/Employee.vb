Imports DevExpress.Persistent.Base
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace ExportReportDemoEF.Module.BusinessObjects
    <DefaultClassOptions> _
    Public Class Employee
        <Browsable(False)> _
        Public Property ID() As Integer
        <VisibleInListView(False)> _
        Public Property FirstName() As String
        <VisibleInListView(False)> _
        Public Property LastName() As String
        Public ReadOnly Property FullName() As String
            Get
                Return String.Format("{0} {1}", FirstName, LastName)
            End Get
        End Property
        Public Property Position() As String
    End Class

End Namespace
