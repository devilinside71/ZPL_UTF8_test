Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonConvert.Click
        Dim sText As String
        Dim array() As String
        Dim i As Integer

        sText = ZebraPrint.GetZPLutf8Code(TextBoxInput.Text) & vbCrLf & vbCrLf
        sText = sText & "http://labelary.com/viewer.html" & vbCrLf & vbCrLf
        sText = sText & "^CWT,E:TT0003M_.FNT" & vbCrLf
        sText = sText & "^CFT,40,30" & vbCrLf
        sText = sText & "^CI28" & vbCrLf

        array = Split(TextBoxInput.Text, vbCrLf)
        For i = LBound(array) To UBound(array)
            sText = sText & "^FT10,90^FH^FD" & ZebraPrint.GetZPLutf8Code(array(i)) & "^FS" & vbCrLf
        Next
        TextBoxOutput.Text = sText
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonCalc.Click
        Dim dpmm As Integer

        dpmm = CInt(TextBoxResmm.Text)
        TextBoxResHanymm.Text = CStr(CLng(TextBoxHanymm.Text) * dpmm)
        TextBoxResLabelW.Text = CStr(CLng(TextBoxLabelW.Text) * dpmm)
        TextBoxResLabelH.Text = CStr(CLng(TextBoxLabelH.Text) * dpmm)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDpi.SelectedIndexChanged
        If ComboBoxDpi.Text = "203dpi" Then
            TextBoxResDpmm.Text = "8dpmm"
            TextBoxResmm.Text = "8"
        End If
        If ComboBoxDpi.Text = "300dpi" Then
            TextBoxResDpmm.Text = "12dpmm"
            TextBoxResmm.Text = "12"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call LoadPrinters()
        Call LoadResolutions()
        Call LoadZPLSamples()
        ComboBoxPrinter.Items.Clear()
        For Each lsa In printernames
            ComboBoxPrinter.Items.Add(lsa)
        Next
        ComboBoxPrinter.SelectedIndex = 0
        ComboBoxSamples.Items.Clear()
        For Each lsa In labelnames
            ComboBoxSamples.Items.Add(lsa)
        Next
        ComboBoxSamples.SelectedIndex = 0
    End Sub

    Private Sub ComboBoxSamples_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSamples.SelectedIndexChanged
        TextBoxPrint.Text = labelcodes(ComboBoxSamples.SelectedIndex)
    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click
        Dim res As Boolean
        Dim strPrintername
        Dim s As String

        strPrintername = ComboBoxPrinter.Text

        For Each prnm In printernames
            If prnm = strPrintername Then
                strPrintername = printerwinnames(ComboBoxPrinter.SelectedIndex)
                Exit For
            End If
        Next

        'Console.WriteLine(strPrintername)

        s = TextBoxPrint.Text
        'Console.WriteLine(s)
        ' Open the printer dialog box, and then allow the user to select a printer.
        res = ZebraPrint.SendStringToPrinter(strPrintername, s)



    End Sub
End Class
