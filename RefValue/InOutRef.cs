using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefValue
{
    internal static class InOutRef
    {
        //In make Variable Read-Only
        public static void SumByInOut(in int a,in int b,out int sum)
        {
            sum = a+b;
        }
        public static int SumByRefAndModifiedThemBy1(ref int a, ref int b)
        {
            a+=1;
            b+=1;
            return a + b;
        }
        public static int NormalSumAndModifiedThemBy1(int a,int b)
        {
            a += 1;
            b += 1;
            return a + b;
        }
    }
}
