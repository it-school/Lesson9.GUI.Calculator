using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9.GUI
{
    class Calculator
    {
        double number1, number2;
        int operationCode;  // 1 - plus, 2 - minus, 3 - mult, 4 - division
        string result;
        double memory;


        public double Number1 { get => number1; set => number1 = value; }
        public double Number2 { get => number2; set => number2 = value; }
        public int OperationCode { get => operationCode; set => operationCode = value; }
        public string Result { get => result; }
        public double Memory { get => memory; set => memory = value; }

        public void Calculate()
        {
            switch (this.operationCode)
            {
                case 1:
                    result = (number1 + number2).ToString();
                    break;
                case 2:
                    result = (number1 - number2) + "";
                    break;
                case 3:
                    result = (number1 * number2).ToString();
                    break;
                case 4:
                    result = (number2 != 0 ? (number1 / number2).ToString() : "Division by zero");
                    break;
                default:
                    break;
            }
        }
    }
}
