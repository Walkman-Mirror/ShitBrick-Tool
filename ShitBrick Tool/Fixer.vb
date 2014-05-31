Module Fixer

    Sub Main()
        Console.WriteLine("Press any key to start the fix process or close the window to abort...")
        Console.ReadLine()
        Console.WriteLine("Creating dims...")
            Dim nameofdll As String = "DevComponents.DotNetBar2.dll"
        Dim pathtocheck As String = "C:\Program Files\DotNetBar for Windows Forms\DevComponents.DotNetBar2.dll"
            Console.WriteLine("Fixing...")
            Console.WriteLine("Downloading dynamic link library...")
        Try
            My.Computer.Network.DownloadFile("http://deavmi.github.io/ShitBrick-Tool/dynamic-link-libraries/" & nameofdll.ToString, pathtocheck.ToString)
            Console.WriteLine("Completed!")
        Catch ex As Exception
            Console.WriteLine("Failed! ERROR: " & ex.ToString)
        End Try
        Console.ReadKey()
        Module1.Main()
    End Sub

End Module
