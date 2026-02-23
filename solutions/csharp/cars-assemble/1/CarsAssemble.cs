static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
      if(speed <= 0){
          return 0.0;
      }else if(speed >= 1 && speed <= 4){
          return 1.0;
      }else if(speed >=5 && speed <=8 ){
         return 0.9;
      }else if(speed == 9){
          return 0.8;
      }else if(speed ==10){
          return 0.77;
      }else{
          return 0.0;
      }
          
      }
    
    
    public static double ProductionRatePerHour(int speed)
    {
        double produccionT = speed * 221;
        double sRate = SuccessRate(speed);

        return produccionT * sRate;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
     double c = ProductionRatePerHour(speed);
     double r = c /60;
     int i = (int)r;
     return i; 
    }
}
