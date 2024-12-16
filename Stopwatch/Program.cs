using System;
using System.Globalization;

class Program{

    public static void Main(){
        UI ui = new UI();
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.OnStarted += ui.StartClock;
        stopwatch.OnStopped += ui.StopClock;
        stopwatch.OnReset += ui.ResetClock;

        ui.Command();
        while (true){
            char key = Console.ReadKey().KeyChar;

            if (char.ToLower(key) == 's'){
                while (!Console.KeyAvailable){
                    stopwatch.Start();
                }
            }
            else if (char.ToLower(key) == 't'){
                stopwatch.Stop();
            }
            else if (char.ToLower(key) == 'r'){
                stopwatch.Reset();
            }
            else{
                Environment.Exit(0);
            }
        }
    }
}
