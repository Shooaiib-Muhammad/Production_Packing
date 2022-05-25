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



        Public Sub New(ByVal ClentID As Integer, ByVal ModelID As Integer, ByVal ArticleID As Integer, ByVal Size As String, ByVal Type As String, ByVal InsertionDate As Date)


        End Sub

    End Structure


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        clock.Text = TimeOfDay
    End Sub


    Private Sub Entry(ByVal Card As String)

        Dim EmpCardVerify As Integer


        EmpCardVerify = VerifyEmp(Card)

        If EmpCardVerify = 1 Then

            Attendence(Label4.Text, Label5.Text, Label9.Text, Label11.Text, Label8.Text, Now.Date)

        End If


        Try
            TInterval = 600
            ClearTimer.Enabled = True
        Catch ex As Exception
            lblMsg.Text = ex.Message
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
    Private Function VerifyEmp(ByVal CardForVerify As String) As Integer
        Dim EmpVerification As Integer
        Try
            EmpVerification = View_Pro_Article_BarCodeTableAdapter.Fill(Me.Production.View_Pro_Article_BarCode, Val(CardForVerify))
            'EmpVerification = Me.View_All_EmployeesTableAdapter.FillBy1(Me.DSPayRoll.View_All_Employees, Val(CardForVerify))
        Catch ex As Exception
            'EmpVerification = Me.View_All_EmployeesTableAdapter.FillBy1(Me.DSPayRoll.View_All_Employees, Val(CardForVerify))
            EmpVerification = View_Pro_Article_BarCodeTableAdapter.Fill(Me.Production.View_Pro_Article_BarCode, Val(CardForVerify))
        End Try


        Return EmpVerification
    End Function

    Private Sub Attendence(ByVal ClentID As Integer, ByVal ModelID As Integer, ByVal ArticleID As Integer, ByVal Size As String, ByVal Type As String, ByVal InsertionDate As Date)
        Dim Repeatitions As Integer

        Try
            Me.Tbl_Pro_Article_BarCode_TransactionsTableAdapter.Insert(Label4.Text, Label5.Text, Label9.Text, Label11.Text, Label8.Text, 1, Now.Date, Now, "Packing", NICLabel2.Text)
            loaddata()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub InsertRecord(ByVal ClentID As Integer, ByVal ModelID As Integer, ByVal ArticleID As Integer, ByVal Size As String, ByVal Type As String, ByVal InsertionDate As Date)
        Dim Temp As New StoreRecord(ClentID, ModelID, ArticleID, Size, Type, InsertionDate)
        ArrayLst.Add(Temp)

        ''(CardID, InsertionDate)
        lblMsg.ForeColor = Color.Blue
        lblMsg.Text = "Your Data Saved"
        TriggerInterval = 120
        TriggerTimer.Enabled = True
    End Sub



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
        Dim barCodeNo As String

        barCodeNo = txtCardNo.Text
        If barCodeNo.Length > 0 Then
            myinterval = 3
            MyTimer.Enabled = True
            MyTimer.Enabled = False
            Try
                MyDate = System.DateTime.Now.Date.ToShortDateString()
                MyTime = System.DateTime.Now.ToShortTimeString()

                Me.View_Pro_Article_BarCodeTableAdapter.Fill(Me.Production.View_Pro_Article_BarCode, barCodeNo)
                Entry(barCodeNo)

            Catch ex As Exception
                lblMsg.ForeColor = Color.Maroon
                lblMsg.Text = "Bar Code..."

                lblDate.Text = ""
                lblTime.Text = ""
            Finally
                txtCardNo.Text = ""
            End Try
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

        Label1.Text = " Production Packing"
        Dim cn As OdbcConnection
        Dim Obj As New UtilityClass()
        cn = New OdbcConnection("Dsn=ERPFS")
        If cn.State = Data.ConnectionState.Closed Then
            Try
                cn.Open()

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

            Try

                Me.Tbl_Pro_Article_BarCode_TransactionsTableAdapter.Insert(Label4.Text, Label5.Text, Label9.Text, Label11.Text, Label8.Text, 1, Now.Date, Now, "Packing", NICLabel2.Text)
            Catch ex As Exception

            End Try
            'Next
            lblMsg.Text = CType(ArrayLst.Count, String) + " Record Posted"
            ArrayLst.Clear()
            ArrayLst.Capacity = 800
            'LoadAttendence()
            CLS()
            txtCardNo.Visible = True
            txtCardNo.Focus()
        End If
    End Sub

    Private Sub loaddata()
        Try
            Me.View_Production_PackingTableAdapter.Fill(Me.Production.view_Production_Packing, Now.Date, Label4.Text, Label5.Text, Label9.Text)
        Catch ex As Exception

        End Try


    End Sub
End Class