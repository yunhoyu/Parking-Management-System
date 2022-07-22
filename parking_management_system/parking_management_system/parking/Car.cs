using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Homework
{
     abstract class Car 
    {
        private readonly string _carNumber;
        private DateTime _inTime;
        private DateTime _outTime;

        public string CarNumber
        {
            get { return _carNumber; }
        }
        public DateTime InTime
        {
            get { return _inTime; }
        }

        public DateTime OutTime
        {
            get { return _outTime; }
        }

        public Car(string carnumber)
        {
            _carNumber = carnumber;
            _inTime = DateTime.Now;
        }

        public virtual void Out()
        {
            _outTime = DateTime.Now;
        }

        public virtual int Diff()
        {
            int term = 0;
            if (_outTime >= _inTime) {
                term = (int)(_outTime - _inTime).TotalSeconds;
            } else {
                term = (int)(DateTime.Now - _inTime).TotalSeconds;
            }
            return term;
        }

        public override string ToString()
        {
            string messge =  $"차량번호:{CarNumber}\r\n입차시간:{InTime}";
            if (OutTime >= InTime) {
                messge += $"\r\n출차시간:{OutTime}\r\n총 주차시간{Diff()}초";
            } else {
                messge += $"\r\n주차중\r\n총 주차시간{Diff()}초";
            }
            return messge;
        }

        
    }

     class ShortTermCar : Car , IPayable
    {
        public ShortTermCar(string carnumber) : base(carnumber)
        {

        }

        public int GetPrice()
        {
            return Diff() * 10;
        }
    }

     class LongTermCar : Car , IPayable
    {
        private DateTime _estimatedTime;
        public DateTime EstimatedTime
        {
            get { return _estimatedTime; }
        }

        public LongTermCar(string carnumber, int term) : base(carnumber)
        {
            this._estimatedTime = InTime.AddSeconds(term);
        }

        public override string ToString()
        {            
            return base.ToString() + $"\r\n*장기주차";

        }
        public override int Diff()
        {
            int time = 0;

            if (OutTime >= InTime) { //주차완료
                if (EstimatedTime <= OutTime) { //주차완료 시간이 원래 계약한 시간보다 더 늦다면
                    time = (int)(OutTime - InTime).TotalSeconds; //초과시간 계산
                } else {
                    time = (int)(EstimatedTime - InTime).TotalSeconds; //무조건 계약 시간
                }
            } else { //주차 중
                if (EstimatedTime < DateTime.Now) { //현재 시간이 원래 계약한 시간보다 더 늦다면
                    time = (int)(DateTime.Now - InTime).TotalSeconds; //초과시간 계산
                } else {
                    time = (int)(EstimatedTime - InTime).TotalSeconds; //무조건 계약 시간
                }
            }

            return time;
        }

        public int GetPrice()
        {
            return Diff() * 8;
        }
    }

    class FreeCar : Car
    {
        public FreeCar(string carnumber) : base(carnumber)
        {

        }
    }
}
