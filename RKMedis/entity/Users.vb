Imports System.Data.SQLite

Public Class Users

    Private columns As String
    Dim allColumns As New ArrayList

    Public Sub New()
        allColumns.Add(New ColumnType("@passw", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@rec_quest", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@rec_answer", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@logo_filename", SqlDbType.VarChar))
        'allColumns.Add(New ColumnType("@logo_content", SqlDbType.Binary))
    End Sub

    Sub addValuesIntoColumn(ByVal data As KeyVal)
        For Each col As ColumnType In allColumns
            If (col.Name = data.KeyName) Then
                col.Value = data.Value
            End If
        Next
    End Sub

    Sub setParameters(ByVal asqlCommand As SQLiteCommand)

        For Each column As ColumnType In allColumns
            asqlCommand.Parameters.Add(column.Name, column.Type).Value = column.Value
        Next
    End Sub

    Function getAllColumnTypes() As ArrayList
        Return allColumns
    End Function


    Function getAllColumnsSet() As String

        columns = "passw=@passw" & _
            ",rec_quest=@rec_quest" & _
            ",rec_answer=@rec_answer" & _
            ",logo_filename=@logo_filename" & _
            ",logo_content=@logo_content"

        Return columns
    End Function

    Function getUsernameColumnWithValue() As String
        columns = "username=" & DBOperation.Varchar(Me.Username)
        Return columns
    End Function


    Private _username As String
    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
            addValuesIntoColumn(New KeyVal("@username", value))
        End Set
    End Property

    Private _passwNew As String
    Public Property PasswordNew() As String
        Get
            Return _passwNew
        End Get
        Set(ByVal value As String)
            _passwNew = value

        End Set
    End Property

    Private _passwOld As String
    Public Property PasswordOld() As String
        Get
            Return _passwOld
        End Get
        Set(ByVal value As String)
            _passwOld = value
        End Set
    End Property

    Private _passw As String
    Public Property Password() As String
        Get
            Return _passw
        End Get
        Set(ByVal value As String)
            _passw = value
            addValuesIntoColumn(New KeyVal("@passw", value))
        End Set
    End Property

    Private _recQuest As String
    Public Property RecoveryQuestion() As String
        Get
            Return _recQuest
        End Get
        Set(ByVal value As String)
            _recQuest = value
            addValuesIntoColumn(New KeyVal("@rec_quest", value))
        End Set
    End Property

    Private _recAnswer As String
    Public Property RecoveryAnswer() As String
        Get
            Return _recAnswer
        End Get
        Set(ByVal value As String)
            _recAnswer = value
            addValuesIntoColumn(New KeyVal("@rec_answer", value))
        End Set
    End Property

    Private _logo As Byte()
    Public Property Logo() As Byte()
        Get
            Return _logo
        End Get
        Set(ByVal value As Byte())
            _logo = value
            ' addValuesIntoColumn(New KeyVal("@logo_content", value))
        End Set
    End Property

    Private _logoFileName As String
    Public Property LogoFileName() As String
        Get
            Return _logoFileName
        End Get
        Set(ByVal value As String)
            _logoFileName = value
            addValuesIntoColumn(New KeyVal("@logo_filename", value))
        End Set
    End Property


End Class
