using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateToyProj
{
    public class ProgramDelegate
    {
        static void Main(string[] args)
        {
            new ProgramDelegate().TestCode();

        }

        // Delegate Function 선언
        // 메소드의 형태 params (int, int) , return (int)
        delegate int CalcDelegate(int a, int b);

        private void TestCode()
        {

            // Calc(int, int CalcDelegate) : Delegate 타입이 같은 메소드들을 다루는 Handler
            // 방법1. 객체 할당 후 사용
            var addOp = new CalcDelegate(Add);
            Calc(6, 3, addOp);

            // 방법2. 메소드 바로 사용 
            Calc(6, 3, Sub);

            Console.ReadLine();
        }

        // params에 Delegation func을 가지고 있는 함수 구현
        void Calc(int a, int b, CalcDelegate calc)
        {
            int res = calc(a, b);
            //int res = calc.Invoke(a, b);

            Console.WriteLine("사용함수 : {0}", calc.Method);
            Console.WriteLine($"f({a}, {b}) = {res}");
        }

        private int Add(int a, int b)
        {
            return a + b;
        }
        private int Sub(int a, int b)
        {
            return a - b;
        }
        private int Mul(int a, int b)
        {
            return a * b;
        }
        private int Div(int a, int b)
        {
            return a / b;
        }
    }
}
