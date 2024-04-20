using System;
namespace StrategyDesignPattern.Properties
{
    public class GiamGiaTamMuoi : IPgiamTrategy
    {
        public double MagiamgiaApdung(float gia) {

            return gia * 0.8;
        }
    }
}
