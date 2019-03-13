using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private string myname;
        private string mytype;
        public SingleMission(string name)
        {
            myname = name;
        }

        public string Name
        {
            get { return myname; }
        }

        public string Type
        {
            get {return mytype; }
        }

        public event EventHandler<double> OnCalculate;


        public double Calculate(double value)
        {
        }
    }
}
