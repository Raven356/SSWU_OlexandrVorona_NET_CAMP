using System;

namespace EX4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextSpliter textSpliter = new TextSpliter();
            EmailVerifier emailVerifier = new EmailVerifier();
            List<string> emails = textSpliter.SplitText("\"\"\"sasad@gmail.com, masmads@, (ASAASAD)A@gmail.com, \"asd@laksd@\"@as@da.com, simple@example.com, very.common@example.com, " +
            "disposable.style.email.with+symbol@example.com, Abc.example.com, A@b@c@example.com, just\"not\"right@example.com, " +
            "\"john..doe\"@example.org, john..doe@example.org, a\"b(c)d,e:f;g<h>i[j\\k]l@example.com, a\"b(c)d,e:f;g<h>i[j\\k]l$example.com, " +
            "this\\ still\\\"not\\\\allowed@example.com, 1234567890123456789012345678901234567890123456789012345678901234+x@example.com, " +
            "i_like_underscore@but_its_not_allow_in _this_part.example.com, user%example.com@example.org, mailhost!username@example.org, " +
            "\" \"@example.org, other.email-with-hyphen@example.com, fully-qualified-domain@example.com, user.name+tag+sorting@example.com, " +
            "example-indeed@strange-example.com, admin@mailserver1, x@example.com");

            var result = emailVerifier.FindEmailsAndLexems(emails);

            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}