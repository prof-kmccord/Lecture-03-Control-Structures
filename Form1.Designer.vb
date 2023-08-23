<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        GpaTextBox = New TextBox()
        EligibilityStatusLabel = New Label()
        CheckEligibilityButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(295, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 15)
        Label1.TabIndex = 0
        Label1.Text = "Enter GPA:"
        ' 
        ' GpaTextBox
        ' 
        GpaTextBox.Location = New Point(297, 63)
        GpaTextBox.Name = "GpaTextBox"
        GpaTextBox.Size = New Size(100, 23)
        GpaTextBox.TabIndex = 1
        ' 
        ' EligibilityStatusLabel
        ' 
        EligibilityStatusLabel.AutoSize = True
        EligibilityStatusLabel.Location = New Point(418, 66)
        EligibilityStatusLabel.Name = "EligibilityStatusLabel"
        EligibilityStatusLabel.Size = New Size(127, 15)
        EligibilityStatusLabel.TabIndex = 2
        EligibilityStatusLabel.Text = "Click Button For Status"
        ' 
        ' CheckEligibilityButton
        ' 
        CheckEligibilityButton.Location = New Point(296, 108)
        CheckEligibilityButton.Name = "CheckEligibilityButton"
        CheckEligibilityButton.Size = New Size(75, 23)
        CheckEligibilityButton.TabIndex = 3
        CheckEligibilityButton.Text = "Update Status"
        CheckEligibilityButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CheckEligibilityButton)
        Controls.Add(EligibilityStatusLabel)
        Controls.Add(GpaTextBox)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GpaTextBox As TextBox
    Friend WithEvents EligibilityStatusLabel As Label
    Friend WithEvents CheckEligibilityButton As Button
End Class
