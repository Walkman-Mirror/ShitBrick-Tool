Module Starter

    Sub Main()
        Console.WriteLine("Press any key to start the detection...")
        Console.WriteLine()
        Console.WriteLine("NOTICE: To fix the bug you will need administration rights.")
        Console.ReadLine()
        Dim archseletor As SelectArch = New SelectArch
        System.Windows.Forms.Application.Run(archseletor)
        Detection.Main()
    End Sub

End Module
