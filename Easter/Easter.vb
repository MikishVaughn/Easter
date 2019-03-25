Public Class Easter

    '*****************
    '* GetEasterDate *'
    '*****************
    '
    ' Returns the EventDate of the next Easter
    '

    Public Shared Function GetEasterDate() As Date

        Dim eventYear As Integer = Date.UtcNow.Year
        Dim eventDate = New DateTime(eventYear, 3, 1)
        Dim eventDay As Integer = (((255 - 11 * (eventYear Mod 19)) - 21) Mod 30) + 21

        eventDate = eventDate.AddDays(+eventDay + CInt((eventDay > 48)) + 6 - ((eventYear + eventYear \ 4 + eventDay + CInt((eventDay > 48)) + 1) Mod 7))

        If eventDate < Date.UtcNow Then

            eventYear = Date.UtcNow.Year + 1
            eventDate = New DateTime(eventYear, 3, 1)
            eventDay = (((255 - 11 * (eventYear Mod 19)) - 21) Mod 30) + 21

            eventDate = eventDate.AddDays(+eventDay + CInt((eventDay > 48)) + 6 - ((eventYear + eventYear \ 4 + eventDay + CInt((eventDay > 48)) + 1) Mod 7))

        End If

        Return (eventDate)

    End Function






    'Public Shared Function GetEasterDate() As Date

    '    Dim eventYear As Integer = Date.UtcNow.Year
    '    eventYear = 2024

    '    Dim h As Integer = (24 + 19 * (eventYear Mod 19)) Mod 30
    '    Dim i As Integer = CInt(h - h / 28)
    '    Dim j As Integer = CInt((eventYear + eventYear / 4 + i - 13) Mod 7)
    '    Dim l As Integer = i - j

    '    ' kludge to add a day ( + 1) if year is 2019
    '    If eventYear = 2019 Or eventYear = 2022 Or eventYear = 2023 Or eventYear = 2024 Then
    '        l = l + 1
    '    End If

    '    Dim eventMonth As Integer = CInt(3 + ((i - j) + 40) / 44)
    '    Dim eventDay As Integer = CInt(l + 28 - 31 * (eventMonth / 4))

    '    Dim eventDate As Date = Date.Parse(eventYear.ToString + "-" +
    '                                eventMonth.ToString + "-" +
    '                                eventDay.ToString +
    '                                "T00:00:00").ToUniversalTime

    '    If eventDate < Date.UtcNow Then

    '        eventYear = Date.UtcNow.Year + 1

    '        h = (24 + 19 * (eventYear Mod 19)) Mod 30
    '        i = CInt(h - h / 28)
    '        j = CInt((eventYear + eventYear / 4 + i - 13) Mod 7)
    '        l = i - j
    '        eventMonth = CInt(3 + ((i - j) + 40) / 44)
    '        eventDay = CInt(l + 28 - 31 * (eventMonth / 4))

    '        eventDate = Date.Parse(eventYear.ToString + "-" +
    '                                eventMonth.ToString + "-" +
    '                                eventDay.ToString +
    '                                "T00:00:00").ToUniversalTime

    '    End If

    '    Return eventDate

    'End Function

End Class
