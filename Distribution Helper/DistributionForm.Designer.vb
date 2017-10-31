<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DistributionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DistributionForm))
        Me.InputPanel = New System.Windows.Forms.Panel()
        Me.CustomerJobNumComboBox = New System.Windows.Forms.ComboBox()
        Me.CustomerJobNumberLabel = New System.Windows.Forms.Label()
        Me.LocationNameLabel = New System.Windows.Forms.Label()
        Me.LocationNameTextBox = New System.Windows.Forms.TextBox()
        Me.InternalJobNumComboBox = New System.Windows.Forms.ComboBox()
        Me.CustomerComboBox = New System.Windows.Forms.ComboBox()
        Me.DistributionDate = New System.Windows.Forms.DateTimePicker()
        Me.InternalJobNumLabel = New System.Windows.Forms.Label()
        Me.CustomerLabel = New System.Windows.Forms.Label()
        Me.ShipMethodComboBox = New System.Windows.Forms.ComboBox()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.ShipMethodLabel = New System.Windows.Forms.Label()
        Me.WeightLabel = New System.Windows.Forms.Label()
        Me.RecipPhoneLabel = New System.Windows.Forms.Label()
        Me.PackageWeightTextBox = New System.Windows.Forms.TextBox()
        Me.RecipNameLabel = New System.Windows.Forms.Label()
        Me.RecipPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.RecipAddyLabel = New System.Windows.Forms.Label()
        Me.RecipNameTextBox = New System.Windows.Forms.TextBox()
        Me.RecipAddyTextBox = New System.Windows.Forms.TextBox()
        Me.SoftwareLocLabel = New System.Windows.Forms.Label()
        Me.DistroPathTextBox = New System.Windows.Forms.TextBox()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.InfoStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToDatabaseMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Toolbar = New System.Windows.Forms.ToolStrip()
        Me.BrowseToolbarBttn = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolBttn = New System.Windows.Forms.ToolStripButton()
        Me.AddToDatabaseToolBttn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolBttn = New System.Windows.Forms.ToolStripButton()
        Me.PrintPrevToolBttn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DistEmailToolBttn = New System.Windows.Forms.ToolStripButton()
        Me.CreateLabelsToolBttn = New System.Windows.Forms.ToolStripButton()
        Me.CreateLetterToolBttn = New System.Windows.Forms.ToolStripButton()
        Me.PrintWindow = New System.Windows.Forms.PrintDialog()
        Me.DistributionDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.DistributionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DistributionsDataSet = New Distribution_Helper.DistributionsDataSet()
        Me.DistributionsTableAdapter = New Distribution_Helper.DistributionsDataSetTableAdapters.DistributionsTableAdapter()
        Me.TabPages = New System.Windows.Forms.TabControl()
        Me.DistributionTab = New System.Windows.Forms.TabPage()
        Me.PrintPreviewTab = New System.Windows.Forms.TabPage()
        Me.PrintPreviewTabWindow = New System.Windows.Forms.PrintPreviewControl()
        Me.DatabaseTab = New System.Windows.Forms.TabPage()
        Me.DistributionsDataGrid = New System.Windows.Forms.DataGridView()
        Me.DistinctLocationTableAdapter = New Distribution_Helper.DistributionsDataSetTableAdapters.DistributionsTableAdapter()
        Me.RefreshDBToolBttn = New System.Windows.Forms.ToolStripButton()
        Me.InputPanel.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.Toolbar.SuspendLayout()
        CType(Me.DistributionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistributionsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPages.SuspendLayout()
        Me.DistributionTab.SuspendLayout()
        Me.PrintPreviewTab.SuspendLayout()
        Me.DatabaseTab.SuspendLayout()
        CType(Me.DistributionsDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputPanel
        '
        Me.InputPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.InputPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.InputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputPanel.Controls.Add(Me.CustomerJobNumComboBox)
        Me.InputPanel.Controls.Add(Me.CustomerJobNumberLabel)
        Me.InputPanel.Controls.Add(Me.LocationNameLabel)
        Me.InputPanel.Controls.Add(Me.LocationNameTextBox)
        Me.InputPanel.Controls.Add(Me.InternalJobNumComboBox)
        Me.InputPanel.Controls.Add(Me.CustomerComboBox)
        Me.InputPanel.Controls.Add(Me.DistributionDate)
        Me.InputPanel.Controls.Add(Me.InternalJobNumLabel)
        Me.InputPanel.Controls.Add(Me.CustomerLabel)
        Me.InputPanel.Controls.Add(Me.ShipMethodComboBox)
        Me.InputPanel.Controls.Add(Me.DateLabel)
        Me.InputPanel.Controls.Add(Me.ShipMethodLabel)
        Me.InputPanel.Controls.Add(Me.WeightLabel)
        Me.InputPanel.Controls.Add(Me.RecipPhoneLabel)
        Me.InputPanel.Controls.Add(Me.PackageWeightTextBox)
        Me.InputPanel.Controls.Add(Me.RecipNameLabel)
        Me.InputPanel.Controls.Add(Me.RecipPhoneTextBox)
        Me.InputPanel.Controls.Add(Me.RecipAddyLabel)
        Me.InputPanel.Controls.Add(Me.RecipNameTextBox)
        Me.InputPanel.Controls.Add(Me.RecipAddyTextBox)
        Me.InputPanel.Controls.Add(Me.SoftwareLocLabel)
        Me.InputPanel.Controls.Add(Me.DistroPathTextBox)
        Me.InputPanel.Location = New System.Drawing.Point(8, 6)
        Me.InputPanel.Name = "InputPanel"
        Me.InputPanel.Size = New System.Drawing.Size(707, 334)
        Me.InputPanel.TabIndex = 0
        '
        'CustomerJobNumComboBox
        '
        Me.CustomerJobNumComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CustomerJobNumComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CustomerJobNumComboBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.CustomerJobNumComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CustomerJobNumComboBox.FormattingEnabled = True
        Me.CustomerJobNumComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CustomerJobNumComboBox.Location = New System.Drawing.Point(357, 301)
        Me.CustomerJobNumComboBox.Name = "CustomerJobNumComboBox"
        Me.CustomerJobNumComboBox.Size = New System.Drawing.Size(340, 21)
        Me.CustomerJobNumComboBox.TabIndex = 11
        '
        'CustomerJobNumberLabel
        '
        Me.CustomerJobNumberLabel.AutoSize = True
        Me.CustomerJobNumberLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CustomerJobNumberLabel.Location = New System.Drawing.Point(357, 286)
        Me.CustomerJobNumberLabel.Name = "CustomerJobNumberLabel"
        Me.CustomerJobNumberLabel.Size = New System.Drawing.Size(113, 13)
        Me.CustomerJobNumberLabel.TabIndex = 10
        Me.CustomerJobNumberLabel.Text = "Customer Job Number"
        '
        'LocationNameLabel
        '
        Me.LocationNameLabel.AutoSize = True
        Me.LocationNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LocationNameLabel.Location = New System.Drawing.Point(3, 286)
        Me.LocationNameLabel.Name = "LocationNameLabel"
        Me.LocationNameLabel.Size = New System.Drawing.Size(77, 13)
        Me.LocationNameLabel.TabIndex = 9
        Me.LocationNameLabel.Text = "Location Name"
        '
        'LocationNameTextBox
        '
        Me.LocationNameTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.LocationNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LocationNameTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationNameTextBox.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LocationNameTextBox.Location = New System.Drawing.Point(3, 301)
        Me.LocationNameTextBox.Name = "LocationNameTextBox"
        Me.LocationNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LocationNameTextBox.Size = New System.Drawing.Size(340, 23)
        Me.LocationNameTextBox.TabIndex = 8
        '
        'InternalJobNumComboBox
        '
        Me.InternalJobNumComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.InternalJobNumComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.InternalJobNumComboBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.InternalJobNumComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.InternalJobNumComboBox.FormattingEnabled = True
        Me.InternalJobNumComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.InternalJobNumComboBox.Location = New System.Drawing.Point(357, 258)
        Me.InternalJobNumComboBox.Name = "InternalJobNumComboBox"
        Me.InternalJobNumComboBox.Size = New System.Drawing.Size(340, 21)
        Me.InternalJobNumComboBox.TabIndex = 7
        '
        'CustomerComboBox
        '
        Me.CustomerComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CustomerComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CustomerComboBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.CustomerComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CustomerComboBox.FormattingEnabled = True
        Me.CustomerComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CustomerComboBox.Location = New System.Drawing.Point(3, 258)
        Me.CustomerComboBox.Name = "CustomerComboBox"
        Me.CustomerComboBox.Size = New System.Drawing.Size(340, 21)
        Me.CustomerComboBox.TabIndex = 7
        '
        'DistributionDate
        '
        Me.DistributionDate.CalendarMonthBackground = System.Drawing.SystemColors.ControlDark
        Me.DistributionDate.Location = New System.Drawing.Point(3, 214)
        Me.DistributionDate.Name = "DistributionDate"
        Me.DistributionDate.Size = New System.Drawing.Size(340, 21)
        Me.DistributionDate.TabIndex = 6
        '
        'InternalJobNumLabel
        '
        Me.InternalJobNumLabel.AutoSize = True
        Me.InternalJobNumLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.InternalJobNumLabel.Location = New System.Drawing.Point(357, 243)
        Me.InternalJobNumLabel.Name = "InternalJobNumLabel"
        Me.InternalJobNumLabel.Size = New System.Drawing.Size(105, 13)
        Me.InternalJobNumLabel.TabIndex = 6
        Me.InternalJobNumLabel.Text = "Internal Job Number"
        '
        'CustomerLabel
        '
        Me.CustomerLabel.AutoSize = True
        Me.CustomerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CustomerLabel.Location = New System.Drawing.Point(3, 243)
        Me.CustomerLabel.Name = "CustomerLabel"
        Me.CustomerLabel.Size = New System.Drawing.Size(53, 13)
        Me.CustomerLabel.TabIndex = 6
        Me.CustomerLabel.Text = "Customer"
        '
        'ShipMethodComboBox
        '
        Me.ShipMethodComboBox.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ShipMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ShipMethodComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ShipMethodComboBox.FormattingEnabled = True
        Me.ShipMethodComboBox.Location = New System.Drawing.Point(357, 214)
        Me.ShipMethodComboBox.Name = "ShipMethodComboBox"
        Me.ShipMethodComboBox.Size = New System.Drawing.Size(340, 21)
        Me.ShipMethodComboBox.TabIndex = 5
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DateLabel.Location = New System.Drawing.Point(3, 198)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(30, 13)
        Me.DateLabel.TabIndex = 4
        Me.DateLabel.Text = "Date"
        '
        'ShipMethodLabel
        '
        Me.ShipMethodLabel.AutoSize = True
        Me.ShipMethodLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ShipMethodLabel.Location = New System.Drawing.Point(357, 199)
        Me.ShipMethodLabel.Name = "ShipMethodLabel"
        Me.ShipMethodLabel.Size = New System.Drawing.Size(86, 13)
        Me.ShipMethodLabel.TabIndex = 4
        Me.ShipMethodLabel.Text = "Shipping Method"
        '
        'WeightLabel
        '
        Me.WeightLabel.AutoSize = True
        Me.WeightLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.WeightLabel.Location = New System.Drawing.Point(357, 151)
        Me.WeightLabel.Name = "WeightLabel"
        Me.WeightLabel.Size = New System.Drawing.Size(151, 13)
        Me.WeightLabel.TabIndex = 4
        Me.WeightLabel.Text = "Package Approximate Weight "
        '
        'RecipPhoneLabel
        '
        Me.RecipPhoneLabel.AutoSize = True
        Me.RecipPhoneLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RecipPhoneLabel.Location = New System.Drawing.Point(357, 103)
        Me.RecipPhoneLabel.Name = "RecipPhoneLabel"
        Me.RecipPhoneLabel.Size = New System.Drawing.Size(124, 13)
        Me.RecipPhoneLabel.TabIndex = 4
        Me.RecipPhoneLabel.Text = "Recipient Phone Number"
        '
        'PackageWeightTextBox
        '
        Me.PackageWeightTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PackageWeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PackageWeightTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PackageWeightTextBox.ForeColor = System.Drawing.Color.DodgerBlue
        Me.PackageWeightTextBox.Location = New System.Drawing.Point(357, 166)
        Me.PackageWeightTextBox.Name = "PackageWeightTextBox"
        Me.PackageWeightTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PackageWeightTextBox.Size = New System.Drawing.Size(340, 23)
        Me.PackageWeightTextBox.TabIndex = 3
        '
        'RecipNameLabel
        '
        Me.RecipNameLabel.AutoSize = True
        Me.RecipNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RecipNameLabel.Location = New System.Drawing.Point(357, 55)
        Me.RecipNameLabel.Name = "RecipNameLabel"
        Me.RecipNameLabel.Size = New System.Drawing.Size(81, 13)
        Me.RecipNameLabel.TabIndex = 4
        Me.RecipNameLabel.Text = "Recipient Name"
        '
        'RecipPhoneTextBox
        '
        Me.RecipPhoneTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.RecipPhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RecipPhoneTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipPhoneTextBox.ForeColor = System.Drawing.Color.DodgerBlue
        Me.RecipPhoneTextBox.Location = New System.Drawing.Point(357, 118)
        Me.RecipPhoneTextBox.Name = "RecipPhoneTextBox"
        Me.RecipPhoneTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.RecipPhoneTextBox.Size = New System.Drawing.Size(340, 23)
        Me.RecipPhoneTextBox.TabIndex = 3
        '
        'RecipAddyLabel
        '
        Me.RecipAddyLabel.AutoSize = True
        Me.RecipAddyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RecipAddyLabel.Location = New System.Drawing.Point(3, 55)
        Me.RecipAddyLabel.Name = "RecipAddyLabel"
        Me.RecipAddyLabel.Size = New System.Drawing.Size(93, 13)
        Me.RecipAddyLabel.TabIndex = 4
        Me.RecipAddyLabel.Text = "Recipient Address"
        '
        'RecipNameTextBox
        '
        Me.RecipNameTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.RecipNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RecipNameTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipNameTextBox.ForeColor = System.Drawing.Color.DodgerBlue
        Me.RecipNameTextBox.Location = New System.Drawing.Point(357, 70)
        Me.RecipNameTextBox.Name = "RecipNameTextBox"
        Me.RecipNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.RecipNameTextBox.Size = New System.Drawing.Size(340, 23)
        Me.RecipNameTextBox.TabIndex = 3
        '
        'RecipAddyTextBox
        '
        Me.RecipAddyTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.RecipAddyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RecipAddyTextBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipAddyTextBox.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.RecipAddyTextBox.Location = New System.Drawing.Point(3, 70)
        Me.RecipAddyTextBox.Multiline = True
        Me.RecipAddyTextBox.Name = "RecipAddyTextBox"
        Me.RecipAddyTextBox.Size = New System.Drawing.Size(340, 119)
        Me.RecipAddyTextBox.TabIndex = 3
        Me.RecipAddyTextBox.WordWrap = False
        '
        'SoftwareLocLabel
        '
        Me.SoftwareLocLabel.AutoSize = True
        Me.SoftwareLocLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SoftwareLocLabel.Location = New System.Drawing.Point(3, 7)
        Me.SoftwareLocLabel.Name = "SoftwareLocLabel"
        Me.SoftwareLocLabel.Size = New System.Drawing.Size(94, 13)
        Me.SoftwareLocLabel.TabIndex = 2
        Me.SoftwareLocLabel.Text = "Software Location"
        '
        'DistroPathTextBox
        '
        Me.DistroPathTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DistroPathTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources
        Me.DistroPathTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.DistroPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DistroPathTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DistroPathTextBox.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DistroPathTextBox.Location = New System.Drawing.Point(3, 22)
        Me.DistroPathTextBox.Name = "DistroPathTextBox"
        Me.DistroPathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DistroPathTextBox.Size = New System.Drawing.Size(694, 23)
        Me.DistroPathTextBox.TabIndex = 1
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.Gray
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoStatusLabel, Me.ProgressBar})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 529)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(731, 25)
        Me.StatusStrip.TabIndex = 1
        Me.StatusStrip.Text = "StatusStrip"
        '
        'InfoStatusLabel
        '
        Me.InfoStatusLabel.AutoSize = False
        Me.InfoStatusLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoStatusLabel.ForeColor = System.Drawing.Color.Yellow
        Me.InfoStatusLabel.Name = "InfoStatusLabel"
        Me.InfoStatusLabel.Size = New System.Drawing.Size(605, 20)
        Me.InfoStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProgressBar
        '
        Me.ProgressBar.AutoSize = False
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(55, 19)
        Me.ProgressBar.Visible = False
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(731, 24)
        Me.MenuStrip.TabIndex = 2
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.FileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenMenuItem, Me.SaveMenuItem, Me.SaveAsMenuItem, Me.AddToDatabaseMenuItem, Me.ToolStripSeparator2, Me.PrintMenuItem, Me.PrintPreviewMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Gray
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShowShortcutKeys = False
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        Me.FileToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'OpenMenuItem
        '
        Me.OpenMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.OpenMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.OpenMenuItem.ImageTransparentColor = System.Drawing.Color.Gray
        Me.OpenMenuItem.Name = "OpenMenuItem"
        Me.OpenMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.OpenMenuItem.Text = "Open"
        '
        'SaveMenuItem
        '
        Me.SaveMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.SaveMenuItem.Enabled = False
        Me.SaveMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.SaveMenuItem.Name = "SaveMenuItem"
        Me.SaveMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SaveMenuItem.Text = "Save"
        '
        'SaveAsMenuItem
        '
        Me.SaveAsMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.SaveAsMenuItem.Enabled = False
        Me.SaveAsMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.SaveAsMenuItem.Name = "SaveAsMenuItem"
        Me.SaveAsMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SaveAsMenuItem.Text = "Save As"
        '
        'AddToDatabaseMenuItem
        '
        Me.AddToDatabaseMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.AddToDatabaseMenuItem.Enabled = False
        Me.AddToDatabaseMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.AddToDatabaseMenuItem.Name = "AddToDatabaseMenuItem"
        Me.AddToDatabaseMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AddToDatabaseMenuItem.Text = "Add to Database"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.BackColor = System.Drawing.SystemColors.GrayText
        Me.ToolStripSeparator2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(158, 6)
        '
        'PrintMenuItem
        '
        Me.PrintMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PrintMenuItem.Enabled = False
        Me.PrintMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.PrintMenuItem.Name = "PrintMenuItem"
        Me.PrintMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.PrintMenuItem.Text = "Print"
        '
        'PrintPreviewMenuItem
        '
        Me.PrintPreviewMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PrintPreviewMenuItem.Enabled = False
        Me.PrintPreviewMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.PrintPreviewMenuItem.Name = "PrintPreviewMenuItem"
        Me.PrintPreviewMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.PrintPreviewMenuItem.Text = "Print Preview"
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.CheckFileExists = True
        Me.SaveFileDialog.CreatePrompt = True
        Me.SaveFileDialog.DefaultExt = "dhf"
        Me.SaveFileDialog.Filter = "Dist Help File (*.dhf)|*.dhf"
        '
        'Toolbar
        '
        Me.Toolbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowseToolbarBttn, Me.SaveToolBttn, Me.AddToDatabaseToolBttn, Me.RefreshDBToolBttn, Me.ToolStripSeparator1, Me.PrintToolBttn, Me.PrintPrevToolBttn, Me.ToolStripSeparator3, Me.DistEmailToolBttn, Me.CreateLabelsToolBttn, Me.CreateLetterToolBttn})
        Me.Toolbar.Location = New System.Drawing.Point(0, 24)
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.Toolbar.Size = New System.Drawing.Size(731, 25)
        Me.Toolbar.TabIndex = 3
        '
        'BrowseToolbarBttn
        '
        Me.BrowseToolbarBttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowseToolbarBttn.Image = CType(resources.GetObject("BrowseToolbarBttn.Image"), System.Drawing.Image)
        Me.BrowseToolbarBttn.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.BrowseToolbarBttn.Name = "BrowseToolbarBttn"
        Me.BrowseToolbarBttn.Size = New System.Drawing.Size(23, 22)
        Me.BrowseToolbarBttn.ToolTipText = "Browse"
        '
        'SaveToolBttn
        '
        Me.SaveToolBttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolBttn.Enabled = False
        Me.SaveToolBttn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SaveToolBttn.Image = CType(resources.GetObject("SaveToolBttn.Image"), System.Drawing.Image)
        Me.SaveToolBttn.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.SaveToolBttn.Name = "SaveToolBttn"
        Me.SaveToolBttn.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolBttn.ToolTipText = "Save"
        '
        'AddToDatabaseToolBttn
        '
        Me.AddToDatabaseToolBttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddToDatabaseToolBttn.Enabled = False
        Me.AddToDatabaseToolBttn.Image = CType(resources.GetObject("AddToDatabaseToolBttn.Image"), System.Drawing.Image)
        Me.AddToDatabaseToolBttn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddToDatabaseToolBttn.Name = "AddToDatabaseToolBttn"
        Me.AddToDatabaseToolBttn.Size = New System.Drawing.Size(23, 22)
        Me.AddToDatabaseToolBttn.ToolTipText = "Add to Database"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'PrintToolBttn
        '
        Me.PrintToolBttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolBttn.Enabled = False
        Me.PrintToolBttn.Image = CType(resources.GetObject("PrintToolBttn.Image"), System.Drawing.Image)
        Me.PrintToolBttn.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.PrintToolBttn.Name = "PrintToolBttn"
        Me.PrintToolBttn.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolBttn.ToolTipText = "Print"
        '
        'PrintPrevToolBttn
        '
        Me.PrintPrevToolBttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintPrevToolBttn.Enabled = False
        Me.PrintPrevToolBttn.Image = CType(resources.GetObject("PrintPrevToolBttn.Image"), System.Drawing.Image)
        Me.PrintPrevToolBttn.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.PrintPrevToolBttn.Name = "PrintPrevToolBttn"
        Me.PrintPrevToolBttn.Size = New System.Drawing.Size(23, 22)
        Me.PrintPrevToolBttn.ToolTipText = "Print Preview"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'DistEmailToolBttn
        '
        Me.DistEmailToolBttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DistEmailToolBttn.Enabled = False
        Me.DistEmailToolBttn.Image = CType(resources.GetObject("DistEmailToolBttn.Image"), System.Drawing.Image)
        Me.DistEmailToolBttn.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.DistEmailToolBttn.Name = "DistEmailToolBttn"
        Me.DistEmailToolBttn.Size = New System.Drawing.Size(23, 22)
        Me.DistEmailToolBttn.ToolTipText = "Create Distribution Email"
        '
        'CreateLabelsToolBttn
        '
        Me.CreateLabelsToolBttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CreateLabelsToolBttn.Enabled = False
        Me.CreateLabelsToolBttn.Image = CType(resources.GetObject("CreateLabelsToolBttn.Image"), System.Drawing.Image)
        Me.CreateLabelsToolBttn.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.CreateLabelsToolBttn.Name = "CreateLabelsToolBttn"
        Me.CreateLabelsToolBttn.Size = New System.Drawing.Size(23, 22)
        Me.CreateLabelsToolBttn.ToolTipText = "Create Labels"
        '
        'CreateLetterToolBttn
        '
        Me.CreateLetterToolBttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CreateLetterToolBttn.Enabled = False
        Me.CreateLetterToolBttn.Image = CType(resources.GetObject("CreateLetterToolBttn.Image"), System.Drawing.Image)
        Me.CreateLetterToolBttn.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.CreateLetterToolBttn.Name = "CreateLetterToolBttn"
        Me.CreateLetterToolBttn.Size = New System.Drawing.Size(23, 22)
        Me.CreateLetterToolBttn.ToolTipText = "Create Distribution Letter"
        '
        'PrintWindow
        '
        Me.PrintWindow.AllowCurrentPage = True
        Me.PrintWindow.Document = Me.DistributionDocument
        Me.PrintWindow.UseEXDialog = True
        '
        'DistributionDocument
        '
        '
        'PrintPreview
        '
        Me.PrintPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreview.Document = Me.DistributionDocument
        Me.PrintPreview.Enabled = True
        Me.PrintPreview.Icon = CType(resources.GetObject("PrintPreview.Icon"), System.Drawing.Icon)
        Me.PrintPreview.Name = "PrintPreview"
        Me.PrintPreview.Visible = False
        '
        'DistributionsBindingSource
        '
        Me.DistributionsBindingSource.DataMember = "Distributions"
        Me.DistributionsBindingSource.DataSource = Me.DistributionsDataSet
        '
        'DistributionsDataSet
        '
        Me.DistributionsDataSet.DataSetName = "DistributionsDataSet"
        Me.DistributionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DistributionsTableAdapter
        '
        Me.DistributionsTableAdapter.ClearBeforeFill = True
        '
        'TabPages
        '
        Me.TabPages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabPages.Controls.Add(Me.DistributionTab)
        Me.TabPages.Controls.Add(Me.PrintPreviewTab)
        Me.TabPages.Controls.Add(Me.DatabaseTab)
        Me.TabPages.Location = New System.Drawing.Point(0, 47)
        Me.TabPages.Name = "TabPages"
        Me.TabPages.SelectedIndex = 0
        Me.TabPages.Size = New System.Drawing.Size(731, 482)
        Me.TabPages.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabPages.TabIndex = 4
        '
        'DistributionTab
        '
        Me.DistributionTab.AutoScroll = True
        Me.DistributionTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DistributionTab.Controls.Add(Me.InputPanel)
        Me.DistributionTab.Location = New System.Drawing.Point(4, 22)
        Me.DistributionTab.Name = "DistributionTab"
        Me.DistributionTab.Padding = New System.Windows.Forms.Padding(3)
        Me.DistributionTab.Size = New System.Drawing.Size(723, 456)
        Me.DistributionTab.TabIndex = 0
        Me.DistributionTab.Text = "Distribution Tab"
        '
        'PrintPreviewTab
        '
        Me.PrintPreviewTab.AutoScroll = True
        Me.PrintPreviewTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PrintPreviewTab.Controls.Add(Me.PrintPreviewTabWindow)
        Me.PrintPreviewTab.Location = New System.Drawing.Point(4, 22)
        Me.PrintPreviewTab.Name = "PrintPreviewTab"
        Me.PrintPreviewTab.Padding = New System.Windows.Forms.Padding(3)
        Me.PrintPreviewTab.Size = New System.Drawing.Size(723, 456)
        Me.PrintPreviewTab.TabIndex = 2
        Me.PrintPreviewTab.Text = "Print Preview"
        '
        'PrintPreviewTabWindow
        '
        Me.PrintPreviewTabWindow.AutoZoom = False
        Me.PrintPreviewTabWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintPreviewTabWindow.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PrintPreviewTabWindow.Location = New System.Drawing.Point(3, 3)
        Me.PrintPreviewTabWindow.Name = "PrintPreviewTabWindow"
        Me.PrintPreviewTabWindow.Size = New System.Drawing.Size(717, 450)
        Me.PrintPreviewTabWindow.TabIndex = 0
        Me.PrintPreviewTabWindow.Zoom = 0.8R
        '
        'DatabaseTab
        '
        Me.DatabaseTab.AutoScroll = True
        Me.DatabaseTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DatabaseTab.Controls.Add(Me.DistributionsDataGrid)
        Me.DatabaseTab.Location = New System.Drawing.Point(4, 22)
        Me.DatabaseTab.Name = "DatabaseTab"
        Me.DatabaseTab.Padding = New System.Windows.Forms.Padding(3)
        Me.DatabaseTab.Size = New System.Drawing.Size(723, 456)
        Me.DatabaseTab.TabIndex = 1
        Me.DatabaseTab.Text = "Database Tab"
        '
        'DistributionsDataGrid
        '
        Me.DistributionsDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DistributionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DistributionsDataGrid.Location = New System.Drawing.Point(-1, 0)
        Me.DistributionsDataGrid.Name = "DistributionsDataGrid"
        Me.DistributionsDataGrid.ReadOnly = True
        Me.DistributionsDataGrid.Size = New System.Drawing.Size(728, 459)
        Me.DistributionsDataGrid.TabIndex = 0
        '
        'DistinctLocationTableAdapter
        '
        Me.DistinctLocationTableAdapter.ClearBeforeFill = True
        '
        'RefreshDBToolBttn
        '
        Me.RefreshDBToolBttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RefreshDBToolBttn.Enabled = False
        Me.RefreshDBToolBttn.Image = CType(resources.GetObject("RefreshDBToolBttn.Image"), System.Drawing.Image)
        Me.RefreshDBToolBttn.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.RefreshDBToolBttn.Name = "RefreshDBToolBttn"
        Me.RefreshDBToolBttn.Size = New System.Drawing.Size(23, 22)
        Me.RefreshDBToolBttn.ToolTipText = "Refresh Database"
        '
        'DistributionForm
        '
        Me.AccessibleDescription = "Creates Distribution Files"
        Me.AccessibleName = "DistroHelp"
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(731, 554)
        Me.Controls.Add(Me.TabPages)
        Me.Controls.Add(Me.Toolbar)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "DistributionForm"
        Me.Opacity = 0.97R
        Me.Tag = "DistroHelp"
        Me.Text = "Distribuion Helper"
        Me.InputPanel.ResumeLayout(False)
        Me.InputPanel.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.Toolbar.ResumeLayout(False)
        Me.Toolbar.PerformLayout()
        CType(Me.DistributionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistributionsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPages.ResumeLayout(False)
        Me.DistributionTab.ResumeLayout(False)
        Me.PrintPreviewTab.ResumeLayout(False)
        Me.DatabaseTab.ResumeLayout(False)
        CType(Me.DistributionsDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InputPanel As Panel
    Friend WithEvents RecipNameLabel As Label
    Friend WithEvents RecipAddyLabel As Label
    Friend WithEvents RecipNameTextBox As TextBox
    Friend WithEvents RecipAddyTextBox As TextBox
    Friend WithEvents SoftwareLocLabel As Label
    Friend WithEvents DistroPathTextBox As TextBox
    Friend WithEvents ShipMethodLabel As Label
    Friend WithEvents WeightLabel As Label
    Friend WithEvents RecipPhoneLabel As Label
    Friend WithEvents PackageWeightTextBox As TextBox
    Friend WithEvents RecipPhoneTextBox As TextBox
    Friend WithEvents ShipMethodComboBox As ComboBox
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenMenuItem As ToolStripMenuItem
    Friend WithEvents SaveMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents InfoStatusLabel As ToolStripStatusLabel
    Friend WithEvents ProgressBar As ToolStripProgressBar
    Friend WithEvents DistributionDate As DateTimePicker
    Friend WithEvents DateLabel As Label
    Friend WithEvents Toolbar As ToolStrip
    Friend WithEvents BrowseToolbarBttn As ToolStripButton
    Friend WithEvents SaveToolBttn As ToolStripButton
    Friend WithEvents PrintToolBttn As ToolStripButton
    Friend WithEvents PrintWindow As PrintDialog
    Friend WithEvents DistributionDocument As Printing.PrintDocument
    Friend WithEvents PrintPreview As PrintPreviewDialog
    Friend WithEvents PrintPrevToolBttn As ToolStripButton
    Friend WithEvents AddToDatabaseMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents PrintMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewMenuItem As ToolStripMenuItem
    Friend WithEvents AddToDatabaseToolBttn As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CustomerComboBox As ComboBox
    Friend WithEvents CustomerLabel As Label
    Friend WithEvents DistributionsDataSet As DistributionsDataSet
    Friend WithEvents DistributionsBindingSource As BindingSource
    Friend WithEvents DistributionsTableAdapter As DistributionsDataSetTableAdapters.DistributionsTableAdapter
    Friend WithEvents LocationNameLabel As Label
    Friend WithEvents LocationNameTextBox As TextBox
    Friend WithEvents InternalJobNumComboBox As ComboBox
    Friend WithEvents InternalJobNumLabel As Label
    Friend WithEvents CustomerJobNumComboBox As ComboBox
    Friend WithEvents CustomerJobNumberLabel As Label
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents DistEmailToolBttn As ToolStripButton
    Friend WithEvents CreateLabelsToolBttn As ToolStripButton
    Friend WithEvents CreateLetterToolBttn As ToolStripButton
    Friend WithEvents TabPages As TabControl
    Friend WithEvents DistributionTab As TabPage
    Friend WithEvents DatabaseTab As TabPage
    Friend WithEvents DistributionsDataGrid As DataGridView
    Friend WithEvents PrintPreviewTab As TabPage
    Friend WithEvents PrintPreviewTabWindow As PrintPreviewControl
    Friend WithEvents DistinctLocationTableAdapter As DistributionsDataSetTableAdapters.DistributionsTableAdapter
    Friend WithEvents RefreshDBToolBttn As ToolStripButton
End Class
