namespace Lec03LibN
{
    
    public static class Lec03LibN
    {
        static public  IFactory getL1()
        {
            return new Bonus_1();
        }
        static public  IFactory getL2(float a)
        {
            return new Bonus_2(a);
        }
        static public  IFactory getL3(float a, float b)
        {
            return new Bonus_3(a, b);
        }
    }

    
    
    
    
   
   

    
    
    


    
    
    



    public class Employee
    {
        public IBonus bonus { get; private set; }
        public Employee(IBonus bonus)
        {
            this.bonus = bonus;
        }
        public float calcBonus(float number_hours)
        {
            return bonus.calc(number_hours);
        }
    }
}