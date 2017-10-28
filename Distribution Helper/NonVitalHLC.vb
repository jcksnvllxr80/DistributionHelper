Public Class NonVitalHLC
    Inherits HLC

    Public Sub New(filename As String, compiler As String)
        MyBase.New(filename, "NVHLC", compiler)
        'MsgBox("Creating NV Obj")
        If Me.isCompiledInALC Then
            Me.ReadNonVitalLog()
        Else
            Me.ReadNonVitalLog()
        End If
    End Sub


    Private Sub ReadNonVitalLog()
        Dim chipNameInLog(2) As String
        If Me.isCompiledInALC Then
            chipNameInLog(0) = "IC14"
            chipNameInLog(1) = "IC15"
        Else
            chipNameInLog(0) = "IC30"
            chipNameInLog(1) = "IC31"
        End If
        Dim fso = CreateObject("Scripting.FileSystemObject")
        Dim logPathAndName = My.Forms.DistributionForm.DistroPathTextBox.Text & "\" & Me.GetName & ".LOG"
        If System.IO.File.Exists(logPathAndName) Then
            Dim logFile = fso.OpenTextFile(logPathAndName)
            Do Until logFile.AtEndOfStream
                Dim nextLine = logFile.ReadLine
                If InStr(nextLine, chipNameInLog(0)) <> 0 Then
                    Dim CrcSum1 = Mid(nextLine, InStr(nextLine, "EPT-1") + 10)
                    Me.SetEvenCRC(Left(CrcSum1, 4))
                    Me.SetEvenChecksum(Right(CrcSum1, 4))
                ElseIf InStr(nextLine, chipNameInLog(1)) <> 0 Then
                    Dim CrcSum2 = Mid(nextLine, InStr(nextLine, "EPT-1") + 10)
                    Me.SetOddCRC(Left(CrcSum2, 4))
                    Me.SetOddChecksum(Right(CrcSum2, 4))
                End If
            Loop
            logFile.Close
        Else
            MsgBox("Non-vital log file does not exist.")
        End If
    End Sub


    Public Overrides Sub InsertDistributionToDB(con As SqlClient.SqlConnection, primaryKey As Integer, revNum As Integer)
        Dim cmd As New SqlClient.SqlCommand

        cmd.CommandText = "INSERT INTO Distributions(ID, locationName, programName, date, CRC_h14, checksum_h14, CRC_h15,
            checksum_h15, revision, customer, customerJobNum, internalJobNum, equipmentType) VALUES(" &
            primaryKey & ", '" & My.Forms.DistributionForm.LocationNameTextBox.Text & "', '" & Me.GetName & "', 
            '" & My.Forms.DistributionForm.DistributionDate.Value & "', '" & Me.GetEvenCRC & "', 
            '" & Me.GetEvenChecksum & "', '" & Me.GetOddCRC & "', '" & Me.GetOddChecksum & "',
            '" & revNum & "','" & My.Forms.DistributionForm.CustomerComboBox.Text & "', 
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
