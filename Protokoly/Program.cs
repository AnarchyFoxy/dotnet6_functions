using static System.Console;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;



Trace.Listeners.Add(new TextWriterTraceListener(
    File.CreateText(Path.Combine(Environment.GetFolderPath(
        Environment.SpecialFolder.DesktopDirectory), "log.txt"))));

Trace.AutoFlush = true;

Debug.WriteLine("Typ Debug mówi, że już jest gotowy.");
Trace.WriteLine("Typ Trace mówi, że już jest gotowy.");

ConfigurationBuilder tworca_konfiguracji = new();

tworca_konfiguracji.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("Appsettings.json",
    optional: true, reloadOnChange: true);

IConfigurationRoot konfiguracja = tworca_konfiguracji.Build();

TraceSwitch ts = new(
    displayName: "Przelacznik",
    description: "Ten przelacznik jest ustawiany przez konfigurację z pliku JSON.");

konfiguracja.GetSection("Przelacznik").Bind(ts);

Trace.WriteLineIf(ts.TraceError, "Poziom błędów");
Trace.WriteLineIf(ts.TraceWarning, "Poziom ostrzeżeń");
Trace.WriteLineIf(ts.TraceInfo, "Poziom informacji");
Trace.WriteLineIf(ts.TraceVerbose, "Poziom ogólny");