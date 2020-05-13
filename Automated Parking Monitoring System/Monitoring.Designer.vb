<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Monitoring
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Monitoring))
        Me.panelFormContainer = New System.Windows.Forms.Panel()
        Me.panelButtonGroup = New System.Windows.Forms.Panel()
        Me.ButtonsGroup = New System.Windows.Forms.Panel()
        Me.btnMinimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.panelUserControlContainer = New System.Windows.Forms.Panel()
        Me.panelDashBoard = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblCountParkingSlot = New System.Windows.Forms.Label()
        Me.lblRemainingParkingSlot = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblCountParkedIn = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BunifuSeparator7 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BunifuSeparator8 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator6 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAutoID = New System.Windows.Forms.Label()
        Me.lblVehicleID = New System.Windows.Forms.Label()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.lblVehicleType = New System.Windows.Forms.Label()
        Me.lblVehicleName = New System.Windows.Forms.Label()
        Me.lblOperatorName = New System.Windows.Forms.Label()
        Me.lblPlateNo = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnClear = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panelController = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.BunifuSeparator4 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnParkOutAll = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnParkOut = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnParkIn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelTable = New System.Windows.Forms.Panel()
        Me.parkedListTable = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.panelMenuBarContainer = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnParkingSlot = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAccountInformation = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnHistory = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnVehiclesList = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnRegistration = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BunifuSeparator5 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.panelFormContainer.SuspendLayout()
        Me.panelButtonGroup.SuspendLayout()
        Me.ButtonsGroup.SuspendLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelUserControlContainer.SuspendLayout()
        Me.panelDashBoard.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelController.SuspendLayout()
        Me.panelTable.SuspendLayout()
        CType(Me.parkedListTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMenuBarContainer.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelFormContainer
        '
        Me.panelFormContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelFormContainer.Controls.Add(Me.panelButtonGroup)
        Me.panelFormContainer.Controls.Add(Me.panelUserControlContainer)
        Me.panelFormContainer.Controls.Add(Me.panelMenuBarContainer)
        Me.BunifuTransition1.SetDecoration(Me.panelFormContainer, BunifuAnimatorNS.DecorationType.None)
        Me.panelFormContainer.Location = New System.Drawing.Point(2, 2)
        Me.panelFormContainer.Name = "panelFormContainer"
        Me.panelFormContainer.Size = New System.Drawing.Size(1309, 638)
        Me.panelFormContainer.TabIndex = 0
        '
        'panelButtonGroup
        '
        Me.panelButtonGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.panelButtonGroup.Controls.Add(Me.ButtonsGroup)
        Me.panelButtonGroup.Controls.Add(Me.Label10)
        Me.panelButtonGroup.Controls.Add(Me.Label9)
        Me.BunifuTransition1.SetDecoration(Me.panelButtonGroup, BunifuAnimatorNS.DecorationType.None)
        Me.panelButtonGroup.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelButtonGroup.Location = New System.Drawing.Point(198, 0)
        Me.panelButtonGroup.Name = "panelButtonGroup"
        Me.panelButtonGroup.Size = New System.Drawing.Size(1111, 26)
        Me.panelButtonGroup.TabIndex = 1
        '
        'ButtonsGroup
        '
        Me.ButtonsGroup.Controls.Add(Me.btnMinimize)
        Me.ButtonsGroup.Controls.Add(Me.btnClose)
        Me.BunifuTransition1.SetDecoration(Me.ButtonsGroup, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonsGroup.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonsGroup.Location = New System.Drawing.Point(1050, 0)
        Me.ButtonsGroup.Name = "ButtonsGroup"
        Me.ButtonsGroup.Size = New System.Drawing.Size(61, 26)
        Me.ButtonsGroup.TabIndex = 1
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnMinimize, BunifuAnimatorNS.DecorationType.None)
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.ImageActive = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(6, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(23, 23)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimize.TabIndex = 0
        Me.btnMinimize.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnMinimize, "Minimize")
        Me.btnMinimize.Zoom = 10
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnClose, BunifuAnimatorNS.DecorationType.None)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageActive = Nothing
        Me.btnClose.Location = New System.Drawing.Point(34, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(23, 21)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 0
        Me.btnClose.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnClose, "Close")
        Me.btnClose.Zoom = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label10, BunifuAnimatorNS.DecorationType.None)
        Me.Label10.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Silver
        Me.Label10.Location = New System.Drawing.Point(100, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 14)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Work Station"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label9, BunifuAnimatorNS.DecorationType.None)
        Me.Label9.Font = New System.Drawing.Font("Corbel", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(9, 1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 23)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Monitoring"
        '
        'panelUserControlContainer
        '
        Me.panelUserControlContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.panelUserControlContainer.Controls.Add(Me.panelDashBoard)
        Me.panelUserControlContainer.Controls.Add(Me.Panel1)
        Me.panelUserControlContainer.Controls.Add(Me.panelController)
        Me.panelUserControlContainer.Controls.Add(Me.panelTable)
        Me.BunifuTransition1.SetDecoration(Me.panelUserControlContainer, BunifuAnimatorNS.DecorationType.None)
        Me.panelUserControlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelUserControlContainer.Location = New System.Drawing.Point(198, 0)
        Me.panelUserControlContainer.Name = "panelUserControlContainer"
        Me.panelUserControlContainer.Size = New System.Drawing.Size(1111, 638)
        Me.panelUserControlContainer.TabIndex = 1
        '
        'panelDashBoard
        '
        Me.panelDashBoard.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.panelDashBoard.Controls.Add(Me.PictureBox2)
        Me.panelDashBoard.Controls.Add(Me.Label17)
        Me.panelDashBoard.Controls.Add(Me.lblCountParkingSlot)
        Me.panelDashBoard.Controls.Add(Me.lblRemainingParkingSlot)
        Me.panelDashBoard.Controls.Add(Me.Label18)
        Me.panelDashBoard.Controls.Add(Me.lblCountParkedIn)
        Me.panelDashBoard.Controls.Add(Me.Label14)
        Me.panelDashBoard.Controls.Add(Me.BunifuSeparator7)
        Me.panelDashBoard.Controls.Add(Me.Label13)
        Me.panelDashBoard.Controls.Add(Me.BunifuSeparator8)
        Me.panelDashBoard.Controls.Add(Me.BunifuSeparator6)
        Me.BunifuTransition1.SetDecoration(Me.panelDashBoard, BunifuAnimatorNS.DecorationType.None)
        Me.panelDashBoard.Location = New System.Drawing.Point(-1, 161)
        Me.panelDashBoard.Name = "panelDashBoard"
        Me.panelDashBoard.Size = New System.Drawing.Size(500, 82)
        Me.panelDashBoard.TabIndex = 4
        '
        'PictureBox2
        '
        Me.BunifuTransition1.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(42, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label17, BunifuAnimatorNS.DecorationType.None)
        Me.Label17.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(412, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 17)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Parking Slot"
        '
        'lblCountParkingSlot
        '
        Me.BunifuTransition1.SetDecoration(Me.lblCountParkingSlot, BunifuAnimatorNS.DecorationType.None)
        Me.lblCountParkingSlot.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountParkingSlot.ForeColor = System.Drawing.Color.Silver
        Me.lblCountParkingSlot.Location = New System.Drawing.Point(417, 35)
        Me.lblCountParkingSlot.Name = "lblCountParkingSlot"
        Me.lblCountParkingSlot.Size = New System.Drawing.Size(67, 39)
        Me.lblCountParkingSlot.TabIndex = 2
        Me.lblCountParkingSlot.Text = "0"
        Me.lblCountParkingSlot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRemainingParkingSlot
        '
        Me.BunifuTransition1.SetDecoration(Me.lblRemainingParkingSlot, BunifuAnimatorNS.DecorationType.None)
        Me.lblRemainingParkingSlot.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemainingParkingSlot.ForeColor = System.Drawing.Color.Red
        Me.lblRemainingParkingSlot.Location = New System.Drawing.Point(278, 34)
        Me.lblRemainingParkingSlot.Name = "lblRemainingParkingSlot"
        Me.lblRemainingParkingSlot.Size = New System.Drawing.Size(67, 39)
        Me.lblRemainingParkingSlot.TabIndex = 2
        Me.lblRemainingParkingSlot.Text = "0"
        Me.lblRemainingParkingSlot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label18, BunifuAnimatorNS.DecorationType.None)
        Me.Label18.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(242, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(142, 17)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Remaining Parking Slot"
        '
        'lblCountParkedIn
        '
        Me.BunifuTransition1.SetDecoration(Me.lblCountParkedIn, BunifuAnimatorNS.DecorationType.None)
        Me.lblCountParkedIn.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountParkedIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.lblCountParkedIn.Location = New System.Drawing.Point(145, 34)
        Me.lblCountParkedIn.Name = "lblCountParkedIn"
        Me.lblCountParkedIn.Size = New System.Drawing.Size(67, 39)
        Me.lblCountParkedIn.TabIndex = 2
        Me.lblCountParkedIn.Text = "0"
        Me.lblCountParkedIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label14, BunifuAnimatorNS.DecorationType.None)
        Me.Label14.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(148, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 17)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Parked In"
        '
        'BunifuSeparator7
        '
        Me.BunifuSeparator7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuSeparator7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BunifuSeparator7.LineThickness = 2
        Me.BunifuSeparator7.Location = New System.Drawing.Point(396, 0)
        Me.BunifuSeparator7.Name = "BunifuSeparator7"
        Me.BunifuSeparator7.Size = New System.Drawing.Size(10, 81)
        Me.BunifuSeparator7.TabIndex = 7
        Me.BunifuSeparator7.Transparency = 255
        Me.BunifuSeparator7.Vertical = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label13, BunifuAnimatorNS.DecorationType.None)
        Me.Label13.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(29, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 17)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Dash Board"
        '
        'BunifuSeparator8
        '
        Me.BunifuSeparator8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuSeparator8, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuSeparator8.LineColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BunifuSeparator8.LineThickness = 2
        Me.BunifuSeparator8.Location = New System.Drawing.Point(125, 1)
        Me.BunifuSeparator8.Name = "BunifuSeparator8"
        Me.BunifuSeparator8.Size = New System.Drawing.Size(10, 81)
        Me.BunifuSeparator8.TabIndex = 7
        Me.BunifuSeparator8.Transparency = 255
        Me.BunifuSeparator8.Vertical = True
        '
        'BunifuSeparator6
        '
        Me.BunifuSeparator6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuSeparator6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BunifuSeparator6.LineThickness = 2
        Me.BunifuSeparator6.Location = New System.Drawing.Point(222, 3)
        Me.BunifuSeparator6.Name = "BunifuSeparator6"
        Me.BunifuSeparator6.Size = New System.Drawing.Size(10, 81)
        Me.BunifuSeparator6.TabIndex = 7
        Me.BunifuSeparator6.Transparency = 255
        Me.BunifuSeparator6.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblAutoID)
        Me.Panel1.Controls.Add(Me.lblVehicleID)
        Me.Panel1.Controls.Add(Me.BunifuSeparator3)
        Me.Panel1.Controls.Add(Me.BunifuSeparator2)
        Me.Panel1.Controls.Add(Me.lblVehicleType)
        Me.Panel1.Controls.Add(Me.lblVehicleName)
        Me.Panel1.Controls.Add(Me.lblOperatorName)
        Me.Panel1.Controls.Add(Me.lblPlateNo)
        Me.Panel1.Controls.Add(Me.BunifuSeparator1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(-1, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 132)
        Me.Panel1.TabIndex = 3
        '
        'lblAutoID
        '
        Me.lblAutoID.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.lblAutoID, BunifuAnimatorNS.DecorationType.None)
        Me.lblAutoID.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutoID.ForeColor = System.Drawing.Color.Silver
        Me.lblAutoID.Location = New System.Drawing.Point(262, 8)
        Me.lblAutoID.Name = "lblAutoID"
        Me.lblAutoID.Size = New System.Drawing.Size(22, 26)
        Me.lblAutoID.TabIndex = 8
        Me.lblAutoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAutoID.Visible = False
        '
        'lblVehicleID
        '
        Me.lblVehicleID.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.lblVehicleID, BunifuAnimatorNS.DecorationType.None)
        Me.lblVehicleID.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehicleID.ForeColor = System.Drawing.Color.Silver
        Me.lblVehicleID.Location = New System.Drawing.Point(287, 8)
        Me.lblVehicleID.Name = "lblVehicleID"
        Me.lblVehicleID.Size = New System.Drawing.Size(20, 26)
        Me.lblVehicleID.TabIndex = 8
        Me.lblVehicleID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblVehicleID.Visible = False
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuSeparator3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(384, 50)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(10, 81)
        Me.BunifuSeparator3.TabIndex = 7
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = True
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuSeparator2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(265, 48)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(10, 83)
        Me.BunifuSeparator2.TabIndex = 7
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = True
        '
        'lblVehicleType
        '
        Me.lblVehicleType.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.lblVehicleType, BunifuAnimatorNS.DecorationType.None)
        Me.lblVehicleType.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehicleType.ForeColor = System.Drawing.Color.Orange
        Me.lblVehicleType.Location = New System.Drawing.Point(397, 74)
        Me.lblVehicleType.Name = "lblVehicleType"
        Me.lblVehicleType.Size = New System.Drawing.Size(100, 26)
        Me.lblVehicleType.TabIndex = 2
        Me.lblVehicleType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVehicleName
        '
        Me.lblVehicleName.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.lblVehicleName, BunifuAnimatorNS.DecorationType.None)
        Me.lblVehicleName.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehicleName.ForeColor = System.Drawing.Color.Orange
        Me.lblVehicleName.Location = New System.Drawing.Point(279, 74)
        Me.lblVehicleName.Name = "lblVehicleName"
        Me.lblVehicleName.Size = New System.Drawing.Size(103, 26)
        Me.lblVehicleName.TabIndex = 2
        Me.lblVehicleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOperatorName
        '
        Me.lblOperatorName.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.lblOperatorName, BunifuAnimatorNS.DecorationType.None)
        Me.lblOperatorName.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperatorName.ForeColor = System.Drawing.Color.Orange
        Me.lblOperatorName.Location = New System.Drawing.Point(104, 74)
        Me.lblOperatorName.Name = "lblOperatorName"
        Me.lblOperatorName.Size = New System.Drawing.Size(159, 26)
        Me.lblOperatorName.TabIndex = 2
        Me.lblOperatorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPlateNo
        '
        Me.lblPlateNo.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.lblPlateNo, BunifuAnimatorNS.DecorationType.None)
        Me.lblPlateNo.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlateNo.ForeColor = System.Drawing.Color.Orange
        Me.lblPlateNo.Location = New System.Drawing.Point(3, 74)
        Me.lblPlateNo.Name = "lblPlateNo"
        Me.lblPlateNo.Size = New System.Drawing.Size(85, 26)
        Me.lblPlateNo.TabIndex = 2
        Me.lblPlateNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuSeparator1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(92, 50)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(10, 81)
        Me.BunifuSeparator1.TabIndex = 7
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(396, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 17)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Vehicle Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(281, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Vehicle Name"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnClear, BunifuAnimatorNS.DecorationType.None)
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageActive = Nothing
        Me.btnClear.Location = New System.Drawing.Point(458, -1)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(42, 40)
        Me.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnClear.TabIndex = 0
        Me.btnClear.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnClear, "Clear")
        Me.btnClear.Zoom = 5
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtSearch.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtSearch.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtSearch.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtSearch.BorderThickness = 1
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txtSearch, BunifuAnimatorNS.DecorationType.None)
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.White
        Me.txtSearch.isPassword = False
        Me.txtSearch.Location = New System.Drawing.Point(309, 0)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(150, 39)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ToolTip1.SetToolTip(Me.txtSearch, "Search Plate Number")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(107, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Operator Name"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(500, 39)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Vehicle Information"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Plate No."
        '
        'panelController
        '
        Me.panelController.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.panelController.Controls.Add(Me.lblTime)
        Me.panelController.Controls.Add(Me.BunifuSeparator4)
        Me.panelController.Controls.Add(Me.Label5)
        Me.panelController.Controls.Add(Me.lblDate)
        Me.panelController.Controls.Add(Me.Label3)
        Me.panelController.Controls.Add(Me.btnParkOutAll)
        Me.panelController.Controls.Add(Me.btnParkOut)
        Me.panelController.Controls.Add(Me.btnParkIn)
        Me.panelController.Controls.Add(Me.Label1)
        Me.BunifuTransition1.SetDecoration(Me.panelController, BunifuAnimatorNS.DecorationType.None)
        Me.panelController.Location = New System.Drawing.Point(500, 28)
        Me.panelController.Name = "panelController"
        Me.panelController.Size = New System.Drawing.Size(608, 215)
        Me.panelController.TabIndex = 1
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.lblTime, BunifuAnimatorNS.DecorationType.None)
        Me.lblTime.Font = New System.Drawing.Font("BrowalliaUPC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.LightGray
        Me.lblTime.Location = New System.Drawing.Point(32, 152)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.lblTime.Size = New System.Drawing.Size(327, 42)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuSeparator4
        '
        Me.BunifuSeparator4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuSeparator4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuSeparator4.LineThickness = 1
        Me.BunifuSeparator4.Location = New System.Drawing.Point(382, 44)
        Me.BunifuSeparator4.Name = "BunifuSeparator4"
        Me.BunifuSeparator4.Size = New System.Drawing.Size(10, 167)
        Me.BunifuSeparator4.TabIndex = 7
        Me.BunifuSeparator4.Transparency = 255
        Me.BunifuSeparator4.Vertical = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(32, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Time"
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.lblDate, BunifuAnimatorNS.DecorationType.None)
        Me.lblDate.Font = New System.Drawing.Font("BrowalliaUPC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.LightGray
        Me.lblDate.Location = New System.Drawing.Point(32, 76)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.lblDate.Size = New System.Drawing.Size(327, 42)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(32, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date"
        '
        'btnParkOutAll
        '
        Me.btnParkOutAll.Activecolor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnParkOutAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnParkOutAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnParkOutAll.BorderRadius = 0
        Me.btnParkOutAll.ButtonText = "PARK OUT ALL"
        Me.btnParkOutAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnParkOutAll, BunifuAnimatorNS.DecorationType.None)
        Me.btnParkOutAll.DisabledColor = System.Drawing.Color.Gray
        Me.btnParkOutAll.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParkOutAll.Iconcolor = System.Drawing.Color.Transparent
        Me.btnParkOutAll.Iconimage = CType(resources.GetObject("btnParkOutAll.Iconimage"), System.Drawing.Image)
        Me.btnParkOutAll.Iconimage_right = Nothing
        Me.btnParkOutAll.Iconimage_right_Selected = Nothing
        Me.btnParkOutAll.Iconimage_Selected = Nothing
        Me.btnParkOutAll.IconMarginLeft = 0
        Me.btnParkOutAll.IconMarginRight = 0
        Me.btnParkOutAll.IconRightVisible = True
        Me.btnParkOutAll.IconRightZoom = 0R
        Me.btnParkOutAll.IconVisible = True
        Me.btnParkOutAll.IconZoom = 90.0R
        Me.btnParkOutAll.IsTab = False
        Me.btnParkOutAll.Location = New System.Drawing.Point(418, 155)
        Me.btnParkOutAll.Name = "btnParkOutAll"
        Me.btnParkOutAll.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnParkOutAll.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnParkOutAll.OnHoverTextColor = System.Drawing.Color.White
        Me.btnParkOutAll.selected = False
        Me.btnParkOutAll.Size = New System.Drawing.Size(166, 48)
        Me.btnParkOutAll.TabIndex = 4
        Me.btnParkOutAll.Text = "PARK OUT ALL"
        Me.btnParkOutAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnParkOutAll.Textcolor = System.Drawing.Color.White
        Me.btnParkOutAll.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnParkOut
        '
        Me.btnParkOut.Activecolor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnParkOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnParkOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnParkOut.BorderRadius = 0
        Me.btnParkOut.ButtonText = "PARK OUT"
        Me.btnParkOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnParkOut, BunifuAnimatorNS.DecorationType.None)
        Me.btnParkOut.DisabledColor = System.Drawing.Color.Gray
        Me.btnParkOut.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParkOut.Iconcolor = System.Drawing.Color.Transparent
        Me.btnParkOut.Iconimage = CType(resources.GetObject("btnParkOut.Iconimage"), System.Drawing.Image)
        Me.btnParkOut.Iconimage_right = Nothing
        Me.btnParkOut.Iconimage_right_Selected = Nothing
        Me.btnParkOut.Iconimage_Selected = Nothing
        Me.btnParkOut.IconMarginLeft = 0
        Me.btnParkOut.IconMarginRight = 0
        Me.btnParkOut.IconRightVisible = True
        Me.btnParkOut.IconRightZoom = 0R
        Me.btnParkOut.IconVisible = True
        Me.btnParkOut.IconZoom = 90.0R
        Me.btnParkOut.IsTab = False
        Me.btnParkOut.Location = New System.Drawing.Point(418, 101)
        Me.btnParkOut.Name = "btnParkOut"
        Me.btnParkOut.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnParkOut.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnParkOut.OnHoverTextColor = System.Drawing.Color.White
        Me.btnParkOut.selected = False
        Me.btnParkOut.Size = New System.Drawing.Size(166, 48)
        Me.btnParkOut.TabIndex = 3
        Me.btnParkOut.Text = "PARK OUT"
        Me.btnParkOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnParkOut.Textcolor = System.Drawing.Color.White
        Me.btnParkOut.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnParkIn
        '
        Me.btnParkIn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnParkIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnParkIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnParkIn.BorderRadius = 0
        Me.btnParkIn.ButtonText = "PARK IN"
        Me.btnParkIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnParkIn, BunifuAnimatorNS.DecorationType.None)
        Me.btnParkIn.DisabledColor = System.Drawing.Color.Gray
        Me.btnParkIn.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParkIn.Iconcolor = System.Drawing.Color.Transparent
        Me.btnParkIn.Iconimage = CType(resources.GetObject("btnParkIn.Iconimage"), System.Drawing.Image)
        Me.btnParkIn.Iconimage_right = Nothing
        Me.btnParkIn.Iconimage_right_Selected = Nothing
        Me.btnParkIn.Iconimage_Selected = Nothing
        Me.btnParkIn.IconMarginLeft = 0
        Me.btnParkIn.IconMarginRight = 0
        Me.btnParkIn.IconRightVisible = True
        Me.btnParkIn.IconRightZoom = 0R
        Me.btnParkIn.IconVisible = True
        Me.btnParkIn.IconZoom = 90.0R
        Me.btnParkIn.IsTab = False
        Me.btnParkIn.Location = New System.Drawing.Point(418, 47)
        Me.btnParkIn.Name = "btnParkIn"
        Me.btnParkIn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnParkIn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnParkIn.OnHoverTextColor = System.Drawing.Color.White
        Me.btnParkIn.selected = False
        Me.btnParkIn.Size = New System.Drawing.Size(166, 48)
        Me.btnParkIn.TabIndex = 2
        Me.btnParkIn.Text = "PARK IN"
        Me.btnParkIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnParkIn.Textcolor = System.Drawing.Color.White
        Me.btnParkIn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(608, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Parking Lot Controller"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelTable
        '
        Me.panelTable.Controls.Add(Me.parkedListTable)
        Me.BunifuTransition1.SetDecoration(Me.panelTable, BunifuAnimatorNS.DecorationType.None)
        Me.panelTable.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelTable.Location = New System.Drawing.Point(0, 245)
        Me.panelTable.Name = "panelTable"
        Me.panelTable.Size = New System.Drawing.Size(1111, 393)
        Me.panelTable.TabIndex = 0
        '
        'parkedListTable
        '
        Me.parkedListTable.AllowUserToAddRows = False
        Me.parkedListTable.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.parkedListTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.parkedListTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.parkedListTable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.parkedListTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.parkedListTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.parkedListTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.parkedListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuTransition1.SetDecoration(Me.parkedListTable, BunifuAnimatorNS.DecorationType.None)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.parkedListTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.parkedListTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.parkedListTable.DoubleBuffered = True
        Me.parkedListTable.EnableHeadersVisualStyles = False
        Me.parkedListTable.GridColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.parkedListTable.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.parkedListTable.HeaderForeColor = System.Drawing.Color.White
        Me.parkedListTable.Location = New System.Drawing.Point(0, 0)
        Me.parkedListTable.Name = "parkedListTable"
        Me.parkedListTable.ReadOnly = True
        Me.parkedListTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.parkedListTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        Me.parkedListTable.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.parkedListTable.Size = New System.Drawing.Size(1111, 393)
        Me.parkedListTable.TabIndex = 0
        '
        'panelMenuBarContainer
        '
        Me.panelMenuBarContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.panelMenuBarContainer.Controls.Add(Me.PictureBox1)
        Me.panelMenuBarContainer.Controls.Add(Me.Label11)
        Me.panelMenuBarContainer.Controls.Add(Me.Label12)
        Me.panelMenuBarContainer.Controls.Add(Me.btnParkingSlot)
        Me.panelMenuBarContainer.Controls.Add(Me.btnAccountInformation)
        Me.panelMenuBarContainer.Controls.Add(Me.btnHistory)
        Me.panelMenuBarContainer.Controls.Add(Me.btnVehiclesList)
        Me.panelMenuBarContainer.Controls.Add(Me.btnRegistration)
        Me.panelMenuBarContainer.Controls.Add(Me.Label16)
        Me.panelMenuBarContainer.Controls.Add(Me.Label15)
        Me.panelMenuBarContainer.Controls.Add(Me.BunifuSeparator5)
        Me.BunifuTransition1.SetDecoration(Me.panelMenuBarContainer, BunifuAnimatorNS.DecorationType.None)
        Me.panelMenuBarContainer.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenuBarContainer.Location = New System.Drawing.Point(0, 0)
        Me.panelMenuBarContainer.Name = "panelMenuBarContainer"
        Me.panelMenuBarContainer.Size = New System.Drawing.Size(198, 638)
        Me.panelMenuBarContainer.TabIndex = 0
        '
        'PictureBox1
        '
        Me.BunifuTransition1.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label11, BunifuAnimatorNS.DecorationType.None)
        Me.Label11.Font = New System.Drawing.Font("Corbel", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Silver
        Me.Label11.Location = New System.Drawing.Point(66, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "VEOSCRIPT"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label12, BunifuAnimatorNS.DecorationType.None)
        Me.Label12.Font = New System.Drawing.Font("Corbel", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(64, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 23)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Work Station"
        '
        'btnParkingSlot
        '
        Me.btnParkingSlot.Activecolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnParkingSlot.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnParkingSlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnParkingSlot.BorderRadius = 0
        Me.btnParkingSlot.ButtonText = "PARKING SLOT"
        Me.btnParkingSlot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnParkingSlot, BunifuAnimatorNS.DecorationType.None)
        Me.btnParkingSlot.DisabledColor = System.Drawing.Color.Gray
        Me.btnParkingSlot.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParkingSlot.Iconcolor = System.Drawing.Color.Transparent
        Me.btnParkingSlot.Iconimage = CType(resources.GetObject("btnParkingSlot.Iconimage"), System.Drawing.Image)
        Me.btnParkingSlot.Iconimage_right = Nothing
        Me.btnParkingSlot.Iconimage_right_Selected = Nothing
        Me.btnParkingSlot.Iconimage_Selected = Nothing
        Me.btnParkingSlot.IconMarginLeft = 0
        Me.btnParkingSlot.IconMarginRight = 0
        Me.btnParkingSlot.IconRightVisible = True
        Me.btnParkingSlot.IconRightZoom = 0R
        Me.btnParkingSlot.IconVisible = True
        Me.btnParkingSlot.IconZoom = 90.0R
        Me.btnParkingSlot.IsTab = False
        Me.btnParkingSlot.Location = New System.Drawing.Point(0, 357)
        Me.btnParkingSlot.Name = "btnParkingSlot"
        Me.btnParkingSlot.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnParkingSlot.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnParkingSlot.OnHoverTextColor = System.Drawing.Color.White
        Me.btnParkingSlot.selected = False
        Me.btnParkingSlot.Size = New System.Drawing.Size(198, 89)
        Me.btnParkingSlot.TabIndex = 9
        Me.btnParkingSlot.Text = "PARKING SLOT"
        Me.btnParkingSlot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnParkingSlot.Textcolor = System.Drawing.Color.White
        Me.btnParkingSlot.TextFont = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAccountInformation
        '
        Me.btnAccountInformation.Activecolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnAccountInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnAccountInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAccountInformation.BorderRadius = 0
        Me.btnAccountInformation.ButtonText = "ACCOUNT INFORMATION"
        Me.btnAccountInformation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnAccountInformation, BunifuAnimatorNS.DecorationType.None)
        Me.btnAccountInformation.DisabledColor = System.Drawing.Color.Gray
        Me.btnAccountInformation.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountInformation.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAccountInformation.Iconimage = CType(resources.GetObject("btnAccountInformation.Iconimage"), System.Drawing.Image)
        Me.btnAccountInformation.Iconimage_right = Nothing
        Me.btnAccountInformation.Iconimage_right_Selected = Nothing
        Me.btnAccountInformation.Iconimage_Selected = Nothing
        Me.btnAccountInformation.IconMarginLeft = 0
        Me.btnAccountInformation.IconMarginRight = 0
        Me.btnAccountInformation.IconRightVisible = True
        Me.btnAccountInformation.IconRightZoom = 0R
        Me.btnAccountInformation.IconVisible = True
        Me.btnAccountInformation.IconZoom = 90.0R
        Me.btnAccountInformation.IsTab = False
        Me.btnAccountInformation.Location = New System.Drawing.Point(0, 449)
        Me.btnAccountInformation.Name = "btnAccountInformation"
        Me.btnAccountInformation.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnAccountInformation.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnAccountInformation.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAccountInformation.selected = False
        Me.btnAccountInformation.Size = New System.Drawing.Size(198, 89)
        Me.btnAccountInformation.TabIndex = 9
        Me.btnAccountInformation.Text = "ACCOUNT INFORMATION"
        Me.btnAccountInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccountInformation.Textcolor = System.Drawing.Color.White
        Me.btnAccountInformation.TextFont = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnHistory
        '
        Me.btnHistory.Activecolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHistory.BorderRadius = 0
        Me.btnHistory.ButtonText = "HISTORY"
        Me.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnHistory, BunifuAnimatorNS.DecorationType.None)
        Me.btnHistory.DisabledColor = System.Drawing.Color.Gray
        Me.btnHistory.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.Iconcolor = System.Drawing.Color.Transparent
        Me.btnHistory.Iconimage = CType(resources.GetObject("btnHistory.Iconimage"), System.Drawing.Image)
        Me.btnHistory.Iconimage_right = Nothing
        Me.btnHistory.Iconimage_right_Selected = Nothing
        Me.btnHistory.Iconimage_Selected = Nothing
        Me.btnHistory.IconMarginLeft = 0
        Me.btnHistory.IconMarginRight = 0
        Me.btnHistory.IconRightVisible = True
        Me.btnHistory.IconRightZoom = 0R
        Me.btnHistory.IconVisible = True
        Me.btnHistory.IconZoom = 90.0R
        Me.btnHistory.IsTab = False
        Me.btnHistory.Location = New System.Drawing.Point(0, 268)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnHistory.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnHistory.OnHoverTextColor = System.Drawing.Color.White
        Me.btnHistory.selected = False
        Me.btnHistory.Size = New System.Drawing.Size(198, 89)
        Me.btnHistory.TabIndex = 8
        Me.btnHistory.Text = "HISTORY"
        Me.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistory.Textcolor = System.Drawing.Color.White
        Me.btnHistory.TextFont = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnVehiclesList
        '
        Me.btnVehiclesList.Activecolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnVehiclesList.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnVehiclesList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVehiclesList.BorderRadius = 0
        Me.btnVehiclesList.ButtonText = "VEHICLES LIST"
        Me.btnVehiclesList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnVehiclesList, BunifuAnimatorNS.DecorationType.None)
        Me.btnVehiclesList.DisabledColor = System.Drawing.Color.Gray
        Me.btnVehiclesList.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVehiclesList.Iconcolor = System.Drawing.Color.Transparent
        Me.btnVehiclesList.Iconimage = CType(resources.GetObject("btnVehiclesList.Iconimage"), System.Drawing.Image)
        Me.btnVehiclesList.Iconimage_right = Nothing
        Me.btnVehiclesList.Iconimage_right_Selected = Nothing
        Me.btnVehiclesList.Iconimage_Selected = Nothing
        Me.btnVehiclesList.IconMarginLeft = 0
        Me.btnVehiclesList.IconMarginRight = 0
        Me.btnVehiclesList.IconRightVisible = True
        Me.btnVehiclesList.IconRightZoom = 0R
        Me.btnVehiclesList.IconVisible = True
        Me.btnVehiclesList.IconZoom = 90.0R
        Me.btnVehiclesList.IsTab = False
        Me.btnVehiclesList.Location = New System.Drawing.Point(0, 178)
        Me.btnVehiclesList.Name = "btnVehiclesList"
        Me.btnVehiclesList.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnVehiclesList.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnVehiclesList.OnHoverTextColor = System.Drawing.Color.White
        Me.btnVehiclesList.selected = False
        Me.btnVehiclesList.Size = New System.Drawing.Size(198, 89)
        Me.btnVehiclesList.TabIndex = 7
        Me.btnVehiclesList.Text = "VEHICLES LIST"
        Me.btnVehiclesList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVehiclesList.Textcolor = System.Drawing.Color.White
        Me.btnVehiclesList.TextFont = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnRegistration
        '
        Me.btnRegistration.Activecolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnRegistration.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegistration.BorderRadius = 0
        Me.btnRegistration.ButtonText = "REGISTRATION"
        Me.btnRegistration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnRegistration, BunifuAnimatorNS.DecorationType.None)
        Me.btnRegistration.DisabledColor = System.Drawing.Color.Gray
        Me.btnRegistration.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistration.Iconcolor = System.Drawing.Color.Transparent
        Me.btnRegistration.Iconimage = CType(resources.GetObject("btnRegistration.Iconimage"), System.Drawing.Image)
        Me.btnRegistration.Iconimage_right = Nothing
        Me.btnRegistration.Iconimage_right_Selected = Nothing
        Me.btnRegistration.Iconimage_Selected = Nothing
        Me.btnRegistration.IconMarginLeft = 0
        Me.btnRegistration.IconMarginRight = 0
        Me.btnRegistration.IconRightVisible = True
        Me.btnRegistration.IconRightZoom = 0R
        Me.btnRegistration.IconVisible = True
        Me.btnRegistration.IconZoom = 90.0R
        Me.btnRegistration.IsTab = False
        Me.btnRegistration.Location = New System.Drawing.Point(0, 88)
        Me.btnRegistration.Name = "btnRegistration"
        Me.btnRegistration.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnRegistration.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnRegistration.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRegistration.selected = False
        Me.btnRegistration.Size = New System.Drawing.Size(198, 89)
        Me.btnRegistration.TabIndex = 6
        Me.btnRegistration.Text = "REGISTRATION"
        Me.btnRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistration.Textcolor = System.Drawing.Color.White
        Me.btnRegistration.TextFont = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label16, BunifuAnimatorNS.DecorationType.None)
        Me.Label16.Font = New System.Drawing.Font("Calibri", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Silver
        Me.Label16.Location = New System.Drawing.Point(45, 613)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Designed and Developed"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label15, BunifuAnimatorNS.DecorationType.None)
        Me.Label15.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Silver
        Me.Label15.Location = New System.Drawing.Point(59, 593)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 17)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "VEOSCRIPT"
        '
        'BunifuSeparator5
        '
        Me.BunifuSeparator5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuSeparator5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BunifuSeparator5.LineThickness = 1
        Me.BunifuSeparator5.Location = New System.Drawing.Point(19, 63)
        Me.BunifuSeparator5.Name = "BunifuSeparator5"
        Me.BunifuSeparator5.Size = New System.Drawing.Size(155, 10)
        Me.BunifuSeparator5.TabIndex = 7
        Me.BunifuSeparator5.Transparency = 255
        Me.BunifuSeparator5.Vertical = False
        '
        'Timer1
        '
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.panelButtonGroup
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.panelMenuBarContainer
        Me.BunifuDragControl2.Vertical = True
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 20
        Animation1.Padding = New System.Windows.Forms.Padding(30)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 10
        Me.BunifuElipse1.TargetControl = Me.lblDate
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 10
        Me.BunifuElipse2.TargetControl = Me.lblTime
        '
        'Monitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1313, 642)
        Me.Controls.Add(Me.panelFormContainer)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.BottomMirror)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Monitoring"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Work Station"
        Me.panelFormContainer.ResumeLayout(False)
        Me.panelButtonGroup.ResumeLayout(False)
        Me.panelButtonGroup.PerformLayout()
        Me.ButtonsGroup.ResumeLayout(False)
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelUserControlContainer.ResumeLayout(False)
        Me.panelDashBoard.ResumeLayout(False)
        Me.panelDashBoard.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelController.ResumeLayout(False)
        Me.panelController.PerformLayout()
        Me.panelTable.ResumeLayout(False)
        CType(Me.parkedListTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMenuBarContainer.ResumeLayout(False)
        Me.panelMenuBarContainer.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelFormContainer As Panel
    Friend WithEvents panelMenuBarContainer As Panel
    Friend WithEvents panelButtonGroup As Panel
    Friend WithEvents panelUserControlContainer As Panel
    Friend WithEvents ButtonsGroup As Panel
    Friend WithEvents btnMinimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents panelTable As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents panelController As Panel
    Friend WithEvents btnParkOutAll As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnParkOut As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnParkIn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblTime As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnClear As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblVehicleType As Label
    Friend WithEvents lblVehicleName As Label
    Friend WithEvents lblOperatorName As Label
    Friend WithEvents lblPlateNo As Label
    Friend WithEvents BunifuSeparator4 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents btnRegistration As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnVehiclesList As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents parkedListTable As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents lblVehicleID As Label
    Friend WithEvents lblAutoID As Label
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnAccountInformation As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuSeparator5 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label11 As Label
    Friend WithEvents panelDashBoard As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents lblCountParkingSlot As Label
    Friend WithEvents lblCountParkedIn As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BunifuSeparator6 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents btnParkingSlot As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnHistory As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblRemainingParkingSlot As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents BunifuSeparator7 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BunifuSeparator8 As Bunifu.Framework.UI.BunifuSeparator
End Class
