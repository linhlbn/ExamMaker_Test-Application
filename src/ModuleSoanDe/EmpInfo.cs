using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSoanDe
{
    internal class EmpInfo
    {
        public String IDExam { get; set; }
        public String IDEmp { get; set; }
        public String TimeDoTest { get; set; }
        public int Score { get; set; }

        public EmpInfo()
        {
            IDExam = "";
            IDEmp = "";
            TimeDoTest = "";
            Score = 0;
        }
        public override string ToString()
        {
            return IDEmp + ", " + IDExam + ", " + TimeDoTest + ", " + Score.ToString();
        }
    }
}
