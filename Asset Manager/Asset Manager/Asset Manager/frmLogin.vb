Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Public Class frmLogin



    Private Sub txtusername_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.GotFocus
        AcceptButton = Button1
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Login()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Are you sure you want to close?", MsgBoxStyle.YesNo, "Close Window") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub frmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If

        If e.KeyCode = Keys.F12 Then
            frmDatabase.Show()
        End If
    End Sub


    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getData()
        txtPassword.Text = ""
        txtUsername.Text = ""

    End Sub





    Private Sub Login()



        Dim HashedPass As String

        'Converts the Password into bytes, computes the hash of those bytes, and then converts them into a Base64 string
        Using MD5hash As MD5 = MD5.Create()

            HashedPass = System.Convert.ToBase64String(MD5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(txtPassword.Text)))

        End Using

        Try

            ConnDB()
            sqL = "SELECT * FROM users where username = '" & txtUsername.Text & "' AND password = md5(?);"
            cmd = New MySqlCommand(sqL, conn)


            cmd.Parameters.Add(New MySqlParameter("?", txtPassword.Text))

            dr = cmd.ExecuteReader()



            If dr.Read = True Then



                MsgBox("Access Granted", MsgBoxStyle.Information)
                AssetSearchAdd.tsslusers.Text = dr("firstname")

                AssetSearchAdd.Show()





            Else
                MsgBox("Incorrect Username or Password.", MsgBoxStyle.Critical, "Asset Manager")
                txtPassword.Text = ""
                txtUsername.Text = ""
                txtUsername.Focus()



            End If

        Finally
            cmd.Dispose()
            conn.Close()

        End Try
    End Sub


End Class
