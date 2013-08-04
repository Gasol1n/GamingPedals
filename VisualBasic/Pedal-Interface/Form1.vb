Public Class Form1


    'Disconnect the COM Port when the Form's Closing
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SerialPort1.Close()
    End Sub

    'On Programm Start
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ML1.SelectedIndex = 0
        KL1.SelectedIndex = 0
        KL2.SelectedIndex = 0
        ML2.SelectedIndex = 0
        KR1.SelectedIndex = 0
        MR1.SelectedIndex = 0
        KR2.SelectedIndex = 0
        MR2.SelectedIndex = 0
        comPortBox()
    End Sub

    'Send Keys to the Chip
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If SerialPort1.IsOpen Then
            SerialPort1.Write(Chr(110) & vbCr)
            SerialPort1.Write(ML1.SelectedIndex & vbCr)
            SerialPort1.Write(KL1.SelectedIndex & vbCr)
            SerialPort1.Write(ML2.SelectedIndex & vbCr)
            SerialPort1.Write(KL2.SelectedIndex & vbCr)
            SerialPort1.Write(MR1.SelectedIndex & vbCr)
            SerialPort1.Write(KR1.SelectedIndex & vbCr)
            SerialPort1.Write(MR2.SelectedIndex & vbCr)
            SerialPort1.Write(KR2.SelectedIndex & vbCr)
            SerialPort1.DiscardInBuffer()
            display("Sended")
        End If
    End Sub

    'List all COM Ports
    Private Sub comPortBox()
        Dim comPort = My.Settings.comPort
        Dim i As Integer = 0
        Dim ports As String() = IO.Ports.SerialPort.GetPortNames()
        comBox.Items.Clear()

        For Each port As String In ports
            comBox.Items.Add(port)
            If port = comPort Then
                comBox.SelectedIndex = i
            End If
            i = i + 1
        Next port
    End Sub

    'Connect / Disconnect
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Not SerialPort1.IsOpen Then
            Try
                SerialPort1.PortName = comBox.SelectedItem
                SerialPort1.Open()
                If SerialPort1.IsOpen Then
                    Button6.Text = "Close"
                    My.Settings.comPort = comBox.SelectedItem
                    display("Connected")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            SerialPort1.Close()
            Button6.Text = "Open"
            display("Closed")
        End If
    End Sub

    'Save Data on Chip
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If SerialPort1.IsOpen Then
            SerialPort1.Write("s" & vbCr)
            SerialPort1.DiscardInBuffer()
            display("Saved on Chip")
        End If
    End Sub

    'Load Data from Chip
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If SerialPort1.IsOpen Then
            SerialPort1.Write("l" & vbCr)
            SerialPort1.DiscardInBuffer()
            display("Loaded from Chip")
        End If
    End Sub

    'Read Keys from Chip
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If SerialPort1.IsOpen Then
            Dim c As Integer = 0
            Dim s As String = ""
            Dim s2() As String
            SerialPort1.DiscardInBuffer()
            SerialPort1.Write("r" & vbCr)
            While c < 10000
                If SerialPort1.BytesToRead >= 16 Then
                    While SerialPort1.BytesToRead > 0
                        s += Chr(SerialPort1.ReadByte)
                    End While
                    s2 = Split(s, ",")
                    ML1.SelectedIndex = s2(0)
                    KL1.SelectedIndex = s2(1)
                    ML2.SelectedIndex = s2(2)
                    KL2.SelectedIndex = s2(3)
                    MR1.SelectedIndex = s2(4)
                    KR1.SelectedIndex = s2(5)
                    MR2.SelectedIndex = s2(6)
                    KR2.SelectedIndex = s2(7)
                    display("Readed")
                    c = 1000
                End If
                c += 1
            End While
        End If
    End Sub

    'Displaying the Status Text
    Private Sub display(ByVal text As String)
        Timer1.Stop()
        Label10.Text = text
        Label10.Visible = True
        Timer1.Start()
    End Sub

    'Timer Tick: For deactivating the Status Text
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label10.Visible = False
        Timer1.Stop()
    End Sub
End Class
