# Slidely Task 2 - Windows Desktop App

## Overview
 This Windows Desktop App is designed for managing and viewing form submissions. It is built using Visual Basic and Visual Studio 2022, and it interacts with a backend server built in TypeScript using Express. The app provides functionality for creating, viewing, and navigating through submissions, with additional features such as a stopwatch and keyboard shortcuts.

# Features
 ### View Submissions
* Displays the details of form submissions.
* Allows navigation through submissions using "Previous" and "Next" buttons.
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
## Interface Description
### Main Window
![slidely1](https://github.com/hrabhinandan/WinFormsApp/assets/96574240/345927ff-596e-4d7c-986f-cd9022da201e)

* Title: H R Abhinandan, Slidely Task 2 - Slidely Form App
* Buttons:
  * View Submissions (Ctrl + V): Opens the form to view submissions.
  * Create New Submission (Ctrl + N): Opens the form to create a new 
 submission.
## View Submissions Form
![slidely2](https://github.com/hrabhinandan/WinFormsApp/assets/96574240/d6ee7d7e-2b45-4ed6-8afa-b41d18204093)

* Title: H R Abhinandan, Slidely Task 2 - View Submissions
   * Fields (Read-only):
   * Name: Displays the name of the submission.
   * Email: Displays the email of the submission.
   * Phone Num: Displays the phone number of the submission.
   * Github Link For Task 2: Displays the GitHub link for the task.
   * Stopwatch Time: Displays the stopwatch time associated with the 
     submission.
   * Buttons:
   *Previous (Ctrl + P): Navigates to the previous submission.
   * Next (Ctrl + N): Navigates to the next submission.
## Create Submission Form
![slidely4](https://github.com/hrabhinandan/WinFormsApp/assets/96574240/af47c3c9-01aa-458d-a536-d2ccc0c12ada)

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
![slidely3](https://github.com/hrabhinandan/WinFormsApp/assets/96574240/11dce492-4dca-4288-ae86-d337bcd8042f)
## Data is stored in the Bancked has a ExpressServer stored in the db.json file.
![slidely5](https://github.com/hrabhinandan/WinFormsApp/assets/96574240/fff1e75a-d16e-4eab-9239-bfc14a2fe5cc)
 ## '/read: A GET request with query parameter index which is a 0-index for reading the (index+1)th form submission.'
![slidely6](https://github.com/hrabhinandan/WinFormsApp/assets/96574240/13e43d0f-abc3-4329-8786-25464af910b6)

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
