Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel


Public Class Form1
    Dim com5 As IO.Ports.SerialPort = Nothing
    Dim y As Integer = 0
    Dim myport As Array
    Dim inputdata As String
    Private comBuffer As Byte()
    Private Delegate Sub SetTextCallback(ByVal [text] As String)
    Dim Connected As Boolean = False
    Dim x As Integer = 0
    'Dim com5 As IO.Ports.SerialPort = Nothing

    Private Sub OvalShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub clearbutt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbutt.Click
        If y >= 1 Then
            Diya1_unlit.Visible = True
            Diya1_lit.Visible = False
            Diya2_unlit.Visible = True
            Diya2_lit.Visible = False
            Diya3_unlit.Visible = True
            Diya3_lit.Visible = False
            Diya4_unlit.Visible = True
            Diya4_lit.Visible = False
            Diya5_unlit.Visible = True
            Diya5_lit.Visible = False
            Diya6_unlit.Visible = True
            Diya6_lit.Visible = False
            Diya7_unlit.Visible = True
            Diya7_lit.Visible = False
            Diya8_unlit.Visible = True
            Diya8_lit.Visible = False
            Diya9_unlit.Visible = True
            Diya9_lit.Visible = False
            Diya10_unlit.Visible = True
            Diya10_lit.Visible = False
            Diya11_unlit.Visible = True
            Diya11_lit.Visible = False
            Diya12_unlit.Visible = True
            Diya12_lit.Visible = False
            Diya13_unlit.Visible = True
            Diya13_lit.Visible = False
            Diya14_unlit.Visible = True
            Diya14_lit.Visible = False
            Diya15_unlit.Visible = True
            Diya15_lit.Visible = False
            Diya16_unlit.Visible = True
            Diya16_lit.Visible = False
            y = 0
        Else
            MsgBox("All OFF, Press Next or Set All button to switch one or all Diya ON ", MessageBoxIcon.Error, "Diya Application")
            y = 0
        End If

    End Sub

    Private Sub setbutt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setbutt.Click
        If y < 16 Then
            Diya1_unlit.Visible = False
            Diya1_lit.Visible = True
            Diya2_unlit.Visible = False
            Diya2_lit.Visible = True
            Diya3_unlit.Visible = False
            Diya3_lit.Visible = True
            Diya4_unlit.Visible = False
            Diya4_lit.Visible = True
            Diya5_unlit.Visible = False
            Diya5_lit.Visible = True
            Diya6_unlit.Visible = False
            Diya6_lit.Visible = True
            Diya7_unlit.Visible = False
            Diya7_lit.Visible = True
            Diya8_unlit.Visible = False
            Diya8_lit.Visible = True
            Diya9_unlit.Visible = False
            Diya9_lit.Visible = True
            Diya10_unlit.Visible = False
            Diya10_lit.Visible = True
            Diya11_unlit.Visible = False
            Diya11_lit.Visible = True
            Diya12_unlit.Visible = False
            Diya12_lit.Visible = True
            Diya13_unlit.Visible = False
            Diya13_lit.Visible = True
            Diya14_unlit.Visible = False
            Diya14_lit.Visible = True
            Diya15_unlit.Visible = False
            Diya15_lit.Visible = True
            Diya16_unlit.Visible = False
            Diya16_lit.Visible = True
            y = 16
        ElseIf y = 16 Then
            MsgBox("All ON, Press Previous or Clear All button to switch one or all Diya OFF", MessageBoxIcon.Error, "Diya Application")
            y = 16
        End If

    End Sub

    Private Sub nextbutt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextbutt.Click
        If y = 0 Then
            Diya1_unlit.Visible = False
            Diya1_lit.Visible = True        'Diya 1 Lighted
            y = 1
            ' MsgBox(" Congratulations..for e-Yantra Lab Setup Initiative : MU1", MessageBoxIcon.Information, "Diya Application")  //just for taking snapshot

        ElseIf y = 1 Then
            Diya2_unlit.Visible = False
            Diya2_lit.Visible = True        'Diya 2 Lighted
            y = 2

        ElseIf y = 2 Then
            Diya3_unlit.Visible = False
            Diya3_lit.Visible = True        'Diya 3 Lighted
            y = 3

        ElseIf y = 3 Then
            Diya4_unlit.Visible = False
            Diya4_lit.Visible = True        'Diya 4 Lighted
            y = 4

        ElseIf y = 4 Then
            Diya5_unlit.Visible = False
            Diya5_lit.Visible = True        'Diya 5 Lighted
            y = 5

        ElseIf y = 5 Then
            Diya6_unlit.Visible = False
            Diya6_lit.Visible = True        'Diya 6 Lighted
            y = 6

        ElseIf y = 6 Then
            Diya7_unlit.Visible = False
            Diya7_lit.Visible = True        'Diya 7 Lighted
            y = 7

        ElseIf y = 7 Then
            Diya8_unlit.Visible = False
            Diya8_lit.Visible = True        'Diya 8 Lighted
            y = 8

        ElseIf y = 8 Then
            Diya9_unlit.Visible = False
            Diya9_lit.Visible = True        'Diya 9 Lighted
            y = 9

        ElseIf y = 9 Then
            Diya10_unlit.Visible = False
            Diya10_lit.Visible = True        'Diya 10 Lighted
            y = 10

        ElseIf y = 10 Then
            Diya11_unlit.Visible = False
            Diya11_lit.Visible = True        'Diya 11 Lighted
            y = 11

        ElseIf y = 11 Then
            Diya12_unlit.Visible = False
            Diya12_lit.Visible = True        'Diya 12 Lighted
            y = 12

        ElseIf y = 12 Then
            Diya13_unlit.Visible = False
            Diya13_lit.Visible = True        'Diya 13 Lighted
            y = 13

        ElseIf y = 13 Then
            Diya14_unlit.Visible = False
            Diya14_lit.Visible = True        'Diya 14 Lighted
            y = 14
            'Exit Do

        ElseIf y = 14 Then
            Diya15_unlit.Visible = False
            Diya15_lit.Visible = True        'Diya 15 Lighted
            y = 15


        ElseIf y = 15 Then
            Diya16_unlit.Visible = False
            Diya16_lit.Visible = True        'Diya 16 Lighted
            y = 16

        ElseIf y = 16 Then
            MsgBox("All ON, Press Previous or Clear All button to switch one or all Diya OFF", MessageBoxIcon.Error, "Diya Application")

        End If
    End Sub

    Private Sub prevbutt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prevbutt.Click
        If y = 16 Then
            Diya16_unlit.Visible = True
            Diya16_lit.Visible = False
            y = 15

        ElseIf y = 15 Then
            Diya15_unlit.Visible = True
            Diya15_lit.Visible = False
            y = 14


        ElseIf y = 14 Then
            Diya14_unlit.Visible = True
            Diya14_lit.Visible = False
            y = 13


        ElseIf y = 13 Then
            Diya13_unlit.Visible = True
            Diya13_lit.Visible = False
            y = 12


        ElseIf y = 12 Then
            Diya12_unlit.Visible = True
            Diya12_lit.Visible = False
            y = 11


        ElseIf y = 11 Then
            Diya11_unlit.Visible = True
            Diya11_lit.Visible = False
            y = 10


        ElseIf y = 10 Then
            Diya10_unlit.Visible = True
            Diya10_lit.Visible = False
            y = 9


        ElseIf y = 9 Then
            Diya9_unlit.Visible = True
            Diya9_lit.Visible = False
            y = 8


        ElseIf y = 8 Then
            Diya8_unlit.Visible = True
            Diya8_lit.Visible = False
            y = 7


        ElseIf y = 7 Then
            Diya7_unlit.Visible = True
            Diya7_lit.Visible = False
            y = 6

        ElseIf y = 6 Then
            Diya6_unlit.Visible = True
            Diya6_lit.Visible = False
            y = 5

        ElseIf y = 5 Then
            Diya5_unlit.Visible = True
            Diya5_lit.Visible = False
            y = 4

        ElseIf y = 4 Then
            Diya4_unlit.Visible = True
            Diya4_lit.Visible = False
            y = 3

        ElseIf y = 3 Then
            Diya3_unlit.Visible = True
            Diya3_lit.Visible = False
            y = 2

        ElseIf y = 2 Then
            Diya2_unlit.Visible = True
            Diya2_lit.Visible = False
            y = 1

        ElseIf y = 1 Then
            Diya1_unlit.Visible = True
            Diya1_lit.Visible = False
            y = 0
        Else
            MsgBox("All OFF, Press Next or Set All button to switch one or all Diya ON", MessageBoxIcon.Error, "Diya Application")
        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Refresh()

    End Sub

    Private Sub ConnectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectButton.Click
        Dim receivedStr As String

        'Once connection is established, connect button will be disabled and disconnect button will be enabled
        ConnectButton.Enabled = False
        DisconnectButton.Enabled = True

        ConnectButton.Visible = False
        ComLabel.Visible = False
        BaudLabel.Visible = False
        BaudComboBox.Visible = False
        PortComboBox.Visible = False
        ManualLabel.Visible = False
        clearbutt.Visible = False
        setbutt.Visible = False
        nextbutt.Visible = False
        prevbutt.Visible = False

        'depending on string received and number of diya already lighted, decision is taken to light which number of diya
        Do While x <> 1
            receivedStr = ReceiveSerialData()
            ' OutputRichTextBox.Text = receivedStr

            If (receivedStr = 48 And y = 0) Then
                Diya1_unlit.Visible = False
                Diya1_lit.Visible = True        'Diya 1 Lighted
                y = 1
                MsgBox(" Congratulations..for e-Yantra Lab Setup Initiative : MU1", MessageBoxIcon.Information, "Diya Application")
                'Exit Do

            ElseIf (receivedStr = 48 And y = 1) Then
                Diya2_unlit.Visible = False
                Diya2_lit.Visible = True        'Diya 2 Lighted
                y = 2
                MsgBox(" Congratulations..for e-Yantra Lab Setup Initiative : MU2", MessageBoxIcon.Information, "Diya Application")
                'Exit Do

            ElseIf (receivedStr = 48 And y = 2) Then
                Diya3_unlit.Visible = False
                Diya3_lit.Visible = True        'Diya 3 Lighted
                y = 3
                MsgBox(" Congratulations..for e-Yantra Lab Setup Initiative : MU3", MessageBoxIcon.Information, "Diya Application")

            ElseIf (receivedStr = 48 And y = 3) Then
                Diya4_unlit.Visible = False
                Diya4_lit.Visible = True        'Diya 4 Lighted
                y = 4
                MsgBox(" Congratulations..for e-Yantra Lab Setup Initiative : MU4", MessageBoxIcon.Information, "Diya Application")

            ElseIf (receivedStr = 48 And y = 4) Then
                Diya5_unlit.Visible = False
                Diya5_lit.Visible = True        'Diya 5 Lighted
                y = 5
                MsgBox(" Congratulations..for e-Yantra Lab Setup Initiative : MU5", MessageBoxIcon.Information, "Diya Application")

            ElseIf (receivedStr = 48 And y = 5) Then
                Diya6_unlit.Visible = False
                Diya6_lit.Visible = True        'Diya 6 Lighted
                y = 6
                MsgBox(" Congratulations..for e-Yantra Lab Setup Initiative : MU6", MessageBoxIcon.Information, "Diya Application")

            ElseIf (receivedStr = 48 And y = 6) Then
                Diya7_unlit.Visible = False
                Diya7_lit.Visible = True        'Diya 7 Lighted
                y = 7
                MsgBox(" Congratulations..for e-Yantra Lab Setup Initiative : MU7", MessageBoxIcon.Information, "Diya Application")

            ElseIf (receivedStr = 48 And y = 7) Then
                Diya8_unlit.Visible = False
                Diya8_lit.Visible = True        'Diya 8 Lighted
                y = 8
                MsgBox(" Congratulations..for e-Yantra Lab Setup Initiative : MU8", MessageBoxIcon.Information, "Diya Application")
            ElseIf (receivedStr = 48 And y = 8) Then
                Diya9_unlit.Visible = False
                Diya9_lit.Visible = True        'Diya 9 Lighted
                y = 9
                MsgBox(" Congratulations..for e-Yantra Lab Setup Initiative : MU9", MessageBoxIcon.Information, "Diya Application")

            ElseIf (receivedStr = 48 And y = 9) Then
                Diya10_unlit.Visible = False
                Diya10_lit.Visible = True        'Diya 10 Lighted
                y = 10
                MsgBox(" Congratulations..for e-Yantra Lab Setup Initiative : MU10", MessageBoxIcon.Information, "Diya Application")

            ElseIf (receivedStr = 48 And y = 10) Then
                Diya11_unlit.Visible = False
                Diya11_lit.Visible = True        'Diya 11 Lighted
                y = 11
                MsgBox(" Congratulations..for e-Yantra Lab Setup Initiative : MU11", MessageBoxIcon.Information, "Diya Application")

            ElseIf (receivedStr = 48 And y = 11) Then
                Diya12_unlit.Visible = False
                Diya12_lit.Visible = True        'Diya 12 Lighted
                y = 12
                MsgBox(" Congratulations..for e-Yantra Lab Setup Initiative : MU12", MessageBoxIcon.Information, "Diya Application")


            ElseIf (receivedStr = 48 And y = 12) Then
                Diya13_unlit.Visible = False
                Diya13_lit.Visible = True        'Diya 13 Lighted
                y = 13
                MsgBox(" Congratulations..for e-Yantra Lab Setup Initiative : MU13", MessageBoxIcon.Information, "Diya Application")


            ElseIf (receivedStr = 48 And y = 13) Then
                Diya14_unlit.Visible = False
                Diya14_lit.Visible = True        'Diya 14 Lighted
                y = 14
                MsgBox(" Congratulations..for e-Yantra Lab Setup Initiative : MU14", MessageBoxIcon.Information, "Diya Application")

                'Exit Do

            ElseIf (receivedStr = 48 And y = 14) Then
                Diya15_unlit.Visible = False
                Diya15_lit.Visible = True        'Diya 15 Lighted
                y = 15
                MsgBox(" Congratulations..for e-Yantra Lab Setup Initiative : MU15", MessageBoxIcon.Information, "Diya Application")


            ElseIf (receivedStr = 48 And y = 15) Then
                Diya16_unlit.Visible = False
                Diya16_lit.Visible = True        'Diya 16 Lighted
                y = 16
                MsgBox(" Congratulations..for e-Yantra Lab Setup Initiative : MU16", MessageBoxIcon.Information, "Diya Application")


            ElseIf (receivedStr = 48 And y = 16) Then
                MsgBox("All Diya's Exhausted." & vbNewLine & "Please get More !!", MessageBoxIcon.Information, "Diya Application")
                Exit Do
            End If
        Loop
    End Sub

    Function ReceiveSerialData() As String
        ' Receive strings from a serial port. 
        Dim returnStr As String = ""
        Dim Incoming As String
        Dim portnumber As String = PortComboBox.Text
        Dim com5 As IO.Ports.SerialPort = Nothing
        Try
            com5 = My.Computer.Ports.OpenSerialPort(portnumber)
            ' com5.ReadTimeout = 10000
            'Incoming = com5.ReadChar()
            Incoming = com5.ReadChar()
            returnStr &= Incoming & vbCrLf
            ' Do
            '    Incoming = com5.ReadChar()
            '     If Incoming Is Nothing Then
            'Exit Do
            '     Else
            '  returnStr &= Incoming & vbCrLf
            '    End If
            '  Loop
        Catch ex As TimeoutException
            returnStr = "Error: Serial Port read timed out."
        Finally
            If com5 IsNot Nothing Then com5.Close()
        End Try

        Return returnStr
    End Function

    Private Sub DisconnectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisconnectButton.Click
        x = 1
        'com5.Close()
        SerialPort1.Close()

        ConnectButton.Enabled = True
        DisconnectButton.Enabled = False
    End Sub


    Function Refresh() As Integer
        y = 0
        x = 0
        myport = IO.Ports.SerialPort.GetPortNames()
        PortComboBox.Items.Clear()
        PortComboBox.Items.AddRange(myport)

        'Disconnect Button will be disabled. It will be enabled when connect is established.
        ConnectButton.Enabled = True
        DisconnectButton.Enabled = False

        ' When form will open, all 16 diya's will be in Unlighted state.
        Diya1_unlit.Visible = True
        Diya1_lit.Visible = False
        Diya2_unlit.Visible = True
        Diya2_lit.Visible = False
        Diya3_unlit.Visible = True
        Diya3_lit.Visible = False
        Diya4_unlit.Visible = True
        Diya4_lit.Visible = False
        Diya5_unlit.Visible = True
        Diya5_lit.Visible = False
        Diya6_unlit.Visible = True
        Diya6_lit.Visible = False
        Diya7_unlit.Visible = True
        Diya7_lit.Visible = False
        Diya8_unlit.Visible = True
        Diya8_lit.Visible = False
        Diya9_unlit.Visible = True
        Diya9_lit.Visible = False
        Diya10_unlit.Visible = True
        Diya10_lit.Visible = False
        Diya11_unlit.Visible = True
        Diya11_lit.Visible = False
        Diya12_unlit.Visible = True
        Diya12_lit.Visible = False
        Diya13_unlit.Visible = True
        Diya13_lit.Visible = False
        Diya14_unlit.Visible = True
        Diya14_lit.Visible = False
        Diya15_unlit.Visible = True
        Diya15_lit.Visible = False
        Diya16_unlit.Visible = True
        Diya16_lit.Visible = False

        Return 0
    End Function

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        Refresh()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualLabel.Click

    End Sub

   
End Class





