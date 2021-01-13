Imports System.Environment
Imports System.IO

Module ProgramPath

    Dim appName As String = "RK-Medis"
    Dim sysPath As String = GetFolderPath(SpecialFolder.ApplicationData)
    Dim dbDefaultFileName As String = "db-default.db"
    Dim dbCurrentFileName As String = "db-used.db"


    Private dbFileLocation As String = sysPath & "\" & appName & "\" & dbCurrentFileName

    Public Function isCurrentDBExist() As Boolean

        ApplicationDBLocation = getCurrentDBFile()
        Return File.Exists(ApplicationDBLocation)

    End Function

    Public Function getDefaultDBFile() As String

        Return sysPath & "\" & appName & "\" & dbDefaultFileName
    End Function

    Public Function getCurrentDBFile() As String

        Return sysPath & "\" & appName & "\" & dbCurrentFileName
    End Function

    Public Property ApplicationDBLocation() As String
        Get
            Return dbFileLocation
        End Get
        Set(ByVal value As String)
            dbFileLocation = value
        End Set
    End Property


    Sub setDBLocationIntoConfig(ByVal anewLocation As String)

        ' set anchor to current file instead of the default one
        ApplicationDBLocation = getCurrentDBFile()
        ' copying newlocation to the currentone overwriting
        File.Copy(anewLocation, ApplicationDBLocation, True)

        ' update the DB usage 
        DBOperation.refreshDBLocation()

    End Sub

End Module
