internal class Program
{
    private static void Main(string[] args)
    {

        #region Nesne Kopyalama
        ////referans turlu değiskenlerde shallow copy default davranıştır
        //MyClass m1 = new MyClass();
        //MyClass m2 = m1;
        //MyClass m3 = m2;
        //Console.WriteLine(Equals(m3,m2));//true
        //MyClass m4 = new MyClass();
        //Console.WriteLine(Equals(m2,m4));
        //MyClass m5 = m1.Clone();//deep copy
        ////değer türlü değişkenlerde deep copy default davranıştır
        //int sayi1 = 5;
        //int sayi2 = sayi1;
        //int sayi3 = sayi2;
        //sayi2 += 5;
        //sayi3 += 6;
        //Console.WriteLine(sayi1.ToString() + ' ' + sayi2.ToString() + ' ' + sayi3.ToString());
        #endregion

        #region Record vs Class
        //MyClass m1 = new MyClass
        //{
        //    //2. prop readonly -- 3. de read only ancak init only prop olduğundan object initializerda setlemeye tek seferlik izin verir
        //    MyClassProperty1 = 1,
        //    MyClassProperty2 = 2,
        //    MyClassProperty3 = 2

        //};
        //MyClass m2 = m1.With(2);
        //Console.WriteLine(Equals(m1, m2));

        //MyRecord myRecord1 = new MyRecord
        //{
        //    MyRecordProperty1 = 1,
        //    MyRecordProperty2 = 2,
        //};
        //MyRecord myRecord2 = myRecord1 with { MyRecordProperty1 = 1, MyRecordProperty2 = 2 };
        //Console.WriteLine(Equals(myRecord1, myRecord2));

        #endregion




    }

    class MyClass
    {
        //encapsulation with full prop
        private String ad;

        public String Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        //encapsulation with method
        int yas;

        public int YasGet()
        {
            return this.yas;
        }
        public void YasSet(int value)
        {
            yas = value;
        }

        public int MyClassProperty1 { get; init; }
        public int MyClassProperty2 { get; init; }
        public int MyClassProperty3 { get; init; }

        public MyClass Clone()
        {
            return (MyClass)this.MemberwiseClone();
        }

        public MyClass With(int m1)
        {
            return new MyClass
            {
                MyClassProperty1 = this.MyClassProperty1,
                MyClassProperty2 = this.MyClassProperty2,
                MyClassProperty3 = m1
            };
        }

    }

    record MyRecord
    {
        public int MyRecordProperty1 { get; init; }
        public int MyRecordProperty2 { get; init; }
    }

}

