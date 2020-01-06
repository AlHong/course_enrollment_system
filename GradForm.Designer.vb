<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GradForm
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
        Me.checkGradStatusButton = New System.Windows.Forms.Button()
        Me.gradCheckBox = New System.Windows.Forms.CheckBox()
        Me.ApplyButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.ViewReqButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'checkGradStatusButton
        '
        Me.checkGradStatusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.checkGradStatusButton.Location = New System.Drawing.Point(313, 285)
        Me.checkGradStatusButton.Name = "checkGradStatusButton"
        Me.checkGradStatusButton.Size = New System.Drawing.Size(180, 42)
        Me.checkGradStatusButton.TabIndex = 0
        Me.checkGradStatusButton.Text = "Check Graduation Status"
        Me.checkGradStatusButton.UseVisualStyleBackColor = True
        '
        'gradCheckBox
        '
        Me.gradCheckBox.AutoCheck = False
        Me.gradCheckBox.AutoSize = True
        Me.gradCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gradCheckBox.Location = New System.Drawing.Point(555, 310)
        Me.gradCheckBox.Name = "gradCheckBox"
        Me.gradCheckBox.Size = New System.Drawing.Size(176, 24)
        Me.gradCheckBox.TabIndex = 1
        Me.gradCheckBox.Text = "Graduation Status"
        Me.gradCheckBox.UseVisualStyleBackColor = True
        '
        'ApplyButton
        '
        Me.ApplyButton.Enabled = False
        Me.ApplyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ApplyButton.Location = New System.Drawing.Point(313, 441)
        Me.ApplyButton.Name = "ApplyButton"
        Me.ApplyButton.Size = New System.Drawing.Size(91, 33)
        Me.ApplyButton.TabIndex = 2
        Me.ApplyButton.Text = "Apply"
        Me.ApplyButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CancelButton.Location = New System.Drawing.Point(521, 441)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(82, 33)
        Me.CancelButton.TabIndex = 3
        Me.CancelButton.Text = "Back"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'ViewReqButton
        '
        Me.ViewReqButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ViewReqButton.Location = New System.Drawing.Point(313, 365)
        Me.ViewReqButton.Name = "ViewReqButton"
        Me.ViewReqButton.Size = New System.Drawing.Size(180, 37)
        Me.ViewReqButton.TabIndex = 4
        Me.ViewReqButton.Text = "View Requirements"
        Me.ViewReqButton.UseVisualStyleBackColor = True
        '
        'GradForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.A3orLedgersizeBrowserWindow
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1149, 684)
        Me.Controls.Add(Me.ViewReqButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ApplyButton)
        Me.Controls.Add(Me.gradCheckBox)
        Me.Controls.Add(Me.checkGradStatusButton)
        Me.Name = "GradForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GradForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents checkGradStatusButton As Button
    Friend WithEvents gradCheckBox As CheckBox
    Friend WithEvents ApplyButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents ViewReqButton As Button
End Class
