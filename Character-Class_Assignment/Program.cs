// Character Class Assignment
#nullable disable
Console.Clear();


// Task 2
Character char1 = new Character("Kung Fu Panda", "Skadoosh", "You have been blinded by pure awesomeness!"); ;
Character char2 = new Character("Spiderman", "My Spider-Sense is tingling!", "Your friendly neighbourhood spiderman.");

//3
char1.Speak(1);
char2.setLevel(2);
char2.Speak(2);

class Character
{
    public string Name { get; set; }
    public string Phrase1 { get; set; }
    public string Phrase2 { get; set; }
    public int Level { get; set; }

    public Character(string name, string phrase1, string phrase2)
    {
        this.Name = name;
        this.Phrase1 = phrase1;
        this.Phrase2 = phrase2;
        Level = 0;
    }
    public string Speak(int phraseNum)
    {
        if (phraseNum == 1)
        {
            Console.WriteLine(Phrase1);
        }
        else if (phraseNum == 2)
        {
            Console.WriteLine(Phrase2);
        }
        else
        {
            Console.WriteLine("Phrase # not found.");
        }
        return null;
    }

    public int setLevel(int newLevel)
    {
        Console.WriteLine($"New level of {Name} is {newLevel}.");
        return this.Level = newLevel;
    }
}
