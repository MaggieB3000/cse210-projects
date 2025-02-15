using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _scriptureText;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _scriptureText = text.Split(' ').Select(word => new Word(word)).ToList();
        _random = new Random();
    }

    public void HideWords(int numberToHide)
    {
        var visibleWords = _scriptureText.Where(w => !w.IsHidden()).ToList();

        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetRenderedTextScripture()
    {
        string wordDisplay = string.Join(" ", _scriptureText.Select(w => w.GetRenderedText()));

        return $"{_reference.GetRef()} {wordDisplay}";
    }

    public bool IsCompletelyHidden()
    {
        return _scriptureText.All(w => w.IsHidden());
    }
}