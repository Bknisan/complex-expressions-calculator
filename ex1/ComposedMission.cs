using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private string myname;
        private string mytype;
        public string Name
        {
            get {return myname; }
        }

        public string Type
        {
            get { return mytype; }
        }
        public ComposedMission(string name)
        {
            myname = name;
        }
        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            return 1;
        }
    }
}
