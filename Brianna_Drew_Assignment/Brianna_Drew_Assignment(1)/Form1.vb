
'
' This is Brianna Drew's introduction to Visual Basic Routine.
'
' Written by: Brianna Drew (0622446) - January 2018
'
' Purpose: To demonstrate knowledge on the basics of Visual Basic (Using buttons, labels, and text
' boxes to control things such as background colour/image, transferring of text via a variable,
' ending the program, and many other features).
'
' Parameters: None
'
' Subroutine Required: Each button on the form has it's own subroutine as well as the text box and the form itself.
'
' Modifications: - January 23/18 - Program started, basic features dragged to form (buttons, text box, label).
'                - January 24/18 - Functions added to some of the buttons (changing background color/image).
'                - January 25/18 - Functions added to textbox, submit button, exit button and green label.
'                - January 29/18 - Rest of labels added, pug gifs added, fun button added along with its function.
'                - January 30/18 - Inline code documentation (comments) added.
'                - February 1/18 - Intro block comment last updated/finished.
'

Public Class Brianna_Drew_Assignment_1


    Private Sub Brianna_Drew_Assignment_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This subroutine runs as soon as the application begins. It sends the pug gifs to the back of the 
        ' form so they do not block other features.

        puggif1.SendToBack() ' Send the first pug gif to the back on the form.
        puggif2.SendToBack() ' Send the second pug gif to the back on the form.

    End Sub


    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        ' This subroutine runs when the base/background of the form is clicked.

        Me.BackColor = Nothing ' Removes background colour so we can actually see the image of lil xan.
        BackgroundImage = My.Resources.xan ' Sets background image to tiled image of the rapper, lil xan.

    End Sub


    Private Sub BlueButton_Click(sender As Object, e As EventArgs) Handles BlueButton.Click
        ' This subroutine runs when the blue button that says "Blue" is clicked.

        BackColor = Color.Blue ' Sets the background colour to blue.
        Me.BackgroundImage = Nothing ' Removes background image so we can actually see the background colour.

    End Sub


    Private Sub RedButton_Click(sender As Object, e As EventArgs) Handles RedButton.Click
        ' This subroutine runs when the red button that says "Red" is clicked.

        BackColor = Color.Red ' Sets the background colour to red.
        Me.BackgroundImage = Nothing ' Removes background image so we can actually see the background colour.

    End Sub


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' This subroutine runs when the pink button that says "Exit" is clicked.

        End ' Ends and closes the application.

    End Sub


    Private Sub TextBox_Click(sender As Object, e As EventArgs) Handles TextBox.Click
        ' This subroutine runs when the purple textbox is clicked.

        TextBox.Clear() ' Clears the text from the textbox.

    End Sub


    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click
        ' This subroutine runs when the orange button that says "Submit" is clicked.

        Dim userText As String ' Defines a variable that will store what the user types into the textbox.
        userText = TextBox.Text ' Stores what the user types into the textbox into that variable.
        ChangingLabel.Text = userText ' Changes the green label near the top of form to read what the user typed.

    End Sub


    Private Sub URLbutton_Click(sender As Object, e As EventArgs) Handles URLbutton.Click
        ' This subroutine runs when the yellow button that says "❤Fun❤" is clicked.

        Process.Start("https://www.youtube.com/watch?v=N3WeXGmqYsE") ' Will open a funny YouTube video in a new tab
        'in your default internet browser.

    End Sub


End Class