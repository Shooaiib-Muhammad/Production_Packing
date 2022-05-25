Imports System.Data.Odbc
Imports System.Data
Public Class UtilityClass
    Public Function ReturnFP(ByVal MyMonth As Integer, ByVal MyYear As Integer) As String
        Dim FPeriod As String = ""
        Dim FP_Year As String

        Dim Con As New OdbcConnection("Dsn=HRMS")
        Dim Cmd As New OdbcCommand()
        Dim DataReaderForFP As OdbcDataReader

        Cmd.Connection = Con
        Cmd.CommandText = "Select FinancialPeriod from tbl_Acc_FinancialPeriod"
        Cmd.CommandType = CommandType.Text

        Con.Open()
        DataReaderForFP = Cmd.ExecuteReader()

        If DataReaderForFP.HasRows Then
            While (DataReaderForFP.Read)
                Select Case (MyMonth)
                    Case 1 To 6
                        FP_Year = DataReaderForFP.GetString(0).Substring(11, 4)
                        If FP_Year = MyYear Then
                            FPeriod = DataReaderForFP.GetString(0)
                        End If
                    Case Else
                        FP_Year = DataReaderForFP.GetString(0).Substring(3, 4)
                        If FP_Year = MyYear Then
                            FPeriod = DataReaderForFP.GetString(0)
                        End If
                End Select
            End While
        End If

        DataReaderForFP.Close()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Cmd.Dispose()
        Con.Dispose()

        Return FPeriod

    End Function










    Public Function GetLastDayInMonth(ByVal dtDate As Date) As Date
        'This is very good piece of code that returns Last Day of a particular month
        Return DateAdd(DateInterval.Day, (DateAdd(DateInterval.Month, 1, dtDate)).Day * -1, DateAdd(DateInterval.Month, 1, dtDate))
    End Function

    Public Function ResetDate() As Date
        Dim NowDate As Date = Now.Date
        NowDate = NowDate.Subtract(New TimeSpan(NowDate.Day - 1, 0, 0, 0))
        Return NowDate
    End Function
End Class
