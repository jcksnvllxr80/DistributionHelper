Public Class ElectroLogIXS
    Inherits ProgramFile
    Private V_Checksum As String
    Private V_CRC As String
    Private NV_Checksum As String
    Private NV_CRC As String
    Private V_ValCrc As String
    Private NV_ValCrc As String
    Private ConsSum As String
    Private ConsCRC As String

    Public Sub New(filename As String)
        MyBase.New(filename, "ElectroLogIXS")
        'MsgBox("Creating ElectroLogIXS Obj")
        Me.ReadConsFile()
        Me.GetValidationCRCs()
    End Sub

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

    Public Sub SetV_Checksum(chksum As String)
        Me.V_Checksum = chksum
    End Sub

    Public Function GetV_Checksum() As String
        Return Me.V_Checksum
    End Function

    Public Sub SetV_CRC(crc As String)
        Me.V_CRC = crc
    End Sub

    Public Function GetV_CRC() As String
        Return Me.V_CRC
    End Function

    Public Sub SetV_ValCRC(valCrc As String)
        Me.V_ValCrc = valCrc
    End Sub

    Public Function GetV_ValCRC() As String
        Return Me.V_ValCrc
    End Function

    Public Sub SetNV_ValCRC(valCrc As String)
        Me.NV_ValCrc = valCrc
    End Sub

    Public Function GetNV_ValCRC() As String
        Return Me.NV_ValCrc
    End Function

    Public Sub SetConsSum(chksum As String)
        Me.ConsSum = chksum
    End Sub

    Public Function GetConsSum() As String
        Return Me.ConsSum
    End Function

    Public Sub SetConsCRC(crc As String)
        Me.ConsCRC = crc
    End Sub

    Public Function GetConsCRC() As String
        Return Me.ConsCRC
    End Function


    Public Overrides Function ToString() As String
        Return Me.GetName & " (" & Me.GetEquipType & ")" & vbCrLf & "Consolidated: CRC = " &
            Me.ConsCRC & "; Checksum = " & Me.ConsSum & vbCrLf & "Vital: CRC = " & Me.V_CRC &
            "; Checksum = " & Me.V_Checksum & vbCrLf & "Non-Vital: CRC = " & Me.NV_CRC &
            "; Checksum = " & Me.NV_Checksum & vbCrLf & "Vital Validation CRC = " & Me.V_ValCrc &
            vbCrLf & "Non-Vital Validation CRC = " & Me.NV_ValCrc
    End Function


    Sub ReadConsFile()
        Dim g
        Dim fso = CreateObject("Scripting.FileSystemObject")
        Dim consFile = My.Forms.DistributionForm.DistroPathTextBox.Text & "\" & Me.GetName & "_cons.txt"
        If System.IO.File.Exists(consFile) Then
            Dim f = fso.OpenTextFile(consFile)
            Do Until f.AtEndOfStream
                Dim nextLine = f.ReadLine
                If InStr(nextLine, "Checksum:") <> 0 Then
                    g = Split(Mid(nextLine, 10), " ")
                    For Each h In g
                        If Len(h) = 4 Then
                            Me.SetConsSum(h)
                            Exit For
                        End If
                    Next
                ElseIf InStr(nextLine, "EPT CRC:") <> 0 Then
                    g = Split(Mid(nextLine, 9), " ")
                    For Each h In g
                        If Len(h) = 4 Then
                            Me.SetConsCRC(h)
                            Exit For
                        End If
                    Next
                ElseIf InStr(nextLine, (Me.GetName & "v")) <> 0 Then
                    g = Split(Mid(nextLine, Len(Me.GetName) + 7), " ")
                    Dim sumFlag = 0
                    For Each h In g
                        If Len(h) = 4 And sumFlag = 0 Then
                            Me.SetV_Checksum(h)
                            sumFlag = 1
                        ElseIf Len(h) = 4 And sumFlag = 1 Then
                            Me.SetV_CRC(h)
                            Exit For
                        End If
                    Next
                ElseIf InStr(nextLine, (Me.GetName & "nv")) <> 0 Then
                    g = Split(Mid(nextLine, Len(Me.GetName) + 8), " ")
                    Dim sumFlag = 0
                    For Each h In g
                        If Len(h) = 4 And sumFlag = 0 Then
                            Me.SetNV_Checksum(h)
                            sumFlag = 1
                        ElseIf Len(h) = 4 And sumFlag = 1 Then
                            Me.SetNV_CRC(h)
                            Exit For
                        End If
                    Next
                End If
            Loop
            f.close
            f = Nothing
        Else
            MsgBox("Consolidated text file does not exist.")
        End If
    End Sub


    Public Sub GetValidationCRCs()
        Dim vLog = My.Forms.DistributionForm.DistroPathTextBox.Text & "\" & Me.GetName & "v.log"
        If System.IO.File.Exists(vLog) Then
            Me.V_ValCrc = Me.FindValidationCRC(vLog)
        Else
            MsgBox("Vital validation file does not exist.")
        End If

        Dim nvLog = My.Forms.DistributionForm.DistroPathTextBox.Text & "\" & Me.GetName & "nv.log"
        If System.IO.File.Exists(nvLog) Then
            Me.NV_ValCrc = Me.FindValidationCRC(nvLog)
        Else
            MsgBox("Non-vital validation file does not exist.")
        End If
    End Sub


    Public Overrides Sub InsertDistributionToDB(con As SqlClient.SqlConnection, primaryKey As Integer, revNum As Integer)
        Dim cmd As New SqlClient.SqlCommand

        cmd.CommandText = "INSERT INTO Distributions(ID, locationName, programName, date, consCRC, consSum, v_crc,
            v_sum, nv_crc, nv_sum, v_valcrc, nv_valcrc, revision, customer, customerJobNum, internalJobNum, equipmentType)
            VALUES(" & primaryKey & ", '" & My.Forms.DistributionForm.LocationNameTextBox.Text & "', '" & Me.GetName & "', 
            '" & My.Forms.DistributionForm.DistributionDate.Value & "', '" & Me.GetConsCRC & "', '" & Me.GetConsSum & "', 
            '" & Me.GetV_CRC & "', '" & Me.GetV_Checksum & "', '" & Me.GetNV_CRC & "', '" & Me.GetNV_Checksum & "', 
            '" & Me.GetV_ValCRC & "', '" & Me.GetNV_ValCRC & "', '" & revNum & "', 
            '" & My.Forms.DistributionForm.CustomerComboBox.Text & "', 
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