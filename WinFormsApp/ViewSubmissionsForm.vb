Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0

    Private Async Sub LoadSubmission(index As Integer)
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
            If response.IsSuccessStatusCode Then
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                ' Deserialize the JSON response
                Dim submission As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(jsonResponse)

                ' Assign values to the textboxes
                txtName.Text = submission("name")
                txtEmail.Text = submission("email")
                txtPhone.Text = submission("phone")
                txtGithubLink.Text = submission("github_link")

                ' Check if the key exists in the dictionary
                If submission.ContainsKey("stopwatch_time") Then
                    lblStopwatchTime.Text = submission("stopwatch_time")
                Else
                    lblStopwatchTime.Text = "00:00:00"
                End If
            Else
                MessageBox.Show("Failed to load submission.")
            End If
        End Using
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        LoadSubmission(currentIndex)
    End Sub

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubmission(currentIndex)
        Me.Focus() ' Set focus to the form when it loads
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            btnDelete.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.E Then
            btnEdit.PerformClick()
        End If
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.DeleteAsync($"http://localhost:3000/delete?index={currentIndex}")
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission deleted successfully.")
                LoadSubmission(currentIndex)
            Else
                MessageBox.Show("Failed to delete submission.")
            End If
        End Using
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim createSubmissionForm As New CreateSubmissionsForm()
        createSubmissionForm.LoadSubmissionForEdit(currentIndex)
        createSubmissionForm.ShowDialog()
        LoadSubmission(currentIndex)
    End Sub
End Class
