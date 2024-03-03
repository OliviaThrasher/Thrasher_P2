'Olivia Thrasher
'Assignment: Project 2 (P2)
'GUI Development Class


Option Strict On


Imports System.ComponentModel

Public Class Form1
    'Declaring decIncome here since it's global now instead of local
    Dim decIncome As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Textbox converts to number, if it's a letter then message pops up
    Protected Sub BoxInput_TextChanged(sender As Object, e As EventArgs) Handles BoxInput.TextChanged
        Dim strIncome As String = BoxInput.Text
        'Had to add null or white space clause so message won't popup when textbox is empty
        If Not String.IsNullOrWhiteSpace(BoxInput.Text) Then
            If IsNumeric(strIncome) Then
                decIncome = Convert.ToDouble(strIncome)


            Else
                MsgBox("Enter a number please.", MsgBoxStyle.OkCancel, "Number Error Message")
                BoxInput.Clear()
                BoxInput.Focus()

            End If
        End If
    End Sub
    'Declaring all taxes and converting them to strings
    Protected Sub ButtonCompute_Click(sender As Object, e As EventArgs) Handles ButtonCompute.Click
        Dim decFica As Double
        Const _cdecFica As Double = 0.0765
        decFica = _cdecFica * decIncome
        FicaBox.Text = decFica.ToString("C2")

        Dim decFed As Double
        Const _cdecFed As Double = 0.22
        decFed = _cdecFed * decIncome
        FedBox.Text = decFed.ToString("C2")

        Dim decState As Double
        Const _cdecState As Double = 0.04
        decState = _cdecState * decIncome
        StateBox.Text = decState.ToString("C2")
        'Added taxes together and subtract income to get paycheck
        Dim decNet As Double
        decNet = (decIncome - (decFica + decFed + decState))
        BoxNetPaycheck.Text = decNet.ToString("C2")

    End Sub

    'Clears everything and put focus back on textbox
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        BoxInput.Clear()
        BoxInput.Focus()
        FicaBox.Clear()
        FedBox.Clear()
        StateBox.Clear()
        BoxNetPaycheck.Clear()
    End Sub

    'Closes Form
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Close()
    End Sub

End Class
'I'm sorry for being late again.