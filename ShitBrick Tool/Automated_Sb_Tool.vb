Imports System.IO
Module Automated_Sb_Tool

    Sub Main()
        Console.WriteLine("Checking if the dynamic link library exists...")
        Dim pathtocheck32bit As String = "C:\Program Files\DotNetBar for Windows Forms\DevComponents.DotNetBar2.dll"
        Console.WriteLine("Checking in the following path " & pathtocheck32bit.ToString)
        If File.Exists(pathtocheck32bit.ToString) = True Then
            Console.WriteLine("Library okay, no need for installation.")
            'do nothin'
        Else
            Console.WriteLine("Creating dims...")
            Dim nameofdll As String = "DevComponents.DotNetBar2.dll"
            Dim pathtocheck As String = "C:\Program Files\DotNetBar for Windows Forms\DevComponents.DotNetBar2.dll"
            Console.WriteLine("Fixing...")
            Console.WriteLine("Downloading dynamic link library...")
            My.Computer.Network.DownloadFile("http://deavmi.github.io/ShitBrick-Tool/dynamic-link-libraries/" & nameofdll.ToString, pathtocheck.ToString)
            Console.WriteLine("Completed!")
        End If
    End Sub

End Module
