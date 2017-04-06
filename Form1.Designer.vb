<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.cmbCom = New System.Windows.Forms.ComboBox()
        Me.txtBaud = New System.Windows.Forms.TextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpDebug = New System.Windows.Forms.GroupBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtSend = New System.Windows.Forms.TextBox()
        Me.txtReturn = New System.Windows.Forms.TextBox()
        Me.lblActualTemp = New System.Windows.Forms.Label()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.liveTab = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbBoil = New System.Windows.Forms.RadioButton()
        Me.rbMash = New System.Windows.Forms.RadioButton()
        Me.btnMashUp = New System.Windows.Forms.Button()
        Me.btnMashDwn = New System.Windows.Forms.Button()
        Me.txtBMRemaining = New System.Windows.Forms.TextBox()
        Me.txtBMTimer = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gvRecipe = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.vBar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnPauseTimers = New System.Windows.Forms.Button()
        Me.btnClearTimers = New System.Windows.Forms.Button()
        Me.btnMash = New System.Windows.Forms.Button()
        Me.btnBoil = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnTimers = New System.Windows.Forms.Button()
        Me.alarmGridView = New System.Windows.Forms.DataGridView()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ingredient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTimeRemaining = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblHeater = New System.Windows.Forms.Label()
        Me.btnSetTemp = New System.Windows.Forms.Button()
        Me.btnHeater = New System.Windows.Forms.Button()
        Me.txtSetTemp = New System.Windows.Forms.TextBox()
        Me.dataTab = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSaveChart = New System.Windows.Forms.Button()
        Me.tempChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.toolsTab = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSubOptions = New System.Windows.Forms.Label()
        Me.cmbHops = New System.Windows.Forms.ComboBox()
        Me.dsHops = New System.Data.DataSet()
        Me.subTable = New System.Data.DataTable()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.settingTab = New System.Windows.Forms.TabPage()
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.txtPerGallon = New System.Windows.Forms.TextBox()
        Me.txtZero = New System.Windows.Forms.TextBox()
        Me.lblReading = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.dsTemp = New System.Data.DataSet()
        Me.dtTemp = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.txtMonitor = New System.Windows.Forms.TextBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.dsRecipe = New System.Data.DataSet()
        Me.GroupBox1.SuspendLayout()
        Me.grpDebug.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.liveTab.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.gvRecipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.alarmGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dataTab.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.tempChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolsTab.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dsHops, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.subTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.settingTab.SuspendLayout()
        CType(Me.dsTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsRecipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCom
        '
        Me.cmbCom.FormattingEnabled = True
        Me.cmbCom.Items.AddRange(New Object() {"COM3"})
        Me.cmbCom.Location = New System.Drawing.Point(6, 30)
        Me.cmbCom.Name = "cmbCom"
        Me.cmbCom.Size = New System.Drawing.Size(90, 33)
        Me.cmbCom.TabIndex = 0
        Me.cmbCom.Text = "COM3"
        '
        'txtBaud
        '
        Me.txtBaud.Location = New System.Drawing.Point(102, 30)
        Me.txtBaud.Name = "txtBaud"
        Me.txtBaud.Size = New System.Drawing.Size(59, 31)
        Me.txtBaud.TabIndex = 1
        Me.txtBaud.Text = "9600"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(167, 27)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(143, 36)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.AutoSize = True
        Me.btnDisconnect.Location = New System.Drawing.Point(316, 28)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(129, 35)
        Me.btnDisconnect.TabIndex = 3
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbCom)
        Me.GroupBox1.Controls.Add(Me.btnDisconnect)
        Me.GroupBox1.Controls.Add(Me.txtBaud)
        Me.GroupBox1.Controls.Add(Me.btnConnect)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 81)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection"
        '
        'grpDebug
        '
        Me.grpDebug.Controls.Add(Me.btnSend)
        Me.grpDebug.Controls.Add(Me.txtSend)
        Me.grpDebug.Controls.Add(Me.txtReturn)
        Me.grpDebug.Location = New System.Drawing.Point(6, 440)
        Me.grpDebug.Name = "grpDebug"
        Me.grpDebug.Size = New System.Drawing.Size(200, 134)
        Me.grpDebug.TabIndex = 5
        Me.grpDebug.TabStop = False
        Me.grpDebug.Text = "Debug"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(119, 46)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 36)
        Me.btnSend.TabIndex = 3
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(6, 49)
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(100, 31)
        Me.txtSend.TabIndex = 0
        '
        'txtReturn
        '
        Me.txtReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReturn.Location = New System.Drawing.Point(6, 86)
        Me.txtReturn.Multiline = True
        Me.txtReturn.Name = "txtReturn"
        Me.txtReturn.Size = New System.Drawing.Size(100, 31)
        Me.txtReturn.TabIndex = 1
        Me.txtReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblActualTemp
        '
        Me.lblActualTemp.BackColor = System.Drawing.Color.Black
        Me.lblActualTemp.Font = New System.Drawing.Font("Engravers MT", 120.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualTemp.ForeColor = System.Drawing.Color.Lime
        Me.lblActualTemp.Location = New System.Drawing.Point(6, 27)
        Me.lblActualTemp.Name = "lblActualTemp"
        Me.lblActualTemp.Size = New System.Drawing.Size(832, 186)
        Me.lblActualTemp.TabIndex = 6
        Me.lblActualTemp.Text = "150.00°"
        Me.lblActualTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblActualTemp.UseCompatibleTextRendering = True
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.liveTab)
        Me.tabMain.Controls.Add(Me.dataTab)
        Me.tabMain.Controls.Add(Me.toolsTab)
        Me.tabMain.Controls.Add(Me.settingTab)
        Me.tabMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.Location = New System.Drawing.Point(12, 12)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(984, 655)
        Me.tabMain.TabIndex = 7
        '
        'liveTab
        '
        Me.liveTab.Controls.Add(Me.GroupBox6)
        Me.liveTab.Controls.Add(Me.btnMashUp)
        Me.liveTab.Controls.Add(Me.btnMashDwn)
        Me.liveTab.Controls.Add(Me.txtBMRemaining)
        Me.liveTab.Controls.Add(Me.txtBMTimer)
        Me.liveTab.Controls.Add(Me.Button1)
        Me.liveTab.Controls.Add(Me.gvRecipe)
        Me.liveTab.Controls.Add(Me.GroupBox5)
        Me.liveTab.Controls.Add(Me.btnPauseTimers)
        Me.liveTab.Controls.Add(Me.btnClearTimers)
        Me.liveTab.Controls.Add(Me.btnMash)
        Me.liveTab.Controls.Add(Me.btnBoil)
        Me.liveTab.Controls.Add(Me.GroupBox2)
        Me.liveTab.Controls.Add(Me.btnUp)
        Me.liveTab.Controls.Add(Me.btnDown)
        Me.liveTab.Controls.Add(Me.btnTimers)
        Me.liveTab.Controls.Add(Me.alarmGridView)
        Me.liveTab.Controls.Add(Me.lblHeater)
        Me.liveTab.Controls.Add(Me.btnSetTemp)
        Me.liveTab.Controls.Add(Me.btnHeater)
        Me.liveTab.Controls.Add(Me.txtSetTemp)
        Me.liveTab.Location = New System.Drawing.Point(4, 34)
        Me.liveTab.Name = "liveTab"
        Me.liveTab.Padding = New System.Windows.Forms.Padding(3)
        Me.liveTab.Size = New System.Drawing.Size(976, 617)
        Me.liveTab.TabIndex = 0
        Me.liveTab.Text = "Live"
        Me.liveTab.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbBoil)
        Me.GroupBox6.Controls.Add(Me.rbMash)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(413, 240)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(184, 61)
        Me.GroupBox6.TabIndex = 29
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Stage"
        '
        'rbBoil
        '
        Me.rbBoil.AutoSize = True
        Me.rbBoil.Location = New System.Drawing.Point(125, 25)
        Me.rbBoil.Name = "rbBoil"
        Me.rbBoil.Size = New System.Drawing.Size(53, 24)
        Me.rbBoil.TabIndex = 0
        Me.rbBoil.TabStop = True
        Me.rbBoil.Text = "Boil"
        Me.rbBoil.UseVisualStyleBackColor = True
        '
        'rbMash
        '
        Me.rbMash.AutoSize = True
        Me.rbMash.Location = New System.Drawing.Point(7, 26)
        Me.rbMash.Name = "rbMash"
        Me.rbMash.Size = New System.Drawing.Size(66, 24)
        Me.rbMash.TabIndex = 0
        Me.rbMash.TabStop = True
        Me.rbMash.Text = "Mash"
        Me.rbMash.UseVisualStyleBackColor = True
        '
        'btnMashUp
        '
        Me.btnMashUp.Location = New System.Drawing.Point(558, 305)
        Me.btnMashUp.Name = "btnMashUp"
        Me.btnMashUp.Size = New System.Drawing.Size(42, 32)
        Me.btnMashUp.TabIndex = 28
        Me.btnMashUp.Text = "+"
        Me.btnMashUp.UseVisualStyleBackColor = True
        '
        'btnMashDwn
        '
        Me.btnMashDwn.Location = New System.Drawing.Point(412, 306)
        Me.btnMashDwn.Name = "btnMashDwn"
        Me.btnMashDwn.Size = New System.Drawing.Size(42, 31)
        Me.btnMashDwn.TabIndex = 28
        Me.btnMashDwn.Text = "-"
        Me.btnMashDwn.UseVisualStyleBackColor = True
        '
        'txtBMRemaining
        '
        Me.txtBMRemaining.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtBMRemaining.Font = New System.Drawing.Font("Minion Pro", 51.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBMRemaining.ForeColor = System.Drawing.Color.Crimson
        Me.txtBMRemaining.Location = New System.Drawing.Point(410, 343)
        Me.txtBMRemaining.Multiline = True
        Me.txtBMRemaining.Name = "txtBMRemaining"
        Me.txtBMRemaining.ReadOnly = True
        Me.txtBMRemaining.Size = New System.Drawing.Size(188, 100)
        Me.txtBMRemaining.TabIndex = 27
        Me.txtBMRemaining.Text = "00:00"
        Me.txtBMRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBMTimer
        '
        Me.txtBMTimer.Location = New System.Drawing.Point(460, 306)
        Me.txtBMTimer.Name = "txtBMTimer"
        Me.txtBMTimer.ReadOnly = True
        Me.txtBMTimer.Size = New System.Drawing.Size(92, 31)
        Me.txtBMTimer.TabIndex = 26
        Me.txtBMTimer.Text = "60"
        Me.txtBMTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(856, 520)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 91)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Import"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gvRecipe
        '
        Me.gvRecipe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvRecipe.Location = New System.Drawing.Point(604, 397)
        Me.gvRecipe.Name = "gvRecipe"
        Me.gvRecipe.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvRecipe.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gvRecipe.Size = New System.Drawing.Size(246, 214)
        Me.gvRecipe.TabIndex = 20
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblVolume)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.vBar)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Location = New System.Drawing.Point(856, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(114, 508)
        Me.GroupBox5.TabIndex = 23
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Volume"
        '
        'lblVolume
        '
        Me.lblVolume.BackColor = System.Drawing.Color.Black
        Me.lblVolume.Font = New System.Drawing.Font("Minion Pro", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolume.ForeColor = System.Drawing.Color.Lime
        Me.lblVolume.Location = New System.Drawing.Point(6, 385)
        Me.lblVolume.Margin = New System.Windows.Forms.Padding(0)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(100, 91)
        Me.lblVolume.TabIndex = 7
        Me.lblVolume.Text = "5.5"
        Me.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 476)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 25)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Gallons"
        '
        'vBar
        '
        Me.vBar.BackColor = System.Drawing.Color.DodgerBlue
        Me.vBar.Enabled = False
        Me.vBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vBar.Location = New System.Drawing.Point(11, 180)
        Me.vBar.Name = "vBar"
        Me.vBar.Size = New System.Drawing.Size(90, 199)
        Me.vBar.TabIndex = 0
        Me.vBar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGray
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(6, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 349)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnPauseTimers
        '
        Me.btnPauseTimers.Location = New System.Drawing.Point(507, 536)
        Me.btnPauseTimers.Name = "btnPauseTimers"
        Me.btnPauseTimers.Size = New System.Drawing.Size(91, 75)
        Me.btnPauseTimers.TabIndex = 22
        Me.btnPauseTimers.Text = "Pause"
        Me.btnPauseTimers.UseVisualStyleBackColor = True
        '
        'btnClearTimers
        '
        Me.btnClearTimers.Location = New System.Drawing.Point(408, 536)
        Me.btnClearTimers.Name = "btnClearTimers"
        Me.btnClearTimers.Size = New System.Drawing.Size(91, 75)
        Me.btnClearTimers.TabIndex = 22
        Me.btnClearTimers.Text = "Clear"
        Me.btnClearTimers.UseVisualStyleBackColor = True
        '
        'btnMash
        '
        Me.btnMash.Location = New System.Drawing.Point(68, 351)
        Me.btnMash.Name = "btnMash"
        Me.btnMash.Size = New System.Drawing.Size(88, 34)
        Me.btnMash.TabIndex = 21
        Me.btnMash.Text = "Mash"
        Me.btnMash.UseVisualStyleBackColor = True
        '
        'btnBoil
        '
        Me.btnBoil.Location = New System.Drawing.Point(68, 240)
        Me.btnBoil.Name = "btnBoil"
        Me.btnBoil.Size = New System.Drawing.Size(88, 34)
        Me.btnBoil.TabIndex = 20
        Me.btnBoil.Text = "Boil"
        Me.btnBoil.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblActualTemp)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(844, 228)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actual Temp"
        '
        'btnUp
        '
        Me.btnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.Location = New System.Drawing.Point(162, 240)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(50, 145)
        Me.btnUp.TabIndex = 18
        Me.btnUp.Text = "+"
        Me.btnUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.Location = New System.Drawing.Point(12, 240)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(50, 145)
        Me.btnDown.TabIndex = 17
        Me.btnDown.Text = "-"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnTimers
        '
        Me.btnTimers.Location = New System.Drawing.Point(410, 449)
        Me.btnTimers.Name = "btnTimers"
        Me.btnTimers.Size = New System.Drawing.Size(189, 81)
        Me.btnTimers.TabIndex = 16
        Me.btnTimers.Text = "Start" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Timers"
        Me.btnTimers.UseVisualStyleBackColor = True
        '
        'alarmGridView
        '
        Me.alarmGridView.AllowUserToResizeColumns = False
        Me.alarmGridView.AllowUserToResizeRows = False
        Me.alarmGridView.ColumnHeadersHeight = 28
        Me.alarmGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.alarmGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Amount, Me.clmTime, Me.Ingredient, Me.clmTimeRemaining})
        Me.alarmGridView.Location = New System.Drawing.Point(12, 391)
        Me.alarmGridView.Name = "alarmGridView"
        Me.alarmGridView.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alarmGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.alarmGridView.Size = New System.Drawing.Size(391, 220)
        Me.alarmGridView.TabIndex = 15
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.Width = 75
        '
        'clmTime
        '
        Me.clmTime.HeaderText = "Time"
        Me.clmTime.Name = "clmTime"
        Me.clmTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmTime.Width = 75
        '
        'Ingredient
        '
        Me.Ingredient.HeaderText = "Ingredient"
        Me.Ingredient.Name = "Ingredient"
        Me.Ingredient.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Ingredient.Width = 125
        '
        'clmTimeRemaining
        '
        Me.clmTimeRemaining.HeaderText = "Remaining"
        Me.clmTimeRemaining.Name = "clmTimeRemaining"
        Me.clmTimeRemaining.ReadOnly = True
        Me.clmTimeRemaining.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmTimeRemaining.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'lblHeater
        '
        Me.lblHeater.BackColor = System.Drawing.Color.Lime
        Me.lblHeater.Location = New System.Drawing.Point(604, 343)
        Me.lblHeater.Name = "lblHeater"
        Me.lblHeater.Size = New System.Drawing.Size(246, 51)
        Me.lblHeater.TabIndex = 14
        '
        'btnSetTemp
        '
        Me.btnSetTemp.Location = New System.Drawing.Point(218, 240)
        Me.btnSetTemp.Name = "btnSetTemp"
        Me.btnSetTemp.Size = New System.Drawing.Size(185, 145)
        Me.btnSetTemp.TabIndex = 13
        Me.btnSetTemp.Text = "SET"
        Me.btnSetTemp.UseVisualStyleBackColor = True
        '
        'btnHeater
        '
        Me.btnHeater.Location = New System.Drawing.Point(604, 240)
        Me.btnHeater.Name = "btnHeater"
        Me.btnHeater.Size = New System.Drawing.Size(246, 97)
        Me.btnHeater.TabIndex = 13
        Me.btnHeater.Text = "HEATER"
        Me.btnHeater.UseVisualStyleBackColor = True
        '
        'txtSetTemp
        '
        Me.txtSetTemp.BackColor = System.Drawing.SystemColors.Window
        Me.txtSetTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSetTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSetTemp.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtSetTemp.Location = New System.Drawing.Point(68, 280)
        Me.txtSetTemp.Name = "txtSetTemp"
        Me.txtSetTemp.Size = New System.Drawing.Size(88, 62)
        Me.txtSetTemp.TabIndex = 9
        Me.txtSetTemp.Text = "154"
        Me.txtSetTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dataTab
        '
        Me.dataTab.Controls.Add(Me.GroupBox3)
        Me.dataTab.Location = New System.Drawing.Point(4, 34)
        Me.dataTab.Name = "dataTab"
        Me.dataTab.Padding = New System.Windows.Forms.Padding(3)
        Me.dataTab.Size = New System.Drawing.Size(976, 617)
        Me.dataTab.TabIndex = 2
        Me.dataTab.Text = "Data"
        Me.dataTab.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSaveChart)
        Me.GroupBox3.Controls.Add(Me.tempChart)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(726, 249)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Temperature"
        '
        'btnSaveChart
        '
        Me.btnSaveChart.Location = New System.Drawing.Point(618, 208)
        Me.btnSaveChart.Name = "btnSaveChart"
        Me.btnSaveChart.Size = New System.Drawing.Size(102, 35)
        Me.btnSaveChart.TabIndex = 1
        Me.btnSaveChart.Text = "Save"
        Me.btnSaveChart.UseVisualStyleBackColor = True
        '
        'tempChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.tempChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Legend1.Title = "Temperature"
        Me.tempChart.Legends.Add(Legend1)
        Me.tempChart.Location = New System.Drawing.Point(6, 30)
        Me.tempChart.Name = "tempChart"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.tempChart.Series.Add(Series1)
        Me.tempChart.Size = New System.Drawing.Size(714, 213)
        Me.tempChart.TabIndex = 0
        Me.tempChart.Text = "Chart1"
        '
        'toolsTab
        '
        Me.toolsTab.Controls.Add(Me.GroupBox4)
        Me.toolsTab.Location = New System.Drawing.Point(4, 34)
        Me.toolsTab.Name = "toolsTab"
        Me.toolsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.toolsTab.Size = New System.Drawing.Size(976, 617)
        Me.toolsTab.TabIndex = 3
        Me.toolsTab.Text = "Tools"
        Me.toolsTab.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.lblSubOptions)
        Me.GroupBox4.Controls.Add(Me.cmbHops)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(726, 128)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Hop Substitution"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hop Variety:"
        '
        'lblSubOptions
        '
        Me.lblSubOptions.AutoSize = True
        Me.lblSubOptions.Location = New System.Drawing.Point(137, 82)
        Me.lblSubOptions.Name = "lblSubOptions"
        Me.lblSubOptions.Size = New System.Drawing.Size(0, 25)
        Me.lblSubOptions.TabIndex = 3
        '
        'cmbHops
        '
        Me.cmbHops.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbHops.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbHops.DataSource = Me.dsHops
        Me.cmbHops.DisplayMember = "subTable.Hop"
        Me.cmbHops.DropDownWidth = 250
        Me.cmbHops.FormattingEnabled = True
        Me.cmbHops.Location = New System.Drawing.Point(142, 33)
        Me.cmbHops.Name = "cmbHops"
        Me.cmbHops.Size = New System.Drawing.Size(218, 33)
        Me.cmbHops.TabIndex = 0
        '
        'dsHops
        '
        Me.dsHops.DataSetName = "NewDataSet"
        Me.dsHops.Tables.AddRange(New System.Data.DataTable() {Me.subTable})
        '
        'subTable
        '
        Me.subTable.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn3, Me.DataColumn4})
        Me.subTable.TableName = "subTable"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Hop"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Substitute"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Substitute:"
        '
        'settingTab
        '
        Me.settingTab.Controls.Add(Me.txtGallons)
        Me.settingTab.Controls.Add(Me.txtPerGallon)
        Me.settingTab.Controls.Add(Me.txtZero)
        Me.settingTab.Controls.Add(Me.lblReading)
        Me.settingTab.Controls.Add(Me.Label7)
        Me.settingTab.Controls.Add(Me.Label6)
        Me.settingTab.Controls.Add(Me.Label5)
        Me.settingTab.Controls.Add(Me.Label4)
        Me.settingTab.Controls.Add(Me.btnTest)
        Me.settingTab.Controls.Add(Me.grpDebug)
        Me.settingTab.Controls.Add(Me.GroupBox1)
        Me.settingTab.Location = New System.Drawing.Point(4, 34)
        Me.settingTab.Name = "settingTab"
        Me.settingTab.Padding = New System.Windows.Forms.Padding(3)
        Me.settingTab.Size = New System.Drawing.Size(976, 617)
        Me.settingTab.TabIndex = 1
        Me.settingTab.Text = "Settings"
        Me.settingTab.UseVisualStyleBackColor = True
        '
        'txtGallons
        '
        Me.txtGallons.Location = New System.Drawing.Point(191, 223)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(100, 31)
        Me.txtGallons.TabIndex = 10
        '
        'txtPerGallon
        '
        Me.txtPerGallon.Location = New System.Drawing.Point(191, 186)
        Me.txtPerGallon.Name = "txtPerGallon"
        Me.txtPerGallon.Size = New System.Drawing.Size(100, 31)
        Me.txtPerGallon.TabIndex = 9
        Me.txtPerGallon.Text = "3785"
        '
        'txtZero
        '
        Me.txtZero.Location = New System.Drawing.Point(191, 149)
        Me.txtZero.Name = "txtZero"
        Me.txtZero.Size = New System.Drawing.Size(100, 31)
        Me.txtZero.TabIndex = 8
        Me.txtZero.Text = "0"
        '
        'lblReading
        '
        Me.lblReading.AutoSize = True
        Me.lblReading.Location = New System.Drawing.Point(199, 103)
        Me.lblReading.Name = "lblReading"
        Me.lblReading.Size = New System.Drawing.Size(33, 25)
        Me.lblReading.TabIndex = 7
        Me.lblReading.Text = "---"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(94, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 25)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Gallons:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(66, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Per Gallon:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(123, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Zero:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Current Readings:"
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(615, 511)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(117, 63)
        Me.btnTest.TabIndex = 6
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'dsTemp
        '
        Me.dsTemp.DataSetName = "NewDataSet"
        Me.dsTemp.Tables.AddRange(New System.Data.DataTable() {Me.dtTemp})
        '
        'dtTemp
        '
        Me.dtTemp.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2})
        Me.dtTemp.TableName = "dtTemp"
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "Time"
        Me.DataColumn1.ColumnName = "timeColumn"
        '
        'DataColumn2
        '
        Me.DataColumn2.Caption = "Temperature"
        Me.DataColumn2.ColumnName = "tempColumn"
        '
        'txtMonitor
        '
        Me.txtMonitor.Location = New System.Drawing.Point(8, 673)
        Me.txtMonitor.Multiline = True
        Me.txtMonitor.Name = "txtMonitor"
        Me.txtMonitor.ReadOnly = True
        Me.txtMonitor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMonitor.Size = New System.Drawing.Size(988, 44)
        Me.txtMonitor.TabIndex = 19
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        Me.SerialPort1.ReadTimeout = 500
        Me.SerialPort1.WriteTimeout = 500
        '
        'dsRecipe
        '
        Me.dsRecipe.DataSetName = "NewDataSet"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.txtMonitor)
        Me.Controls.Add(Me.tabMain)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BrewControl"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpDebug.ResumeLayout(False)
        Me.grpDebug.PerformLayout()
        Me.tabMain.ResumeLayout(False)
        Me.liveTab.ResumeLayout(False)
        Me.liveTab.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.gvRecipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.alarmGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dataTab.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.tempChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolsTab.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dsHops, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.subTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.settingTab.ResumeLayout(False)
        Me.settingTab.PerformLayout()
        CType(Me.dsTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsRecipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbCom As ComboBox
    Friend WithEvents txtBaud As TextBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grpDebug As GroupBox
    Friend WithEvents btnSend As Button
    Friend WithEvents txtReturn As TextBox
    Friend WithEvents txtSend As TextBox
    Friend WithEvents lblActualTemp As Label
    Friend WithEvents tabMain As TabControl
    Friend WithEvents liveTab As TabPage
    Friend WithEvents settingTab As TabPage
    Friend WithEvents txtSetTemp As TextBox
    Friend WithEvents btnHeater As Button
    Friend WithEvents lblHeater As Label
    Friend WithEvents btnSetTemp As Button
    Friend WithEvents alarmGridView As DataGridView
    Friend WithEvents btnTimers As Button
    Friend WithEvents btnUp As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents btnTest As Button
    Friend WithEvents txtMonitor As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dataTab As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tempChart As DataVisualization.Charting.Chart
    Friend WithEvents dsTemp As DataSet
    Friend WithEvents dtTemp As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents toolsTab As TabPage
    Friend WithEvents btnSaveChart As Button
    Friend WithEvents btnBoil As Button
    Friend WithEvents btnMash As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents btnClearTimers As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbHops As ComboBox
    Friend WithEvents dsHops As DataSet
    Friend WithEvents subTable As DataTable
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents lblSubOptions As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblVolume As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents vBar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblReading As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGallons As TextBox
    Friend WithEvents txtPerGallon As TextBox
    Friend WithEvents txtZero As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents gvRecipe As DataGridView
    Friend WithEvents dsRecipe As DataSet
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents clmTime As DataGridViewTextBoxColumn
    Friend WithEvents Ingredient As DataGridViewTextBoxColumn
    Friend WithEvents clmTimeRemaining As DataGridViewTextBoxColumn
    Friend WithEvents btnMashUp As Button
    Friend WithEvents btnMashDwn As Button
    Friend WithEvents txtBMRemaining As TextBox
    Friend WithEvents txtBMTimer As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents rbBoil As RadioButton
    Friend WithEvents rbMash As RadioButton
    Friend WithEvents btnPauseTimers As Button
End Class
