using System;
namespace StrategyDesignPattern.Properties
{
    public class GiamGiaBonMuoi : IPgiamTrategy
    {
       public double MagiamgiaApdung(float gia)
        {
            return gia * 0.4;
        }
    }
}
