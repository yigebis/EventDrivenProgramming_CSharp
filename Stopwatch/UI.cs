using System;

class UI{

    public void Command(){
        Console.ResetColor();
        Console.WriteLine(
            @"Stopwatch app
            S/s : start.   T/t : Stop.   R/r : Reset
            Press any other key to exit"
        );
        
    }

    public void StartClock(int timeElapsed, string message){
        Console.Clear();

        Command();
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n" + message);
        DisplayClock(timeElapsed);
    }

    public void StopClock(int timeElapsed, string message){

        Console.Clear();
                
        Command();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n" + message);
        DisplayClock(timeElapsed);
    }

    public void ResetClock(int timeElapsed, string message){
        Console.Clear();

        Command();

        Console.WriteLine("\n" + message);
        DisplayClock(timeElapsed);
    }

    public void DisplayClock(int timeElapsed){
        var minutes = TimeService.getMinutes(timeElapsed);
        var seconds = TimeService.getSeconds(timeElapsed);
        var hours = TimeService.getHours(timeElapsed);
        
        string displayMinutes = "", displaySeconds = "", displayHours = "";
        if (minutes < 10){
            displayMinutes = "0" + minutes;
        }
        else{
            displayMinutes += minutes;
        }

        if (seconds < 10){
            displaySeconds = "0" + seconds;
        }
        else{
            displaySeconds += seconds;
        }

        if (hours < 10){
            displayHours = "0" + hours;
        }
        else{
            displayHours += hours;
        }

        Console.WriteLine(displayHours + ":" + displayMinutes + ":" + displaySeconds);
    }
}