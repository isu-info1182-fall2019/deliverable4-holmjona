using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyInterOper_Demo
{
    class Room: ISayTeacher
    {
        private int _Number;

        public int Number {
            get { return _Number; }
            set { _Number = value; }
        }

        public string SayTeacher()
        {
            return "Boo";
        }

    }



}
