using System;

class Stopwatch{
    private int timeElapsed;
    bool isRunning;

    public delegate void StopwatchEventHandler(int timeElapsed, string message);

    public event StopwatchEventHandler OnStarted, OnStopped, OnReset;

    public void Start(){
        
        this.isRunning = true;
        this.Tick();
        Thread.Sleep(1000);
            
        OnStarted?.Invoke(timeElapsed, "Stopwatch started");
       
    }

    public void Stop(){

        if (this.isRunning){
            isRunning = false;
            OnStopped?.Invoke(timeElapsed, "Stopwatch stopped");
        }
        
    }

    public void Reset(){

        this.isRunning = false;
        this.timeElapsed = 0;
        OnReset?.Invoke(timeElapsed, "Stopwatch reset");
    }

    public void Tick(){
        this.timeElapsed += 1;
    }    
}