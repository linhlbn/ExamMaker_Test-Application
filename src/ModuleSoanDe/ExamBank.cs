using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSoanDe
{
    internal class ExamBank
    {
        public String _Q { get; set; }
        public List<String> _A { get; set; }
        public ExamBank()
        {
            _Q = "";
            _A = new List<String>();
        }
        public override String ToString()
        {
            string result = _Q + "|";
            for (int i = 0; i < _A.Count - 1; i++)
                result += _A[i] + "|";
            result += _A[_A.Count - 1];

            return result;
        }

    }
}
