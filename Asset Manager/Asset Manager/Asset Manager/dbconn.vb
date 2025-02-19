Imports MySql.Data.MySqlClient
Module SQLConn
    Public myServer As String
    Public myPort As String
    Public myUsername As String
    Public myPassword As String
    Public myDB As String
    Public sqL As String
    Public sqL1 As String
    Public ds As New DataSet()
    Public cmd As MySqlCommand
    Public cmd1 As MySqlCommand
    Public dr As MySqlDataReader
    Public da As New MySqlDataAdapter

    Public conn As New MySqlConnection

    Sub getData()
        Dim AppName As String = Application.ProductName

        Try
            myDB = GetSetting(AppName, "DBSection", "DB_Name", "temp")
            myServer = GetSetting(AppName, "DBSection", "DB_IP", "temp")
            myPort = GetSetting(AppName, "DBSection", "DB_Port", "temp")
            myUsername = GetSetting(AppName, "DBSection", "DB_User", "temp")
            myPassword = GetSetting(AppName, "DBSection", "DB_Password", "temp")
        Catch ex As Exception
            MsgBox("System registry was not established, you can set/save " & _
            "these settings by pressing F1", MsgBoxStyle.Information)
        End Try

    End Sub

    Public Sub ConnDB()
        conn.Close()
        Try
            conn.ConnectionString = "Server = '" & myServer & "';  " _
                                         & "Port = '" & myPort & "'; " _
                                         & "Database = '" & myDB & "'; " _
                                         & "user id = '" & myUsername & "'; " _
                                         & "password = '" & myPassword & "'"

            conn.Open()
        Catch ex As Exception
            MsgBox("The system failed to establish a connection", MsgBoxStyle.Information, "Database Settings")
        End Try

    End Sub

    Public Sub DisconnMy()

        conn.Close()
        conn.Dispose()

    End Sub

    Sub SaveData()
        Dim AppName As String = Application.ProductName

        SaveSetting(AppName, "DBSection", "DB_Name", myDB)
        SaveSetting(AppName, "DBSection", "DB_IP", myServer)
        SaveSetting(AppName, "DBSection", "DB_Port", myPort)
        SaveSetting(AppName, "DBSection", "DB_User", myUsername)
        SaveSetting(AppName, "DBSection", "DB_Password", myPassword)

        MsgBox("Database connection settings are saved.", MsgBoxStyle.Information)
    End Sub



End Module

