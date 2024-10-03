Futbolcu futbolcu = new Futbolcu()
{
	Age = 23,
	Name = "Burak",
	Pace = 84,
	physical = 77
};

Futbolcu futbolcu3 = new Futbolcu()
{
    Age = 23,
    Name = "Burak",
    Pace = 84,
    physical = 77
};

Futbolcu futbolcu2 = futbolcu;
Futbolcu futbolcu4 = futbolcu.Clone();

Console.WriteLine(futbolcu.Equals(futbolcu2));
Console.WriteLine(futbolcu.Equals(futbolcu3));
Console.WriteLine(futbolcu.Equals(futbolcu4));






class Futbolcu
{
	public string Name { get; set; }
	public int Age { get; set; }

	private int pace;
	public int Pace
	{
		get { return pace; }
		set { pace = value; }
	}

    public int physical { get; set; }

	public Futbolcu Clone()
	{
		return (Futbolcu)this.MemberwiseClone();
	}

}




