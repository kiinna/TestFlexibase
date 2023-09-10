namespace TestFlexibase
{
    public class FlexibaseTest
    {
        /// <summary>
        /// Если число делится на 3 без остатка - заменить его на "fizz", 
        /// если делится на 5 без остатка - заменить его на "buzz", если делится на 3 и на 5 без остатка - заменить на "fizz-buzz"
        /// </summary>
        /// <param name="value"></param>
        public static string Test1(string value)
        {
            return Сalculationmain.rewritingListNumberTest(value, 1);
        }
        /// <summary>
        /// На основе первой задачи. Нужно добавить аналогичное поведения для чисел кратным 7 и 4. 
        /// Если делится на 4 без остатка - заменить на "muzz", если делится на 7 без остатка - заменить на "guzz", 
        /// если делится на 4 и 7 без остатка - заменить на "muzz-guzz".
        /// </summary>
        public static string Test2(string value)
        {
            return Сalculationmain.rewritingListNumberTest(value, 2);
        }
        /// <summary>
        /// На основе первой задачи. Нужно добавить аналогичное поведения для чисел кратным 7 и 4. 
        /// Если делится на 4 без остатка - заменить на "muzz", если делится на 7 без остатка - заменить на "guzz", 
        /// если делится на 4 и 7 без остатка - заменить на "muzz-guzz".
        /// </summary>
        public static string Test3(string value)
        {
            return Сalculationmain.rewritingListNumberTest(value, 2);
        }
    }
}