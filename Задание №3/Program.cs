Orc army = new Orc(0, 1);
for (int i = 1; i < 20; i++)
{
    army.inc();
}
Console.ReadKey(true);

class Orc
{
    public int Gold { get; set; }
    public int Quantity { get; set; }
    public Orc(int gold, int quantity)
    {
        Gold = gold;
        Quantity = quantity;
    }
    public void inc()
    {
        Quantity++;
        Gold += 2;
        if (Quantity > 5)
        {
            Gold += 2 * (Quantity - 5);

        }
        Console.WriteLine("Получено " + Gold + " единиц золота");
    }

}
