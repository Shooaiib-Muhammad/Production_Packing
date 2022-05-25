Imports System.Net
Imports System.IO
Imports System.Data.Odbc
Public Class frmAutoAttendence
    Dim myinterval As Integer
    Dim TInterval As Integer
    Dim TriggerInterval As Integer
    Dim MyDate As String
    Dim MyTime As String
    Dim DTMyDate As Date
    Dim FPeriod As String
    Dim ArrayLst As New Collections.ArrayList()

    Public Structure StoreRecord
        Public CNo As Integer
        Public DAT As Date
        Public AttTime As DateTime

        Public shift As Integer

        Public ShiftST As DateTime
        Public ShiftET As DateTime
        Public ShiftBreakST As DateTime
        Public ShiftBreakET As DateTime
        Public EmployeeID As Integer
        Public FP As String



        Public Sub New(ByVal CID As Integer, ByVal Dt As Date, ByVal ATime As DateTime, ByVal Shift As Integer, ByVal SSTime As DateTime, ByVal SETime As DateTime, ByVal SBSTime As DateTime, ByVal SBETime As DateTime, ByVal empID As Integer, ByVal MyFP As String, FridayShift As Int32)
            Me.CNo = CID
            Me.DAT = Dt
            Me.AttTime = ATime
            Me.shift = Shift


            If WeekdayName(Weekday(Dt)) = "Friday" And FridayShift = 1 Then 'for Day
                Me.ShiftST = SSTime
                Me.ShiftET = DateAdd(DateInterval.Minute, 30, SETime)
                Me.ShiftBreakST = DateAdd(DateInterval.Minute, 30, SBSTime)
                Me.ShiftBreakET = DateAdd(DateInterval.Minute, 60, SBETime)
            ElseIf WeekdayName(Weekday(Dt)) = "Friday" And FridayShift = 2 'for Night
                Me.ShiftST = DateAdd(DateInterval.Minute, 30, SSTime)
                Me.ShiftET = DateAdd(DateInterval.Minute, 30, SETime)
                Me.ShiftBreakST = DateAdd(DateInterval.Minute, 30, SBSTime)
                Me.ShiftBreakET = DateAdd(DateInterval.Minute, 30, SBETime)
            Else
                Me.ShiftST = SSTime
                Me.ShiftET = SETime
                Me.ShiftBreakST = SBSTime
                Me.ShiftBreakET = SBETime
            End If

            'Me.ShiftST = SSTime
            'Me.ShiftET = SETime
            'Me.ShiftBreakST = SBSTime
            'Me.ShiftBreakET = SBETime
            Me.EmployeeID = empID
            Me.FP = MyFP

        End Sub

    End Structure


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        clock.Text = TimeOfDay
    End Sub

    Private Sub frmAutoAttendence_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim CurrentDt As DateTime = Now
        For i As Integer = 0 To ArrayLst.Count - 1
            Dim Struct As StoreRecord = CType(ArrayLst.Item(i), StoreRecord)

            Dim StructCard As Integer = Struct.CNo
            Dim StructDate As Date = Struct.DAT
            Dim StructTime As DateTime = Struct.AttTime

            Dim StructShift As Integer = Struct.shift

            Dim StructSST As DateTime = Struct.ShiftST
            Dim StructSET As DateTime = Struct.ShiftET
            Dim StructSBST As DateTime = Struct.ShiftBreakST
            Dim StructSBET As DateTime = Struct.ShiftBreakET
            Dim StructEmpID As Integer = Struct.EmployeeID
            Dim StructFP As String = Struct.FP


            Try
                Me.Tbl_Hrm_Emp_Att1TableAdapter.Insert(StructCard, StructEmpID, StructDate, StructTime, False, StructShift, StructSST, StructSET, StructSBST, StructSBET, StructFP, CurrentDt, Nothing)

                'Me.Tbl_Hrm_Emp_Att1TableAdapter.Insert(StructCard, StructDate, StructTime, Nothing, Nothing, False, StructInOut, StructShift, StructIP, StructSST, StructSET, StructSBST, StructSBET, StructEmpID, StructFP, CurrentDt, StructJTEmpID)
            Catch ex As Exception
                ErrorFileWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\AttError.txt", "Error Time: '" & Now & "' Given CardNo:" & StructCard & ", AttDate:" & StructDate & ", AttTime:" & StructTime & ", ShiftNo:" & StructShift & ", Shift StartTime:" & StructSST & ", Shift EndTime:" & StructSET & " Error Code: Attendance Not saved for this Employee due to the exception '" & ex.Message & "'")
            End Try
        Next
        MsgBox(CType(ArrayLst.Count, String) + " Record Posted")
    End Sub
    Private Sub ErrorFileWriter(ByVal p As String, ByVal st As String)
        Dim oStreamWriter As StreamWriter
        Try
            If st <> "" Then
                oStreamWriter = New StreamWriter(p, True)
                oStreamWriter.WriteLine(st)
                oStreamWriter.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Entry(ByVal Card As Integer)
        Dim EmpID As Integer
        Dim FridayShift As Integer
        Dim ShiftID As Integer
        Dim AttCount As Integer
        Dim EmpCardVerify As Integer
        DTMyDate = CType(MyDate, Date)
        Dim Shiftstarttime As DateTime
        Dim Shiftendtime As DateTime
        Dim Shiftbreakstarttime As DateTime
        Dim Shiftbreakendtime As DateTime


        EmpCardVerify = VerifyEmp(Card)                                                       'Display Info of the Employee
        If EmpCardVerify = 1 Then
            If Me.DSPayRoll.View_All_Employees(0).Item("EndDate") Is DBNull.Value Then
                DisplayInfo(Card)
                If Me.DSPayRoll.View_All_Employees(0).Item("ShiftID") IsNot DBNull.Value Then
                    ShiftID = Me.DSPayRoll.View_All_Employees(0).Item("ShiftID")
                    EmpID = Me.DSPayRoll.View_All_Employees(0).Item("EmpID")
                    Shiftstarttime = Me.DSPayRoll.View_All_Employees(0).Item("ShiftST")
                    Shiftendtime = Me.DSPayRoll.View_All_Employees(0).Item("ShiftET")
                    Shiftbreakstarttime = Me.DSPayRoll.View_All_Employees(0).Item("BreakST")
                    Shiftbreakendtime = Me.DSPayRoll.View_All_Employees(0).Item("BreakET")
                    'Dim Night As Boolean = Me.DSPayRoll.View_All_Employees.Rows(0).Item("NightAndFriday")
                    'Dim Day As Boolean = Me.DSPayRoll.View_All_Employees.Rows(0).Item("FridayBreakStatus"

                    If CType(Me.DSPayRoll.View_All_Employees(0).Item("FridayBreakStatus"), Boolean) = True Then
                        FridayShift = 1
                    ElseIf CType(Me.DSPayRoll.View_All_Employees(0).Item("NightAndFriday"), Boolean) = True Then
                        FridayShift = 2
                    Else
                        FridayShift = 3
                    End If
                    Select Case (ShiftID)                                                           'By checking the shifts we are Inserting Data to check InOut Status and Attendence Count
                        Case 1, 4 To 11                                                             'Normal Shift 1  Case
                            AttCount = ReturnAttCount(Card, MyDate)
                            Attendence(Card, AttCount, ShiftID, MyDate, Shiftstarttime, Shiftendtime, Shiftbreakstarttime, Shiftbreakendtime, EmpID, FPeriod, FridayShift)
                        Case 2, 12                                                                  'Here We Handle Shift 2 whose timings are 5:00 PM to 1:00 AM  and We Handle Shift 12 whose timings are 4:00 PM to 12:00 AM
                            If Now >= CType(Now.ToShortDateString + " 12:00:00 AM", Date) And Now <= CType(Now.ToShortDateString + " 6:00:00 AM", Date) Then
                                'MyDate = PreviousDate(MyDay, MyMonth, MyYear)
                                MyDate = DateAdd(DateInterval.Day, -1, DTMyDate)
                                AttCount = ReturnAttCount(Card, MyDate)
                            Else
                                AttCount = ReturnAttCount(Card, MyDate)
                            End If
                            Attendence(Card, AttCount, ShiftID, MyDate, Shiftstarttime, Shiftendtime, Shiftbreakstarttime, Shiftbreakendtime, EmpID, FPeriod, FridayShift)
                        Case 3                                                                      'Here We Handle Shift 3 whose timings are 12:00 AM to 8:00 AM
                            If Now < CType(Now.ToShortDateString + " 12:00:00 AM", Date) Then
                                'MyDate = NextDate(MyDay, MyMonth, MyYear)
                                MyDate = DateAdd(DateInterval.Day, 1, DTMyDate)
                                AttCount = ReturnAttCount(Card, MyDate)
                            Else
                                AttCount = ReturnAttCount(Card, MyDate)
                            End If
                            Attendence(Card, AttCount, ShiftID, MyDate, Shiftstarttime, Shiftendtime, Shiftbreakstarttime, Shiftbreakendtime, EmpID, FPeriod, FridayShift)
                        Case 13
                            AttCount = ReturnAttCount(Card, MyDate)
                            Attendence(Card, AttCount, ShiftID, MyDate, Shiftstarttime, Shiftendtime, Shiftbreakstarttime, Shiftbreakendtime, EmpID, FPeriod, FridayShift)
                        Case Else
                            'Work Later On
                    End Select
                    'DisplayTodaysAtt(Card, MyDate)

                Else
                    CLS()
                    lblMsg.ForeColor = Color.Maroon
                    lblMsg.Text = "Attendance Not Saved, Contact PayRoll"
                    ErrorFileWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\AttError.txt", "Error Time: '" & Now & "' Given CardNo:" & Card & " Error Code: 'Shift Not Set for this CardNo...'")
                End If
            Else
                If CType(Me.DSPayRoll.View_All_Employees(0).Item("EndDate").ToString(), Date) >= Now.Date Then  'Expire date
                    DisplayInfo(Card)
                    If Me.DSPayRoll.View_All_Employees(0).Item("CardNo") IsNot DBNull.Value Then
                        ShiftID = Me.DSPayRoll.View_All_Employees(0).Item("ShiftID")
                        EmpID = Me.DSPayRoll.View_All_Employees(0).Item("EmpID")
                        Shiftstarttime = Me.DSPayRoll.View_All_Employees(0).Item("ShiftST")
                        Shiftendtime = Me.DSPayRoll.View_All_Employees(0).Item("ShiftET")
                        Shiftbreakstarttime = Me.DSPayRoll.View_All_Employees(0).Item("BreakST")
                        Shiftbreakendtime = Me.DSPayRoll.View_All_Employees(0).Item("BreakET")

                        If CType(Me.DSPayRoll.View_All_Employees(0).Item("FridayBreakStatus"), Boolean) = True Then
                            FridayShift = 1
                        ElseIf CType(Me.DSPayRoll.View_All_Employees(0).Item("NightAndFriday"), Boolean) = True Then
                            FridayShift = 2
                        Else
                            FridayShift = 3
                        End If
                        Select Case (ShiftID)                                                           'By checking the shifts we are Inserting Data to check InOut Status and Attendence Count
                            Case 1, 4 To 11                                                             'Normal Shift 1  Case
                                AttCount = ReturnAttCount(Card, MyDate)
                                Attendence(Card, AttCount, ShiftID, MyDate, Shiftstarttime, Shiftendtime, Shiftbreakstarttime, Shiftbreakendtime, EmpID, FPeriod, FridayShift)
                            Case 2, 12                                                                  'Here We Handle Shift 2 whose timings are 5:00 PM to 1:00 AM  and We Handle Shift 12 whose timings are 4:00 PM to 12:00 AM
                                If Now >= CType(Now.ToShortDateString + " 12:00:00 AM", Date) And Now <= CType(Now.ToShortDateString + " 6:00:00 AM", Date) Then
                                    'MyDate = PreviousDate(MyDay, MyMonth, MyYear)
                                    MyDate = DateAdd(DateInterval.Day, -1, DTMyDate)
                                    AttCount = ReturnAttCount(Card, MyDate)
                                Else
                                    AttCount = ReturnAttCount(Card, MyDate)
                                End If
                                Attendence(Card, AttCount, ShiftID, MyDate, Shiftstarttime, Shiftendtime, Shiftbreakstarttime, Shiftbreakendtime, EmpID, FPeriod, FridayShift)
                            Case 3                                                                      'Here We Handle Shift 3 whose timings are 12:00 AM to 8:00 AM
                                If Now < CType(Now.ToShortDateString + " 12:00:00 AM", Date) Then
                                    'MyDate = NextDate(MyDay, MyMonth, MyYear)
                                    MyDate = DateAdd(DateInterval.Day, 1, DTMyDate)
                                    AttCount = ReturnAttCount(Card, MyDate)
                                Else
                                    AttCount = ReturnAttCount(Card, MyDate)
                                End If
                                Attendence(Card, AttCount, ShiftID, MyDate, Shiftstarttime, Shiftendtime, Shiftbreakstarttime, Shiftbreakendtime, EmpID, FPeriod, FridayShift)
                            Case 13
                                AttCount = ReturnAttCount(Card, MyDate)
                                Attendence(Card, AttCount, ShiftID, MyDate, Shiftstarttime, Shiftendtime, Shiftbreakstarttime, Shiftbreakendtime, EmpID, FPeriod, FridayShift)
                            Case Else
                                'Work Later On
                        End Select

                    Else
                        CLS()
                        lblMsg.ForeColor = Color.Maroon
                        lblMsg.Text = "Attendance Not Saved, Contact PayRoll"
                        ErrorFileWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\AttError.txt", "Error Time: '" & Now & "' Given CardNo:" & Card & " Error Code: 'Shift Not Set for this CardNo...'")
                    End If
                Else
                    CLS()
                    lblMsg.ForeColor = Color.Maroon
                    lblMsg.Text = "Your Card Has Been Expired"
                    ErrorFileWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\AttError.txt", "Error Time: '" & Now & "' Given CardNo:" & Card & " Error Code: 'Employees Card has been Expired...'")
                    lblDate.Text = ""
                    lblTime.Text = ""
                End If
            End If
        Else
            CLS()
            lblMsg.ForeColor = Color.Maroon
            lblMsg.Text = "You are not a Registered Employee"
            ErrorFileWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\AttError.txt", "Error Time: '" & Now & "' Given CardNo:" & Card & " Error Code: 'No Employee Registered on this Card...'")
            lblDate.Text = ""
            lblTime.Text = ""
        End If

        Try
            TInterval = 600
            ClearTimer.Enabled = True
        Catch ex As Exception
            lblMsg.Text = ex.Message
        End Try

    End Sub
    Private Sub DisplayInfo(ByVal card As Integer)
        lblDate.Text = MyDate
        lblTime.Text = MyTime
        Try
            Me.View_All_EmployeesTableAdapter.FillBy(Me.DSPayRoll.View_All_Employees, card)
        Catch ex As Exception
            lblMsg.Text = ex.Message
            ErrorFileWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\AttError.txt", "Error Time: '" & Now & "' Given CardNo:" & card & " Error Code: '" & ex.Message & "'")
        End Try
    End Sub
    Private Sub CLS()
        lblMsg.Text = ""
        mylbl.Text = ""
        CardNoLabel2.Text = ""
        lblDate.Text = ""
        lblTime.Text = ""
        EmpPicPictureBox.Image = Nothing
        FNameLabel1.Text = ""
        FatherNameLabel2.Text = ""
        NICLabel2.Text = ""
        Label4.Text = ""
        Label8.Text = ""
        Label9.Text = ""
    End Sub
    Private Function VerifyEmp(ByVal CardForVerify As Integer) As Integer
        Dim EmpVerification As Integer
        Try
            EmpVerification = Me.View_All_EmployeesTableAdapter.FillBy1(Me.DSPayRoll.View_All_Employees, Val(CardForVerify))
        Catch ex As Exception
            EmpVerification = Me.View_All_EmployeesTableAdapter.FillBy1(Me.DSPayRoll.View_All_Employees, Val(CardForVerify))
        End Try


        Return EmpVerification
    End Function
    Private Sub Attendence(ByVal Card As Integer, ByVal ACount As Integer, ByVal Shift As Integer, ByVal DT As String, ByVal ShiftStartTime As DateTime, ByVal ShiftEndTime As DateTime, ByVal ShiftBreakStartTime As DateTime, ByVal ShiftBreakEndTime As DateTime, ByVal Eid As Integer, ByVal MyFinancialPeriod As String, FridayShift As Integer)
        Dim Repeatitions As Integer
        'Dim HostName As String = Dns.GetHostName
        'Dim ipEntry As IPHostEntry = Dns.GetHostEntry(HostName)
        'Dim IpAddr As IPAddress() = ipEntry.AddressList

        'IpAddr(0).ToString()
        Select Case (ACount)                                                'By Checking Attendence Count Result We are inserting data for different cases
            Case 0
                InsertRecord(Card, DT, Shift, ShiftStartTime, ShiftEndTime, ShiftBreakStartTime, ShiftBreakEndTime, Eid, MyFinancialPeriod, FridayShift)
            Case 1, 3, 5, 7, 9                                              'Cheching for Odds to Set OutStatus
                Repeatitions = ReturnAttRepeatition(Card)
                If Repeatitions = 1 Then
                    lblMsg.ForeColor = Color.Maroon
                    lblMsg.Text = "Your Attendence Already been Saved"
                    ErrorFileWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\AttError.txt", "Error Time: '" & Now & "' Given CardNo:" & Card & " Error Code: 'Try more than once to roll the Attendance, but Attendance already saved'")
                Else
                    InsertRecord(Card, DT, Shift, ShiftStartTime, ShiftEndTime, ShiftBreakStartTime, ShiftBreakEndTime, Eid, MyFinancialPeriod, FridayShift)
                End If
            Case 2, 4, 6, 8                                                 'Cheching for Evens to Set InStatus
                Repeatitions = ReturnAttRepeatition(Card)
                If Repeatitions = 1 Then
                    lblMsg.ForeColor = Color.Maroon
                    lblMsg.Text = "Your Attendence Already been Saved"
                    ErrorFileWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\AttError.txt", "Error Time: '" & Now & "' Given CardNo:" & Card & " Error Code: 'Try more than once to roll the Attendance, but Attendance already saved'")
                Else
                    InsertRecord(Card, DT, Shift, ShiftStartTime, ShiftEndTime, ShiftBreakStartTime, ShiftBreakEndTime, Eid, MyFinancialPeriod, FridayShift)
                End If
            Case Else
                'Work Later On
        End Select

    End Sub

    Private Sub InsertRecord(ByVal CardID As Integer, ByVal InsertionDate As Date, ByVal shiftID As Integer, ByVal ShiftStartTime As DateTime, ByVal ShiftEndTime As DateTime, ByVal ShiftBreakStartTime As DateTime, ByVal ShiftBreakEndTime As DateTime, ByVal EID As Integer, ByVal MyFinancialPeriod As String, fridayShift As Integer)
        Dim Temp As New StoreRecord(CardID, InsertionDate, Format(Now, "dd/MM/yyyy hh:mm tt"), shiftID, ShiftStartTime, ShiftEndTime, ShiftBreakStartTime, ShiftBreakEndTime, EID, MyFinancialPeriod, fridayShift)
        ArrayLst.Add(Temp)
        ''(CardID, InsertionDate)
        lblMsg.ForeColor = Color.Blue
        lblMsg.Text = "Your Attendance Saved"
        TriggerInterval = 120
        TriggerTimer.Enabled = True
    End Sub

    Private Function ReturnAttCount(ByVal Card As Integer, ByVal AttendenceDate As String) As Integer
        Dim ACount As Integer
        Dim RowCount As Integer
        Dim CardCompare As String = Nothing
        Dim DateCompare As String = Nothing
        RowCount = Me.DSAutoAtt.tbl_Hrm_Emp_Att.Rows.Count

        If Me.DSPayRoll.View_All_Employees(0).Item("ShiftID") = 13 Then 'ShiftID
            If ArrayLst.Count > 0 Then
                For i As Integer = 0 To ArrayLst.Count - 1
                    Dim Struct As StoreRecord = CType(ArrayLst.Item(i), StoreRecord)
                    Dim StructCard As Integer = Struct.CNo
                    If StructCard = Card Then
                        ACount += 1
                    End If
                Next
                If ACount = 0 Then
                    For j As Integer = 0 To RowCount - 1
                        CardCompare = Me.DSAutoAtt.tbl_Hrm_Emp_Att.Rows(j).Item(1).ToString()
                        If CardCompare = Card Then
                            ACount += 1
                        End If
                    Next
                End If
            Else
                For k As Integer = 0 To RowCount - 1
                    CardCompare = Me.DSAutoAtt.tbl_Hrm_Emp_Att.Rows(k).Item(1).ToString()
                    If CardCompare = Card Then
                        ACount += 1
                    End If
                Next
            End If
        Else
            If ArrayLst.Count > 0 Then
                For i As Integer = 0 To ArrayLst.Count - 1
                    Dim Struct As StoreRecord = CType(ArrayLst.Item(i), StoreRecord)
                    Dim StructCard As Integer = Struct.CNo
                    Dim StructDate As Date = Struct.DAT
                    If StructCard = Card And StructDate = AttendenceDate Then
                        ACount += 1
                    End If
                Next
                If ACount = 0 Then
                    For j As Integer = 0 To RowCount - 1
                        CardCompare = Me.DSAutoAtt.tbl_Hrm_Emp_Att.Rows(j).Item(1).ToString()
                        DateCompare = Me.DSAutoAtt.tbl_Hrm_Emp_Att.Rows(j).Item(2).ToString()
                        If CardCompare = Card And CType(DateCompare, DateTime) = CType(AttendenceDate.Trim() + " 12:00:00 AM", DateTime) Then
                            ACount += 1
                        End If
                    Next
                End If
            Else
                For k As Integer = 0 To RowCount - 1
                    CardCompare = Me.DSAutoAtt.tbl_Hrm_Emp_Att.Rows(k).Item(1).ToString()
                    DateCompare = Me.DSAutoAtt.tbl_Hrm_Emp_Att.Rows(k).Item(2).ToString()
                    If CardCompare = Card And CType(DateCompare, DateTime) = CType(AttendenceDate.Trim() + " 12:00:00 AM", DateTime) Then
                        ACount += 1
                    End If
                Next
            End If
        End If
        Return ACount
    End Function

    Private Function ReturnAttRepeatition(ByVal Card As Integer) As Integer
        Dim CardCompare As String = Nothing
        Dim TimeCompare As String = Nothing

        Dim ARep As Integer
        Dim RowCount As Integer
        RowCount = Me.DSAutoAtt.tbl_Hrm_Emp_Att.Rows.Count

        If ArrayLst.Count > 0 Then
            For i As Integer = 0 To ArrayLst.Count - 1
                Dim Struct As StoreRecord = CType(ArrayLst.Item(i), StoreRecord)
                Dim StructCard As Integer = Struct.CNo
                Dim StructAttTime As DateTime = Struct.AttTime
                If Card = StructCard Then
                    If StructAttTime >= Now.Subtract(TimeSpan.FromMinutes(15)) And StructAttTime <= Now Then
                        ARep += 1
                    End If
                End If
            Next
            If ARep = 0 Then
                For j As Integer = 0 To RowCount - 1
                    CardCompare = Me.DSAutoAtt.tbl_Hrm_Emp_Att.Rows(j).Item(1).ToString()
                    TimeCompare = Me.DSAutoAtt.tbl_Hrm_Emp_Att.Rows(j).Item(3).ToString()
                    If CardCompare = CType(Card, String) Then
                        If TimeCompare >= Now.Subtract(TimeSpan.FromMinutes(15)) And TimeCompare <= Now Then
                            ARep += 1
                        End If
                    End If
                Next
            End If
        Else
            For k As Integer = 0 To RowCount - 1
                CardCompare = Me.DSAutoAtt.tbl_Hrm_Emp_Att.Rows(k).Item(1).ToString()
                TimeCompare = Me.DSAutoAtt.tbl_Hrm_Emp_Att.Rows(k).Item(3).ToString()
                If CardCompare = CType(Card, String) Then
                    If TimeCompare >= Now.Subtract(TimeSpan.FromMinutes(15)) And TimeCompare <= Now Then
                        ARep += 1
                    End If
                End If
            Next
        End If
        Return ARep
    End Function

    Private Sub txtCardNo_TextChanged(sender As Object, e As EventArgs) Handles txtCardNo.TextChanged
        Dim CardNo As Integer
        Dim CopyNo As Integer
        Dim Result As Integer
        Dim Count As Integer
        Dim sign As String = Me.DSAutoAtt.tbl_Comp_Info(0).Item(9)
        Dim SignCap As String = StrConv(sign, VbStrConv.Uppercase)
        Dim Signlower As String = StrConv(sign, VbStrConv.Lowercase)

        If (txtCardNo.Text.Contains(SignCap) Or txtCardNo.Text.Contains(Signlower)) Then
            'If (txtCardNo.Text.Contains("g") Or txtCardNo.Text.Contains("G")) Then
            If txtCardNo.TextLength > 0 And txtCardNo.TextLength < 8 Then
                myinterval = 3
                MyTimer.Enabled = True
            ElseIf txtCardNo.TextLength = 13 Or txtCardNo.TextLength = 12 Then
                MyTimer.Enabled = False
                Try
                    MyDate = System.DateTime.Now.Date.ToShortDateString()
                    MyTime = System.DateTime.Now.ToShortTimeString()
                    CardNo = txtCardNo.Text.Substring(1, 5)
                    CopyNo = txtCardNo.Text.Substring(6, 2)
                    Me.View_Pro_Article_BarCodeTableAdapter.Fill(Me.Production.View_Pro_Article_BarCode, CardNo)
                    'Count = Me.View_Rpt_HR_ActiveCardCopyTableAdapter.Fill(Me.DSAutoAtt.View_Rpt_HR_ActiveCardCopy, Val(CardNo), Val(CopyNo))
                    'If Count = 1 Then
                    '    Result = Me.DSAutoAtt.View_Rpt_HR_ActiveCardCopy.Rows(0).Item(2)
                    '    If Result = CopyNo Then
                    '        Entry(CardNo)
                    '    Else
                    '        lblMsg.ForeColor = Color.Maroon
                    '        lblMsg.Text = "Invalid Card Number..."
                    '        ErrorFileWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\AttError.txt", "Error Time: '" & Now & "' Given CardNo:" & CardNo & " Error Code: 'Invalid Card Number...'")
                    '        lblDate.Text = ""
                    '        lblTime.Text = ""
                    '    End If
                    'ElseIf Count = 0 Then
                    '    lblMsg.ForeColor = Color.Maroon
                    '    lblMsg.Text = "Invalid Card Number..."
                    '    ErrorFileWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\AttError.txt", "Error Time: '" & Now & "' Given CardNo:" & CardNo & " Error Code: 'Invalid Card Number...'")
                    '    lblDate.Text = ""
                    '    lblTime.Text = ""
                    'ElseIf Count > 1 Then
                    '    lblMsg.ForeColor = Color.Maroon
                    '    lblMsg.Text = "More Than One Record Saved for This Employee..."
                    '    ErrorFileWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\AttError.txt", "Error Time: '" & Now & "' Given CardNo:" & CardNo & " Error Code: 'More Than One Record Saved for This Employee...'")
                    '    lblDate.Text = ""
                    '    lblTime.Text = ""
                    'End If
                Catch ex As Exception
                    lblMsg.ForeColor = Color.Maroon
                    lblMsg.Text = "Invalid Bar Code..."
                    ErrorFileWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\AttError.txt", "Error Time: '" & Now & "' Given CardNo:" & CardNo & " Error Code: '" & ex.Message & "'")
                    lblDate.Text = ""
                    lblTime.Text = ""
                Finally
                    txtCardNo.Text = ""
                End Try
            End If
        Else
            txtCardNo.Text = ""
        End If
    End Sub

    Private Sub MyTimer_Tick(sender As Object, e As EventArgs) Handles MyTimer.Tick
        If myinterval > 0 Then
            mylbl.Text = myinterval
            myinterval = myinterval - 1
        Else
            Me.mylbl.Text = "Clear"
            Me.txtCardNo.Text = ""
            MyTimer.Enabled = False
        End If
    End Sub

    Private Sub ClearTimer_Tick(sender As Object, e As EventArgs) Handles ClearTimer.Tick
        If TInterval > 0 Then
            TInterval -= 1
        Else
            ClearTimer.Enabled = False
            CLS()
        End If
    End Sub

    Private Sub frmAutoAttendence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSAutoAtt.tbl_Comp_Info' table. You can move, or remove it, as needed.
        Me.Tbl_Comp_InfoTableAdapter.Fill(Me.DSAutoAtt.tbl_Comp_Info)
        Label1.Text = Me.DSAutoAtt.tbl_Comp_Info(0).Item(1) & " Attendance System"
        Dim cn As OdbcConnection
        Dim Obj As New UtilityClass()
        cn = New OdbcConnection("Dsn=HRMS")
        If cn.State = Data.ConnectionState.Closed Then
            Try
                cn.Open()
                Try
                    'LoadAttendence()
                    FPeriod = Obj.ReturnFP(Now.Month, Now.Year)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Catch ex As Exception
                MsgBox("Error: Server Not Responding; The Network May be Malfunctioning, So Contact Network Administrator" & vbCrLf & "Actual Error: " & ex.Message)
            End Try
        End If
        ArrayLst.Capacity = 800
        Timer1 = New Timer
        AddHandler Timer1.Tick, AddressOf Timer1_Tick
        Timer1.Start()
    End Sub

    Private Sub TriggerTimer_Tick(sender As Object, e As EventArgs) Handles TriggerTimer.Tick
        If TriggerInterval > 0 Then
            TriggerInterval -= 1
        Else
            Dim CurrentDt As DateTime = Now
            TriggerTimer.Enabled = False
            lblMsg.ForeColor = Color.Blue
            lblMsg.Text = "Please Wait..."
            txtCardNo.Visible = False
            For i As Integer = 0 To ArrayLst.Count - 1
                Dim Struct As StoreRecord = CType(ArrayLst.Item(i), StoreRecord)

                Dim StructCard As Integer = Struct.CNo
                Dim StructDate As Date = Struct.DAT
                Dim StructTime As DateTime = Struct.AttTime
                Dim StructShift As Integer = Struct.shift
                Dim StructSST As DateTime = Struct.ShiftST
                Dim StructSET As DateTime = Struct.ShiftET
                Dim StructSBST As DateTime = Struct.ShiftBreakST
                Dim StructSBET As DateTime = Struct.ShiftBreakET
                Dim StructEmpID As Integer = Struct.EmployeeID
                Dim StructFP As String = Struct.FP


                Try
                    Me.Tbl_Hrm_Emp_Att1TableAdapter.Insert(StructCard, StructEmpID, StructDate, StructTime, False, StructShift, StructSST, StructSET, StructSBST, StructSBET, StructFP, CurrentDt, Nothing)

                Catch ex As Exception
                    ErrorFileWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\AttError.txt", "Error Time: '" & Now & "' Given CardNo:" & StructCard & ", AttDate:" & StructDate & ", AttTime:" & StructTime & ", ShiftNo:" & StructShift & ", Shift StartTime:" & StructSST & ", Shift EndTime:" & StructSET & " Error Code: Attendance Not saved for this Employee due to the exception '" & ex.Message & "'")
                End Try
            Next
            lblMsg.Text = CType(ArrayLst.Count, String) + " Record Posted"
            ArrayLst.Clear()
            ArrayLst.Capacity = 800
            'LoadAttendence()
            CLS()
            txtCardNo.Visible = True
            txtCardNo.Focus()
        End If
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.View_Pro_Article_BarCodeTableAdapter.Fill(Me.Production.View_Pro_Article_BarCode, BarcodeToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class