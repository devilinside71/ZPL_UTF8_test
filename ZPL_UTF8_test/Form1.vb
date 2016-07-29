Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sText As String
        Dim array() As String
        Dim i As Integer

        sText = ZebraPrint.GetZPLutf8Code(TextBox1.Text) & vbCrLf & vbCrLf
        sText = sText & "^CWT,E:TT0003M_.FNT" & vbCrLf
        sText = sText & "^CFT,40,30" & vbCrLf
        sText = sText & "^CI28" & vbCrLf

        array = Split(TextBox1.Text, vbCrLf)
        For i = LBound(array) To UBound(array)
            sText = sText & "^FT10,90^FH^FD" & ZebraPrint.GetZPLutf8Code(array(i)) & "^FS" & vbCrLf
        Next
        TextBox2.Text = sText
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dpmm As Integer

        dpmm = CInt(TextBoxResmm.Text)
        TextBoxResHanymm.Text = CStr(CLng(TextBox5.Text) * dpmm)
        TextBoxResLabelW.Text = CStr(CLng(TextBox7.Text) * dpmm)
        TextBoxResLabelH.Text = CStr(CLng(TextBox8.Text) * dpmm)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "203dpi" Then
            TextBoxResDpmm.Text = "8dpmm"
            TextBoxResmm.Text = "8"
        End If
        If ComboBox1.Text = "300dpi" Then
            TextBoxResDpmm.Text = "12dpmm"
            TextBoxResmm.Text = "12"
        End If
    End Sub
End Class
