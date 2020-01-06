<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FinancialForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FeeTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.totalTuitionFeesPaidLabel = New System.Windows.Forms.Label()
        Me.totalTuitionFeesOwedLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.paymentDateLabel = New System.Windows.Forms.Label()
        Me.owedDateLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.FeeTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(4, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tuition Fees Currently Owed"
        '
        'FeeTable
        '
        Me.FeeTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.FeeTable.ColumnCount = 4
        Me.FeeTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.0!))
        Me.FeeTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.FeeTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.FeeTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.FeeTable.Controls.Add(Me.Label4, 0, 2)
        Me.FeeTable.Controls.Add(Me.Label1, 0, 1)
        Me.FeeTable.Controls.Add(Me.totalTuitionFeesPaidLabel, 1, 2)
        Me.FeeTable.Controls.Add(Me.totalTuitionFeesOwedLabel, 1, 1)
        Me.FeeTable.Controls.Add(Me.Label9, 1, 0)
        Me.FeeTable.Controls.Add(Me.Label10, 2, 0)
        Me.FeeTable.Controls.Add(Me.Label5, 0, 3)
        Me.FeeTable.Controls.Add(Me.Label13, 1, 3)
        Me.FeeTable.Controls.Add(Me.Label18, 0, 4)
        Me.FeeTable.Controls.Add(Me.Label11, 1, 4)
        Me.FeeTable.Controls.Add(Me.Label6, 3, 0)
        Me.FeeTable.Controls.Add(Me.paymentDateLabel, 2, 2)
        Me.FeeTable.Controls.Add(Me.owedDateLabel, 3, 1)
        Me.FeeTable.Location = New System.Drawing.Point(328, 278)
        Me.FeeTable.Name = "FeeTable"
        Me.FeeTable.RowCount = 5
        Me.FeeTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.FeeTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.FeeTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.FeeTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.FeeTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.FeeTable.Size = New System.Drawing.Size(605, 469)
        Me.FeeTable.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(4, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tuition Fees Paid"
        '
        'totalTuitionFeesPaidLabel
        '
        Me.totalTuitionFeesPaidLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.totalTuitionFeesPaidLabel.AutoSize = True
        Me.totalTuitionFeesPaidLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.totalTuitionFeesPaidLabel.Location = New System.Drawing.Point(356, 223)
        Me.totalTuitionFeesPaidLabel.Name = "totalTuitionFeesPaidLabel"
        Me.totalTuitionFeesPaidLabel.Size = New System.Drawing.Size(27, 20)
        Me.totalTuitionFeesPaidLabel.TabIndex = 4
        Me.totalTuitionFeesPaidLabel.Text = "$0"
        '
        'totalTuitionFeesOwedLabel
        '
        Me.totalTuitionFeesOwedLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.totalTuitionFeesOwedLabel.AutoSize = True
        Me.totalTuitionFeesOwedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.totalTuitionFeesOwedLabel.Location = New System.Drawing.Point(356, 130)
        Me.totalTuitionFeesOwedLabel.Name = "totalTuitionFeesOwedLabel"
        Me.totalTuitionFeesOwedLabel.Size = New System.Drawing.Size(27, 20)
        Me.totalTuitionFeesOwedLabel.TabIndex = 3
        Me.totalTuitionFeesOwedLabel.Text = "$0"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(281, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 20)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Amount"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(390, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 20)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Date"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(4, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Semester OSAP"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(356, 316)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 20)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "$0"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label18.Location = New System.Drawing.Point(4, 410)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 20)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Total OSAP"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(356, 410)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 20)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "$0"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(499, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Due Date"
        '
        'paymentDateLabel
        '
        Me.paymentDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.paymentDateLabel.AutoSize = True
        Me.paymentDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.paymentDateLabel.Location = New System.Drawing.Point(492, 223)
        Me.paymentDateLabel.Name = "paymentDateLabel"
        Me.paymentDateLabel.Size = New System.Drawing.Size(0, 20)
        Me.paymentDateLabel.TabIndex = 15
        '
        'owedDateLabel
        '
        Me.owedDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.owedDateLabel.AutoSize = True
        Me.owedDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.owedDateLabel.Location = New System.Drawing.Point(601, 130)
        Me.owedDateLabel.Name = "owedDateLabel"
        Me.owedDateLabel.Size = New System.Drawing.Size(0, 20)
        Me.owedDateLabel.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(319, 909)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 37)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Fall", "Winter"})
        Me.ComboBox1.Location = New System.Drawing.Point(328, 208)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(259, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Term:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(259, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Year:"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"2016", "2017", "2018"})
        Me.ComboBox2.Location = New System.Drawing.Point(328, 244)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox2.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(680, 165)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 37)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Go Back"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.White
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.MidnightBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(258, 148)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(96, 26)
        Me.LinkLabel1.TabIndex = 22
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "RAMSS"
        '
        'FinancialForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.A3orLedgersizeBrowserWindow
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1203, 717)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FeeTable)
        Me.Name = "FinancialForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finacial Status"
        Me.FeeTable.ResumeLayout(False)
        Me.FeeTable.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FeeTable As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents totalTuitionFeesOwedLabel As Label
    Friend WithEvents totalTuitionFeesPaidLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents owedDateLabel As Label
    Friend WithEvents paymentDateLabel As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
