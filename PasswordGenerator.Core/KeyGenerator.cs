using PasswordGenerator.Core.Properties;
using PasswordGenerator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Core
{
    public class KeyGenerator : IKeyGenerator
    {
        public int Length { get; set; }
        public string Password { get; set; }

        public KeyGenerator(int length)
        {
            Length = length;
        }

        public void Generate()
        {
            if (Length <= 0) throw new ApplicationException(Resources.InvalidLength);
            CharacterFactory characterFactory = new CharacterFactory();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < Length; i++)
            {
                stringBuilder.Append(characterFactory.GetCharacter());
            }
            Password = stringBuilder.ToString();
        }
    }
}
