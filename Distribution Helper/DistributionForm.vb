Imports System.Drawing.Printing

Public Class DistributionForm
    Dim tempInfoString
    Dim INITIAL_ARRAY_SIZE = 8
    Dim DistributionPrograms(INITIAL_ARRAY_SIZE)
    Dim DistributionDataLoaded As Boolean = False
    Dim locationInfo As LocationData
    Dim xrlFolder = Nothing

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsMenuItem.Click
        SaveFileDialog.ShowDialog()
    End Sub


    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenMenuItem.Click
        SelectFolder()
    End Sub


    Private Sub DistroPathTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles DistroPathTextBox.KeyDown
        If e.KeyValue.Equals(13) Then
            If System.IO.Directory.Exists(Me.DistroPathTextBox.Text) Then
                'Enter or TAB and path exists
                FindFilesAndCreateProgramSelectWindow()
                InfoStatusLabel.Text = ""
            Else
                InfoStatusLabel.Text = "Invalid path"
            End If
        End If
        'Console.Write("pressed " & Int(e.KeyValue) & vbCrLf)
    End Sub


    Private Sub PackageWeightTextBox_MouseHover(sender As Object, e As EventArgs) Handles PackageWeightTextBox.MouseHover
        tempInfoString = InfoStatusLabel.Text
        InfoStatusLabel.Text = "Weight in Pounds (Underestimation)"
    End Sub

    Private Sub PackageWeightTextBox_MouseLeave(sender As Object, e As EventArgs) Handles PackageWeightTextBox.MouseLeave
        InfoStatusLabel.Text = tempInfoString
    End Sub

    Private Sub DistroPathTextBox_MouseHover(sender As Object, e As EventArgs) Handles DistroPathTextBox.MouseHover
        tempInfoString = InfoStatusLabel.Text
        InfoStatusLabel.Text = "Use the ""Browse"" toolbar button or ""New"" under the ""File"" menu"
    End Sub

    Private Sub DistroPathTextBox_MouseLeave(sender As Object, e As EventArgs) Handles DistroPathTextBox.MouseLeave
        InfoStatusLabel.Text = tempInfoString
    End Sub

    Private Sub RecipAddyTextBox_MouseHover(sender As Object, e As EventArgs) Handles RecipAddyTextBox.MouseHover
        tempInfoString = InfoStatusLabel.Text
        InfoStatusLabel.Text = "Full shipping address"
    End Sub

    Private Sub RecipAddyTextBox_MouseLeave(sender As Object, e As EventArgs) Handles RecipAddyTextBox.MouseLeave
        InfoStatusLabel.Text = tempInfoString
    End Sub

    Private Sub RecipNameTextBox_MouseHover(sender As Object, e As EventArgs) Handles RecipNameTextBox.MouseHover
        tempInfoString = InfoStatusLabel.Text
        InfoStatusLabel.Text = "Recipient's first and last name"
    End Sub

    Private Sub RecipNameTextBox_MouseLeave(sender As Object, e As EventArgs) Handles RecipNameTextBox.MouseLeave
        InfoStatusLabel.Text = tempInfoString
    End Sub

    Private Sub RecipPhoneTextBox_MouseHover(sender As Object, e As EventArgs) Handles RecipPhoneTextBox.MouseHover
        tempInfoString = InfoStatusLabel.Text
        InfoStatusLabel.Text = "Recipient's phone number (123) 456-7890"
    End Sub

    Private Sub RecipPhoneTextBox_MouseLeave(sender As Object, e As EventArgs) Handles RecipPhoneTextBox.MouseLeave
        InfoStatusLabel.Text = tempInfoString
    End Sub

    Private Sub ShipMethodComboBox_MouseHover(sender As Object, e As EventArgs) Handles ShipMethodComboBox.MouseHover
        tempInfoString = InfoStatusLabel.Text
        InfoStatusLabel.Text = "Use dropdown to select shipping method"
    End Sub

    Private Sub ShipMethodComboBox_MouseLeave(sender As Object, e As EventArgs) Handles ShipMethodComboBox.MouseLeave
        InfoStatusLabel.Text = tempInfoString
    End Sub

    Private Sub ShipMethodComboBox_Click(sender As Object, e As EventArgs) Handles ShipMethodComboBox.Click
        InfoStatusLabel.Text = tempInfoString
    End Sub

    Private Sub BrowseButton_MouseHover(sender As Object, e As EventArgs)
        tempInfoString = InfoStatusLabel.Text
        InfoStatusLabel.Text = "Press to select folder containing distribution files"
    End Sub

    Private Sub BrowseButton_MouseLeave(sender As Object, e As EventArgs)
        InfoStatusLabel.Text = tempInfoString
    End Sub

    Private Sub DistributionDate_MouseHover(sender As Object, e As EventArgs) Handles DistributionDate.MouseHover
        tempInfoString = InfoStatusLabel.Text
        InfoStatusLabel.Text = "Choose the date for this distribution"
    End Sub

    Private Sub DistributionDate_MouseLeave(sender As Object, e As EventArgs) Handles DistributionDate.MouseLeave
        InfoStatusLabel.Text = tempInfoString
    End Sub

    Private Sub BrowseToolbarBttn_MouseHover(sender As Object, e As EventArgs) Handles BrowseToolbarBttn.MouseHover
        tempInfoString = InfoStatusLabel.Text
        InfoStatusLabel.Text = "Browse"
    End Sub

    Private Sub BrowseToolbarBttn_MouseLeave(sender As Object, e As EventArgs) Handles BrowseToolbarBttn.MouseLeave
        InfoStatusLabel.Text = tempInfoString
    End Sub

    Private Sub SaveToolBttn_MouseHover(sender As Object, e As EventArgs) Handles SaveToolBttn.MouseHover
        tempInfoString = InfoStatusLabel.Text
        InfoStatusLabel.Text = "Save"
    End Sub

    Private Sub SaveToolBttn_MouseLeave(sender As Object, e As EventArgs) Handles SaveToolBttn.MouseLeave
        InfoStatusLabel.Text = tempInfoString
    End Sub

    Private Sub PrintToolBttn_MouseHover(sender As Object, e As EventArgs) Handles PrintToolBttn.MouseHover
        tempInfoString = InfoStatusLabel.Text
        InfoStatusLabel.Text = "Print"
    End Sub

    Private Sub PrintToolBttn_MouseLeave(sender As Object, e As EventArgs) Handles PrintToolBttn.MouseLeave
        InfoStatusLabel.Text = tempInfoString
    End Sub

    Private Sub PrintPrevToolBttn_MouseHover(sender As Object, e As EventArgs) Handles PrintPrevToolBttn.MouseHover
        tempInfoString = InfoStatusLabel.Text
        InfoStatusLabel.Text = "Print preview"
    End Sub

    Private Sub PrintPrevToolBttn_MouseLeave(sender As Object, e As EventArgs) Handles PrintPrevToolBttn.MouseLeave
        InfoStatusLabel.Text = tempInfoString
    End Sub


    Private Sub AddToDatabaseToolBttn_MouseHover(sender As Object, e As EventArgs) Handles AddToDatabaseToolBttn.MouseHover
        tempInfoString = InfoStatusLabel.Text
        InfoStatusLabel.Text = "Insert information to database"
    End Sub


    Private Sub AddToDatabaseToolBttn_MouseLeave(sender As Object, e As EventArgs) Handles AddToDatabaseToolBttn.MouseLeave
        InfoStatusLabel.Text = tempInfoString
    End Sub


    Private Sub CustomerComboBox_MouseHover(sender As Object, e As EventArgs) Handles CustomerComboBox.MouseHover
        tempInfoString = InfoStatusLabel.Text
        InfoStatusLabel.Text = "Customer"
    End Sub


    Private Sub CustomerComboBox_MouseLeave(sender As Object, e As EventArgs) Handles CustomerComboBox.MouseLeave
        InfoStatusLabel.Text = tempInfoString
    End Sub


    Private Sub CustomerJobNumComboBox_MouseHover(sender As Object, e As EventArgs) Handles CustomerJobNumComboBox.MouseHover
        tempInfoString = InfoStatusLabel.Text
        InfoStatusLabel.Text = "Customer job number"
    End Sub


    Private Sub CustomerJobNumComboBox_MouseLeave(sender As Object, e As EventArgs) Handles CustomerJobNumComboBox.MouseLeave
        InfoStatusLabel.Text = tempInfoString
    End Sub


    Private Sub LocationNameTextBox_MouseHover(sender As Object, e As EventArgs) Handles LocationNameTextBox.MouseHover
        tempInfoString = InfoStatusLabel.Text
        InfoStatusLabel.Text = "Location name"
    End Sub


    Private Sub LocationNameTextBox_MouseLeave(sender As Object, e As EventArgs) Handles LocationNameTextBox.MouseLeave
        InfoStatusLabel.Text = tempInfoString
    End Sub


    Private Sub InternalJobNumComboBox_MouseHover(sender As Object, e As EventArgs) Handles InternalJobNumComboBox.MouseHover
        tempInfoString = InfoStatusLabel.Text
        InfoStatusLabel.Text = "Internal job number"
    End Sub


    Private Sub InternalJobNumComboBox_MouseLeave(sender As Object, e As EventArgs) Handles InternalJobNumComboBox.MouseLeave
        InfoStatusLabel.Text = tempInfoString
    End Sub


    Private Sub DistributionDate_MouseClick(sender As Object, e As MouseEventArgs) Handles DistributionDate.MouseClick
        InfoStatusLabel.Text = tempInfoString
    End Sub


    Private Sub CustomerComboBox_Click(sender As Object, e As EventArgs) Handles CustomerComboBox.Click
        InfoStatusLabel.Text = tempInfoString
    End Sub


    Private Sub CustomerJobNumComboBox_Click(sender As Object, e As EventArgs) Handles CustomerJobNumComboBox.Click
        InfoStatusLabel.Text = tempInfoString
    End Sub


    Private Sub InternalJobNumComboBox_Click(sender As Object, e As EventArgs) Handles InternalJobNumComboBox.Click
        InfoStatusLabel.Text = tempInfoString
    End Sub


    Private Sub DistributionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'future use of datagridview
        BindGrid()

        'read from database and fill in combo boxes
        LoadCustomerComboBox()
        LoadCustomerJobNumComboBox()
        LoadInternalJobNumComboBox()

        'fill in combo box for shipping methods
        ShipMethodComboBox.Items.Add("Standard (3-5 Days)")
        ShipMethodComboBox.Items.Add("Express (1-2 Days)")
        ShipMethodComboBox.Items.Add("Overnight")
        ShipMethodComboBox.SelectedItem = "Standard (3-5 Days)"
    End Sub


    Private Sub BindGrid()
        DataGridView1.DataSource = DistributionsBindingSource

    End Sub


    Private Sub SelectFolder()
        Dim StartDir As String
        If Not Me.DistroPathTextBox.Text = "" Then
            StartDir = Me.DistroPathTextBox.Text
        Else
            StartDir = "P:\"
        End If
        Dim FilesDirectory = GetDistributionFolder(StartDir, "Browse for folder containing distribution files")
        InfoStatusLabel.Text = tempInfoString
        If Not FilesDirectory = "" Then
            DistroPathTextBox.Text = FilesDirectory
            FindFilesAndCreateProgramSelectWindow()
        End If
    End Sub


    Private Function GetInfoFile() As String
        InfoStatusLabel.Text = "Looking for info worksheet..."
        Dim fso = CreateObject("Scripting.FileSystemObject")
        Dim f = fso.GetFolder(DistroPathTextBox.Text)
        Dim subFldrs = f.SubFolders
        For Each subF In subFldrs
            If (UCase(subF.name.Substring(0, 3)) = "XRL") Then
                Dim infoPathStr = fso.GetAbsolutePathName(subF)
                xrlFolder = infoPathStr
                Dim folder = fso.GetFolder(infoPathStr)
                For Each f In folder.Files
                    If f.Name.Length > 19 Then
                        If (f.Name.Substring(f.Name.Length - 19) = "info worksheet.xlsm") Then
                            Return infoPathStr & "\" & f.Name
                            fso = Nothing
                            Exit Function
                        End If
                    End If
                Next
            End If
        Next
        Return ""
    End Function


    Private Function GetDistributionFolder(currentDir As String, instructionString As String) As String
        Const msoFileDialogOpen = 4
        Dim FolderPath = Nothing
        Dim i = 0
        Dim fso = CreateObject("Scripting.FileSystemObject")
        Dim objWord = CreateObject("Word.Application")
        objWord.ChangeFileOpenDirectory(currentDir)

        With objWord.FileDialog(msoFileDialogOpen)
            .Title = instructionString
            .AllowMultiSelect = False
            .Filters.Clear
            .AllowMultiSelect = False
            .Filters.Clear
            '.Filters.Add("Log Files", "*.LOG")

            If .Show = -1 Then  'short form
                For Each Folder In .SelectedItems  'short form
                    Dim objFile = fso.GetFolder(Folder)
                    FolderPath = objFile.Path
                    i += 1
                Next
            End If
        End With
        If i = 0 Then
            GetDistributionFolder = ""
        Else
            GetDistributionFolder = FolderPath
        End If
        objWord.Quit
        objWord = Nothing
    End Function


    Private Sub FindFilesAndCreateProgramSelectWindow()
        Dim dirPathComponents = Split(Me.DistroPathTextBox.Text, "\")
        If dirPathComponents.Length > 1 Then
            Me.CustomerComboBox.Text = UCase(dirPathComponents(1))
        End If

        'check for info worksheet in XRL folder
        Dim infoFile = GetInfoFile()

        If infoFile <> "" Then
            InfoStatusLabel.Text = "Reading info worksheet..."
            locationInfo = New LocationData(infoFile)
            Me.CustomerJobNumComboBox.Text = locationInfo.GetCustomerNumber()
            Me.InternalJobNumComboBox.Text = locationInfo.GetInternalNumber()
            Me.LocationNameTextBox.Text = locationInfo.GetLocationName()
            locationInfo.SetCustomer(Me.CustomerComboBox.Text)
        End If

        InfoStatusLabel.Text = "Looking for software to distribute..."
        Dim j = 0
        Dim filesys = CreateObject("Scripting.FileSystemObject")
        If filesys.FolderExists(Me.DistroPathTextBox.Text) Then
            Dim Folder = filesys.getfolder(Me.DistroPathTextBox.Text)
            For Each File In Folder.Files
                Dim filetype = filesys.GetExtensionName(File)
                Dim filename = filesys.GetFileName(File)

                If InStr(filename, "~") = 0 And Not filetype Is Nothing Then 'dont use system files
                    Dim typeStr = filetype.ToUpper
                    If New String() {"CCF", "LOC", "ML2", "GN2", "MAP"}.Contains(typeStr) Then
                        ' Create a checkbox
                        Dim checkBox As New CheckBox()
                        ' Add checkbox to form
                        My.Forms.ProgramSelectorWindow.ProgramsPanel.Controls.Add(checkBox)
                        'Set size, position, ...
                        checkBox.Text = filename
                        checkBox.Location = New Point(10, j * 20)
                        checkBox.Size = New Size(160, 20)
                        checkBox.Checked = True
                        j = j + 1
                    End If
                End If
            Next
            If j > 0 Then
                Dim OkButton As New Button()
                My.Forms.ProgramSelectorWindow.ProgramsPanel.Controls.Add(OkButton)
                OkButton.Text = "OK"
                OkButton.Location = New Point(My.Forms.ProgramSelectorWindow.Width / 2 + 5, j * 20 + 10)
                OkButton.Size = New Size(My.Forms.ProgramSelectorWindow.Width / 2 - 10, 30)
                AddHandler OkButton.Click, AddressOf Me.OkButton_Click

                Dim CancelButton As New Button()
                My.Forms.ProgramSelectorWindow.ProgramsPanel.Controls.Add(CancelButton)
                CancelButton.Text = "Cancel"
                CancelButton.Location = New Point(1, j * 20 + 10)
                CancelButton.Size = New Size(My.Forms.ProgramSelectorWindow.Width / 2 - 10, 30)
                AddHandler CancelButton.Click, AddressOf Me.CancelButton_Click

                My.Forms.ProgramSelectorWindow.Show()
            Else
                MsgBox("There are no B1 or H14 Files to Distribute in the selected folder.")
            End If
        Else
            Me.DistroPathTextBox.Text = "Invalid path."
        End If
    End Sub


    Private Sub OkButton_Click(sender As Object, e As EventArgs)
        Dim i = 0
        Array.Clear(DistributionPrograms, 0, DistributionPrograms.Length)
        For Each controlObj In My.Forms.ProgramSelectorWindow.ProgramsPanel.Controls
            If controlObj.GetType() Is GetType(System.Windows.Forms.CheckBox) Then
                If controlObj.Checked Then
                    If i = DistributionPrograms.Length Then
                        Dim NewArraySize = DistributionPrograms.Length + INITIAL_ARRAY_SIZE
                        ReDim DistributionPrograms(NewArraySize)
                    End If

                    DistributionPrograms(i) = DetermineProgramType(controlObj.Text) 'Array of ProgramFile objects
                    'MsgBox(i & vbCrLf & DistributionPrograms(i).GetName() & vbCrLf & DistributionPrograms(i).GetEquipType())
                    i = i + 1
                End If
            End If
        Next
        My.Forms.ProgramSelectorWindow.Close()
        For Each Prog In DistributionPrograms
            If Not Prog Is Nothing Then
                EnableDataViewFunctions()
                Exit For
            Else
                DisableDataViewFunctions()
            End If
        Next
    End Sub


    Private Function DetermineProgramType(fileStr As String) As ProgramFile
        Dim filetype = System.IO.Path.GetExtension(fileStr)
        Dim filename = System.IO.Path.GetFileNameWithoutExtension(fileStr)

        Dim typeStr = filetype.ToUpper
        Dim program
        'MsgBox(typeStr)
        Select Case typeStr
            Case ".CCF"
                If System.IO.File.Exists(Me.DistroPathTextBox.Text & "\" & filename & ".H30") Then
                    program = New NonVitalHLC(filename, "ACE")
                ElseIf System.IO.File.Exists(Me.DistroPathTextBox.Text & "\" & filename & ".H14") Then
                    program = New VitalHLC(filename, "ACE")
                Else
                    program = New ElectroLogIXS(filename)
                End If
            Case ".LOC"
                If System.IO.File.Exists(Me.DistroPathTextBox.Text & "\" & filename & ".H30") Then
                    program = New NonVitalHLC(filename, "ALC")
                Else
                    program = New VitalHLC(filename, "ALC")
                End If
            Case ".ML2"
                program = New ML2(filename)
            Case ".GN2"
                program = New GN2(filename)
            Case ".MAP"
                program = New EC4(filename)
            Case Else
                program = Nothing
        End Select
        Return program

    End Function


    Private Sub CancelButton_Click(sender As Object, e As EventArgs)
        My.Forms.ProgramSelectorWindow.Close()
    End Sub


    Private Sub BrowseToolbarBttn_Click(sender As Object, e As EventArgs) Handles BrowseToolbarBttn.Click
        SelectFolder()
    End Sub


    Private Sub PrintToolBttn_Click(sender As Object, e As EventArgs) Handles PrintToolBttn.Click

        Dim result = PrintWindow.ShowDialog()
        If result = DialogResult.OK Then
            DistributionDocument.Print()
        End If

    End Sub


    Private Sub DistributionDocument_PrintPage(sender As Object, e As PrintPageEventArgs) Handles DistributionDocument.PrintPage
        Dim DocFont As New Font("Arial", 12, FontStyle.Regular)
        Dim ProgInfoStr = ""
        If Not locationInfo Is Nothing Then
            ProgInfoStr = locationInfo.ToString()
        End If

        For Each Prog In DistributionPrograms
            If Prog Is Nothing Then
                Exit For
            End If
            ProgInfoStr = ProgInfoStr & Prog.ToString & vbCrLf & vbCrLf
        Next
        e.Graphics.DrawString(ProgInfoStr, DocFont, Brushes.Black, 100, 100)
    End Sub


    Private Sub PrintPrevToolBttn_Click(sender As Object, e As EventArgs) Handles PrintPrevToolBttn.Click
        PrintPreview.ShowDialog()
    End Sub


    Private Sub AddToDatabaseToolBttn_Click(sender As Object, e As EventArgs) Handles AddToDatabaseToolBttn.Click
        InsertDistInfoToDatabase()
    End Sub


    Private Sub AddToDatabaseMenuItem_Click(sender As Object, e As EventArgs) Handles AddToDatabaseMenuItem.Click
        InsertDistInfoToDatabase()
    End Sub


    Private Sub InsertDistInfoToDatabase()
        Dim connection = New SqlClient.SqlConnection("Data Source=XJALAP0569\SQLEXPRESS;Initial Catalog=Distributions;Integrated Security=True;MultipleActiveResultSets=True")
        connection.Open()

        Dim totalProgress = DistributionPrograms.Length
        Dim currentProgress = 1
        Me.ProgressBar.Visible = True

        For Each Prog In DistributionPrograms
            If Prog Is Nothing Then
                Exit For
            End If
            Dim nextPrimaryKey = GetNextPrimaryKey(connection)
            Dim nextRevNumber = getNextRevisionNumber(connection, Prog.GetName)
            Prog.InsertDistributionToDB(connection, nextPrimaryKey, nextRevNumber)
            'Console.WriteLine("Primary Key: " & nextPrimaryKey & vbCrLf & "Revision Number: " & nextRevNumber & vbCrLf & vbCrLf)
            currentProgress += 1
            Me.ProgressBar.Value = 100 * currentProgress / totalProgress
        Next

        Me.ProgressBar.Value = 100
        InfoStatusLabel.Text = "Distribution information was inserted successfully to the database"

        connection.Close()

        LoadInternalJobNumComboBox()
        LoadCustomerComboBox()
        LoadCustomerJobNumComboBox()

        Me.ProgressBar.Visible = False
    End Sub


    Private Function GetNextPrimaryKey(con As SqlClient.SqlConnection) As Integer
        Dim cmd As New SqlClient.SqlCommand
        Dim reader As SqlClient.SqlDataReader

        cmd.CommandText = "SELECT MAX(ID) FROM Distributions"
        cmd.CommandType = CommandType.Text
        cmd.Connection = con

        reader = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        reader.Read()
        Dim maxPrimaryKey = CType(reader, IDataRecord)

        If TypeOf maxPrimaryKey(0) Is DBNull Then
            Return 0
        Else
            Return Int(maxPrimaryKey(0)) + 1
        End If

    End Function


    Private Sub LoadCustomerComboBox()
        Dim cmd As New SqlClient.SqlCommand
        Dim reader As SqlClient.SqlDataReader
        Dim nextRev = 0

        cmd.CommandText = "SELECT DISTINCT customer FROM Distributions"
        cmd.CommandType = CommandType.Text
        cmd.Connection = Me.DistributionsTableAdapter.Connection
        cmd.Connection.Open()

        CustomerComboBox.Items.Clear()
        reader = cmd.ExecuteReader()
        While reader.Read()
            Dim customer = CType(reader, IDataRecord)

            If Not TypeOf customer(0) Is DBNull Then
                CustomerComboBox.Items.Add(customer(0))
            End If
        End While

        cmd.Connection.Close()
    End Sub


    Private Sub LoadInternalJobNumComboBox()
        Dim cmd As New SqlClient.SqlCommand
        Dim reader As SqlClient.SqlDataReader
        Dim nextRev = 0

        cmd.CommandText = "SELECT DISTINCT internalJobNum FROM Distributions"
        cmd.CommandType = CommandType.Text
        cmd.Connection = Me.DistributionsTableAdapter.Connection
        cmd.Connection.Open()

        InternalJobNumComboBox.Items.Clear()
        reader = cmd.ExecuteReader()
        While reader.Read()
            Dim internalJobNum = CType(reader, IDataRecord)

            If Not TypeOf internalJobNum(0) Is DBNull Then
                InternalJobNumComboBox.Items.Add(internalJobNum(0))
            End If
        End While

        cmd.Connection.Close()
    End Sub


    Private Sub LoadCustomerJobNumComboBox()
        Dim cmd As New SqlClient.SqlCommand
        Dim reader As SqlClient.SqlDataReader
        Dim nextRev = 0

        cmd.CommandText = "SELECT DISTINCT customerJobNum FROM Distributions WHERE customerJobNum <> '';"
        cmd.CommandType = CommandType.Text
        cmd.Connection = Me.DistributionsTableAdapter.Connection
        cmd.Connection.Open()

        CustomerJobNumComboBox.Items.Clear()
        reader = cmd.ExecuteReader()
        While reader.Read()
            Dim customerJobNum = CType(reader, IDataRecord)

            If Not TypeOf customerJobNum(0) Is DBNull Then
                CustomerJobNumComboBox.Items.Add(customerJobNum(0))
            End If
        End While

        cmd.Connection.Close()
    End Sub


    Private Function getNextRevisionNumber(con As SqlClient.SqlConnection, programName As String) As Integer
        Dim cmd As New SqlClient.SqlCommand
        Dim reader As SqlClient.SqlDataReader
        Dim nextRev = 0

        cmd.CommandText = "SELECT MAX(revision) FROM Distributions WHERE (programName = '" & programName & "' AND internalJobNum = '" & InternalJobNumComboBox.Text & "');"
        cmd.CommandType = CommandType.Text
        cmd.Connection = con

        reader = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        If reader.Read() Then
            Dim revision = CType(reader, IDataRecord)

            If Not TypeOf revision(0) Is DBNull Then
                nextRev = Int(revision(0)) + 1
            End If
        End If

        Return nextRev
    End Function


    Private Sub EnableDataViewFunctions()
        DistributionDataLoaded = True

        PrintToolBttn.Enabled = True
        PrintMenuItem.Enabled = True

        PrintPrevToolBttn.Enabled = True
        PrintPreviewMenuItem.Enabled = True
        PrintPreviewTabWindow.Document = Me.DistributionDocument

        SaveToolBttn.Enabled = True
        SaveMenuItem.Enabled = True
        SaveAsMenuItem.Enabled = True

        If Me.CustomerComboBox.Text.Trim.Equals("") Or Me.InternalJobNumComboBox.Text.Trim.Equals("") Or Me.LocationNameTextBox.Text.Trim.Equals("") Then
            InfoStatusLabel.Text = "Fill customer, internal job number, and location name fields to insert info to database."
        Else
            EnableCreationControls()
        End If
    End Sub


    Private Sub DisableDataViewFunctions()
        DistributionDataLoaded = False

        PrintToolBttn.Enabled = False
        PrintMenuItem.Enabled = False

        PrintPrevToolBttn.Enabled = False
        PrintPreviewMenuItem.Enabled = False

        SaveToolBttn.Enabled = False
        SaveMenuItem.Enabled = False
        SaveAsMenuItem.Enabled = False

        AddToDatabaseToolBttn.Enabled = False
        AddToDatabaseMenuItem.Enabled = False

        CreateLabelsToolBttn.Enabled = False

        DistEmailToolBttn.Enabled = False

        CreateLetterToolBttn.Enabled = False

    End Sub


    Private Sub CustomerComboBox_TextChanged(sender As Object, e As EventArgs) Handles CustomerComboBox.TextChanged
        If Not (Me.CustomerComboBox.Text.Trim.Equals("") Or Me.InternalJobNumComboBox.Text.Trim.Equals("") Or Me.LocationNameTextBox.Text.Trim.Equals("")) And DistributionDataLoaded Then
            EnableCreationControls()
            InfoStatusLabel.Text = ""
        Else
            DisableCreationControls()
            InfoStatusLabel.Text = "Fill customer, internal job number, and location name fields to insert info to database."
        End If
    End Sub


    Private Sub InternalJobNumComboBox_TextChanged(sender As Object, e As EventArgs) Handles InternalJobNumComboBox.TextChanged
        If Not (Me.CustomerComboBox.Text.Trim.Equals("") Or Me.InternalJobNumComboBox.Text.Trim.Equals("") Or Me.LocationNameTextBox.Text.Trim.Equals("")) And DistributionDataLoaded Then
            EnableCreationControls()
            InfoStatusLabel.Text = ""
        Else
            DisableCreationControls()
            InfoStatusLabel.Text = "Fill customer, internal job number, and location name fields to insert info to database."
        End If
    End Sub


    Private Sub LocationNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles LocationNameTextBox.TextChanged
        If Not (Me.CustomerComboBox.Text.Trim.Equals("") Or Me.InternalJobNumComboBox.Text.Trim.Equals("") Or Me.LocationNameTextBox.Text.Trim.Equals("")) And DistributionDataLoaded Then
            EnableCreationControls()
            InfoStatusLabel.Text = ""
        Else
            DisableCreationControls()
            InfoStatusLabel.Text = "Fill customer, internal job number, and location name fields to insert info to database."
        End If
    End Sub


    Private Sub PrintMenuItem_Click(sender As Object, e As EventArgs) Handles PrintMenuItem.Click
        Dim result = PrintWindow.ShowDialog()
        If result = DialogResult.OK Then
            DistributionDocument.Print()
        End If
    End Sub


    Private Sub PrintPreviewMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewMenuItem.Click
        PrintPreview.ShowDialog()
    End Sub


    Private Sub CreateLabelsToolBttn_Click(sender As Object, e As EventArgs) Handles CreateLabelsToolBttn.Click
        CreateLabels()
    End Sub


    Private Sub CreateLabels()
        Dim labelPath = FindOrCreateLabelsDirectory()

        Dim doc As XDocument = XDocument.Load("Blank.label")
        Dim labelnode = doc.Descendants("String")
        For Each prog In DistributionPrograms
            If Not prog Is Nothing Then
                If prog.GetEquipType() = "EC4" Then
                    labelnode(0).Value = prog.MAPLabelStr
                    labelnode(1).Value = prog.MAPLabelStr
                    doc.Save(labelPath & "\" & prog.GetName & ".label")
                ElseIf {"VHLC", "NVHLC"}.Contains(prog.GetEquipType()) Then
                    labelnode(0).Value = prog.evenLabelStr
                    labelnode(1).Value = prog.oddLabelStr
                    doc.Save(labelPath & "\" & prog.GetName & ".label")
                End If
            End If
        Next
    End Sub


    Private Function FindOrCreateLabelsDirectory() As String
        Dim fso = CreateObject("Scripting.FileSystemObject")
        Dim distributionFldrPath As String = Nothing
        Dim labelsFldrPath As String = Nothing
        Dim searchStr As String

        searchStr = "Distribution"
        Dim f = fso.GetFolder(DistroPathTextBox.Text)
        For Each subF In f.subFolders
            If subF.Name.Length >= searchStr.Length Then
                If (UCase(subF.name.Substring(0, 12)) = searchStr) Then
                    distributionFldrPath = fso.GetAbsolutePathName(subF)
                    Exit For
                End If
            End If
        Next

        If distributionFldrPath Is Nothing Then
            distributionFldrPath = DistroPathTextBox.Text & "\" & searchStr
            System.IO.Directory.CreateDirectory(distributionFldrPath)
        End If

        searchStr = "Labels"
        f = fso.GetFolder(distributionFldrPath)
        For Each subF In f.subFolders
            If subF.Name.Length >= searchStr.Length Then
                If (UCase(subF.name.Substring(0, 6)) = searchStr) Then
                    labelsFldrPath = fso.GetAbsolutePathName(subF)
                    Exit For
                End If
            End If
        Next

        If labelsFldrPath Is Nothing Then
            labelsFldrPath = distributionFldrPath & "\" & searchStr
            System.IO.Directory.CreateDirectory(labelsFldrPath)
        End If

        Return labelsFldrPath
    End Function


    Private Sub EnableCreationControls()
        AddToDatabaseToolBttn.Enabled = True
        AddToDatabaseMenuItem.Enabled = True

        CreateLabelsToolBttn.Enabled = True

        DistEmailToolBttn.Enabled = True

        CreateLetterToolBttn.Enabled = True

    End Sub


    Private Sub DisableCreationControls()
        AddToDatabaseToolBttn.Enabled = False
        AddToDatabaseMenuItem.Enabled = False

        CreateLabelsToolBttn.Enabled = False

        DistEmailToolBttn.Enabled = False

        CreateLetterToolBttn.Enabled = False

    End Sub

End Class