class Lasagna
{
    private int expectedOvenTime = 40;
    private int minutesToPrepare = 2;

    
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){
        return expectedOvenTime;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesInOven){
        return expectedOvenTime - minutesInOven;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layer){
        return minutesToPrepare * layer;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layer, int minutesInOven){
        return layer * minutesToPrepare + minutesInOven;
    }
}
