
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionsForm
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
        components = New ComponentModel.Container()
        btnSubmit = New Button()
        btnToggleStopwatch = New Button()
        StopwatchTime = New TextBox()
        txtGithubLink = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        txtName = New TextBox()
        lblGithubLink = New Label()
        lblPhone = New Label()
        lblEmail = New Label()
        lblName = New Label()
        Label1 = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.LightBlue
        btnSubmit.FlatStyle = FlatStyle.Popup
        btnSubmit.Location = New Point(180, 385)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(410, 43)
        btnSubmit.TabIndex = 27
        btnSubmit.Text = "SUBMIT(CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.Khaki
        btnToggleStopwatch.FlatStyle = FlatStyle.Popup
        btnToggleStopwatch.Location = New Point(76, 324)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(334, 43)
        btnToggleStopwatch.TabIndex = 26
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH(CTRL + T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' StopwatchTime
        ' 
        StopwatchTime.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        StopwatchTime.BackColor = SystemColors.Control
        StopwatchTime.BorderStyle = BorderStyle.FixedSingle
        StopwatchTime.Location = New Point(443, 327)
        StopwatchTime.Multiline = True
        StopwatchTime.Name = "StopwatchTime"
        StopwatchTime.Size = New Size(147, 34)
        StopwatchTime.TabIndex = 25
        StopwatchTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BackColor = SystemColors.Window
        txtGithubLink.BorderStyle = BorderStyle.FixedSingle
        txtGithubLink.Location = New Point(241, 236)
        txtGithubLink.Multiline = True
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(349, 50)
        txtGithubLink.TabIndex = 24
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = SystemColors.Window
        txtPhone.BorderStyle = BorderStyle.FixedSingle
        txtPhone.Location = New Point(241, 184)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(349, 31)
        txtPhone.TabIndex = 23
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.Window
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Location = New Point(241, 138)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(349, 31)
        txtEmail.TabIndex = 22
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.ControlLightLight
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Location = New Point(241, 87)
        txtName.Name = "txtName"
        txtName.Size = New Size(349, 31)
        txtName.TabIndex = 21
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(122, 236)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(106, 50)
        lblGithubLink.TabIndex = 19
        lblGithubLink.Text = "Github Link " & vbCrLf & " For Task 2"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(122, 190)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(106, 25)
        lblPhone.TabIndex = 18
        lblPhone.Text = "Phone Num"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(122, 144)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(54, 25)
        lblEmail.TabIndex = 17
        lblEmail.Text = "Email"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(122, 93)
        lblName.Name = "lblName"
        lblName.Size = New Size(59, 25)
        lblName.TabIndex = 16
        lblName.Text = "Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(122, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(427, 25)
        Label1.TabIndex = 15
        Label1.Text = "H R Abhinandan, Slidely  Task 2 -Create Submissions"
        ' 
        ' Timer1
        ' 
        ' 
        ' CreateSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(800, 450)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(StopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(Label1)
        Name = "CreateSubmissionsForm"
        Text = "CreateSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents StopwatchTime As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
