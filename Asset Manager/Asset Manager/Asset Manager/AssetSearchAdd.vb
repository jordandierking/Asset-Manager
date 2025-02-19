Imports MySql.Data.MySqlClient

Public Class AssetSearchAdd
    Private Sub AssetSearchAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLogin.Close()
        Timer1.Enabled = True
        txtdate.Text = Date.Now.ToString("MM/dd/yyyy")
        txttime.Text = Date.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = True
        txtdate.Text = Date.Now.ToString("MM/dd/yyyy")
        txttime.Text = Date.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub DBQuery()

        Try
            sqL = "SELECT * from assets where asset_number = @barcode "

            ConnDB()
            cmd = New MySqlCommand(sqL, conn)

            cmd.Parameters.Add(New MySqlParameter("@barcode", TxtBarcode.Text))

            dr = cmd.ExecuteReader


            If dr.Read = True Then
                DeviceType.Enabled = True
                Manufacturer.Enabled = True
                Model.Enabled = True
                SerialNumber.Enabled = True
                Location.Enabled = True
                IPAddress.Enabled = True
                BtnUpdate.Enabled = True
                BtnAdd.Enabled = False
                BtnDelete.Enabled = True




                DeviceType.Text = dr("device_type")
                Manufacturer.Text = dr("manufacturer")
                Model.Text = dr("model")
                SerialNumber.Text = dr("serial_number")
                Location.Text = dr("location")
                IPAddress.Text = dr("ip_address")

            Else
                MsgBox("Item not on file", MsgBoxStyle.Critical, "Asset Manager")
                DeviceType.Enabled = True
                Manufacturer.Enabled = True
                Model.Enabled = True
                SerialNumber.Enabled = True
                Location.Enabled = True
                IPAddress.Enabled = True
                BtnUpdate.Enabled = False
                BtnAdd.Enabled = True


                DeviceType.Clear()
                Manufacturer.Clear()
                Model.Clear()
                SerialNumber.Clear()
                Location.Clear()
                IPAddress.Clear()



            End If
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DBQuery()

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

    End Sub
    Private Sub AddLog()
        Try
            sqL = "INSERT INTO assets(asset_number, device_type, manufacturer, model, serial_number, location, ip_address) VALUES('" & TxtBarcode.Text & "', '" & DeviceType.Text & "', '" & Manufacturer.Text & "', '" & Model.Text & "', '" & SerialNumber.Text & "', '" & Location.Text & "', '" & IPAddress.Text & "')"
            ConnDB()

            If DeviceType.Text = "" Or Manufacturer.Text = "" Or Model.Text = "" Or SerialNumber.Text = "" Or Location.Text = "" Or IPAddress.Text = "" Then
                MsgBox("Please fill in all fields!", MsgBoxStyle.Critical, "Asset Manager")
            Else


                conn.Close()
                conn.Open()
                ' Item does not exist, add them
                Dim cmd As MySqlCommand = New MySqlCommand(sqL, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Successfully Logged", MsgBoxStyle.Information, "Add New Item!")
                TxtBarcode.Clear()
                DeviceType.Clear()
                Manufacturer.Clear()
                Model.Clear()
                SerialNumber.Clear()
                Location.Clear()
                IPAddress.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub




    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        AddLog()
    End Sub
End Class