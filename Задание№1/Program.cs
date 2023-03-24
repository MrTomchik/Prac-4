Spell alohomora = new Spell(60, "Замок открывается!");
Spell vingardiumLeviosa = new Spell(60, "Предмет поднимается в воздух!");
Magician garryPotter = new Magician("Гарри Поттер", 100);
garryPotter.CastSpell(alohomora);
garryPotter.CastSpell(vingardiumLeviosa);
Console.ReadKey(true);
class Spell
{
    public int Mana { get; private set; }
    private string Effect { get; set; }
    public Spell(int mana, string effect)
    {
        Mana = mana;
        Effect = effect;
    }
    public void Use() { Console.WriteLine(Effect); }
}
class Magician
{
    public string Name { get; private set; }
    public int Mana { get; private set; }
    public Magician(string name, int mana)
    {
        Name = name;
        Mana = mana;
    }
    public void CastSpell(Spell spell)
    {
        if (Mana >= spell.Mana)
        {
            Console.WriteLine(Name + " шаманит!");
            spell.Use(); Mana -= spell.Mana;
        }
        else
        {
            Console.WriteLine("Для испольования " + spell + " не хватает " + (Math.Abs(spell.Mana - Mana)) + " единиц маны." +//названия заклинаний никак не отображаются
            " Хлебните зелья!");
        }
    }
}

