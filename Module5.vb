Module Module1
    'TASK 1.5
    Sub Main()
        Dim name As String = ""
        Dim addMoreRec As Char = "Y"
        Dim isFound As Boolean = False
        Dim memberId As String = ""
        Dim telephoneNumber As String = ""
        Dim membershipStartDate As String = ""

        FileOpen(1, "C:\Users\talha\Desktop\AS-Assignments Computer Science\Assignments\records.txt", OpenMode.Input)
        FileOpen(2, "C:\Users\talha\Desktop\AS-Assignments Computer Science\Assignments\recordsupdated.txt", OpenMode.Output)
        

        While EOF(1) <> True

            Input(1, name)
            Input(1, memberId)

            Console.WriteLine("Enter telephone number for " & name & ", MemberID: " & memberId) : telephoneNumber = Console.ReadLine
            Console.WriteLine("Enter membership start date for " & name & ", " & memberId) : membershipStartDate = Console.ReadLine

            WriteLine(2, name)
            WriteLine(2, memberId)
            WriteLine(2, telephoneNumber)
            WriteLine(2, membershipStartDate)

        End While
        FileClose(1)
        FileClose(2)
        Console.ReadKey()


    End Sub

End Module
