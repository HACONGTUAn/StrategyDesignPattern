using System;
namespace StrategyDesignPattern.Properties
{
    public class Ticket
    {
        private string _name;
        private float _gia;
        private IPgiamTrategy _pgiam;
        public GiamGiaBonMuoi giamgia;

        public Ticket()
        {
        }
        public Ticket(IPgiamTrategy giamgia)
        {
            _pgiam = giamgia;
        }
     
        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetGia(float gia)
        {
            _gia = gia;
        }
        public float GetGia()
        {
            return _gia;
        }
        public void SetGiam(IPgiamTrategy giam)
        {
            _pgiam = giam;
        }
        public IPgiamTrategy GetGiam()
        {
            return _pgiam;
        }
        public double duockhuyenmai()
        {
            return _pgiam.MagiamgiaApdung(_gia);
        }
     
    }
}
