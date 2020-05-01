using PasswordGenerator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PasswordGenerator.Core
{
    public class CharacterFactory : ICharacterFactory
    {
        public static readonly IEnumerable<char> asciiIdentifiers = GetAsciiCharacters();
        public char GetCharacter()
        {
            Random random = new Random();
            var itemIndex = random.Next(asciiIdentifiers.Count());
            return asciiIdentifiers.ElementAt(itemIndex);
        }

        public static IEnumerable<char> GetAsciiCharacters()
        {
            IEnumerable<int> rawCharsRange = Enumerable.Range(48, 75);
            var punctuationCharsRange = Enumerable.Range(58, 7).Concat(Enumerable.Range(91, 6));
            var asciiIds = rawCharsRange.Except(punctuationCharsRange);
            return asciiIds.Select(asciiId => (char)asciiId);
        }
    }
}
