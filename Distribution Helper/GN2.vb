Public Class GN2
    Inherits ProgramFile
    Private NV_Checksum As String
    Private NV_CRC As String

    Public Sub New(filename As String)
        MyBase.New(filename, "GN2")
        GetChecksumAndCRC()
    End Sub


    Public Overrides Function ToString() As String
        Return Me.GetName & " (" & Me.GetEquipType & ")" & vbCrLf & "gnl: CRC = " &
            Me.NV_CRC & "; Checksum = " & Me.NV_Checksum
    End Function


    Public Sub SetNV_Checksum(chksum As String)
        Me.NV_Checksum = chksum
    End Sub


    Public Function GetNV_Checksum() As String
        Return Me.NV_Checksum
    End Function


    Public Sub SetNV_CRC(crc As String)
        Me.NV_CRC = crc
    End Sub


    Public Function GetNV_CRC() As String
        Return Me.NV_CRC
    End Function

    Sub GetChecksumAndCRC()
        Dim fso = CreateObject("Scripting.FileSystemObject")
        Dim gnlPathAndName = My.Forms.DistributionForm.DistroPathTextBox.Text & "\" & Me.GetName & ".gnl"
        If System.IO.File.Exists(gnlPathAndName) Then
            Dim gnlFile = fso.OpenTextFile(gnlPathAndName)
            Do Until gnlFile.AtEndOfStream
                Dim nextLine = gnlFile.ReadLine
                If InStr(nextLine, "Application Image CRC:") <> 0 Then
                    Me.SetNV_CRC(Right(nextLine, 4))
                ElseIf InStr(nextLine, "Application Image Checksum:") <> 0 Then
                    Me.SetNV_Checksum(Right(nextLine, 4))
                End If
            Loop
            gnlFile.Close
        Else
            MsgBox("gnl file does not exist")
        End If
    End Sub


    Public Overrides Sub InsertDistributionToDB(con As SqlClient.SqlConnection, primaryKey As Integer, revNum As Integer)
        Dim cmd As New SqlClient.SqlCommand

        cmd.CommandText = "INSERT INTO Distributions(ID, locationName, programName, date, v_crc, v_sum, revision, 
            customer, customerJobNum, internalJobNum, equipmentType) VALUES(" & primaryKey & ", 
            '" & My.Forms.DistributionForm.LocationNameTextBox.Text & "', '" & Me.GetName & "', 
            '" & My.Forms.DistributionForm.DistributionDate.Value & "', '" & Me.GetNV_CRC & "', 
            '" & Me.GetNV_Checksum & "', '" & revNum & "','" & My.Forms.DistributionForm.CustomerComboBox.Text & "', 
            '" & My.Forms.DistributionForm.CustomerJobNumComboBox.Text & "', 
            '" & My.Forms.DistributionForm.InternalJobNumComboBox.Text & "', '" & Me.GetEquipType & "')"

        cmd.CommandType = CommandType.Text
        cmd.Connection = con

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error:" & vbCrLf & ex.Message)
        End Try
    End Sub
End Class
