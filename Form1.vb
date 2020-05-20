Imports System
Imports System.IO

Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim enteredDate As Date
    Dim startMiles As Integer
    Dim endMiles As Integer
    Dim actualMiles As Integer
    Dim avgMPG As Decimal
    Dim gasUsed As Decimal
    Dim programStart As Boolean = True

    Dim nFileNum As Integer
    Dim sText As String
    Dim sNextLine As String
    Dim lLineCount As Long
    Dim recordsFound As Integer

    Dim filePath As String = System.IO.Path.Combine( _
                My.Computer.FileSystem.SpecialDirectories.MyDocuments, "mileage_report.csv")

    Private Sub Write_To_CSV_Function()
        If Dir(filePath) <> "" And (programStart = False) Then
            'ONLY WRITE TO FILE IF IT EXISTS AND THIS IS NOT THE INITIAL RUN OF FUNCTION
            'MsgBox("file exists")
            'MsgBox(filePath)

            Try
                My.Computer.FileSystem.WriteAllText(filePath, CStr(enteredDate) + "," + CStr(startMiles) + "," + CStr(endMiles) + "," + _
                                                    CStr(actualMiles) + "," + CStr(avgMPG) + "," + CStr(gasUsed) + Chr(13), True)
                'WRITE RECORDS TO REPORT
            Catch fileException As Exception
                Throw fileException
            End Try
        End If

        If (programStart = True) And Dir(filePath) = "" Then
            'CREATE FILE IF IT DOES NOT EXIST AND IF THIS IS INITIAL RUN OF FUNCTION
            'MsgBox("file does not exist")
            Try
                My.Computer.FileSystem.WriteAllText(filePath, "DATE,ODDMETER START,ODDMETER END,ACTUAL MILES,AVERAGE MPG,GALLONS GAS USED" + _
                                                    Chr(13), True)
                'WRITE COLUMN HEADERS TO REPORT
            Catch fileException As Exception
                Throw fileException
            End Try

        End If
    End Sub

    Private Sub Read_From_File_Function()

        Try
            Dim sr As StreamReader = New StreamReader(filePath)
            Dim line As String

            recordsFound = 0

            Do
                line = sr.ReadLine()
                recordsFound = recordsFound + 1
            Loop Until line Is Nothing
            sr.Close()
        Catch fileException As Exception
            Throw fileException
        End Try
    End Sub

    Private Sub Save_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save_Button.Click
        If (StartMileage_TextBox.TextLength > 0) And (EndMilage_TextBox.TextLength > 0) And (AvgMpg_TextBox.TextLength > 0) Then
            'CHECK INPUT BOXES TO MAKE SURE THEY ARE NOT BLANK

            enteredDate = CDate(DateTimePicker1.Text)
            startMiles = CInt(Trim(StartMileage_TextBox.Text))
            endMiles = CInt(Trim(EndMilage_TextBox.Text))
            avgMPG = CInt(Trim(AvgMpg_TextBox.Text))

            If (endMiles > startMiles) And (avgMPG > 0) Then
                actualMiles = endMiles - startMiles  'CALCULATE ACTUAL MILES
                gasUsed = actualMiles * avgMPG       'CALCULATE APPROX GAS USED
                MsgBox("Distance: " + CStr(actualMiles) + " miles" + Chr(13) + "Approx. Gas Used: " + CStr(gasUsed) + " gallons")
                'DISPLAY STATS ABOUT ENTERED INFORMATION
                Write_To_CSV_Function()
                Clear_Boxes_Function()
            Else
                MsgBox("End Miles must be greater than Start Miles.")   'ERROR MESSAGE
            End If
        Else
            MsgBox("All fields are required. Please complete the form.")    'ERROR MESSAGE
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Write_To_CSV_Function()
        programStart = False
    End Sub

    Private Sub Reset_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset_Button.Click
        Clear_Boxes_Function()
    End Sub

    Private Sub Clear_Boxes_Function()
        StartMileage_TextBox.Clear()
        EndMilage_TextBox.Clear()
        AvgMpg_TextBox.Clear()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim aboutInfo As New AboutBox1
        aboutInfo.ShowDialog(Me)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ExportLocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportLocationToolStripMenuItem.Click
        MsgBox("A CSV Report is automatically exported and updated after entering each entry. The report can be found at " + _
               CStr(filePath) + ".")
    End Sub

    Private Sub URL_LinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles URL_LinkLabel.LinkClicked
        System.Diagnostics.Process.Start("http://krcomputers.bravehost.com")
    End Sub
End Class