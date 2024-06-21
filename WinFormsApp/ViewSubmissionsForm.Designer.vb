<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Label1 = New Label()
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGithubLink = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        btnNext = New Button()
        btnPrevious = New Button()
        Label2 = New Label()
        lblStopwatchTime = New TextBox()
        btnDelete = New Button()
        btnEdit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(77, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(595, 32)
        Label1.TabIndex = 1
        Label1.Text = "H R Abhinandan, Slidely  Task 2 -View Submissions"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(68, 92)
        lblName.Name = "lblName"
        lblName.Size = New Size(59, 25)
        lblName.TabIndex = 2
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(68, 143)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(54, 25)
        lblEmail.TabIndex = 3
        lblEmail.Text = "Email"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(68, 189)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(106, 25)
        lblPhone.TabIndex = 4
        lblPhone.Text = "Phone Num"
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(68, 235)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(106, 50)
        lblGithubLink.TabIndex = 5
        lblGithubLink.Text = "Github Link " & vbCrLf & " For Task 2"
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Location = New Point(187, 86)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.RightToLeft = RightToLeft.No
        txtName.Size = New Size(349, 31)
        txtName.TabIndex = 7
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Location = New Point(187, 137)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(349, 31)
        txtEmail.TabIndex = 8
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPhone
        ' 
        txtPhone.BorderStyle = BorderStyle.FixedSingle
        txtPhone.Location = New Point(187, 183)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(349, 31)
        txtPhone.TabIndex = 9
        txtPhone.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BorderStyle = BorderStyle.FixedSingle
        txtGithubLink.Location = New Point(187, 235)
        txtGithubLink.Multiline = True
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(349, 50)
        txtGithubLink.TabIndex = 10
        txtGithubLink.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.LightBlue
        btnNext.FlatStyle = FlatStyle.Popup
        btnNext.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnNext.Location = New Point(617, 388)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(161, 39)
        btnNext.TabIndex = 14
        btnNext.Text = "NEXT(CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Khaki
        btnPrevious.FlatStyle = FlatStyle.Popup
        btnPrevious.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPrevious.Location = New Point(34, 388)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(200, 36)
        btnPrevious.TabIndex = 13
        btnPrevious.Text = "PREVIOUS(CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(77, 303)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 50)
        Label2.TabIndex = 15
        Label2.Text = "Stopwatch " & vbCrLf & "    time"
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.BackColor = SystemColors.Menu
        lblStopwatchTime.BorderStyle = BorderStyle.FixedSingle
        lblStopwatchTime.Location = New Point(187, 313)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.ReadOnly = True
        lblStopwatchTime.Size = New Size(349, 31)
        lblStopwatchTime.TabIndex = 16
        lblStopwatchTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(240, 388)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(176, 39)
        btnDelete.TabIndex = 17
        btnDelete.Text = "DELETE(CTRL + D)"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.SpringGreen
        btnEdit.FlatStyle = FlatStyle.Popup
        btnEdit.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnEdit.Location = New Point(433, 388)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(156, 39)
        btnEdit.TabIndex = 18
        btnEdit.Text = "EDIT(CTRL + E)"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(lblStopwatchTime)
        Controls.Add(Label2)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(Label1)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStopwatchTime As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
End Class
