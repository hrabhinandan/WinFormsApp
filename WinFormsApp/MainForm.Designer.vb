<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        btnViewSubmissions = New Button()
        btnCreateSubmissions = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(68, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(677, 38)
        Label1.TabIndex = 0
        Label1.Text = "H R Abhinandan, Slidely Task 2 - Slidely Form App"
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.Khaki
        btnViewSubmissions.FlatStyle = FlatStyle.Flat
        btnViewSubmissions.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewSubmissions.Location = New Point(160, 158)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(432, 54)
        btnViewSubmissions.TabIndex = 1
        btnViewSubmissions.Text = "VIEW SUBMISSIONS(CTRL + V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateSubmissions
        ' 
        btnCreateSubmissions.BackColor = Color.LightBlue
        btnCreateSubmissions.FlatStyle = FlatStyle.Flat
        btnCreateSubmissions.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreateSubmissions.Location = New Point(160, 240)
        btnCreateSubmissions.Name = "btnCreateSubmissions"
        btnCreateSubmissions.Size = New Size(432, 54)
        btnCreateSubmissions.TabIndex = 2
        btnCreateSubmissions.Text = "CREATE NEW SUBMISSIONS(CTRL + N)"
        btnCreateSubmissions.UseVisualStyleBackColor = False
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnCreateSubmissions)
        Controls.Add(btnViewSubmissions)
        Controls.Add(Label1)
        Name = "MainForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmissions As Button

End Class
