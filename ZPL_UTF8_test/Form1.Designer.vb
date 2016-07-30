<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxInput = New System.Windows.Forms.TextBox()
        Me.TextBoxOutput = New System.Windows.Forms.TextBox()
        Me.ButtonConvert = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxDpi = New System.Windows.Forms.ComboBox()
        Me.TextBoxResDpmm = New System.Windows.Forms.TextBox()
        Me.TextBoxResmm = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxHanymm = New System.Windows.Forms.TextBox()
        Me.TextBoxResHanymm = New System.Windows.Forms.TextBox()
        Me.ButtonCalc = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxLabelW = New System.Windows.Forms.TextBox()
        Me.TextBoxLabelH = New System.Windows.Forms.TextBox()
        Me.TextBoxResLabelW = New System.Windows.Forms.TextBox()
        Me.TextBoxResLabelH = New System.Windows.Forms.TextBox()
        Me.TextBoxPrint = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.ComboBoxPrinter = New System.Windows.Forms.ComboBox()
        Me.ComboBoxSamples = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.59199!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.40801!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxInput, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxOutput, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonConvert, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonCalc, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxPrint, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 1, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.02899!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.21014!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.34058!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.072464!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.615942!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.45652!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(799, 552)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TextBoxInput
        '
        Me.TextBoxInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxInput.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxInput.Multiline = True
        Me.TextBoxInput.Name = "TextBoxInput"
        Me.TextBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxInput.Size = New System.Drawing.Size(581, 87)
        Me.TextBoxInput.TabIndex = 0
        '
        'TextBoxOutput
        '
        Me.TextBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxOutput.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxOutput.Location = New System.Drawing.Point(3, 96)
        Me.TextBoxOutput.Multiline = True
        Me.TextBoxOutput.Name = "TextBoxOutput"
        Me.TextBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxOutput.Size = New System.Drawing.Size(581, 88)
        Me.TextBoxOutput.TabIndex = 1
        '
        'ButtonConvert
        '
        Me.ButtonConvert.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonConvert.Location = New System.Drawing.Point(590, 3)
        Me.ButtonConvert.Name = "ButtonConvert"
        Me.ButtonConvert.Size = New System.Drawing.Size(206, 87)
        Me.ButtonConvert.TabIndex = 2
        Me.ButtonConvert.Text = "Convert"
        Me.ButtonConvert.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ComboBoxDpi, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxResDpmm, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxResmm, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 190)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(581, 28)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'ComboBoxDpi
        '
        Me.ComboBoxDpi.BackColor = System.Drawing.Color.Yellow
        Me.ComboBoxDpi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxDpi.FormattingEnabled = True
        Me.ComboBoxDpi.Items.AddRange(New Object() {"203dpi", "300dpi"})
        Me.ComboBoxDpi.Location = New System.Drawing.Point(3, 3)
        Me.ComboBoxDpi.Name = "ComboBoxDpi"
        Me.ComboBoxDpi.Size = New System.Drawing.Size(139, 21)
        Me.ComboBoxDpi.TabIndex = 0
        Me.ComboBoxDpi.Text = "203dpi"
        '
        'TextBoxResDpmm
        '
        Me.TextBoxResDpmm.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxResDpmm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxResDpmm.Location = New System.Drawing.Point(148, 3)
        Me.TextBoxResDpmm.Name = "TextBoxResDpmm"
        Me.TextBoxResDpmm.Size = New System.Drawing.Size(139, 20)
        Me.TextBoxResDpmm.TabIndex = 1
        Me.TextBoxResDpmm.Text = "8dpmm"
        '
        'TextBoxResmm
        '
        Me.TextBoxResmm.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxResmm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxResmm.Location = New System.Drawing.Point(293, 3)
        Me.TextBoxResmm.Name = "TextBoxResmm"
        Me.TextBoxResmm.Size = New System.Drawing.Size(139, 20)
        Me.TextBoxResmm.TabIndex = 2
        Me.TextBoxResmm.Text = "8"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxHanymm, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxResHanymm, 2, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 224)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(581, 21)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Location = New System.Drawing.Point(88, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hány mm:"
        '
        'TextBoxHanymm
        '
        Me.TextBoxHanymm.BackColor = System.Drawing.Color.Yellow
        Me.TextBoxHanymm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxHanymm.Location = New System.Drawing.Point(148, 3)
        Me.TextBoxHanymm.Name = "TextBoxHanymm"
        Me.TextBoxHanymm.Size = New System.Drawing.Size(139, 20)
        Me.TextBoxHanymm.TabIndex = 1
        Me.TextBoxHanymm.Text = "0"
        '
        'TextBoxResHanymm
        '
        Me.TextBoxResHanymm.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxResHanymm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxResHanymm.Location = New System.Drawing.Point(293, 3)
        Me.TextBoxResHanymm.Name = "TextBoxResHanymm"
        Me.TextBoxResHanymm.Size = New System.Drawing.Size(139, 20)
        Me.TextBoxResHanymm.TabIndex = 2
        '
        'ButtonCalc
        '
        Me.ButtonCalc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonCalc.Location = New System.Drawing.Point(590, 190)
        Me.ButtonCalc.Name = "ButtonCalc"
        Me.ButtonCalc.Size = New System.Drawing.Size(206, 28)
        Me.ButtonCalc.TabIndex = 5
        Me.ButtonCalc.Text = "Calc"
        Me.ButtonCalc.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxLabelW, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxLabelH, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxResLabelW, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxResLabelH, 4, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 251)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(581, 24)
        Me.TableLayoutPanel4.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Location = New System.Drawing.Point(46, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Címkeméret:"
        '
        'TextBoxLabelW
        '
        Me.TextBoxLabelW.BackColor = System.Drawing.Color.Yellow
        Me.TextBoxLabelW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxLabelW.Location = New System.Drawing.Point(119, 3)
        Me.TextBoxLabelW.Name = "TextBoxLabelW"
        Me.TextBoxLabelW.Size = New System.Drawing.Size(110, 20)
        Me.TextBoxLabelW.TabIndex = 1
        Me.TextBoxLabelW.Text = "90"
        '
        'TextBoxLabelH
        '
        Me.TextBoxLabelH.BackColor = System.Drawing.Color.Yellow
        Me.TextBoxLabelH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxLabelH.Location = New System.Drawing.Point(235, 3)
        Me.TextBoxLabelH.Name = "TextBoxLabelH"
        Me.TextBoxLabelH.Size = New System.Drawing.Size(110, 20)
        Me.TextBoxLabelH.TabIndex = 2
        Me.TextBoxLabelH.Text = "50"
        '
        'TextBoxResLabelW
        '
        Me.TextBoxResLabelW.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxResLabelW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxResLabelW.Location = New System.Drawing.Point(351, 3)
        Me.TextBoxResLabelW.Name = "TextBoxResLabelW"
        Me.TextBoxResLabelW.Size = New System.Drawing.Size(110, 20)
        Me.TextBoxResLabelW.TabIndex = 3
        '
        'TextBoxResLabelH
        '
        Me.TextBoxResLabelH.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxResLabelH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxResLabelH.Location = New System.Drawing.Point(467, 3)
        Me.TextBoxResLabelH.Name = "TextBoxResLabelH"
        Me.TextBoxResLabelH.Size = New System.Drawing.Size(111, 20)
        Me.TextBoxResLabelH.TabIndex = 4
        '
        'TextBoxPrint
        '
        Me.TextBoxPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxPrint.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxPrint.Location = New System.Drawing.Point(3, 281)
        Me.TextBoxPrint.Multiline = True
        Me.TextBoxPrint.Name = "TextBoxPrint"
        Me.TextBoxPrint.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxPrint.Size = New System.Drawing.Size(581, 268)
        Me.TextBoxPrint.TabIndex = 7
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.ButtonPrint, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.ComboBoxPrinter, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.ComboBoxSamples, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(590, 281)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 4
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(206, 268)
        Me.TableLayoutPanel5.TabIndex = 8
        '
        'ButtonPrint
        '
        Me.ButtonPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonPrint.Location = New System.Drawing.Point(3, 204)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(200, 61)
        Me.ButtonPrint.TabIndex = 0
        Me.ButtonPrint.Text = "Print"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'ComboBoxPrinter
        '
        Me.ComboBoxPrinter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxPrinter.FormattingEnabled = True
        Me.ComboBoxPrinter.Location = New System.Drawing.Point(3, 3)
        Me.ComboBoxPrinter.Name = "ComboBoxPrinter"
        Me.ComboBoxPrinter.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxPrinter.TabIndex = 1
        '
        'ComboBoxSamples
        '
        Me.ComboBoxSamples.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxSamples.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSamples.FormattingEnabled = True
        Me.ComboBoxSamples.Location = New System.Drawing.Point(3, 70)
        Me.ComboBoxSamples.Name = "ComboBoxSamples"
        Me.ComboBoxSamples.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxSamples.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 552)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Zebra UTF8 converter"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBoxInput As TextBox
    Friend WithEvents TextBoxOutput As TextBox
    Friend WithEvents ButtonConvert As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ComboBoxDpi As ComboBox
    Friend WithEvents TextBoxResDpmm As TextBox
    Friend WithEvents TextBoxResmm As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxHanymm As TextBox
    Friend WithEvents TextBoxResHanymm As TextBox
    Friend WithEvents ButtonCalc As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxLabelW As TextBox
    Friend WithEvents TextBoxLabelH As TextBox
    Friend WithEvents TextBoxResLabelW As TextBox
    Friend WithEvents TextBoxResLabelH As TextBox
    Friend WithEvents TextBoxPrint As TextBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents ButtonPrint As Button
    Friend WithEvents ComboBoxPrinter As ComboBox
    Friend WithEvents ComboBoxSamples As ComboBox
End Class
