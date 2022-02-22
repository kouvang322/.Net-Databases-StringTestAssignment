using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;
System.Globalization.CultureInfo.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");

namespace StringInterpolationTemplate.Services
{
    public class StringInterpolationService : IStringInterpolationService
    {

        private readonly ISystemDate _date;
        private readonly ILogger<IStringInterpolationService> _logger;

        public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
        {
            _date = date;
            _logger = logger;
            _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
        }

        //1. January 22, 2019 (right aligned in a 40 character field)
        public string Number01()
        {
            var date = _date.Now.ToString("MMMM dd, yyyy");
            var answer = $"{date,40}";
            Console.WriteLine(answer);

            return answer;
        }

        public string Number02()
        {
            var date = _date.Now.ToString("yyyy.mm.dd");
            Console.WriteLine(date);
            return date;
        }

        public string Number03()
        {
            var date = $"Day {_date.Now.ToString("dd")} of {_date.Now.ToString("MMMM")}, {_date.Now.ToString("yyyy")}";
            Console.WriteLine(date);
            return date;
        }

        public string Number04()
        {
            var date = $"Year: {_date.Now.ToString("yyyy")}, Month: {_date.Now.ToString("MM")}, Day: {_date.Now.ToString("dd")}";
            Console.WriteLine(date);
            return date;
        }

        public string Number05()
        {
            var date = _date.Now.ToString("dddd");
            var answer = $"{date,10}";
            return answer;
        }

        public string Number06()
        {
            var date = _date.Now.ToString("hh:mm tt");
            var date2 = _date.Now.ToString("dddd");
            var answer = $"{date,10}" + $"{date2,10}";
            Console.WriteLine(answer);
            return answer;
        }

        public string Number07()
        {
            var date = $"h:{_date.Now.ToString("hh")}, m:{_date.Now.ToString("mm")}, s:{_date.Now.ToString("ss")}";
            Console.WriteLine(date);
            return date;
        }

        public string Number08()
        {
            var date = _date.Now.ToString("yyyy.MM.dd.hh.mm.ss");
            Console.WriteLine(date);
            return date;
        }

        public string Number09()
        {
            var pi = Math.PI;
            var answer = $"{pi:C}";
            Console.WriteLine(answer);
            return answer;
        }

        public string Number10()
        {
            var pi = Math.PI;
            var answer = $"{pi,10:n3}";
            Console.WriteLine(answer);
            return answer;
        }

        public string Number11()
        {
            var num = 2;
            var squareRootOf2 = Convert.ToInt32(Math.Sqrt(num));

            var hexadecimalOfSquareRootOf2 = $"{squareRootOf2:X}";

            Console.WriteLine(hexadecimalOfSquareRootOf2);

            return hexadecimalOfSquareRootOf2;
        }
    }
}
