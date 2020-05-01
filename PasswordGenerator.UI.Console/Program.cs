using PasswordGenerator.Core;
using PasswordGenerator.UI.Console.Properties;
using System;
using System.Resources;

namespace PasswordGenerator.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            if (IsValid(args))
            {
                var length = int.Parse(args[0]);
                var passwordGenerator = new KeyGenerator(length);
                passwordGenerator.Generate();
                TextCopy.Clipboard.SetText(passwordGenerator.Password);
            }
        }

        private static bool IsValid(string[] args)
        {
            bool isValid = false;
            if (args.Length <= 0)
            {
                System.Console.WriteLine(Resources.NoInput);
            }
            else
            {
                isValid = int.TryParse(args[0], out _);
                if (!isValid) System.Console.WriteLine(Resources.NaN);
            }

            return isValid;
        }
    }
}
