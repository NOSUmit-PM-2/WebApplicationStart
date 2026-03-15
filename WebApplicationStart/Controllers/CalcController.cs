using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalcController : Controller
    {
        public string Index(double a = 0, double b = 0, string c="+")
        { 
            double res = 0;

            switch (c)
            {
                case "+":
                    res = a+b;
                    break;

                case "-":
                    res = a - b;
                    break;

                case "*":
                    res = a * b;
                    break;

                case "/":
                    {
                        if (b == 0)
                        {
                            return "на 0 делить нельзя";
                        }
                        res = a / b;
                        break;
                    }

                default:
                    return "недопутсимая операция ошибка!";

            }

            return $"{a} {c} {b} = {res}";
        }
    }
}
