Module Module1

    Sub Main()

        'TASK 1.1

        Dim name As String = ""
        Dim memberId As String = ""
        Dim addMoreRec As String = "Y"

        FileOpen(1, "C:\Users\talha\Desktop\AS-Assignments Computer Science\Assignments\records.txt", OpenMode.Output)


        While UCase(addMoreRec) = "Y"

            Console.WriteLine("Enter name of the member you want to add.  ") : name = Console.ReadLine
            Console.WriteLine("Enter MemberId of the member you want to add.  ") : memberId = Console.ReadLine
            WriteLine(1, name)
            WriteLine(1, memberId)
            Console.WriteLine("Do you want to add another record? Y/N") : addMoreRec = Console.ReadLine


            While UCase(addMoreRec) <> "Y" And UCase(addMoreRec) <> "N"
                Console.WriteLine("Please enter Y or N") : addMoreRec = Console.ReadLine
            End While


        End While
        FileClose(1)
        Console.ReadKey()

        'TASK 1.2

        FileOpen(1, "C:\Users\talha\Desktop\AS-Assignments Computer Science\Assignments\records.txt", OpenMode.Input)

        While EOF(1) = False

            Input(1, name)
            Input(1, memberId)
            Console.WriteLine(name & vbCrLf & memberId)



        End While



        FileClose(1)
        Console.ReadKey()

        'TASK 1.3

        Dim nameFound As String = ""
        Dim nameToSearch As String = ""
        Dim isFound As Boolean = False

        FileOpen(1, "C:\Users\talha\Desktop\AS-Assignments Computer Science\Assignments\records.txt", OpenMode.Input)

        Console.WriteLine("Enter the name of the member you want to search for.  ") : nameToSearch = Console.ReadLine


        While EOF(1) <> True And isFound = False

            Input(1, nameFound)
            Input(1, memberId)


            If String.Compare(nameFound, nameToSearch, True) = 0 Then
                Console.WriteLine("Name found, member id is: " & memberId)
                isFound = True
            End If
           


        End While

        If (isFound = False) Then
            Console.WriteLine("Record not found")
        End If

        FileClose(1)

        Console.ReadKey()

    End Sub

End Module
