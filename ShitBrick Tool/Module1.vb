Module Module1

    Sub Main()
        Console.Title = (My.Application.Info.ProductName & " v" & My.Application.Info.Version.ToString)
        Console.WriteLine("################################################################################")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("                                 " & My.Application.Info.ProductName)
        Console.WriteLine("                                    v" & My.Application.Info.Version.ToString)
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine(" Welcome to the ShitBrick tool. This utility is used to download and install a")
        Console.WriteLine("   certain dynamic link library that most of Deavmi's applications use, but")
        Console.WriteLine("    this dll is referenced in a different location and causes a bug, which")
        Console.WriteLine("         will be fixed soon, this is a temporary tool to fix that bug.")
        Console.WriteLine()
        Console.WriteLine("          Read more about this topic: http://bit.ly/shitbrick-utility")
        Console.WriteLine()
        Console.WriteLine("          Registered under the GPLv3. http://gnu.org/licenses/gpl.txt")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("                          Press any key to continue...")
        Console.WriteLine()
        Console.WriteLine("        Please note that this application must be run as administrator!")
        Console.WriteLine("             " & My.Application.Info.Copyright)
        Console.WriteLine()
        Console.WriteLine("################################################################################")
        Console.ReadLine()
        'This needed to be added (Fix for issue "Doesn't work (#1)")
        'Thanks to Walkman100 for helping on picking up this bug.
        Starter.Main()
    End Sub

End Module
