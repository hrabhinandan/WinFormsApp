Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Diagnostics

Public Class CreateSubmissionsForm
    Dim stopwatch As New Stopwatch()
    Dim isRunning As Boolean = False
    Private isEditMode As Boolean = False
    Private editIndex As Integer = -1

    ' Method to load submission for edit
    Public Sub LoadSubmissionForEdit(index As Integer)
        isEditMode = True
        editIndex = index
        LoadSubmissionData(index)
    End Sub

    ' Method to load submission data
    Private Async Sub LoadSubmissionData(index As Integer)
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
            If response.IsSuccessStatusCode Then
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                Dim submission As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(jsonResponse)

                txtName.Text = submission("name")
                txtEmail.Text = submission("email")
                txtPhone.Text = submission("phone")
                txtGithubLink.Text = submission("github_link")

                If submission.ContainsKey("stopwatch_time") Then
                    lblStopwatchTime.Text = submission("stopwatch_time")
                    ' Initialize stopwatch with the loaded time
                    Dim timeParts() As String = submission("stopwatch_time").Split(":")
                    stopwatch.Reset()
                    stopwatch.Start()
                    stopwatch.Elapsed.Add(New TimeSpan(CInt(timeParts(0)), CInt(timeParts(1)), CInt(timeParts(2))))
                Else
                    lblStopwatchTime.Text = "00:00:00"
                End If
            Else
                MessageBox.Show("Failed to load submission for edit.")
            End If
        End Using
    End Sub

    ' Toggle stopwatch start/stop
    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If isRunning Then
            Timer1.Stop()
            stopwatch.Stop()
            btnToggleStopwatch.Text = "Start Stopwatch"
        Else
            Timer1.Start()
            stopwatch.Start()
            btnToggleStopwatch.Text = "Stop Stopwatch"
        End If
        isRunning = Not isRunning
    End Sub

    ' Form keydown event to handle shortcuts
    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub

    ' Constructor
    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    ' Method to submit form data
    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If isRunning Then
            Timer1.Stop()
            stopwatch.Stop()
            isRunning = False
        End If

        Dim submissionData As New With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhone.Text,
            .github_link = txtGithubLink.Text,
            .stopwatch_time = lblStopwatchTime.Text
        }

        Dim json = JsonConvert.SerializeObject(submissionData)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Dim response As HttpResponseMessage

            If isEditMode AndAlso editIndex >= 0 Then
                response = Await client.PutAsync($"http://localhost:3000/edit?index={editIndex}", content)
            Else
                response = Await client.PostAsync("http://localhost:3000/submit", content)
            End If

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!")
                Me.Close()
            Else
                MessageBox.Show("Error submitting form.")
            End If
        End Using
    End Sub

    ' Timer tick event to update stopwatch time
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblStopwatchTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    ' Form load event to initialize stopwatch label
    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000 ' Set the timer interval to 1 second
        lblStopwatchTime.Text = "00:00:00"
        Timer1.Start() ' Start the timer
        stopwatch.Start() ' Start the stopwatch
        isRunning = True
        btnToggleStopwatch.Text = "STOP/START(CTRL + T)" ' Update button text to indicate the stopwatch is running
    End Sub
End Class
