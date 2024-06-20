Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionsForm
    Dim stopwatch As New Stopwatch()
    Dim isRunning As Boolean = False
    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatchRunning Then
            Timer1.Stop()
            stopwatch.Stop()
            btnToggleStopwatch.Text = "Start Stopwatch"
        Else
            Timer1.Start()
            stopwatch.Start()
            btnToggleStopwatch.Text = "Stop Stopwatch"
        End If
        stopwatchRunning = Not stopwatchRunning
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub
    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub
    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Stop the stopwatch when submitting
        If stopwatchRunning Then
            Timer1.Stop()
            stopwatch.Stop()
            stopwatchRunning = False
        End If
        Dim submissionData As New With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhone.Text,
            .github_link = txtGithubLink.Text,
            .stopwatch_time = StopwatchTime.Text
        }

        Dim json = JsonConvert.SerializeObject(submissionData)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Dim response = Await client.PostAsync("http://localhost:3000/submit", content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!")
            Else
                MessageBox.Show("Error submitting form.")
            End If
        End Using
    End Sub
    Private elapsedTime As TimeSpan
    Private stopwatchRunning As Boolean = False

    ' Form Load Event to initialize the stopwatch label
    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000 ' Set the timer interval to 1 second
        elapsedTime = TimeSpan.Zero
        StopwatchTime.Text = elapsedTime.ToString("hh\:mm\:ss")
        ' Start the stopwatch and timer when the form loads
        Timer1.Start()
        stopwatch.Start()
        stopwatchRunning = True
        btnToggleStopwatch.Text = "Stop Stopwatch"
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1))
        StopwatchTime.Text = elapsedTime.ToString("hh\:mm\:ss")
    End Sub
End Class