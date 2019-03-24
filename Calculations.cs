using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculations
    {
        internal static string RemoveWhiteCahracters(string number)
        {
            number = number.Replace(" ", "");
            number = number.Replace("\n", "");
            number = number.Replace("\t", "");
            number = number.Replace("\v", "");
            return number;
        }
        internal static bool IsItNumber(string number)
        {
            if (number == "")
                return false;
            if (number == "-,")
                return false;
            string AllowedCharacters = "0123456789,-";
            string AllowedCharactersIfLengthIsZero = "0123456789";
            if (number.Length == 1)
            {
                if (!AllowedCharactersIfLengthIsZero.Contains(number))
                    return false;
                return true;
            }
            int how_many_commas = 0;

            for (int i = 0; i < number.Length; i++)
            {

                if (!AllowedCharacters.Contains(number[i].ToString()))
                    return false;
                if (number[i] == '-' && i != 0)
                    return false;
                if (number[i] == ',')
                {
                    how_many_commas++;
                }
                if (how_many_commas > 1)
                    return false;
            }
            
            
            return true;
        }
        static bool IsItNegative(string number)
        {
            if (number.Length == 0)
                return false;
            if (number[0] == '-')
                return true;
            return false;
        }
        static string AbsoluteValue(string number)
        {
            if (IsItNegative(number))
                return number.Substring(1, number.Length - 1);
            return number;
        }
        static int MakeIntFromChar(char character)
        {
            string s = "";
            s += character;
            return Int32.Parse(s); // Parser jest chybal wolniejszy niz operacje na kodach ASCII 
        }
        static string RemoveZerosFromTheBack(string number)
        {
            if (number.Length == 0)
                return "0";
            if (!IsThereComma(number))// 10000 -> 10000
                return number;

            bool OnlyZeros = true;
            int index = number.Length - 1;

            for (int i = number.Length - 1; ; --i)
            {
                if (number[i] == ',')
                {
                    index = i;
                    break;
                }
                if (number[i] != '0')
                {
                    OnlyZeros = false;
                    index = i;
                    break;
                }
            }
            if (OnlyZeros) // 9,000 -> 9
                return number.Substring(0, index);
            return number.Substring(0, index + 1);
        }
        static string RemoveZerosFromTheFront(string number)
        {
            if (number == "")
                return "0";
            if (IsItNegative(number))
            {
                if (number[1] != '0')
                    return number;
            }
            else if (number[0] != '0')
            {
                return number;
            }
            string result = "";
            if (IsItNegative(number))
                result += '-';
            string number_abs = AbsoluteValue(number);
            bool OnlyZerosAll_number_abs = true;
            for (int i = 0; i < number_abs.Length; i++)
            {
                if (number_abs[i] != '0')
                {
                    OnlyZerosAll_number_abs = false;
                    break;
                }
            }
            if (OnlyZerosAll_number_abs)
                return "0";
            int n = HowManyBeforeComma(number_abs);
            if (IsThereComma(number_abs))
                n++;
            int HowManyZeros = 0;
            int LastIsComa = 0;
            for (int i = 0; i < n; i++)
            {
                if (number_abs[i] != '0')
                {
                    if (number_abs[i] == ',')
                    {
                        LastIsComa = 1;
                    }
                    break;
                }
                else
                {
                    HowManyZeros++;
                }

            }
            return result + number_abs.Substring(HowManyZeros - LastIsComa, number_abs.Length - HowManyZeros + LastIsComa);
        }// 0098,56 -> 98,56  
       
        static bool IsThereComma(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == ',')
                    return true;
            }
            return false;
        }
        static string AddComma(string number)
        {
            return number + ',';
        }
        static string AddComa(string number, int n)
        {
            int k = number.Length - n;

            if (k <= 0)
            {
                return "0," + AddZerosAtTheFront(number, -k);
            }

            return number.Substring(0, k) + "," + number.Substring(k, n);
        }
        static string RemoveComma(string liczba)
        {
            if (IsThereComma(liczba))
                liczba = liczba.Remove(HowManyBeforeComma(liczba), 1);
            return liczba;
        }
        static string AddZerosAtTheBack(string number, int n)
        {
            string result = number;
            for (int i = 0; i < n; ++i)
            {
                result += '0';
            }
            return result;
        }
        static string AddZerosAtTheFront(string number, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += '0';
            }
            return result + number;
        }
        static int HowManyAfterComma(string number)
        {
            bool CommaWasAlready = false;
            int result = 0;
            for (int i = 0; i < number.Length; ++i)
            {
                if (CommaWasAlready)
                    result++;
                if (number[i] == ',')
                    CommaWasAlready = true;
            }
            return result;
        }
        static int HowManyBeforeComma(string number)
        {
            int result = 0;
            for (int i = 0; i < number.Length; ++i)
            {
                if (number[i] == ',')
                    return result;
                result++;
            }
            return result;
        }
        static string[] AlignNumbers(string number1, string number2) //"comma under comma"
        {
            

            if (number1[0] == ',')
                number1 = '0' + number1;
            // ,5 -> 0,5
            if (number2[0] == ',')
                number2 = '0' + number2;

            if (!IsThereComma(number1) && IsThereComma(number2))
            {
                number1 = AddComma(number1);
                int n = HowManyAfterComma(number2);
                number1 = AddZerosAtTheBack(number1, n);
            }
            else if (IsThereComma(number1) && !IsThereComma(number2))
            {
                number2 = AddComma(number2);
                int n = HowManyAfterComma(number1);
                number2 = AddZerosAtTheBack(number2, n);
            }
            else if (IsThereComma(number1) && IsThereComma(number2))
            {
                int n1 = HowManyAfterComma(number1);
                int n2 = HowManyAfterComma(number2);
                if (n1 > n2)
                {
                    number2 = AddZerosAtTheBack(number2, n1 - n2);
                }
                else if (n2 > n1)
                {
                    number1 = AddZerosAtTheBack(number1, n2 - n1);
                }
            }
            if (number1.Length > number2.Length)
            {
                number2 = AddZerosAtTheFront(number2, number1.Length - number2.Length);
            }
            else if (number2.Length > number1.Length)
            {
                number1 = AddZerosAtTheFront(number1, number2.Length - number1.Length);
            }
            string[] result = { number1, number2 };
            return result;

        }

        // calculation functions

        internal static string Add(string number1, string number2)
        {
            if (IsItNegative(number1) && IsItNegative(number2))
                return "-" + Add(AbsoluteValue(number1), AbsoluteValue(number2));

            if (IsItNegative(number1) && !IsItNegative(number2))
                return Subtract(number2, AbsoluteValue(number1));

            if (!IsItNegative(number1) && IsItNegative(number2))
                return Subtract(number1, AbsoluteValue(number2));

            string[] numbers = AlignNumbers(number1, number2);
            int n = numbers[1].Length;
            int carry = 0;
            string result = "";

            for (int i = n - 1; i >= 0; i--)
            {
                if (numbers[0][i] == ',')
                {
                    result = ',' + result;
                    --i;
                }

                int tmp = MakeIntFromChar(numbers[0][i]) + MakeIntFromChar(numbers[1][i]);
                tmp += carry;
                int addit = tmp % 10;
                result = addit + result;
                carry = tmp / 10;
            }

            if (carry != 0)
                result = carry + result;

            result = RemoveZerosFromTheFront(RemoveZerosFromTheBack(result));
            return result;
        }
        internal static string Subtract(string number1, string number2)
        {
            if (!IsItNegative(number1) && IsItNegative(number2))
                return Add(number1, AbsoluteValue(number2));

            if (IsItNegative(number1) && !IsItNegative(number2))
                return '-' + Add(AbsoluteValue(number1), number2);

            if (IsItNegative(number1) && IsItNegative(number2))
                return Subtract(AbsoluteValue(number2), AbsoluteValue(number1));

            string[] numbers = AlignNumbers(number1, number2);
            int n = numbers[1].Length;
            bool borrow = false;
            string result = "";

            for (int i = n - 1; i >= 0; i--)
            {
                if (numbers[0][i] == ',')
                {
                    i--;
                    result = ',' + result;
                }
                int tmp = MakeIntFromChar(numbers[0][i]) - MakeIntFromChar(numbers[1][i]);
                if (borrow)
                {
                    tmp -= 1;
                }
                if (tmp < 0)
                {
                    tmp += 10;
                    borrow = true;
                }
                else
                {
                    borrow = false;
                }
                result = tmp + result;

            }

            if (borrow)
                return '-' + Subtract(number2, number1);

            return RemoveZerosFromTheBack(RemoveZerosFromTheFront(result));
        }
        internal static string Multiply(string number1, string number2)
        {
            if (AbsoluteValue(RemoveZerosFromTheFront(RemoveZerosFromTheBack(number1))) == "0" || AbsoluteValue(RemoveZerosFromTheFront(RemoveZerosFromTheBack(number2))) == "0")
                return "0";
            if (IsItNegative(number1) != IsItNegative(number2))
                return "-" + Multiply(AbsoluteValue(number1), AbsoluteValue(number2));
            if (IsItNegative(number1) == IsItNegative(number2) && IsItNegative(number1) == true)
                return Multiply(AbsoluteValue(number1), AbsoluteValue(number2));
            int where_comma = HowManyAfterComma(number1) + HowManyAfterComma(number2);
            number1 = RemoveComma(number1);
            number2 = RemoveComma(number2);
            string result = "0";

            for (int i = 0; i < number1.Length; i++)
            {
                int carry = 0;
                string i_result = "";
                for (int j = 0; j < number2.Length; j++)
                {
                    
                    int tmp = MakeIntFromChar(number2[number2.Length - 1 - j]) * MakeIntFromChar(number1[number1.Length - 1 - i]);
                    tmp += carry;
                    carry = tmp / 10;
                    i_result = (tmp % 10) + i_result;
                }

                if (carry != 0)
                    i_result = carry + i_result;
                i_result = AddZerosAtTheBack(i_result, i);
                result = Add(result, i_result);
            }
            result = RemoveZerosFromTheFront(RemoveZerosFromTheBack(AddComa(result, where_comma)));
            return result;

        }
        internal static string Divide(string number1, string number2)
        {
            
            if (RemoveZerosFromTheFront(RemoveZerosFromTheBack(AbsoluteValue(number2))) == "0")
                return " Division by zero is mathematically undefined, is not allowed in this calculator.";
            if (RemoveZerosFromTheFront(RemoveZerosFromTheBack(AbsoluteValue(number1))) == "0")
                return "0";
            if (IsItNegative(number1) != IsItNegative(number2))
            {
                return "-" + Divide(AbsoluteValue(number1), AbsoluteValue(number2));
            }
            if (IsItNegative(number1) == IsItNegative(number2) && IsItNegative(number1) == true)
            {
                return Divide(AbsoluteValue(number1), AbsoluteValue(number2));
            }
            int x = HowManyBeforeComma(number1);
            if (IsThereComma(number1))
            {
                number1 = RemoveComma(RemoveZerosFromTheBack(number1));
            }
            string mozezera = "1";
            int IleDziesatek = 0;
            if (IsThereComma(number2))
            {
                IleDziesatek = HowManyAfterComma(RemoveZerosFromTheBack(number2));
                mozezera = AddZerosAtTheBack(mozezera, IleDziesatek);
                number2 = RemoveComma(number2);
            }
            
            string divident = number1[0].ToString();
            int i = 0;
            string result = "";
            while (true)
            {
                
                string tmp = "";
                for (int j = 0; j <= 10; j++)
                {
                    string j_string = "" + j;
                    tmp = Multiply(number2, j_string);
                    if (!IsItNegative(Subtract(tmp, divident)))
                    {
                        if (Subtract(tmp, divident) != "0")
                        {
                            j_string = "" + (j - 1);
                            tmp = Multiply(number2, j_string);
                        }
                        result += j_string;
                        break;
                    }

                }
                i++;
                if (i >= number1.Length)
                {
                    string remainder = Subtract(divident, tmp);
                    if (i > (number1.Length + number2.Length) * 2)
                    {
                        string last = result[result.Length - 1].ToString();
                        string one_before_last = result[result.Length - 2].ToString();
                        if (!IsItNegative(Subtract(last, "5")))
                        {
                            one_before_last = Add(one_before_last, "1");
                        }
                        result = RemoveZerosFromTheFront(RemoveZerosFromTheBack(result.Substring(0, x) + "," + result.Substring(x, result.Length - x - 2) + one_before_last));
                        result = Multiply(result, mozezera);
                        return result;
                    }
                    divident = remainder + "0";
                }
                else
                {
                    divident = Subtract(divident, tmp) + number1[i];
                }

            }
        }
    }
}
