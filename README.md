# Slidely Task 2 - Windows Desktop App

## Overview
 This Windows Desktop App is designed for managing and viewing form submissions. It is built using Visual Basic and Visual Studio 2022, and it interacts with a backend server built in TypeScript using Express. The app provides functionality for creating, viewing, and navigating through submissions, with additional features such as a stopwatch and keyboard shortcuts.

# Features
 ### View Submissions
* Displays the details of form submissions.
* Allows navigation through submissions using "Previous" and "Next" buttons.
* Delete submission: Deletes the current submission.
* Edit submission: Opens the form to edit the current submission.
### Create New Submission
* Provides a form to enter new submission details: Name, Email, Phone 
 Number, and GitHub Link.
* Includes a stopwatch feature to track time spent on tasks.
### Stopwatch
* Can be toggled to start, pause, and resume without resetting the time.
* The elapsed time is displayed and can be submitted as part of the form.
### Keyboard Shortcuts
* View Submissions: Ctrl + V
* Create New Submission: Ctrl + N
* Previous Submission: Ctrl + P
* Next Submission: Ctrl + N
* Toggle Stopwatch: Ctrl + T
* Submit Form: Ctrl + S
* Delete Submission: Ctrl + D
* Edit Submission: Ctrl + E
## Interface Description
### Main Window

![slidely1](https://github.com/hrabhinandan/WinFormsApp/assets/96574240/e60b8ef4-19f1-4d6c-afb7-34f10606b845)

* Title: H R Abhinandan, Slidely Task 2 - Slidely Form App
* Buttons:
  * View Submissions (Ctrl + V): Opens the form to view submissions.
  * Create New Submission (Ctrl + N): Opens the form to create a new 
 submission.
## View Submissions Form

![slidely2](https://github.com/hrabhinandan/WinFormsApp/assets/96574240/38c71944-ac8d-4344-8854-bcaaf0769a3b)

![slidely3](https://github.com/hrabhinandan/WinFormsApp/assets/96574240/d69686a8-98a6-4e58-99ab-69b684fa5aa0)

![slidely4](https://github.com/hrabhinandan/WinFormsApp/assets/96574240/eea25e2c-2f9f-424f-882b-3c8851ea5129)

* Title: H R Abhinandan, Slidely Task 2 - View Submissions
   * Fields (Read-only):
   * Name: Displays the name of the submission.
   * Email: Displays the email of the submission.
   * Phone Num: Displays the phone number of the submission.
   * Github Link For Task 2: Displays the GitHub link for the task.
   * Stopwatch Time: Displays the stopwatch time associated with the 
     submission.
   * Buttons:
   * Previous (Ctrl + P): Navigates to the previous submission.
   * Next (Ctrl + N): Navigates to the next submission.
   * Delete Submission (Ctrl + D): Deletes the current submission.
   * Edit Submission (Ctrl + E): Opens the form to edit the current submission.
## Create Submission Form

![slidely5](https://github.com/hrabhinandan/WinFormsApp/assets/96574240/8bfbd923-0af7-4149-9cff-a34c24ed2481)

* Title: H R Abhinandan, Slidely Task 2 - Create Submission
* Fields:
   * Name: Editable text field to enter the name.
   * Email: Editable text field to enter the email.
   * Phone Num: Editable text field to enter the phone number.
   * Github Link For Task 2: Editable text field to enter the GitHub 
      link.
   * Stopwatch Time: Read-only field to display the elapsed stopwatch 
    time.
* Buttons:
   * Toggle Stopwatch (Ctrl + T): Starts or pauses the stopwatch.
   * Submit (Ctrl + S): Submits the form with the entered details and 
    the stopwatch time.
## View Submissions Form After Create Submission Form Submitted.

![slidely4](https://github.com/hrabhinandan/WinFormsApp/assets/96574240/bc5c4ec3-9a1c-4f9a-868e-961233db0e79)

## Data is stored in the Bancked has a ExpressServer stored in the db.json file.

![slidely8](https://github.com/hrabhinandan/WinFormsApp/assets/96574240/2db565fa-b53b-4949-86b3-f481f4f647f2)

 ## '/read: A GET request with query parameter index which is a 0-index for reading the (index+1)th form submission.'

![slidely6](https://github.com/hrabhinandan/WinFormsApp/assets/96574240/fee669ac-addf-4466-962e-45849e68b6d5)

 ## '/search: A GET request with query parameter index which is a 0-index for search  by the emailid form submission.'

![slidely7](https://github.com/hrabhinandan/WinFormsApp/assets/96574240/943f4492-6571-43a4-b038-bb9fa2440aad)

## Https Requests comments to search fetch in the Localhost:3000 server
  * for the read ---  http://localhost:3000/read?index=0
  * for the search by emailids -- http://localhost:3000/search?email=abhinandanholalu2001@gmail.com
## How to Run
### Prerequisites
* Visual Studio 2022
* Backend server built with TypeScript and Express running as per the 
  provided specifications.
* Clone the Repository
* bash - git clone <repository-url>
### Open the Project
* Open the project in Visual Studio 2022.
### Build and Run
* Build the project to ensure all dependencies are resolved.
* Run the project from Visual Studio.
### Interact with the App
* Use the main window to navigate between viewing submissions and creating 
  new submissions.
* Utilize the keyboard shortcuts for quick access to various 
  functionalities.
## Backend Server Endpoints
 Ensure the backend server is running and accessible with the following endpoints:
* /ping: A GET request that always returns True.
* /submit: A POST request with parameters name, email, phone, github_link, 
  and stopwatch_time.
* /read: A GET request with query parameter index which is a 0-index for 
  reading the (index+1)th form submission.
## Contact 
 ### For any questions or issues, please contact H R Abhinandan.
* Note: Ensure the display scaling is set to 150% for optimal user  interface display, as per the project settings.
* Images Source: All images are screenshots taken from the application. Save the images in the images directory within the project folder.
