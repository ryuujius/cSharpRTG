FutbolcuRecord futbolcuRecord = new FutbolcuRecord()
{
    Age = 22,
    Name = "Burak"
};

FutbolcuRecord futbolcuRecord2 = new FutbolcuRecord()
{
    Age = 22,
    Name = "Burak"
};

FutbolcuRecord futbolcuRecord3 = futbolcuRecord with { Age = 21, Name = "İsmail" };
FutbolcuRecord futbolcuRecord4 = futbolcuRecord with { Age = 21, Name = "İsmail" };

FutbolcuRecord futbolcuRecord5 = futbolcuRecord2.With(25);

Console.WriteLine(futbolcuRecord.Equals(futbolcuRecord2));//true
Console.WriteLine(futbolcuRecord3.Equals(futbolcuRecord4));//true
Console.WriteLine(futbolcuRecord2.Equals(futbolcuRecord5));//false

record FutbolcuRecord
{
    public int Age { get; init; }
    private string name;

    public string Name
    {
        get { return name; }
        init { name = value; }
    }

    public FutbolcuRecord()
    {

    }

    //old version of with expression
    public FutbolcuRecord With(int age)
    {
        return new FutbolcuRecord { Age = age , Name = this.Name};
    }
}

class FutbolcuClass
{
    public int Age { get; set; }
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public FutbolcuClass()
    {

    }
}