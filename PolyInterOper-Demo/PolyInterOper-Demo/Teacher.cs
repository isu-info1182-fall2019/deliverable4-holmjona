using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyInterOper_Demo
{
    class Teacher : Person {
        public override string SayYourName() {
            return string.Format("Listen, I am {0}.", FirstName);
        }

        public override string ToString() {
            return "I am a Teacher, call me " + this.FirstName;
        }

        public Teacher CloneMeReally() {
            Teacher newTeach = new Teacher();
            newTeach.FirstName = this.FirstName;
            return newTeach;
        }


    }
}
