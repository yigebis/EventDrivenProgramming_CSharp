using System;

class TimeService{

    public static int getMinutes(int timeElapsed){
        return timeElapsed / 60;
    }

    public static int getSeconds(int timeElapsed){
        return timeElapsed % 60;
    }
}