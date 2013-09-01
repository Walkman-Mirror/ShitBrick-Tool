Imports System.IO
Module Detection

    Sub Main()
        Console.WriteLine("Checking if the dynamic link library exists...")
        Dim pathtocheck As String = "C:\Program Files\DotNetBar for Windows Forms\DevComponents.DotNetBar2.dll"
        Console.WriteLine("Checking in the following path " & pathtocheck.ToString)
        If File.Exists(pathtocheck.ToString) = True Then
            Console.WriteLine("FILE EXISTS! NO NEED TO RE-INSTALL")
            MsgBox("FILE EXISTS! NO NEED TO RE-INSTALL")
        Else
            Console.WriteLine("FILE DOES NOT EXIST! YOU NEED TO INSTALL")
            MsgBox("FILE DOES NOT EXIST! YOU NEED TO INSTALL. Click OK to continue to the installation process. (You will be prompted again to confirm the fix.)")
            Fixer.Main()
        End If
    End Sub

End Module


