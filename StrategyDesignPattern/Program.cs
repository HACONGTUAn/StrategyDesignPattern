using System;
using StrategyDesignPattern.Properties;

namespace StrategyDesignPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var ve = new Ticket();
            ve.SetName("ve so 1");
            ve.SetGia(5f);
            ve.SetGiam(new GiamGiaTamMuoi());

            Console.WriteLine(ve.GetName() +" "+ ve.GetGia()+" " + ve.duockhuyenmai() );
        }
    }
}
