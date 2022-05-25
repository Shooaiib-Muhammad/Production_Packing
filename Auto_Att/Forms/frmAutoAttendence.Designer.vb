<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAutoAttendence
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
        Dim CardNoLabel As System.Windows.Forms.Label
        Dim EmpPicLabel As System.Windows.Forms.Label
        Dim NICLabel As System.Windows.Forms.Label
        Dim FatherNameLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim CountLabel As System.Windows.Forms.Label
        Me.TriggerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCardNo = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LogoPictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Tbl_Comp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSAutoAtt = New Auto_Att.DsAutoAtt()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.EmpPicPictureBox = New System.Windows.Forms.PictureBox()
        Me.View_Pro_Article_BarCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Production = New Auto_Att.Production()
        Me.MyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.clock = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.ClearTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FNameLabel1 = New System.Windows.Forms.Label()
        Me.NICLabel2 = New System.Windows.Forms.Label()
        Me.FatherNameLabel2 = New System.Windows.Forms.Label()
        Me.CardNoLabel2 = New System.Windows.Forms.Label()
        Me.mylbl = New System.Windows.Forms.Label()
        Me.View_All_EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPayRoll = New Auto_Att.DSPayRoll()
        Me.View_All_EmployeesTableAdapter = New Auto_Att.DSPayRollTableAdapters.View_All_EmployeesTableAdapter()
        Me.TableAdapterManager1 = New Auto_Att.DSPayRollTableAdapters.TableAdapterManager()
        Me.DSBuses = New Auto_Att.DSBuses()
        Me.Tbl_Bus_AttBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Bus_AttTableAdapter = New Auto_Att.DSBusesTableAdapters.tbl_Bus_AttTableAdapter()
        Me.TableAdapterManager2 = New Auto_Att.DSBusesTableAdapters.TableAdapterManager()
        Me.View_BUS_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_BUS_InfoTableAdapter = New Auto_Att.DSBusesTableAdapters.View_BUS_InfoTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tbl_Hrm_Emp_AttBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_AttTableAdapter = New Auto_Att.DsAutoAttTableAdapters.tbl_Hrm_Emp_AttTableAdapter()
        Me.TableAdapterManager = New Auto_Att.DsAutoAttTableAdapters.TableAdapterManager()
        Me.Tbl_Hrm_Emp_Att1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_Att1TableAdapter = New Auto_Att.DsAutoAttTableAdapters.tbl_Hrm_Emp_Att1TableAdapter()
        Me.View_Rpt_HR_ActiveCardCopyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_HR_ActiveCardCopyTableAdapter = New Auto_Att.DsAutoAttTableAdapters.View_Rpt_HR_ActiveCardCopyTableAdapter()
        Me.Tbl_Comp_InfoTableAdapter = New Auto_Att.DsAutoAttTableAdapters.tbl_Comp_InfoTableAdapter()
        Me.View_Pro_Article_BarCodeTableAdapter = New Auto_Att.ProductionTableAdapters.View_Pro_Article_BarCodeTableAdapter()
        Me.TableAdapterManager3 = New Auto_Att.ProductionTableAdapters.TableAdapterManager()
        Me.Tbl_Pro_Article_BarCode_TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pro_Article_BarCode_TransactionsTableAdapter = New Auto_Att.ProductionTableAdapters.tbl_Pro_Article_BarCode_TransactionsTableAdapter()
        Me.View_Production_PackingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Production_PackingTableAdapter = New Auto_Att.ProductionTableAdapters.view_Production_PackingTableAdapter()
        Me.CountLabel1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CardNoLabel = New System.Windows.Forms.Label()
        EmpPicLabel = New System.Windows.Forms.Label()
        NICLabel = New System.Windows.Forms.Label()
        FatherNameLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        CountLabel = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.LogoPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSAutoAtt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.EmpPicPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Pro_Article_BarCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Production, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.View_All_EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPayRoll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSBuses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Bus_AttBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_BUS_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_AttBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_Att1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_HR_ActiveCardCopyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pro_Article_BarCode_TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Production_PackingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CardNoLabel
        '
        CardNoLabel.BackColor = System.Drawing.Color.Transparent
        CardNoLabel.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CardNoLabel.ForeColor = System.Drawing.Color.Black
        CardNoLabel.Location = New System.Drawing.Point(10, 8)
        CardNoLabel.Name = "CardNoLabel"
        CardNoLabel.Size = New System.Drawing.Size(205, 65)
        CardNoLabel.TabIndex = 0
        CardNoLabel.Text = "Article Code :"
        CardNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmpPicLabel
        '
        EmpPicLabel.BackColor = System.Drawing.SystemColors.Highlight
        EmpPicLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        EmpPicLabel.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpPicLabel.ForeColor = System.Drawing.Color.White
        EmpPicLabel.Location = New System.Drawing.Point(457, 50)
        EmpPicLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmpPicLabel.Name = "EmpPicLabel"
        EmpPicLabel.Size = New System.Drawing.Size(180, 29)
        EmpPicLabel.TabIndex = 58
        EmpPicLabel.Text = "Photo"
        EmpPicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NICLabel
        '
        NICLabel.BackColor = System.Drawing.Color.Transparent
        NICLabel.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NICLabel.ForeColor = System.Drawing.Color.Black
        NICLabel.Location = New System.Drawing.Point(3, 241)
        NICLabel.Name = "NICLabel"
        NICLabel.Size = New System.Drawing.Size(217, 65)
        NICLabel.TabIndex = 4
        NICLabel.Text = "Factory Code :"
        NICLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FatherNameLabel
        '
        FatherNameLabel.BackColor = System.Drawing.Color.Transparent
        FatherNameLabel.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FatherNameLabel.ForeColor = System.Drawing.Color.Black
        FatherNameLabel.Location = New System.Drawing.Point(10, 162)
        FatherNameLabel.Name = "FatherNameLabel"
        FatherNameLabel.Size = New System.Drawing.Size(205, 65)
        FatherNameLabel.TabIndex = 2
        FatherNameLabel.Text = "Model No. :"
        FatherNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NameLabel
        '
        NameLabel.BackColor = System.Drawing.Color.Transparent
        NameLabel.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.ForeColor = System.Drawing.Color.Black
        NameLabel.Location = New System.Drawing.Point(10, 85)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(205, 65)
        NameLabel.TabIndex = 0
        NameLabel.Text = "Model Name:"
        NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Label6.BackColor = System.Drawing.Color.Transparent
        Label6.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.Color.Black
        Label6.Location = New System.Drawing.Point(544, 239)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(107, 65)
        Label6.TabIndex = 51
        Label6.Text = "Type :"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Label12.BackColor = System.Drawing.Color.Transparent
        Label12.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.ForeColor = System.Drawing.Color.Black
        Label12.Location = New System.Drawing.Point(490, 10)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(107, 65)
        Label12.TabIndex = 55
        Label12.Text = "Size :"
        Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CountLabel
        '
        CountLabel.BackColor = System.Drawing.SystemColors.HotTrack
        CountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        CountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CountLabel.ForeColor = System.Drawing.Color.White
        CountLabel.Location = New System.Drawing.Point(644, 51)
        CountLabel.Name = "CountLabel"
        CountLabel.Size = New System.Drawing.Size(161, 31)
        CountLabel.TabIndex = 65
        CountLabel.Text = "Count"
        CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TriggerTimer
        '
        Me.TriggerTimer.Interval = 1000
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.txtCardNo)
        Me.Panel4.Location = New System.Drawing.Point(16, 49)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(434, 88)
        Me.Panel4.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(432, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Barcode Terminal"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCardNo
        '
        Me.txtCardNo.BackColor = System.Drawing.SystemColors.Control
        Me.txtCardNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNo.Location = New System.Drawing.Point(23, 40)
        Me.txtCardNo.Name = "txtCardNo"
        Me.txtCardNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCardNo.Size = New System.Drawing.Size(383, 23)
        Me.txtCardNo.TabIndex = 0
        Me.txtCardNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.LogoPictureBox1)
        Me.Panel5.Location = New System.Drawing.Point(811, 52)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(190, 134)
        Me.Panel5.TabIndex = 61
        '
        'LogoPictureBox1
        '
        Me.LogoPictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.LogoPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LogoPictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Tbl_Comp_InfoBindingSource, "Logo", True))
        Me.LogoPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogoPictureBox1.Image = Global.Auto_Att.My.Resources.Resources.Forward1212
        Me.LogoPictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox1.Name = "LogoPictureBox1"
        Me.LogoPictureBox1.Size = New System.Drawing.Size(188, 132)
        Me.LogoPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox1.TabIndex = 62
        Me.LogoPictureBox1.TabStop = False
        '
        'Tbl_Comp_InfoBindingSource
        '
        Me.Tbl_Comp_InfoBindingSource.DataMember = "tbl_Comp_Info"
        Me.Tbl_Comp_InfoBindingSource.DataSource = Me.DSAutoAtt
        '
        'DSAutoAtt
        '
        Me.DSAutoAtt.DataSetName = "DSAutoAtt"
        Me.DSAutoAtt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.EmpPicPictureBox)
        Me.Panel3.Location = New System.Drawing.Point(457, 82)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(180, 194)
        Me.Panel3.TabIndex = 60
        '
        'EmpPicPictureBox
        '
        Me.EmpPicPictureBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.EmpPicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpPicPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.View_Pro_Article_BarCodeBindingSource, "ArtImage", True))
        Me.EmpPicPictureBox.Location = New System.Drawing.Point(3, 4)
        Me.EmpPicPictureBox.Name = "EmpPicPictureBox"
        Me.EmpPicPictureBox.Size = New System.Drawing.Size(172, 185)
        Me.EmpPicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EmpPicPictureBox.TabIndex = 46
        Me.EmpPicPictureBox.TabStop = False
        '
        'View_Pro_Article_BarCodeBindingSource
        '
        Me.View_Pro_Article_BarCodeBindingSource.DataMember = "View_Pro_Article_BarCode"
        Me.View_Pro_Article_BarCodeBindingSource.DataSource = Me.Production
        '
        'Production
        '
        Me.Production.DataSetName = "Production"
        Me.Production.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MyTimer
        '
        Me.MyTimer.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.clock)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(16, 143)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(435, 132)
        Me.Panel1.TabIndex = 56
        '
        'clock
        '
        Me.clock.BackColor = System.Drawing.Color.Maroon
        Me.clock.Dock = System.Windows.Forms.DockStyle.Top
        Me.clock.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clock.ForeColor = System.Drawing.Color.Yellow
        Me.clock.Location = New System.Drawing.Point(0, 0)
        Me.clock.Name = "clock"
        Me.clock.Size = New System.Drawing.Size(433, 42)
        Me.clock.TabIndex = 18
        Me.clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.SystemColors.Control
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Maroon
        Me.lblDate.Location = New System.Drawing.Point(220, 57)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(206, 28)
        Me.lblDate.TabIndex = 17
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 28)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Packing Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.SystemColors.Control
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTime.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Maroon
        Me.lblTime.Location = New System.Drawing.Point(220, 94)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(206, 28)
        Me.lblTime.TabIndex = 16
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTime.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 28)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Packing Time:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.SystemColors.Control
        Me.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMsg.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.Maroon
        Me.lblMsg.Location = New System.Drawing.Point(1037, 526)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(73, 87)
        Me.lblMsg.TabIndex = 55
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMsg.Visible = False
        '
        'ClearTimer
        '
        Me.ClearTimer.Interval = 1000
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1013, 40)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Production Packing"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Label12)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Label6)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.FNameLabel1)
        Me.Panel2.Controls.Add(Me.NICLabel2)
        Me.Panel2.Controls.Add(Me.FatherNameLabel2)
        Me.Panel2.Controls.Add(Me.CardNoLabel2)
        Me.Panel2.Controls.Add(CardNoLabel)
        Me.Panel2.Controls.Add(NICLabel)
        Me.Panel2.Controls.Add(FatherNameLabel)
        Me.Panel2.Controls.Add(NameLabel)
        Me.Panel2.Location = New System.Drawing.Point(16, 284)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(984, 331)
        Me.Panel2.TabIndex = 57
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Pro_Article_BarCodeBindingSource, "Size", True))
        Me.Label11.Font = New System.Drawing.Font("Georgia", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(607, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(363, 65)
        Me.Label11.TabIndex = 56
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Pro_Article_BarCodeBindingSource, "Type", True))
        Me.Label8.Font = New System.Drawing.Font("Georgia", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(661, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(312, 65)
        Me.Label8.TabIndex = 52
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(68, -175)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(174, 23)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FNameLabel1
        '
        Me.FNameLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.FNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Pro_Article_BarCodeBindingSource, "ModelName", True))
        Me.FNameLabel1.Font = New System.Drawing.Font("Georgia", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNameLabel1.ForeColor = System.Drawing.Color.Maroon
        Me.FNameLabel1.Location = New System.Drawing.Point(225, 85)
        Me.FNameLabel1.Name = "FNameLabel1"
        Me.FNameLabel1.Size = New System.Drawing.Size(748, 65)
        Me.FNameLabel1.TabIndex = 50
        Me.FNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NICLabel2
        '
        Me.NICLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.NICLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NICLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Pro_Article_BarCodeBindingSource, "FactoryCode", True))
        Me.NICLabel2.Font = New System.Drawing.Font("Georgia", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NICLabel2.ForeColor = System.Drawing.Color.Maroon
        Me.NICLabel2.Location = New System.Drawing.Point(225, 239)
        Me.NICLabel2.Name = "NICLabel2"
        Me.NICLabel2.Size = New System.Drawing.Size(313, 65)
        Me.NICLabel2.TabIndex = 45
        Me.NICLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FatherNameLabel2
        '
        Me.FatherNameLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.FatherNameLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FatherNameLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Pro_Article_BarCodeBindingSource, "ModelNo", True))
        Me.FatherNameLabel2.Font = New System.Drawing.Font("Georgia", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FatherNameLabel2.ForeColor = System.Drawing.Color.Maroon
        Me.FatherNameLabel2.Location = New System.Drawing.Point(225, 162)
        Me.FatherNameLabel2.Name = "FatherNameLabel2"
        Me.FatherNameLabel2.Size = New System.Drawing.Size(748, 65)
        Me.FatherNameLabel2.TabIndex = 44
        Me.FatherNameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CardNoLabel2
        '
        Me.CardNoLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.CardNoLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CardNoLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Pro_Article_BarCodeBindingSource, "ArtCode", True))
        Me.CardNoLabel2.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CardNoLabel2.ForeColor = System.Drawing.Color.Maroon
        Me.CardNoLabel2.Location = New System.Drawing.Point(225, 8)
        Me.CardNoLabel2.Name = "CardNoLabel2"
        Me.CardNoLabel2.Size = New System.Drawing.Size(224, 65)
        Me.CardNoLabel2.TabIndex = 42
        Me.CardNoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mylbl
        '
        Me.mylbl.BackColor = System.Drawing.SystemColors.Control
        Me.mylbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mylbl.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mylbl.Location = New System.Drawing.Point(1022, 486)
        Me.mylbl.Name = "mylbl"
        Me.mylbl.Size = New System.Drawing.Size(77, 26)
        Me.mylbl.TabIndex = 53
        Me.mylbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mylbl.Visible = False
        '
        'View_All_EmployeesBindingSource
        '
        Me.View_All_EmployeesBindingSource.DataMember = "View_All_Employees"
        Me.View_All_EmployeesBindingSource.DataSource = Me.DSPayRoll
        '
        'DSPayRoll
        '
        Me.DSPayRoll.DataSetName = "DSPayRoll"
        Me.DSPayRoll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_All_EmployeesTableAdapter
        '
        Me.View_All_EmployeesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.tbl_Acc_AnnualLeaveTransactionsTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Att_DeviceSpecialTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Att_DeviceTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_Emp_AttTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_HolidaysTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Shift1TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_ShiftTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_PayRoll_LongLeavesTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_PayRoll_ShortLeavesTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Auto_Att.DSPayRollTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DSBuses
        '
        Me.DSBuses.DataSetName = "DSBuses"
        Me.DSBuses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Bus_AttBindingSource
        '
        Me.Tbl_Bus_AttBindingSource.DataMember = "tbl_Bus_Att"
        Me.Tbl_Bus_AttBindingSource.DataSource = Me.DSBuses
        '
        'Tbl_Bus_AttTableAdapter
        '
        Me.Tbl_Bus_AttTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.tbl_Bus_AttTableAdapter = Me.Tbl_Bus_AttTableAdapter
        Me.TableAdapterManager2.UpdateOrder = Auto_Att.DSBusesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'View_BUS_InfoBindingSource
        '
        Me.View_BUS_InfoBindingSource.DataMember = "View_BUS_Info"
        Me.View_BUS_InfoBindingSource.DataSource = Me.DSBuses
        '
        'View_BUS_InfoTableAdapter
        '
        Me.View_BUS_InfoTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Pro_Article_BarCodeBindingSource, "ClientID", True))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1034, 402)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Pro_Article_BarCodeBindingSource, "ModelID", True))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1034, 426)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Label5"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Pro_Article_BarCodeBindingSource, "ArtID", True))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(1034, 447)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Label9"
        '
        'Tbl_Hrm_Emp_AttBindingSource
        '
        Me.Tbl_Hrm_Emp_AttBindingSource.DataMember = "tbl_Hrm_Emp_Att"
        Me.Tbl_Hrm_Emp_AttBindingSource.DataSource = Me.DSAutoAtt
        '
        'Tbl_Hrm_Emp_AttTableAdapter
        '
        Me.Tbl_Hrm_Emp_AttTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Comp_InfoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_Att_MealTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_Att1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_AttTableAdapter = Me.Tbl_Hrm_Emp_AttTableAdapter
        Me.TableAdapterManager.UpdateOrder = Auto_Att.DsAutoAttTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.View_Rpt_HR_ActiveCardCopyTableAdapter = Nothing
        '
        'Tbl_Hrm_Emp_Att1BindingSource
        '
        Me.Tbl_Hrm_Emp_Att1BindingSource.DataSource = Me.DSAutoAtt
        Me.Tbl_Hrm_Emp_Att1BindingSource.Position = 0
        '
        'Tbl_Hrm_Emp_Att1TableAdapter
        '
        Me.Tbl_Hrm_Emp_Att1TableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_HR_ActiveCardCopyBindingSource
        '
        Me.View_Rpt_HR_ActiveCardCopyBindingSource.DataMember = "View_Rpt_HR_ActiveCardCopy"
        Me.View_Rpt_HR_ActiveCardCopyBindingSource.DataSource = Me.DSAutoAtt
        '
        'View_Rpt_HR_ActiveCardCopyTableAdapter
        '
        Me.View_Rpt_HR_ActiveCardCopyTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Comp_InfoTableAdapter
        '
        Me.Tbl_Comp_InfoTableAdapter.ClearBeforeFill = True
        '
        'View_Pro_Article_BarCodeTableAdapter
        '
        Me.View_Pro_Article_BarCodeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.Connection = Nothing
        Me.TableAdapterManager3.tbl_Pro_Article_BarCode_TransactionsTableAdapter = Nothing
        Me.TableAdapterManager3.UpdateOrder = Auto_Att.ProductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Pro_Article_BarCode_TransactionsBindingSource
        '
        Me.Tbl_Pro_Article_BarCode_TransactionsBindingSource.DataMember = "tbl_Pro_Article_BarCode_Transactions"
        Me.Tbl_Pro_Article_BarCode_TransactionsBindingSource.DataSource = Me.Production
        '
        'Tbl_Pro_Article_BarCode_TransactionsTableAdapter
        '
        Me.Tbl_Pro_Article_BarCode_TransactionsTableAdapter.ClearBeforeFill = True
        '
        'View_Production_PackingBindingSource
        '
        Me.View_Production_PackingBindingSource.DataMember = "view_Production_Packing"
        Me.View_Production_PackingBindingSource.DataSource = Me.Production
        '
        'View_Production_PackingTableAdapter
        '
        Me.View_Production_PackingTableAdapter.ClearBeforeFill = True
        '
        'CountLabel1
        '
        Me.CountLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Production_PackingBindingSource, "Count", True))
        Me.CountLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountLabel1.Location = New System.Drawing.Point(644, 82)
        Me.CountLabel1.Name = "CountLabel1"
        Me.CountLabel1.Size = New System.Drawing.Size(161, 147)
        Me.CountLabel1.TabIndex = 66
        Me.CountLabel1.Text = "Label10"
        Me.CountLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(780, 621)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(220, 44)
        Me.Button2.TabIndex = 68
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmAutoAttendence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1013, 676)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(CountLabel)
        Me.Controls.Add(Me.CountLabel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(EmpPicLabel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.mylbl)
        Me.Name = "frmAutoAttendence"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.LogoPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSAutoAtt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.EmpPicPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Pro_Article_BarCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Production, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.View_All_EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPayRoll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSBuses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Bus_AttBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_BUS_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_AttBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_Att1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_HR_ActiveCardCopyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pro_Article_BarCode_TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Production_PackingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TriggerTimer As Timer
    Friend WithEvents EmpPicPictureBox As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCardNo As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MyTimer As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents clock As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMsg As Label
    Friend WithEvents ClearTimer As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents FNameLabel1 As Label
    Friend WithEvents NICLabel2 As Label
    Friend WithEvents FatherNameLabel2 As Label
    Friend WithEvents CardNoLabel2 As Label
    Friend WithEvents mylbl As Label
    Friend WithEvents DSAutoAtt As DsAutoAtt
    Friend WithEvents Tbl_Hrm_Emp_AttBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_Emp_AttTableAdapter As DsAutoAttTableAdapters.tbl_Hrm_Emp_AttTableAdapter
    Friend WithEvents TableAdapterManager As DsAutoAttTableAdapters.TableAdapterManager
    Friend WithEvents DSPayRoll As DSPayRoll
    Friend WithEvents View_All_EmployeesBindingSource As BindingSource
    Friend WithEvents View_All_EmployeesTableAdapter As DSPayRollTableAdapters.View_All_EmployeesTableAdapter
    Friend WithEvents TableAdapterManager1 As DSPayRollTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Hrm_Emp_Att1BindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_Emp_Att1TableAdapter As DsAutoAttTableAdapters.tbl_Hrm_Emp_Att1TableAdapter
    Friend WithEvents View_Rpt_HR_ActiveCardCopyBindingSource As BindingSource
    Friend WithEvents View_Rpt_HR_ActiveCardCopyTableAdapter As DsAutoAttTableAdapters.View_Rpt_HR_ActiveCardCopyTableAdapter
    Friend WithEvents Tbl_Comp_InfoBindingSource As BindingSource
    Friend WithEvents Tbl_Comp_InfoTableAdapter As DsAutoAttTableAdapters.tbl_Comp_InfoTableAdapter
    Friend WithEvents LogoPictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DSBuses As DSBuses
    Friend WithEvents Tbl_Bus_AttBindingSource As BindingSource
    Friend WithEvents Tbl_Bus_AttTableAdapter As DSBusesTableAdapters.tbl_Bus_AttTableAdapter
    Friend WithEvents TableAdapterManager2 As DSBusesTableAdapters.TableAdapterManager
    Friend WithEvents View_BUS_InfoBindingSource As BindingSource
    Friend WithEvents View_BUS_InfoTableAdapter As DSBusesTableAdapters.View_BUS_InfoTableAdapter
    Friend WithEvents Production As Production
    Friend WithEvents View_Pro_Article_BarCodeBindingSource As BindingSource
    Friend WithEvents View_Pro_Article_BarCodeTableAdapter As ProductionTableAdapters.View_Pro_Article_BarCodeTableAdapter
    Friend WithEvents TableAdapterManager3 As ProductionTableAdapters.TableAdapterManager
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Tbl_Pro_Article_BarCode_TransactionsBindingSource As BindingSource
    Friend WithEvents Tbl_Pro_Article_BarCode_TransactionsTableAdapter As ProductionTableAdapters.tbl_Pro_Article_BarCode_TransactionsTableAdapter
    Friend WithEvents View_Production_PackingBindingSource As BindingSource
    Friend WithEvents View_Production_PackingTableAdapter As ProductionTableAdapters.view_Production_PackingTableAdapter
    Friend WithEvents CountLabel1 As Label
    Friend WithEvents Button2 As Button
End Class
