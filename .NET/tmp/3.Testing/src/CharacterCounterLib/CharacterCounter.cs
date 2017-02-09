using System;
using System.Collections.Generic;

namespace Library
{    
    public class CharacterCounter
    {
        readonly Dictionary<char, int> _counts = new Dictionary<char, int>();

        readonly char[] _alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        public CharacterCounter()
        {
            foreach (var letter in _alphabet)
            {
                _counts.Add(letter, 0);
            }
        }

        public void ParseString(string phrase)
        {
            char[] charactersInPhrase = phrase.ToLower().ToCharArray();

            foreach (var letter in charactersInPhrase)
            {
                if(Char.IsLetter(letter))
                    _counts[letter] = _counts[letter] + 1;
            }
        }

        public int GetCountForLetter(char letter)
        {
            return _counts[letter];
        }
    }
}