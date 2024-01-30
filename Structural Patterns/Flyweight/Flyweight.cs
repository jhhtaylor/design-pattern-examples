using System;
using System.Collections.Generic;

// Flyweight interface
public interface ICharacter
{
    void Display(int pointSize);
}

// Concrete Flyweight
public class Character : ICharacter
{
    private readonly char _symbol;
    private int _pointSize;

    public Character(char symbol)
    {
        this._symbol = symbol;
    }

    public void Display(int pointSize)
    {
        this._pointSize = pointSize;
        Console.WriteLine($"{_symbol} (pointsize {_pointSize})");
    }
}

// Flyweight Factory
public class CharacterFactory
{
    private Dictionary<char, Character> _characters = new Dictionary<char, Character>();

    public Character GetCharacter(char key)
    {
        // Uses "lazy initialization"
        Character character = null;
        if (_characters.ContainsKey(key))
        {
            character = _characters[key];
        }
        else
        {
            character = new Character(key);
            _characters.Add(key, character);
        }
        return character;
    }
}