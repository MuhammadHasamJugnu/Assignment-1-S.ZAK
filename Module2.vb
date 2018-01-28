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

    End Sub

End Module

























 