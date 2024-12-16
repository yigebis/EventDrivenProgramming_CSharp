using System;

class UI{

    public void Command(){
        Console.WriteLine(
            @"S/s : start stopwatch 
            \nT/t : Stop the stopwatch 
            \nR/r : Reset the stopwatch 
            \nPress any other key to exit
        ");
    }

    public void StartClock(int timeElapsed, string message){
        Console.Clear();

        Command();
        Console.WriteLine("\n" + message);
        DisplayClock(timeElapsed);
    }

    public void StopClock(int timeElapsed, string message){

        Console.Clear();
                
        Command();

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
        
        string displayMinutes = "", displaySeconds = "";
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

        Console.WriteLine(displayMinutes + ":" + displaySeconds);
    }
}