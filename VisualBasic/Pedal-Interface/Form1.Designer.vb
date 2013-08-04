<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.KL2 = New System.Windows.Forms.ComboBox()
        Me.ML2 = New System.Windows.Forms.ComboBox()
        Me.KL1 = New System.Windows.Forms.ComboBox()
        Me.ML1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.KR2 = New System.Windows.Forms.ComboBox()
        Me.MR2 = New System.Windows.Forms.ComboBox()
        Me.KR1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MR1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.comBox = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.KL2)
        Me.GroupBox1.Controls.Add(Me.ML2)
        Me.GroupBox1.Controls.Add(Me.KL1)
        Me.GroupBox1.Controls.Add(Me.ML1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 117)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Links"
        '
        'KL2
        '
        Me.KL2.FormattingEnabled = True
        Me.KL2.Items.AddRange(New Object() {"Nothing", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "Enter", "ESC", "Backspace", "TAB", "Space", "Minus", "Equal", "Left Brace", "Right Brace", "Backslash", "Backslash", "Semicolon", "Quote", "Tilde", "Comma", "Period", "Slash", "Caps Lock", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "Printscreen", "Scroll Lock", "Pause", "Insert", "Home", "Page Up", "Delete", "End", "Page Down", "Right", "Left", "Down", "Up", "Num Lock", "KP-Slash", "KP-Asterix", "KP-Minus", "KP-Plus", "KP-Enter", "KP-1", "KP-2", "KP-3", "KP-4", "KP-5", "KP-6", "KP-7", "KP-8", "KP-9", "KP-0", "KP-Period"})
        Me.KL2.Location = New System.Drawing.Point(122, 75)
        Me.KL2.Name = "KL2"
        Me.KL2.Size = New System.Drawing.Size(70, 21)
        Me.KL2.TabIndex = 9
        '
        'ML2
        '
        Me.ML2.FormattingEnabled = True
        Me.ML2.Items.AddRange(New Object() {"Nothing", "Control", "Shift", "Alt", "GUI"})
        Me.ML2.Location = New System.Drawing.Point(46, 75)
        Me.ML2.Name = "ML2"
        Me.ML2.Size = New System.Drawing.Size(70, 21)
        Me.ML2.TabIndex = 8
        '
        'KL1
        '
        Me.KL1.FormattingEnabled = True
        Me.KL1.Items.AddRange(New Object() {"Nothing", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "Enter", "ESC", "Backspace", "TAB", "Space", "Minus", "Equal", "Left Brace", "Right Brace", "Backslash", "Backslash", "Semicolon", "Quote", "Tilde", "Comma", "Period", "Slash", "Caps Lock", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "Printscreen", "Scroll Lock", "Pause", "Insert", "Home", "Page Up", "Delete", "End", "Page Down", "Right", "Left", "Down", "Up", "Num Lock", "KP-Slash", "KP-Asterix", "KP-Minus", "KP-Plus", "KP-Enter", "KP-1", "KP-2", "KP-3", "KP-4", "KP-5", "KP-6", "KP-7", "KP-8", "KP-9", "KP-0", "KP-Period"})
        Me.KL1.Location = New System.Drawing.Point(122, 42)
        Me.KL1.Name = "KL1"
        Me.KL1.Size = New System.Drawing.Size(70, 21)
        Me.KL1.TabIndex = 7
        '
        'ML1
        '
        Me.ML1.FormattingEnabled = True
        Me.ML1.Items.AddRange(New Object() {"Nothing", "Control", "Shift", "Alt", "GUI"})
        Me.ML1.Location = New System.Drawing.Point(46, 42)
        Me.ML1.Name = "ML1"
        Me.ML1.Size = New System.Drawing.Size(70, 21)
        Me.ML1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Modifier"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(119, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Key"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pos 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pos 1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.KR2)
        Me.GroupBox2.Controls.Add(Me.MR2)
        Me.GroupBox2.Controls.Add(Me.KR1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.MR1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(218, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 117)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rechts"
        '
        'KR2
        '
        Me.KR2.FormattingEnabled = True
        Me.KR2.Items.AddRange(New Object() {"Nothing", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "Enter", "ESC", "Backspace", "TAB", "Space", "Minus", "Equal", "Left Brace", "Right Brace", "Backslash", "Backslash", "Semicolon", "Quote", "Tilde", "Comma", "Period", "Slash", "Caps Lock", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "Printscreen", "Scroll Lock", "Pause", "Insert", "Home", "Page Up", "Delete", "End", "Page Down", "Right", "Left", "Down", "Up", "Num Lock", "KP-Slash", "KP-Asterix", "KP-Minus", "KP-Plus", "KP-Enter", "KP-1", "KP-2", "KP-3", "KP-4", "KP-5", "KP-6", "KP-7", "KP-8", "KP-9", "KP-0", "KP-Period"})
        Me.KR2.Location = New System.Drawing.Point(122, 75)
        Me.KR2.Name = "KR2"
        Me.KR2.Size = New System.Drawing.Size(70, 21)
        Me.KR2.TabIndex = 13
        '
        'MR2
        '
        Me.MR2.FormattingEnabled = True
        Me.MR2.Items.AddRange(New Object() {"Nothing", "Control", "Shift", "Alt", "GUI"})
        Me.MR2.Location = New System.Drawing.Point(46, 75)
        Me.MR2.Name = "MR2"
        Me.MR2.Size = New System.Drawing.Size(70, 21)
        Me.MR2.TabIndex = 12
        '
        'KR1
        '
        Me.KR1.FormattingEnabled = True
        Me.KR1.Items.AddRange(New Object() {"Nothing", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "Enter", "ESC", "Backspace", "TAB", "Space", "Minus", "Equal", "Left Brace", "Right Brace", "Backslash", "Backslash", "Semicolon", "Quote", "Tilde", "Comma", "Period", "Slash", "Caps Lock", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "Printscreen", "Scroll Lock", "Pause", "Insert", "Home", "Page Up", "Delete", "End", "Page Down", "Right", "Left", "Down", "Up", "Num Lock", "KP-Slash", "KP-Asterix", "KP-Minus", "KP-Plus", "KP-Enter", "KP-1", "KP-2", "KP-3", "KP-4", "KP-5", "KP-6", "KP-7", "KP-8", "KP-9", "KP-0", "KP-Period"})
        Me.KR1.Location = New System.Drawing.Point(122, 42)
        Me.KR1.Name = "KR1"
        Me.KR1.Size = New System.Drawing.Size(70, 21)
        Me.KR1.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(119, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Key"
        '
        'MR1
        '
        Me.MR1.FormattingEnabled = True
        Me.MR1.Items.AddRange(New Object() {"Nothing", "Control", "Shift", "Alt", "GUI"})
        Me.MR1.Location = New System.Drawing.Point(46, 42)
        Me.MR1.Name = "MR1"
        Me.MR1.Size = New System.Drawing.Size(70, 21)
        Me.MR1.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Modifier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pos 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pos 1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Send to Chip"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "COM Port"
        '
        'comBox
        '
        Me.comBox.FormattingEnabled = True
        Me.comBox.Location = New System.Drawing.Point(12, 187)
        Me.comBox.Name = "comBox"
        Me.comBox.Size = New System.Drawing.Size(86, 21)
        Me.comBox.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(95, 135)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Read from Chip"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(192, 135)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(113, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Save Data on Chip"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(311, 135)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(114, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Load Data from Chip"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(104, 185)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Open"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(185, 187)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 25)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Label10"
        Me.Label10.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 238)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.comBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(445, 262)
        Me.MinimumSize = New System.Drawing.Size(445, 262)
        Me.Name = "Form1"
        Me.Text = "PedalInterface"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents KL2 As System.Windows.Forms.ComboBox
    Friend WithEvents ML2 As System.Windows.Forms.ComboBox
    Friend WithEvents KL1 As System.Windows.Forms.ComboBox
    Friend WithEvents ML1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents KR2 As System.Windows.Forms.ComboBox
    Friend WithEvents MR2 As System.Windows.Forms.ComboBox
    Friend WithEvents KR1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MR1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents comBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
