using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Exception_
{
    class MyExceptionClass
    {
        // method containing the regex 
        public static bool isValidCode(string code, string ArgumentName)
        {
            bool exceptionBool = true;
            string strRegex;
            if (code.Length == 16)
            {
                strRegex = @"(^[0-9]{16}$)";
            }
            else if (code.Length == 4)
            {
                strRegex = @"(^[0-9]{4}$)";
            }
            else if (code.Length == 3)
            {
                strRegex = @"(^[0-9]{3}$)";
            }
            else
            {
                strRegex = @"(^[0-9]{1}$)";
            }
            Regex re = new Regex(strRegex);
            try
            {
                if (!re.IsMatch(code))
                {
                    exceptionBool = false;
                    throw new Exception($"Wrong {ArgumentName} code");
                }
                else if (ArgumentName == "PAN" && code.Length != 16)
                {
                    exceptionBool = false;
                    throw new Exception($"Wrong {ArgumentName} code");
                }
                else if (ArgumentName == "PIN" && code.Length != 4)
                {
                    exceptionBool = false;
                    throw new Exception($"Wrong {ArgumentName} code");
                }
                else if (ArgumentName == "CVC" && code.Length != 3)
                {
                    exceptionBool = false;
                    throw new Exception($"Wrong {ArgumentName} code");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program Completed");
            }
            return exceptionBool;
        }
        public static bool isValidBalansString(string balans)
        {
            bool exceptionBool = true;
            string strRegex;
            if (balans.Length == 3)
            {
                strRegex = @"(^[0-9]{3}$)";
            }
            else if (balans.Length == 2)
            {
                strRegex = @"(^[0-9]{2}$)";
            }
            else
            {
                strRegex = @"(^[0-9]{1}$)";
            }
            Regex re = new Regex(strRegex);
            try
            {
                if (!re.IsMatch(balans))
                {
                    exceptionBool = false;
                    throw new Exception($"Incorrect monetary value entered");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program Completed");
            }
            return exceptionBool;
        }

        public static bool isValidExpireDate(string year)
        {
            bool exceptionBool = true;
            try
            {
                if (year == "1")
                {

                }
                else if (year == "3")
                {
                }
                else if (year == "5")
                {
                }
                else
                {
                    exceptionBool = false;
                    throw new Exception($"Wrong Expire Date");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program Completed");
            }
            return exceptionBool;
        }
        public static bool isValidBalansDouble(double balans)
        {
            bool exceptionBool = true;
            try
            {
                if (balans < 0)
                {
                    exceptionBool = false;
                    throw new Exception("Not enough money on balance");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program Completed");
            }
            return exceptionBool;
        }
        public static bool isValidName(string name, string ArgumentName)
        {
            bool exceptionBool = true;
            Regex rgx = new Regex("[^a-zA-Z]");
            try
            {
                if (rgx.IsMatch(name))
                {
                    exceptionBool = false;
                    throw new Exception($"{ArgumentName} is wrong");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program Completed");
            }
            return exceptionBool;
        }
    }
}
