<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AssetSearchAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBarcode = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Manufacturer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Model = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SerialNumber = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslusers = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtdate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txttime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Location = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IPAddress = New System.Windows.Forms.TextBox()
        Me.DeviceType = New System.Windows.Forms.TextBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Barcode/Asset #"
        '
        'TxtBarcode
        '
        Me.TxtBarcode.Location = New System.Drawing.Point(196, 41)
        Me.TxtBarcode.Name = "TxtBarcode"
        Me.TxtBarcode.Size = New System.Drawing.Size(171, 20)
        Me.TxtBarcode.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(392, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(520, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 22)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(0, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(522, 1)
        Me.Panel1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Device Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Manufacturer"
        '
        'Manufacturer
        '
        Me.Manufacturer.Enabled = False
        Me.Manufacturer.Location = New System.Drawing.Point(196, 175)
        Me.Manufacturer.Name = "Manufacturer"
        Me.Manufacturer.Size = New System.Drawing.Size(171, 20)
        Me.Manufacturer.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(111, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Model"
        '
        'Model
        '
        Me.Model.Enabled = False
        Me.Model.Location = New System.Drawing.Point(196, 223)
        Me.Model.Name = "Model"
        Me.Model.Size = New System.Drawing.Size(171, 20)
        Me.Model.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Serial Number"
        '
        'SerialNumber
        '
        Me.SerialNumber.Enabled = False
        Me.SerialNumber.Location = New System.Drawing.Point(196, 274)
        Me.SerialNumber.Name = "SerialNumber"
        Me.SerialNumber.Size = New System.Drawing.Size(171, 20)
        Me.SerialNumber.TabIndex = 13
        '
        'BtnAdd
        '
        Me.BtnAdd.Enabled = False
        Me.BtnAdd.Location = New System.Drawing.Point(76, 424)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(96, 47)
        Me.BtnAdd.TabIndex = 14
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Enabled = False
        Me.BtnUpdate.Location = New System.Drawing.Point(203, 424)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(96, 47)
        Me.BtnUpdate.TabIndex = 15
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tsslusers, Me.txtdate, Me.txttime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 488)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(520, 22)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(33, 17)
        Me.ToolStripStatusLabel1.Text = "User:"
        '
        'tsslusers
        '
        Me.tsslusers.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tsslusers.Name = "tsslusers"
        Me.tsslusers.Size = New System.Drawing.Size(119, 17)
        Me.tsslusers.Text = "ToolStripStatusLabel2"
        '
        'txtdate
        '
        Me.txtdate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(119, 17)
        Me.txtdate.Text = "ToolStripStatusLabel2"
        '
        'txttime
        '
        Me.txttime.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(119, 17)
        Me.txttime.Text = "ToolStripStatusLabel2"
        '
        'Timer1
        '
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(89, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Location"
        '
        'Location
        '
        Me.Location.Enabled = False
        Me.Location.Location = New System.Drawing.Point(196, 325)
        Me.Location.Name = "Location"
        Me.Location.Size = New System.Drawing.Size(171, 20)
        Me.Location.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(72, 374)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "IP Address"
        '
        'IPAddress
        '
        Me.IPAddress.Enabled = False
        Me.IPAddress.Location = New System.Drawing.Point(196, 376)
        Me.IPAddress.Name = "IPAddress"
        Me.IPAddress.Size = New System.Drawing.Size(171, 20)
        Me.IPAddress.TabIndex = 21
        '
        'DeviceType
        '
        Me.DeviceType.Enabled = False
        Me.DeviceType.Location = New System.Drawing.Point(196, 131)
        Me.DeviceType.Name = "DeviceType"
        Me.DeviceType.Size = New System.Drawing.Size(171, 20)
        Me.DeviceType.TabIndex = 22
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(322, 424)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(96, 47)
        Me.BtnDelete.TabIndex = 23
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'AssetSearchAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(520, 510)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.DeviceType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.IPAddress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Location)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SerialNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Model)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Manufacturer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBarcode)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AssetSearchAdd"
        Me.Text = "Add/Search An Asset"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBarcode As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Manufacturer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Model As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SerialNumber As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tsslusers As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtdate As ToolStripStatusLabel
    Friend WithEvents txttime As ToolStripStatusLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Location As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents IPAddress As TextBox
    Friend WithEvents DeviceType As TextBox
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnDelete As Button
End Class
