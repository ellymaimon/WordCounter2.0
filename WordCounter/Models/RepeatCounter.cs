using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
        private string _userWord;
        private string _userPhrase;
        private string[] _splitPhrase;
        private int _totalCount;
        private static Dictionary<string, string> _allSearched = new Dictionary<string, string>();

        public void SetUserWord(string word)
        {
            _userWord = word.ToLower();
            _allSearched.Add(_userWord, "");
        }

        public string GetUserWord()
        {
            return _userWord;
        }

        public void SetUserPhrase(string word)
        {
            _userPhrase = word.ToLower();
        }

        public string GetUserPhrase()
        {
            return _userPhrase;
        }

        public void SplitPhrase()
        {
            char[] specialCharacters = {',', '.', '!', '?', ' ', '"', '-', '(', ')'};
            _splitPhrase = GetUserPhrase().Split(specialCharacters);
        }

        public void IncrementTotalCount()
        {
            _totalCount++;
        }

        public int GetTotalCount()
        {
            return _totalCount;
        }

        public void GetOutcomeLettersInWord()
        {
            foreach (char letterInWord in GetUserWord())
            {
                foreach (char letterInPhrase in GetUserPhrase())
                {
                    if (letterInWord == letterInPhrase) IncrementTotalCount();
                }
            }
        }

        public void GetOutcomeWordsInPhrase()
        {
            SplitPhrase();
            foreach (string word in _splitPhrase)
            {
                if (GetUserWord() == word) IncrementTotalCount();
            }
        }

        public void GetOutcomePhraseInPhrase()
        {
            int i = 0;
            while ((i = GetUserPhrase().IndexOf(GetUserWord(), i)) != -1)
            {
                IncrementTotalCount();
                i++;
            }
        }

        public void GetOutcome()
        {
            if (GetUserWord().Length == 1) GetOutcomeLettersInWord();
            else if (GetUserWord().Contains(" ")) GetOutcomePhraseInPhrase();
            else GetOutcomeWordsInPhrase();
        }

        public static Dictionary<string, string> GetSearched()
        {
            return _allSearched;
        }

        public static void ClearAll()
        {
            _allSearched.Clear();
        }
    }
}
