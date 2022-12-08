﻿using RawPrint;

if (args.Length != 2)
{
    Console.WriteLine("Syntax:\n\n    rp <printer name> <file name>\n");
    return;
}

IPrinter printer = new Printer();
printer.OnJobCreated += (_, _) => { Console.WriteLine("Job started."); };
printer.PrintRawFile(args[0], args[1], args[1]);