using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFlexibase
{
    internal class Сalculationmain
    {
        /// <summary>
        /// Обрабодчик входных данных 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="NumbTest"></param>
        /// <returns></returns>
        public static string rewritingListNumberTest(string value, int NumbTest)
        {
            List<string> Listvalue = value.Split(", ").ToList();
            for (int i = 0; i < Listvalue.Count; i++)
            {
                if (NumbTest == 1) Listvalue[i] = rewritingNumberTest1(Convert.ToInt32(Listvalue[i]));
                else if (NumbTest == 2) Listvalue[i] = rewritingNumberTest2(Convert.ToInt32(Listvalue[i]));
                else Listvalue[i] = rewritingNumberTest3(Convert.ToInt32(Listvalue[i]));
            }
            return String.Join(", ", Listvalue);
        }
        /// <summary>
        /// Проверка для первого теста   
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static string rewritingNumberTest1(int value)
        {
            List<string> strings = new List<string>();
            if (value % 3 == 0) strings.Add("fizz");
            if (value % 5 == 0) strings.Add("buzz");
            return strings.Count == 0 ? Convert.ToString(value) : String.Join("-", strings);
        }
        /// <summary>
        /// Проверка для второго теста   
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static string rewritingNumberTest2(int value)
        {
            List<string> strings = new List<string>();
            if (value % 3 == 0) strings.Add("fizz");
            if (value % 4 == 0) strings.Add("muzz");
            if (value % 5 == 0) strings.Add("buzz");
            if (value % 7 == 0) strings.Add("guzz");
            return strings.Count == 0 ? Convert.ToString(value) : String.Join("-", strings);
        }
        /// <summary>
        /// Проверка для третьего теста   
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static string rewritingNumberTest3(int value)
        {
            List<string> strings = new List<string>();
            if (value % 3 == 0 && value % 5 != 0) strings.Add("dog");
            if (value % 4 == 0) strings.Add("muzz");
            if (value % 5 == 0 && value % 3 != 0) strings.Add("cat");
            if (value % 5 == 0 && value % 3 == 0) strings.Add("good-boy");
            if (value % 7 == 0) strings.Add("guzz");
            return strings.Count == 0 ? Convert.ToString(value) : String.Join("-", strings);
        }
    }
}
