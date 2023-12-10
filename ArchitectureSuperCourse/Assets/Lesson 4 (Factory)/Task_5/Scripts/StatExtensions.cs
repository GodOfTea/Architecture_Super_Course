using Factory.Task_5.PlayerComponents;

namespace Factory.Task_5
{
    public static class StatExtensions
    {
        public static Stat Add(this Stat input, int augend)
        {
            return new Stat(input.StatType, input.Value + augend);
        }
        
        public static Stat Subtract(this Stat input, int deduction)
        {
            return new Stat(input.StatType, input.Value - deduction);
        }
        
        public static Stat Multiply(this Stat input, int multiplicative)
        {
            return new Stat(input.StatType, input.Value * multiplicative);
        }
    }
}