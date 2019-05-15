using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        #region Declaration

        #endregion

        #region Property

        #endregion

        #region Contructor

        #endregion

        #region Method
        /// <summary>
        /// Hàm main
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();

            //var reverseString = new ReverseString();
            //reverseString.Reverse();

            //var speed = new Speed();
            //speed.Calculate();

            //var checkInput = new CheckInput();
            //checkInput.Check();

            //var checkAccount = new CheckAccount();
            //checkAccount.check();

            //var convertBinary = new ConvertBinary();
            //convertBinary.Convert();

            //string s = Console.ReadLine();
            //try
            //{
            //    Int32.Parse(s);
            //    Console.WriteLine("You entered valid Int32 number {0}.", s);
            //    Console.ReadKey();
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid integer number!");
            //    Console.ReadKey();
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("The number is too big to fit in Int32!");
            //    Console.ReadKey();
            //}

            //var a = Console.ReadLine();
            //Console.WriteLine(a[0]);

            //Console.Write("Nhập 1 số : ");
            //var number = Console.ReadLine();
            //var convertNumberToString = new ConvertNumberToString();
            //var text = convertNumberToString.ToText(number);
            //Console.WriteLine(text);

            var checkDay = new CheckDay();
            checkDay.Check();

            //var numberTriangular = new NumberTriangular();
            //numberTriangular.DrawTriangular();

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        #endregion

        #region Event

        #endregion

    }

    public class ReverseString
    {
        #region Method

        /// <summary>
        /// Hàm đảo ngược chuỗi String
        /// </summary>
        public void Reverse()
        {
            var input = Console.ReadLine();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.ReadKey();
        }

        #endregion
    }

    public class Speed
    {
        #region Declaration

        public static string Distance;
        public static string Time;

        #endregion

        #region Method

        /// <summary>
        /// Hàm tính vận tốc đi được khi biết thời gian và quãng đường
        /// </summary>
        public void Calculate()
        {
            do
            {
                Console.Write("Nhập quãng đường(m) là ");
                Distance = Console.ReadLine();
            }
            while (!IsNumber(Distance));

            do
            {
                Console.Write("Nhập thời gian(s) là ");
                Time = Console.ReadLine();
            }
            while (!IsNumber(Time));

            int distance = int.Parse(Distance);
            int time = int.Parse(Time);

            float speed = (float)distance / time;

            Console.WriteLine("Vận tốc là " + speed);
            Console.ReadKey();

        }

        /// <summary>
        /// Hàm để kiểm tra chuỗi nhập vào có phải là số hay không
        /// </summary>
        /// <param name="pValue">Dữ liêu vào là 1 chuỗi</param>
        /// <returns></returns>
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        #endregion
    }

    public class CheckInput
    {
        #region Method

        /// <summary>
        /// Hàm kiểm tra dữ liệu đầu vào 
        /// </summary>
        public void Check()
        {
            Console.Write("Nhập chuỗi cần kiểm tra: ");
            var input = Console.ReadLine();
            if (IsNumber(input))
            {
                Console.WriteLine(input + " là 1 số");
                Console.ReadKey();
            }
            else if (IsValidString(input))
            {
                Console.WriteLine(input + " là 1 chuỗi");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(input + " chứa kí tự đặc biệt");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Hàm kiểm tra dữ liệu nhập vào có phải 1 chuỗi hay không
        /// </summary>
        /// <param name="value">Dữ liệu vào</param>
        /// <returns></returns>
        public static bool IsValidString(string value)
        {
            string pattern = @"^[a-zA-Z]{1,25}$";
            return Regex.IsMatch(value, pattern);
        }

        /// <summary>
        /// Hàm kiểm tra dữ liệu nhập vào có phải số hay không
        /// </summary>
        /// <param name="pValue">Dữ liệu vào </param>
        /// <returns></returns>
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        #endregion
    }

    public class CheckAccount
    {
        #region Declaration

        public const string Username = "toilahan";
        public const string Password = "toilahan";
        public static string InputUsername;
        public static string InputPassword;

        #endregion

        #region Method

        public void check()
        {
            int count = 0;
            do
            {
                Console.Write("Nhập Username : ");
                InputUsername = Console.ReadLine();
                Console.Write("Nhập Password : ");
                InputPassword = Console.ReadLine();
                if ((InputUsername == Username) && (InputPassword == Password))
                {
                    Console.WriteLine("Đăng nhập thành công!");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Đăng nhạp sai. Mời nhập lại.");
                    count++;
                }
                if (count == 3)
                {
                    Console.WriteLine("Bạn đã nhập sai quá số lần cho phép. Vui lòng quay lại sau!");
                    Console.ReadKey();
                    break;
                }
            }
            while (true);
        }

        #endregion
    }

    public class ConvertBinary
    {
        #region Method

        /// <summary>
        /// Hàm chuyển đổi 1 số thạp phân sang nhị phân
        /// </summary>
        public void Convert()
        {
            var checkInput = new CheckInput();
            String input;
            do
            {
                Console.Write("Nhập vào 1 số thập phân là ");
                input = Console.ReadLine();
            }
            while (!checkInput.IsNumber(input));
            var inputConvert = int.Parse(input);
            string output = "";
            while (inputConvert > 0)
            {
                var surplus = inputConvert % 2;
                output = output + surplus;
                inputConvert = inputConvert / 2;
            }
            for (int i = output.Length - 1; i >= 0; i--)
            {
                Console.Write(output[i]);
            }
            Console.ReadKey();
        }

        #endregion
    }

    public class NumberTriangular
    {
        #region Method

        /// <summary>
        /// Hàm vẽ tam giác số
        /// </summary>
        public void DrawTriangular()
        {
            var checkInput = new CheckInput();
            string number;
            string width;
            do
            {
                Console.Write("Nhập số : ");
                number = Console.ReadLine();
                Console.Write("Nhập chiều rộng : ");
                width = Console.ReadLine();
            }
            while (!checkInput.IsNumber(number) || !checkInput.IsNumber(width));

            int intWidth = int.Parse(width);
            int intNumber = int.Parse(number);
            for(int i = intWidth; i>0; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(intNumber + " ");
                }
                Console.WriteLine();
            }
        }

        #endregion
    }

    public class ConvertNumberToString
    {
        #region Method

        /// <summary>
        /// Hàm chuyển đổi số thành chữ
        /// </summary>
        /// <param name="str">Số nhập vào</param>
        /// <returns></returns>
        public string ToText(string str)
        {
            string[] word = { "", " một", " hai", " ba", " bốn", " năm", " sáu", " bẩy", " tám", " chín" };
            string[] million = { "", " mươi", " trăm", "" };
            string[] billion = { "", "", "", " nghìn", "", "", " triệu", "", "" };
            string result = "{0}";
            int count = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (count > 0 && count % 9 == 0)
                    result = string.Format(result, "{0} tỷ");
                if (!(count < str.Length - 3 && count > 2 && str[i].Equals('0') && str[i - 1].Equals('0') && str[i - 2].Equals('0')))
                    result = string.Format(result, "{0}" + billion[count % 9]);
                if (!str[i].Equals('0'))
                    result = string.Format(result, "{0}" + million[count % 3]);
                else if (count % 3 == 1 && count > 1 && !str[i - 1].Equals('0') && !str[i + 1].Equals('0'))
                    result = string.Format(result, "{0} lẻ");
                var num = Convert.ToInt16(str[i].ToString());
                result = string.Format(result, "{0}" + word[num]);
                count++;
            }
            result = result.Replace("{0}", "");
            return result.Trim();
        }

        #endregion
    }

    public class CheckDay
    {
        #region Method

        public void Check()
        {
            Console.Write("Nhập ngày : ");
            var day = Console.ReadLine();
            Console.Write("Nhập tháng : ");
            var month = Console.ReadLine();
            Console.Write("Nhập năm : ");
            var year = Console.ReadLine();
            var stuff = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day)).DayOfWeek;
            Console.WriteLine("Ngày {0}/{1}/{2} là {3}.",day,month,year,stuff);
        }

        #endregion
    }
}
