Imports System.ComponentModel
Imports System.Drawing.Text
Imports System.IO
Imports System.IO.Ports
Imports System.Net
Imports System.Net.Mail
Imports System.Runtime.InteropServices
Imports System.Text




Public Class frmMain
    Public comOpen As Boolean
    Public readBuffer As String
    Public heaterOn As Boolean = False
    Public pumpOn As Boolean = False
    Public cTime As Single = 0
    Public pwrW As Integer = 5
    Public pwrC As Integer = 50
    Public Charting As Boolean = False
    Public chartTimerCount As Integer = 0
    Public timerCount As Integer = 0
    Public bmTimerCount As Integer = 0
    Public recipeTable As New DataTable("Recipe")
    Public mashRunning As Boolean = False
    Public boilRunning As Boolean = False
    Public oTimer As System.Threading.Timer
    Public paused As Boolean = False



    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        'Set up the serial port connection
        With SerialPort1
            'Selected Port
            .PortName = "COM3"
            'Baud Rate. 9600 is default.
            .BaudRate = CInt(txtBaud.Text)
            .Parity = IO.Ports.Parity.None
            .DataBits = 8
            .StopBits = IO.Ports.StopBits.One
            .Handshake = IO.Ports.Handshake.None
            .RtsEnable = False
            .ReceivedBytesThreshold = 1
            .NewLine = vbCr
            .ReadTimeout = 500
            .WriteTimeout = 500
        End With

        AddHandler SerialPort1.DataReceived, AddressOf SerialPort1_DataReceived

        'Try to open the selected port...
        Try
            SerialPort1.Open()
            comOpen = SerialPort1.IsOpen
        Catch ex As Exception
            'Couldn't open it... show error
            comOpen = False
            MsgBox("Error Open: " & ex.Message)
        End Try

        btnDisconnect.Enabled = True
        btnConnect.Enabled = False
        txtBaud.Enabled = False
        cmbCom.Enabled = False

    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        'Graceful disconnect if port is open
        If comOpen Then

            SerialPort1.WriteLine("x")
            SerialPort1.DiscardInBuffer()
            SerialPort1.Close()

            'Reset our flag and controls
            comOpen = False
            btnDisconnect.Enabled = False
            btnConnect.Enabled = True
            txtBaud.Enabled = True
            cmbCom.Enabled = True
        End If

    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs)
        If comOpen Then
            Try
                'Send data to a new thread to update the temperature and volume displays
                'comes in as TEMP/VOLUME
                'Temperature is in degrees F, Volume in grams

                readBuffer = SerialPort1.ReadLine()

                If readBuffer.Contains("/") Then
                    Me.Invoke(New EventHandler(AddressOf updateTemp))
                Else
                    Me.Invoke(New EventHandler(AddressOf updateMonitor))
                End If
            Catch ex As Exception
                'Otherwise show error. Will display when
                'disconnecting.
                'MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Public Sub updateMonitor(ByVal sender As Object, ByVal e As System.EventArgs)
        txtMonitor.AppendText(readBuffer & vbNewLine)
    End Sub


    Public Sub updateTemp(ByVal sender As Object, ByVal e As System.EventArgs)
        'Update temperature and volume displays as data comes in
        Dim read, rTemp, rVol As String

        read = readBuffer.Replace(vbCr, "").Replace(vbLf, "")
        lblReading.Text = readBuffer

        Dim splitReading() As String = read.Split("/")

        rTemp = splitReading(0)
        rVol = splitReading(1)

        txtPerGallon.Text = rVol / Val(txtGallons.Text) - Val(txtZero.Text)

        'Dim vGal As Single = Math.Round((Val(rVol) - Val(txtZero.Text)) / Val(txtPerGallon.Text), 2)       'use to calibrate - turn OFF when done

        Dim vGal As Single = Math.Round(Val(rVol) / 134, 2)       '134 oz in a gallon
        vGal = 7.5  'Set Constant until we figure out a better way
        lblVolume.Text = vGal

        'Update volume display
        'lHeight Max = 400
        'vGal Max = 10
        'lTop bottom @ 430


        Dim lHeight, lTop As Single
        lHeight = 400 / (10 / vGal)
        lTop = 430 - lHeight

        vBar.Height = lHeight
        vBar.Top = lTop

        If Val(rTemp) > Val(txtSetTemp.Text) Then
            lblActualTemp.ForeColor = Color.Red
        Else
            lblActualTemp.ForeColor = Color.LimeGreen
        End If

        lblActualTemp.Text = rTemp & "°"

        updateWeb()
    End Sub

    Public Sub updateWeb()
        Dim file As String = "C:\xampp\htdocs\test.txt"
        Dim updateString As String = ""
        Dim x As Integer = 1

        updateString = "{""temp"":""" & lblActualTemp.Text.Replace("°", "") & """"

        For Each row As DataGridViewRow In alarmGridView.Rows
            If row.Cells("clmTime").Value > 0 Then
                updateString += ",""T" & x & """:""" & row.Cells("clmTimeRemaining").Value & """"

                x += 1
            End If
        Next

        updateString += "}"

        System.IO.File.Delete(file)
        Dim txtWriter As New System.IO.StreamWriter(file, True)
        txtWriter.Write(updateString)
        txtWriter.Close()
    End Sub


    Public Sub updateHeater(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        SerialPort1.WriteLine(txtSend.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbMash.Checked = True
        oTimer = New Threading.Timer(AddressOf oTimer_Tick, Nothing, 0, 1000)

        ' oTimer.Start()

        '---Start Charting---
        Charting = True
        chartTimerCount = 0
        tempChart.Series("Series1").XValueMember = "TimeColumn"
        tempChart.Series("Series1").YValueMembers = "TempColumn"
        tempChart.DataSource = dtTemp
        tempChart.DataBind()
        dtTemp.Rows.Clear()

        '---Start Node Webserver (Make sure Node.JS is installed---
        'Shell("node C:\NodeJS\index.js")
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles liveTab.Click

    End Sub

    Private Sub txtSend_TextChanged(sender As Object, e As EventArgs) Handles txtSend.TextChanged

    End Sub

    Private Sub btnPump_Click(sender As Object, e As EventArgs)
        'SerialPort1.WriteLine("0")
    End Sub

    Private Sub btnHeater_Click(sender As Object, e As EventArgs) Handles btnHeater.Click
        If SerialPort1.IsOpen Then
            If heaterOn Then
                lblHeater.BackColor = Color.Lime
                heaterOn = False
                SerialPort1.Write("n")
            Else
                lblHeater.BackColor = Color.Red
                heaterOn = True
                SerialPort1.Write("y")
            End If
        End If

    End Sub

    Private Sub btnSetTemp_Click(sender As Object, e As EventArgs) Handles btnSetTemp.Click
        If SerialPort1.IsOpen Then
            SerialPort1.Write(txtSetTemp.Text)
        End If
    End Sub

    Private Sub alarmGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles alarmGridView.CellContentClick

    End Sub

    Private Sub btnTimers_Click(sender As Object, e As EventArgs) Handles btnTimers.Click
        timerCount = 0
        bmTimerCount = 0
        If rbMash.Checked Then
            mashRunning = True
            boilRunning = False
        Else
            mashRunning = False
            boilRunning = True
        End If

    End Sub

    Private Sub oTimer_Tick(ByVal state As Object)
        If paused = True Then
            GoTo SkipTimers
        End If
        If boilRunning = True Then
            For Each row As DataGridViewRow In alarmGridView.Rows
                If row.Cells("clmTimeRemaining").Value = "-DONE-" Then
                    GoTo SkipRow
                End If

                If row.Cells("clmTime").Value > 0 Then
                    Dim timeRemain, timerSeconds As Integer
                    Dim minRemain, secRemain As Integer
                    Dim timeDisplay As String

                    timerSeconds = row.Cells("clmTime").Value * 60
                    timeRemain = 3600 - (timerSeconds + timerCount)

                    If timeRemain <= 0 Then
                        row.Cells("clmTimeRemaining").Value = "DONE"

                        If row.Cells("clmTimeRemaining").Value <> "-DONE-" Then
                            My.Computer.Audio.Play(My.Resources.missleAlarm, AudioPlayMode.Background)
                            row.Cells("clmTimeRemaining").Value = "-DONE-"
                        End If
                    Else
                        minRemain = Math.Floor(timeRemain / 60)
                        secRemain = timeRemain - (minRemain * 60)
                        timeDisplay = minRemain & ":" & IIf(secRemain > 9, secRemain, "0" & secRemain)

                        row.Cells("clmTimeRemaining").Value = timeDisplay
                    End If
                End If
SkipRow:
            Next

            If timerCount > 3600 Then
                timerCount = 0
            Else
                timerCount += 1
            End If
        End If

        If boilRunning = True Or mashRunning = True Then
            '----Boil/Mash Timer (only run if boil or mash is running)---
            Dim bmTimeRemain, bmTimerSeconds As Integer
            Dim bmMinRemain, bmSecRemain As Integer
            Dim bmTimeDisplay As String

            bmTimerSeconds = Val(txtBMTimer.Text) * 60
            bmTimeRemain = bmTimerSeconds - bmTimerCount

            If bmTimeRemain <= 0 Then
                txtBMRemaining.Invoke(Sub()
                                          txtBMRemaining.Text = "DONE"
                                      End Sub)
                If txtBMRemaining.Text <> "-DONE-" Then
                    My.Computer.Audio.Play(My.Resources.missleAlarm, AudioPlayMode.Background)
                    txtBMRemaining.Invoke(Sub()
                                              txtBMRemaining.Text = "-DONE-"
                                          End Sub)
                End If
            Else
                bmMinRemain = Math.Floor(bmTimeRemain / 60)
                bmSecRemain = bmTimeRemain - (bmMinRemain * 60)
                bmTimeDisplay = bmMinRemain & ":" & IIf(bmSecRemain > 9, bmSecRemain, "0" & bmSecRemain)

                txtBMRemaining.Invoke(Sub()
                                          txtBMRemaining.Text = bmTimeDisplay
                                      End Sub)

                bmTimerCount += 1
            End If
        End If
skipTimers:
        '----Chart Timing (Run all the time)---
        If Charting = True Then
            dtTemp.Rows.Add(chartTimerCount / 60, Val(lblActualTemp.Text.Replace("°", "")))
            tempChart.Invoke(Sub()
                                 tempChart.DataBind()
                             End Sub)

        End If

        chartTimerCount += 1

        sendPostData()

    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        txtSetTemp.Text = Val(txtSetTemp.Text) - 1
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        txtSetTemp.Text = Val(txtSetTemp.Text) + 1
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim request As WebRequest = WebRequest.Create("http://192.168.0.2:80/jsonrpc")
        request.Method = "POST"
        Dim postData As String = "{""jsonrpc"":  ""2.0"", ""method"": ""Application.GetProperties"", ""params"": {""properties"": [""volume""]}, ""id"": ""1""}"
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentType = "application/json"
        request.ContentLength = byteArray.Length
        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()
        Dim response As WebResponse = request.GetResponse
        dataStream = response.GetResponseStream
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd
        Console.WriteLine(responseFromServer)
        reader.Close()
        dataStream.Close()
        response.Close()

        MsgBox(responseFromServer)
    End Sub

    Private Sub btnSaveChart_Click(sender As Object, e As EventArgs) Handles btnSaveChart.Click
        '---Save Chart---
    End Sub

    Private Sub btnBoil_Click(sender As Object, e As EventArgs) Handles btnBoil.Click
        txtSetTemp.Text = "214"
    End Sub

    Private Sub btnMash_Click(sender As Object, e As EventArgs) Handles btnMash.Click
        txtSetTemp.Text = "154"
    End Sub

    Private Sub cmbCom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCom.SelectedIndexChanged

    End Sub

    Private Sub lblActualTemp_Click(sender As Object, e As EventArgs) Handles lblActualTemp.Click

    End Sub

    Private Sub btnClearTimers_Click(sender As Object, e As EventArgs) Handles btnClearTimers.Click, btnClearTimers.Click
        alarmGridView.Rows.Clear()
    End Sub

    Private Sub tabMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabMain.SelectedIndexChanged
        If tabMain.SelectedTab Is toolsTab Then
            If subTable.Rows.Count = 0 Then
                'Table not build yet...build table now
                With subTable.Rows
                    .Add("Admiral", "Target, Northdown, Challenger")
                    .Add("Amarillo", "Cascade, Centennial, Summit, Ahtanum")
                    .Add("Brewers Gold", "Bullion, Chinook, Galena, Nugget")
                    .Add("Bullion", "Columbus, Northern Brewer")
                    .Add("Cascade", "Amarillo, Centennial, Summit")
                    .Add("Centennial", "Amarillo, Cascade, Columbus, Summit")
                    .Add("Challenger", "Perle, Admiral")
                    .Add("Chinook", "Brewers Gold, Columbus, Nugget, Northern Brewer")
                    .Add("Cluster", "Galena, Eroica")
                    .Add("Columbus", "Magnum, Chinook, Northern Brewer, Warrior, Millenium, Bullion")
                    .Add("Crystal", "Mt. Hood, Liberty, Hallertauer, Tettnanger")
                    .Add("E.K. Goldings", "Fuggle, Progress, First Gold")
                    .Add("Eroica", "Galena")
                    .Add("First Gold", "E.K. Goldings")
                    .Add("Fuggle", "Willamette, Styrian Golding, Tettnanger, Newport")
                    .Add("Galena", "Brewers Gold, Nugget, Cluster, Chinook, Newport")
                    .Add("Glacier", "Willamette, Fuggle, Tettnanger")
                    .Add("Hallertau", "Liberty, Tettnanger, Mt. Hood, Crystal")
                    .Add("Horizon", "Magnum")
                    .Add("Liberty", "Hallertau, Tettnanger, Mt. Hood, Crystal, Ultra")
                    .Add("Lublin", "Saaz, Sterling")
                    .Add("Magnum", "Horizon, Newport")
                    .Add("Marynka", "Northern Brewer")
                    .Add("Millenium", "Nugget, Columbus")
                    .Add("Mt. Hood", "Hallertau, Liberty, Crystal")
                    .Add("Northern Brewer", "Nugget, Chinook, Columbus")
                    .Add("Newport", "Galena, Nugget, Fuggle, Magnum")
                    .Add("Northdown", "Admiral, Challenger")
                    .Add("Nugget", "Cluster, Galena, Brewers Gold, Warrior")
                    .Add("Perle", "Challenger, Northern Brewer")
                    .Add("Progress", "Fuggle, E.K. Golding")
                    .Add("Saaz", "Sladek, Lublin, Sterling, Ultra, Vanguard")
                    .Add("Santiam", "Tettnanger, Spalt, Liberty, Hallertau")
                    .Add("Simcoe", "Northern Brewer")
                    .Add("Sladek", "Saaz, Lublin")
                    .Add("Spalt", "Santiam, Liberty, Tettnanger, Hallertau")
                    .Add("Sterling", "Saaz, Lublin")
                    .Add("Strisselspalt", "Mt. Hood, Crystal")
                    .Add("Styrian Aurora", "Northern Brewer")
                    .Add("Styrian Goldings", "Fuggle, Willamette")
                    .Add("Summit", "Amarillo, Cascade")
                    .Add("Target", "Nugget, Fuggle, Willamette, Admiral")
                    .Add("Tettnanger", "Hallertau, Liberty, Fuggle")
                    .Add("Tradition", "Hallertau")
                    .Add("Ultra", "Liberty, Hallertau, Saaz")
                    .Add("Vanguard", "Saaz, Hallertau")
                    .Add("Warrior", "Nugget, Columbus")
                    .Add("Willamette", "Styrian Golding, Target, Fuggle, Tettnanger")
                End With
            End If
        End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHops.SelectedIndexChanged
        Dim result() As DataRow = subTable.Select("Hop = '" & cmbHops.Text & "'")
        Dim hopString As String = result(0)(1)

        lblSubOptions.Text = hopString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim recipePath As String = ""
        Dim ofd As New OpenFileDialog
        ofd.InitialDirectory = "d:\"
        ofd.FileName = "*.xml"
        ofd.FilterIndex = 2
        ofd.RestoreDirectory = True

        If ofd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            recipePath = ofd.FileName
        Else
            GoTo SkipLoad
        End If

        dsRecipe = New DataSet

        dsRecipe.ReadXml(recipePath)
        If recipeTable.Rows.Count = 0 Then
            recipeTable.Columns.Add("Name")
            recipeTable.Columns.Add("Amount")
        End If

        recipeTable.Rows.Clear()
        alarmGridView.Rows.Clear()

        For Each tbl As DataTable In dsRecipe.Tables
            If tbl.TableName = "FERMENTABLE" Then
                For Each row As DataRow In tbl.Rows
                    recipeTable.Rows.Add(row("NAME"), row("DISPLAY_AMOUNT"))
                Next
            End If

            If tbl.TableName = "HOP" Then
                For Each row As DataRow In tbl.Rows
                    alarmGridView.Rows.Add(row("DISPLAY_AMOUNT"), row("TIME"), row("NAME"))
                Next
            End If
        Next

        gvRecipe.DataSource = recipeTable
        gvRecipe.Refresh()
SkipLoad:

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs)
        bmTimerCount = 0
    End Sub

    Private Sub btnMashUp_Click(sender As Object, e As EventArgs) Handles btnMashUp.Click
        txtBMTimer.Text = Val(txtBMTimer.Text) + 5
    End Sub

    Private Sub btnMashDwn_Click(sender As Object, e As EventArgs) Handles btnMashDwn.Click
        txtBMTimer.Text = Val(txtBMTimer.Text) - 5
    End Sub

    Private Sub rbMash_CheckedChanged(sender As Object, e As EventArgs) Handles rbMash.CheckedChanged

    End Sub

    Public Sub sendPostData()
        Dim postData As String = buildJSONstring()

        Try
            Dim request As WebRequest = WebRequest.Create("http://127.0.0.1:8888")
            request.Method = "POST"
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse
            dataStream = response.GetResponseStream
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd
            Console.WriteLine(responseFromServer)
            reader.Close()
            dataStream.Close()
            response.Close()
        Catch
        End Try


    End Sub

    Public Function buildJSONstring()
        Dim jString As String = ""
        Dim hCount As Integer = 0

        'Json String Format = {"Temp":"120","MainTimer":"59:48"}
        jString += "{""temp"":"""
        jString += lblActualTemp.Text.Replace("°", "")
        jString += """,""MainTimer"":"""
        jString += txtBMRemaining.Text
        jString += """"

        For Each row As DataGridViewRow In alarmGridView.Rows
            hCount += 1

            Dim hop As String = row.Cells("Ingredient").Value
            Dim timeLeft As String = row.Cells("clmTimeRemaining").Value

            If hop <> "" Then
                jString += ",""" & hop & "(" & hCount & ")"":""" & timeLeft & """"
            End If
        Next

        jString += "}"

        Return jString
    End Function

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim proc = Process.GetProcessesByName("node")
        For i As Integer = 0 To proc.Count - 1
            proc(i).CloseMainWindow()
        Next
    End Sub

    Private Sub btnPauseTimers_Click(sender As Object, e As EventArgs) Handles btnPauseTimers.Click
        'Pause Timers
        If paused = True Then
            paused = False
            btnPauseTimers.BackColor = Color.Transparent
        Else
            paused = True
            btnPauseTimers.BackColor = Color.Red
        End If

    End Sub
End Class
