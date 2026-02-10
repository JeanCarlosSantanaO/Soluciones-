class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
     public int ExpectedMinutesInOven()
     {
         return 40;
     }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int x)
    { 
     int tiempoEs= ExpectedMinutesInOven() - x;
        return tiempoEs;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
       public int PreparationTimeInMinutes(int x)
        {
            int tiempoPre = x * 2;
           return tiempoPre;
        }
  
    // TODO: define the 'ElapsedTimeInMinutes()' method

    public int ElapsedTimeInMinutes(int x, int y)
    {
     int nCapas = PreparationTimeInMinutes(x);
     return nCapas + y;   
    }
}
