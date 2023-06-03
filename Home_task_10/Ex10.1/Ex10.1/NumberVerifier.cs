using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10._1
{
    internal class NumberVerifier
    {
        public bool VerifyNumber(string distributor, string number)
        {
            if(VerifyLength(distributor, number))
            {
                StringBuilder checkSum = new StringBuilder();
                for(int i = number.Length - 2; i >= 0; i -= 2)
                {
                    checkSum.Append(number[i]);
                }
                for(int i = 0; i < checkSum.Length; i++)
                {
                    string doubled = (int.Parse(checkSum[i].ToString()) * 2).ToString();
                    int localTemp = doubled.Length == 1 ? int.Parse(doubled) : int.Parse(doubled[0].ToString()) + int.Parse(doubled[1].ToString());
                    checkSum[i] = char.Parse(localTemp.ToString());
                }
                List<char> temp = checkSum.ToString().ToList();

                int iterator = 0;
                List<char> listNumber = number.ToList();
                for(int i = listNumber.Count - 2; i >= 0; i -= 2, iterator++)
                {
                    listNumber.RemoveAt(i);
                    listNumber.Insert(i, temp[iterator]);
                }
                int sum = 0;
                foreach(char c in listNumber)
                {
                    sum += int.Parse(c.ToString());
                }
                return sum % 10 == 0;
            }
            return false;
        }

        private bool VerifyLength(string distributor, string number)
        {
            switch(distributor)
            {
                case "American Express":
                    return number.Length == 15 && (number.StartsWith("34") || number.StartsWith("37"));
                case "Visa":
                    return (number.Length == 13 || number.Length == 16) && number.StartsWith("4");
                case "MasterCard":
                    return number.Length == 16 && (number.StartsWith("51") || number.StartsWith("52") 
                        || number.StartsWith("53") || number.StartsWith("54") || number.StartsWith("55"));
                default:
                    throw new ArgumentException("Wrong distributor");
            }
        }
    }
}
