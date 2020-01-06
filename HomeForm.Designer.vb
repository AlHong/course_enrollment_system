<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StudentNameLabel = New System.Windows.Forms.Label()
        Me.StudentNumberLabel = New System.Windows.Forms.Label()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.FallListBox = New System.Windows.Forms.ListBox()
        Me.WinterListBox = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(124, 269)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(124, 313)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Student Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(122, 412)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Your courses - Fall 2017:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(111, 641)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(233, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Your courses - Winter 2018:"
        '
        'StudentNameLabel
        '
        Me.StudentNameLabel.AutoSize = True
        Me.StudentNameLabel.BackColor = System.Drawing.Color.White
        Me.StudentNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentNameLabel.Location = New System.Drawing.Point(327, 269)
        Me.StudentNameLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.StudentNameLabel.Name = "StudentNameLabel"
        Me.StudentNameLabel.Size = New System.Drawing.Size(15, 20)
        Me.StudentNameLabel.TabIndex = 8
        Me.StudentNameLabel.Text = "-"
        '
        'StudentNumberLabel
        '
        Me.StudentNumberLabel.AutoSize = True
        Me.StudentNumberLabel.BackColor = System.Drawing.Color.White
        Me.StudentNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentNumberLabel.Location = New System.Drawing.Point(327, 313)
        Me.StudentNumberLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.StudentNumberLabel.Name = "StudentNumberLabel"
        Me.StudentNumberLabel.Size = New System.Drawing.Size(15, 20)
        Me.StudentNumberLabel.TabIndex = 9
        Me.StudentNumberLabel.Text = "-"
        '
        'LogoutButton
        '
        Me.LogoutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutButton.Location = New System.Drawing.Point(992, 229)
        Me.LogoutButton.Margin = New System.Windows.Forms.Padding(6)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(148, 46)
        Me.LogoutButton.TabIndex = 10
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'FallListBox
        '
        Me.FallListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FallListBox.FormattingEnabled = True
        Me.FallListBox.Location = New System.Drawing.Point(116, 412)
        Me.FallListBox.Margin = New System.Windows.Forms.Padding(6)
        Me.FallListBox.MultiColumn = True
        Me.FallListBox.Name = "FallListBox"
        Me.FallListBox.Size = New System.Drawing.Size(864, 186)
        Me.FallListBox.TabIndex = 11
        '
        'WinterListBox
        '
        Me.WinterListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinterListBox.FormattingEnabled = True
        Me.WinterListBox.Location = New System.Drawing.Point(116, 672)
        Me.WinterListBox.Margin = New System.Windows.Forms.Padding(6)
        Me.WinterListBox.MultiColumn = True
        Me.WinterListBox.Name = "WinterListBox"
        Me.WinterListBox.Size = New System.Drawing.Size(864, 186)
        Me.WinterListBox.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(111, 368)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(210, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Your courses - Fall 2017:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(122, 425)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(124, 682)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Label8"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(670, 305)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(296, 28)
        Me.ComboBox1.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(992, 305)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 33)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.White
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.MidnightBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(123, 219)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(181, 26)
        Me.LinkLabel1.TabIndex = 18
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "RAMSS - Home"
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.A3orLedgersizeBrowserWindow
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 977)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.WinterListBox)
        Me.Controls.Add(Me.FallListBox)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.StudentNumberLabel)
        Me.Controls.Add(Me.StudentNameLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "HomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RAMSS - Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents StudentNameLabel As Label
    Friend WithEvents StudentNumberLabel As Label
    Friend WithEvents LogoutButton As Button
    Friend WithEvents FallListBox As ListBox
    Friend WithEvents WinterListBox As ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
