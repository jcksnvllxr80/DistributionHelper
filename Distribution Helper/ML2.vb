﻿Public Class ML2
    Inherits ProgramFile
    Private V_Checksum As String
    Private V_CRC As String

    Public Sub New(filename As String)
        MyBase.New(filename, "ML2")
        GetChecksumAndCRC()
    End Sub


    Public Overrides Function ToString() As String
        Return Me.GetName & " (" & Me.GetEquipType & ")" & vbCrLf & "mll: CRC = " &
            Me.V_CRC & "; Checksum = " & Me.V_Checksum
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


    Sub GetChecksumAndCRC()
        Dim fso = CreateObject("Scripting.FileSystemObject")
        Dim mllPathAndName = My.Forms.DistributionForm.DistroPathTextBox.Text & "\" & Me.GetName & ".mll"
        If System.IO.File.Exists(mllPathAndName) Then
            Dim mllFile = fso.OpenTextFile(mllPathAndName)
            Do Until mllFile.AtEndOfStream
                Dim nextLine = mllFile.ReadLine
                If InStr(nextLine, "Application Image CRC:") <> 0 Then
                    Me.SetV_CRC(Right(nextLine, 4))
                ElseIf InStr(nextLine, "Application Image Checksum:") <> 0 Then
                    Me.SetV_Checksum(Right(nextLine, 4))
                End If
            Loop
            mllFile.Close
        Else
            MsgBox("mll file does not exist")
        End If
    End Sub


    Public Overrides Sub InsertDistributionToDB(con As SqlClient.SqlConnection, primaryKey As Integer, revNum As Integer)
        Dim cmd As New SqlClient.SqlCommand

        cmd.CommandText = "INSERT INTO Distributions(ID, locationName, programName, date, v_crc, v_sum, revision, 
            customer, customerJobNum, internalJobNum, equipmentType) VALUES(" & primaryKey & ", 
            '" & My.Forms.DistributionForm.LocationNameTextBox.Text & "', '" & Me.GetName & "', 
            '" & My.Forms.DistributionForm.DistributionDate.Value & "', '" & Me.GetV_CRC & "', 
            '" & Me.GetV_Checksum & "', '" & revNum & "','" & My.Forms.DistributionForm.CustomerComboBox.Text & "', 
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
