Imports System.Windows.Forms
Public Class InputBoxForm

    Protected m_blankvalid As Boolean = True
    Protected m_returnText As String = ""

    Public Overloads Function ShowDialog(
        ByVal titleText As String,
        ByVal promptText As String,
        ByVal defaultText As String,
        ByRef enteredText As String,
        ByVal blankvalid As String) As System.Windows.Forms.DialogResult
        m_blankvalid = blankvalid

        Me.Text = titleText
        Me.ShowDialog()

        enteredText = m_returnText

        Return Me.DialogResult
    End Function


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_input.TextChanged
        If Me.txt_input.Text = "" Then
            butt_ok.Enabled = m_blankvalid
        Else
            butt_ok.Enabled = True
            Me.Label1.Text = "Rp." + Format(Val(Me.txt_input.Text), "##,##0.00")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = DialogResult.Cancel
        m_returnText = ""
        Me.Close()
    End Sub

    Private Sub InputBoxForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub butt_ok_Click(sender As Object, e As EventArgs) Handles butt_ok.Click
        Me.DialogResult = DialogResult.OK
        m_returnText = Me.txt_input.Text
        Me.Close()
    End Sub
End Class