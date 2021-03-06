Public Class ShamsiDate

    Enum ShowType
        LongDate = 1
        ShortDate = 2
    End Enum

    Public Shared Function Miladi2Shamsi(ByVal d As DateTime, ByVal Show As ShowType) As String
        Dim FDate As New System.Globalization.PersianCalendar
        Dim Result As String = ""
        '
        If Show = ShowType.ShortDate Then
            Result += FDate.GetYear(d).ToString + "/"
            Result += FDate.GetMonth(d).ToString + "/"
            Result += FDate.GetDayOfMonth(d).ToString
            Return Result
        Else
            Result += ShamsiDayName(FDate.GetDayOfWeek(d)) + "  "
            Result += FDate.GetDayOfMonth(d).ToString + "  "
            Result += ShamsiMonthName(FDate.GetMonth(d)) + "  "
            Result += FDate.GetYear(d).ToString
            Return Result
        End If
        '
    End Function

    Public Shared Function ShamsiMonthName(ByVal MonthID As Byte) As String
        Dim Result As String = ""
        Select Case MonthID
            Case 1
                Result = "فروردین"
            Case 2
                Result = "اردیبهشت"
            Case 3
                Result = "خرداد"
            Case 4
                Result = "تیر"
            Case 5
                Result = "مرداد"
            Case 6
                Result = "شهریور"
            Case 7
                Result = "مهر"
            Case 8
                Result = "ابان"
            Case 9
                Result = "آذر"
            Case 10
                Result = "دی"
            Case 11
                Result = "بهمن"
            Case 12
                Result = "اسفند"
        End Select
        Return Result
    End Function

    Public Shared Function ShamsiDayName(ByVal DayID As Byte) As String
        Dim Result As String = ""
        Select Case DayID
            Case 0
                Result = "یک شنبه"
            Case 1
                Result = "دو شنبه"
            Case 2
                Result = "سه شنبه"
            Case 3
                Result = "چهار شنبه"
            Case 4
                Result = "پنج شنبه"
            Case 5
                Result = "جمعه"
            Case 6
                Result = "شنبه"
        End Select
        Return Result
    End Function

    Public Shared Function MiladiTohijri(ByVal Year As Integer, ByVal Month As Integer, ByVal Day As Integer) As String

        Try
            Dim Date_M As Date = Year & "/" & Month & "/" & Day
            Dim Date_Sh As New Globalization.HijriCalendar
            Return Date_Sh.GetYear(Date_M) & "/" & Format(Date_Sh.GetMonth(Date_M), "00") & "/" & Format(Date_Sh.GetDayOfMonth(Date_M), "00")
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Shared Function ShamsiToMiladi(ByVal ShamsiDate As String) As String

        If IsNumeric(ShamsiDate.Replace("/", "")) = False Then Return 0
        Try
            If ShamsiDate.Length <> 10 Then Return 0
            Dim Date_Sh As New Globalization.PersianCalendar()
            Dim Date_M As DateTime = Date_Sh.ToDateTime(ShamsiDate.Substring(0, 4), ShamsiDate.Substring(5, 2), _
                                  ShamsiDate.Substring(8, 2), _
                                  0, 0, 0, 0, _
                                 Globalization.PersianCalendar.PersianEra)

            Dim d_() As String = Date_M.ToShortDateString.Split("/")
            'd(0)=mm
            'd(1)=dd
            'd(2)=yyyy
            Return IIf(d_(0).Length = 1, "0" & d_(0), d_(0)) + "/" + IIf(d_(1).Length = 1, "0" & d_(1), d_(1)) + "/" + d_(2)
            'Return Date_M.ToShortDateString
        Catch ex As Exception
            Return 0
        End Try

    End Function

    ''' <summary>
    ''' در این تابع اگه ماه یا روز بصورت تک رقمی بود صفر را در سمت چپ اش لحاظ می کند و بصورت کامل بر می گرداند.
    ''' </summary>
    ''' <param name="d"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function MiladiToShamsiFull(ByVal d As DateTime) As String

        Dim FDate As New System.Globalization.PersianCalendar
        Dim Result As String = ""

        Result += FDate.GetYear(d).ToString + "/"
        Result += FDate.GetMonth(d).ToString + "/"
        Result += FDate.GetDayOfMonth(d).ToString

        Dim d_() As String = Result.Split("/")
        'd(0)=yyyy
        'd(1)=mm
        'd(2)=dd
        Return d_(0) + "/" + IIf(d_(1).Length = 1, "0" & d_(1), d_(1)) + "/" + IIf(d_(2).Length = 1, "0" & d_(2), d_(2))

    End Function

End Class
