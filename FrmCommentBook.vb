Imports System.IO

Public Class FrmCommentBook
    Public mUsername As String = ""
    Public selectedID As String = ""
    Dim wptr As StreamWriter
    Dim rptr As StreamReader

    Private Sub FrmCommentBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

        wptr = New StreamWriter(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\BookComment\" & selectedID.Trim & ".txt"), True)
        wptr.WriteLine()
        wptr.Close()

        rptr = New StreamReader(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\BookComment\" & selectedID.Trim & ".txt"))

        Dim db As New DBDataContext
        Dim b As New book
        b = db.books.FirstOrDefault(Function(o) o.bookID = selectedID)
        PictureBox1.Image = Image.FromFile("..\..\Resources\BookImage\" & b.bookID.Trim & ".jpg")
        While rptr.Peek <> -1
            lblComment.Text = rptr.ReadToEnd()
        End While

        rptr.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        wptr = New StreamWriter(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\BookComment\" & selectedID.Trim & ".txt"), True)

        wptr.WriteLine(mUsername & ": " & txtComment.Text & vbNewLine)
        wptr.Close()

        rptr = New StreamReader(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\BookComment\" & selectedID.Trim & ".txt"))

        While rptr.Peek <> -1
            lblComment.Text = rptr.ReadToEnd()
        End While

        rptr.Close()
        txtComment.Clear()
    End Sub

    Private Sub FrmCommentBook_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        rptr = New StreamReader(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\BookComment\" & selectedID.Trim & ".txt"))

        While rptr.Peek <> -1
            lblComment.Text = rptr.ReadToEnd()
        End While

        rptr.Close()
    End Sub

End Class