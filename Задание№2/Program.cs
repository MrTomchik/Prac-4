Mailing Jabroni_stuff = new Mailing("Одежда для новичков", 25);
Mailing BattleCompMod2 = new Mailing("Одежда для новисков", 80);
MailService Novarro = new MailService("Новарро", 30);
Novarro.Send_Mailing(Jabroni_stuff);
Novarro.Send_Mailing(BattleCompMod2);


Console.ReadKey(true);

class Mailing
{
    public string Desc { get; private set; }
    public int Weight { get; set; }
    public Mailing(string desc, int weight)
    {
        Desc = desc;
        Weight = weight;
    }
    public void Use() { Console.WriteLine(Weight); }
}
class MailService
{
    public string Name { get; private set; }
    private int WLimit { get; set; }
    public MailService(string name, int wlimit)
    {
        Name = name;
        WLimit = wlimit;
    }
    public void Send_Mailing(Mailing mailing)
    {
        if ((WLimit + mailing.Weight) <= 100)
        {
            Console.WriteLine("Отправлена посылка " + mailing);
            WLimit += mailing.Weight;
        }
        else { Console.WriteLine("Вес отправленных посылок превысил лимит"); }
    }
}
