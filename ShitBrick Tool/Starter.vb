Module Starter

    Sub Main()
        Console.WriteLine("Press any key to start the detection...")
        Console.WriteLine()
        Console.WriteLine("NOTICE: To fix the bug you will need administration rights.")
        Console.ReadLine()
        Dim archseletor As SelectArch = New SelectArch
        archseletor.Show()
        Detection.Main()
    End Sub

End Module
