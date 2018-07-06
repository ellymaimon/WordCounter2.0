using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class ScrabbleCounter
    {
        private string _inputtedWord;
        private char[] _inputedWordLetters;
        private int _finalScore = 0;

        public void SetInputtedWord(string inputtedWord)
        {
            _inputtedWord = inputtedWord.ToLower();
        }

        public string GetInputtedWord()
        {
            return _inputtedWord;
        }

        public void SetInputtedWordLetters(char[] inputtedLetters)
        {
            _inputedWordLetters = inputtedLetters;
        }

        public char[] GetInputtedWordLetters()
        {
            return _inputedWordLetters;
        }

        public void SetFinalScore(int addToScore)
        {
            _finalScore += addToScore;
        }

        public int GetFinalScore()
        {
            return _finalScore;
        }

        private Dictionary<char, int> _letterScores = new Dictionary<char, int>()
        {
            {'a', 1},
            {'e', 1},
            {'i', 1},
            {'o', 1},
            {'u', 1},
            {'l', 1},
            {'n', 1},
            {'r', 1},
            {'s', 1},
            {'t', 1},
            {'d', 2},
            {'g', 2},
            {'b', 3},
            {'c', 3},
            {'m', 3},
            {'p', 3},
            {'f', 4},
            {'h', 4},
            {'v', 4},
            {'w', 4},
            {'y', 4},
            {'k', 5},
            {'j', 8},
            {'x', 8},
            {'q', 10},
            {'z', 10},
            {' ', 0}
        };

        public Dictionary<char,int> GetLetterScores()
        {
            return _letterScores;
        }

        public void WordIntoLetters()
        {
            SetInputtedWordLetters(GetInputtedWord().ToCharArray());
        }

        public void LettersIntoPoints()
        {
            for (int i = 0; i < GetInputtedWordLetters().Length; i++)
            {
                SetFinalScore(GetLetterScores()[GetInputtedWordLetters()[i]]);
            }
        }
    }
}
