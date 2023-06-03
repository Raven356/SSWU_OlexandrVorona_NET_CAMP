using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10._1
{
    internal static class Controller
    {
        private static List<CreditCard> _creditCards = new List<CreditCard>();
        private static List<string> results = new List<string>();
        static Controller() { }

        public static List<string> Results { get => new List<string>(results);}

        public static void AddCard(string text)
        {
            string[] separator = new string[] { " # ", "# ", " = ", "\"" };
            string[] splited = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            _creditCards.Add(new CreditCard(splited[0], splited[2]));
        }

        public static void CheckCardsNumbers()
        {
            NumberVerifier numberVerifier = new NumberVerifier();
            results.Clear();
            foreach (CreditCard card in _creditCards)
            {
                string temp = numberVerifier.VerifyNumber(card.Distributor, card.Number)? "Valid" : "Invalid";
                results.Add($"# {card.Distributor} # card_number = {card.Number} # is_number_valid: {temp}");
            }
        }
    }
}
