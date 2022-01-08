using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_15._1
{
    class ArithProgression : ISeries
    {
        int shagValue;
        int startValue;
        int currentValue;
        public int GetNext()
        {
            currentValue += shagValue;
                return currentValue;
        }

        public void Reset()
        {
            currentValue=startValue;
        }

        public void SetStart(int x)
        {
            startValue=x;
            currentValue = startValue;
        }
        public void setStep(int s)
        {
            shagValue = s;
        }
    }
}
