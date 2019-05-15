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

            var convertBinary = new ConvertBinary();
            convertBinary.Convert();

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

            float speed = (float) distance / time;

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
                if(count==3)
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
            string output ="";
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


}
