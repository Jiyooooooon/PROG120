using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Vending
    {
        private int _MachineBalance;
        private int _Bottles;
        
        public Vending()
        {
            _MachineBalance = 0;
            _Bottles = 5; 
        }

        public int Bottle
        {
            get
            {
                return _Bottles;
            }     
        }
        public int Balance
        {
            get
            {
                return _MachineBalance;
            }
        }
        public int BuyCoke()
        {
            if (_Bottles > 0 && _MachineBalance > 0) //_Bottles != 0 is also correct!
            {
                _Bottles = _Bottles - 1;
                _MachineBalance = _MachineBalance - 1;
                return 0;  
            }
            else if (_Bottles == 0)
                return 1;
            else if (_MachineBalance == 0)
                return 2;
            else
                return 3;
        }
        public void AcceptCash()
        {
            _MachineBalance = _MachineBalance + 1;
        }
        public int GiveRefund()
        {
            int temp = _MachineBalance;
            _MachineBalance = 0;
                return temp;
        }
       
    }
}
