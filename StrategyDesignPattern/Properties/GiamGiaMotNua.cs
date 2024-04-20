using System;
namespace StrategyDesignPattern.Properties
{
    public class GiamGiaMotNua : IPgiamTrategy
    {
       public double MagiamgiaApdung(float gia)
        {
            return gia * 0.5;
        }
    }
}
