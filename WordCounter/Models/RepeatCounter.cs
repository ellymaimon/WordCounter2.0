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
        private static List<string> _allWords = new List<string>();
        private static List<string> _allPhrases = new List<string>();

        public void SetUserWord(string word)
        {
            _userWord = word.ToLower();
            _allWords.Add(_userWord);
        }

        public string GetUserWord()
        {
            return _userWord;
        }

        public void SetUserPhrase(string word)
        {
            _userPhrase = word.ToLower();
            _allPhrases.Add(_userPhrase);
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

        public static List<string> GetAllWords()
        {
            return _allWords;
        }

        public static List<string> GetAllPhrases()
        {
            return _allPhrases;
        }
        public static void ClearAll()
        {
            _allWords.Clear();
            _allPhrases.Clear();
        }
    }
}
