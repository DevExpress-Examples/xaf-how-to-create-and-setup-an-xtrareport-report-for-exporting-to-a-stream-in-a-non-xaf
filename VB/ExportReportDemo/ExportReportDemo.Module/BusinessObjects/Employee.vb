Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo

Namespace ExportReportDemo.Module.BusinessObjects

    Public Class Employee
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Private firstNameField As String

        Private lastNameField As String

        Private positionField As String

        <VisibleInListView(False)>
        Public Property FirstName As String
            Get
                Return firstNameField
            End Get

            Set(ByVal value As String)
                SetPropertyValue("FirstName", firstNameField, value)
            End Set
        End Property

        <VisibleInListView(False)>
        Public Property LastName As String
            Get
                Return lastNameField
            End Get

            Set(ByVal value As String)
                SetPropertyValue("LastName", lastNameField, value)
            End Set
        End Property

        <VisibleInDetailView(False)>
        Public ReadOnly Property FullName As String
            Get
                Return String.Format("{0} {1}", FirstName, LastName)
            End Get
        End Property

        Public Property Position As String
            Get
                Return positionField
            End Get

            Set(ByVal value As String)
                SetPropertyValue("Position", positionField, value)
            End Set
        End Property
    End Class
End Namespace
