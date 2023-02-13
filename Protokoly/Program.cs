using static System.Console;
using System.Diagnostics;



Trace.Listeners.Add(new TextWriterTraceListener(
    File.CreateText(Path.Combine(Environment.GetFolderPath(
        Environment.SpecialFolder.DesktopDirectory), "log.txt"))));

Trace.AutoFlush = true;

Debug.WriteLine("Typ Debug mówi, że już jest gotowy.");
Trace.WriteLine("Typ Trace mówi, że już jest gotowy.");Working with protocols