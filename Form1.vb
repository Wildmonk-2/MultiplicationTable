Public Class Form1
    Dim checker As Boolean
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        'Invalid Source :(
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Multiply and execute the numbers for multiplication
        If TextBox1.Text = "" Then
            'Checks if the textbox is blank then it will execute a message box
            MessageBox.Show("Please write a number for answer", "Multiplication Table", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'Else if textbox contains any number then this command will execute to show the list of multiplication in list
            ListBox1.Items.Clear()
            ListBox1.Items.Add(TextBox1.Text & " x " & "1" & " = " & TextBox1.Text * 1)
            ListBox1.Items.Add(TextBox1.Text & " x " & "2" & " = " & TextBox1.Text * 2)
            ListBox1.Items.Add(TextBox1.Text & " x " & "3" & " = " & TextBox1.Text * 3)
            ListBox1.Items.Add(TextBox1.Text & " x " & "4" & " = " & TextBox1.Text * 4)
            ListBox1.Items.Add(TextBox1.Text & " x " & "5" & " = " & TextBox1.Text * 5)
            ListBox1.Items.Add(TextBox1.Text & " x " & "6" & " = " & TextBox1.Text * 6)
            ListBox1.Items.Add(TextBox1.Text & " x " & "7" & " = " & TextBox1.Text * 7)
            ListBox1.Items.Add(TextBox1.Text & " x " & "8" & " = " & TextBox1.Text * 8)
            ListBox1.Items.Add(TextBox1.Text & " x " & "9" & " = " & TextBox1.Text * 9)
            ListBox1.Items.Add(TextBox1.Text & " x " & "10" & " = " & TextBox1.Text * 10)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Clear TextBox
        TextBox1.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Clear the sources in list
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Reset and Clear the List
        TextBox1.Text = ""
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Checker is a boolean that checks as an output of "True/False" if the checker is false then ListBox will show only Multiplication till 1 to 20
        If checker = False Then
            If TextBox1.Text = "" Then
                MessageBox.Show("Please write a number for answer", "Multiplication Table", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                'Checker is false then it will show table from 1 to 20
                ListBox1.Items.Clear()
                ListBox1.Items.Add(TextBox1.Text & " x " & "1" & " = " & TextBox1.Text * 1)
                ListBox1.Items.Add(TextBox1.Text & " x " & "2" & " = " & TextBox1.Text * 2)
                ListBox1.Items.Add(TextBox1.Text & " x " & "3" & " = " & TextBox1.Text * 3)
                ListBox1.Items.Add(TextBox1.Text & " x " & "4" & " = " & TextBox1.Text * 4)
                ListBox1.Items.Add(TextBox1.Text & " x " & "5" & " = " & TextBox1.Text * 5)
                ListBox1.Items.Add(TextBox1.Text & " x " & "6" & " = " & TextBox1.Text * 6)
                ListBox1.Items.Add(TextBox1.Text & " x " & "7" & " = " & TextBox1.Text * 7)
                ListBox1.Items.Add(TextBox1.Text & " x " & "8" & " = " & TextBox1.Text * 8)
                ListBox1.Items.Add(TextBox1.Text & " x " & "9" & " = " & TextBox1.Text * 9)
                ListBox1.Items.Add(TextBox1.Text & " x " & "10" & " = " & TextBox1.Text * 10)
                ListBox1.Items.Add(TextBox1.Text & " x " & "11" & " = " & TextBox1.Text * 11)
                ListBox1.Items.Add(TextBox1.Text & " x " & "12" & " = " & TextBox1.Text * 12)
                ListBox1.Items.Add(TextBox1.Text & " x " & "13" & " = " & TextBox1.Text * 13)
                ListBox1.Items.Add(TextBox1.Text & " x " & "14" & " = " & TextBox1.Text * 14)
                ListBox1.Items.Add(TextBox1.Text & " x " & "15" & " = " & TextBox1.Text * 15)
                ListBox1.Items.Add(TextBox1.Text & " x " & "16" & " = " & TextBox1.Text * 16)
                ListBox1.Items.Add(TextBox1.Text & " x " & "17" & " = " & TextBox1.Text * 17)
                ListBox1.Items.Add(TextBox1.Text & " x " & "18" & " = " & TextBox1.Text * 18)
                ListBox1.Items.Add(TextBox1.Text & " x " & "19" & " = " & TextBox1.Text * 19)
                ListBox1.Items.Add(TextBox1.Text & " x " & "20" & " = " & TextBox1.Text * 20)
            End If
            'After showing table the value of checker will become true
            checker = True
        Else
            'After Checker becomes True then it will become false then execute another command
            checker = False
            'Checker is True then it will show table from 1 to 10
            If TextBox1.Text = "" Then
                MessageBox.Show("Please write a number for answer", "Multiplication Table", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                ListBox1.Items.Clear()
                ListBox1.Items.Add(TextBox1.Text & " x " & "1" & " = " & TextBox1.Text * 1)
                ListBox1.Items.Add(TextBox1.Text & " x " & "2" & " = " & TextBox1.Text * 2)
                ListBox1.Items.Add(TextBox1.Text & " x " & "3" & " = " & TextBox1.Text * 3)
                ListBox1.Items.Add(TextBox1.Text & " x " & "4" & " = " & TextBox1.Text * 4)
                ListBox1.Items.Add(TextBox1.Text & " x " & "5" & " = " & TextBox1.Text * 5)
                ListBox1.Items.Add(TextBox1.Text & " x " & "6" & " = " & TextBox1.Text * 6)
                ListBox1.Items.Add(TextBox1.Text & " x " & "7" & " = " & TextBox1.Text * 7)
                ListBox1.Items.Add(TextBox1.Text & " x " & "8" & " = " & TextBox1.Text * 8)
                ListBox1.Items.Add(TextBox1.Text & " x " & "9" & " = " & TextBox1.Text * 9)
                ListBox1.Items.Add(TextBox1.Text & " x " & "10" & " = " & TextBox1.Text * 10)
                ListBox1.Items.Add(TextBox1.Text & " x " & "11" & " = " & TextBox1.Text * 11)
                ListBox1.Items.Add(TextBox1.Text & " x " & "12" & " = " & TextBox1.Text * 12)
                ListBox1.Items.Add(TextBox1.Text & " x " & "13" & " = " & TextBox1.Text * 13)
                ListBox1.Items.Add(TextBox1.Text & " x " & "14" & " = " & TextBox1.Text * 14)
                ListBox1.Items.Add(TextBox1.Text & " x " & "15" & " = " & TextBox1.Text * 15)
                ListBox1.Items.Add(TextBox1.Text & " x " & "16" & " = " & TextBox1.Text * 16)
                ListBox1.Items.Add(TextBox1.Text & " x " & "17" & " = " & TextBox1.Text * 17)
                ListBox1.Items.Add(TextBox1.Text & " x " & "18" & " = " & TextBox1.Text * 18)
                ListBox1.Items.Add(TextBox1.Text & " x " & "19" & " = " & TextBox1.Text * 19)
                ListBox1.Items.Add(TextBox1.Text & " x " & "20" & " = " & TextBox1.Text * 20)
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Closes the application command
        End
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Closes the application command
        End
    End Sub

    Private Sub EdallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EdallToolStripMenuItem.Click
        'EdallToolStripMenuItem.Click will execute the numbers to multiplication table
        If TextBox1.Text = "" Then
            'Checks that is the TextBox1.Text Contains number or not
            MessageBox.Show("Please write a number for answer", "Multiplication Table", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Just clear list and shows the numbers of multiplication
            ListBox1.Items.Clear()
            ListBox1.Items.Add(TextBox1.Text & " x " & "1" & " = " & TextBox1.Text * 1)
            ListBox1.Items.Add(TextBox1.Text & " x " & "2" & " = " & TextBox1.Text * 2)
            ListBox1.Items.Add(TextBox1.Text & " x " & "3" & " = " & TextBox1.Text * 3)
            ListBox1.Items.Add(TextBox1.Text & " x " & "4" & " = " & TextBox1.Text * 4)
            ListBox1.Items.Add(TextBox1.Text & " x " & "5" & " = " & TextBox1.Text * 5)
            ListBox1.Items.Add(TextBox1.Text & " x " & "6" & " = " & TextBox1.Text * 6)
            ListBox1.Items.Add(TextBox1.Text & " x " & "7" & " = " & TextBox1.Text * 7)
            ListBox1.Items.Add(TextBox1.Text & " x " & "8" & " = " & TextBox1.Text * 8)
            ListBox1.Items.Add(TextBox1.Text & " x " & "9" & " = " & TextBox1.Text * 9)
            ListBox1.Items.Add(TextBox1.Text & " x " & "10" & " = " & TextBox1.Text * 10)
            ListBox1.Items.Add(TextBox1.Text & " x " & "11" & " = " & TextBox1.Text * 11)
            ListBox1.Items.Add(TextBox1.Text & " x " & "12" & " = " & TextBox1.Text * 12)
            ListBox1.Items.Add(TextBox1.Text & " x " & "13" & " = " & TextBox1.Text * 13)
            ListBox1.Items.Add(TextBox1.Text & " x " & "14" & " = " & TextBox1.Text * 14)
            ListBox1.Items.Add(TextBox1.Text & " x " & "15" & " = " & TextBox1.Text * 15)
            ListBox1.Items.Add(TextBox1.Text & " x " & "16" & " = " & TextBox1.Text * 16)
            ListBox1.Items.Add(TextBox1.Text & " x " & "17" & " = " & TextBox1.Text * 17)
            ListBox1.Items.Add(TextBox1.Text & " x " & "18" & " = " & TextBox1.Text * 18)
            ListBox1.Items.Add(TextBox1.Text & " x " & "19" & " = " & TextBox1.Text * 19)
            ListBox1.Items.Add(TextBox1.Text & " x " & "20" & " = " & TextBox1.Text * 20)
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'AboutToolStripMenuItem.Click - Provides you the information about this application once you clicked on menu "view" and select "about
        About.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On the form basis this will be the title of that Application
        Text = "Multiplication Time Table"
    End Sub

End Class
