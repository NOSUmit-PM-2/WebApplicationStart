using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalcController : Controller
    {
        public string Index(double a = 0, double b = 0, string c = "+")
        {
            double res = 0;
            if (c == "+")
            {
                res = a + b;
            }
            else if (c == "-")
            {
                res = a - b;
            }
            else if (c == "*")
            {
                res = a * b;
            }
            else if (c == "/")
            {
                if (b == 0)
                {
                    return "На ноль делить нельзя";
                }
                res = a / b;
            }
            else
            {
                return "Недопустимая операция!\r\nВ параметре, в котором передается знак арифметической опреации,\r\nмогут быть указаны только следующие варианты символов: %2B, - , *, /.";
            }
            return $"{a} {c} {b} = {res}";
        }
    }
}
