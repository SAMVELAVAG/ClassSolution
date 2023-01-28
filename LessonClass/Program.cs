// See https://aka.ms/new-console-template for more information


//BankAccount bank = new BankAccount("10012574", 115000.84, "Jack Tomas");
//bank.Deposit(5000.12);
//bank.Draw(1500);
//bank.PrintAccountInfo();


//class BankAccount
//{
//    public string AccountNumber { get; private set; }
//    public double Balance { get;private set; }
//    public string HolderName { get; private set; }

//    public BankAccount(string accountNumber, double balance, string holderName)
//    {
//        AccountNumber = accountNumber;
//        Balance = balance;
//        HolderName = holderName;
//    }

//    public void Deposit(double amount)
//    {
//        Balance += amount;
//        Console.WriteLine(Balance);
//    }
//    public void Draw(double amount)
//    {
//        Balance -= amount;
//        Console.WriteLine(Balance);
//    }
//    public void PrintAccountInfo()
//    {
//        Console.WriteLine($"HolderName: {HolderName}, AccountNumber:{AccountNumber}, Balance:{Balance}");
//    }
//}







//Rectangle rec=new Rectangle(5,20);
//rec.Area();
//rec.Perimeter();

//struct Rectangle
//{
//    public int Width { get; set; }
//    public int Height { get; set; }

//    public Rectangle(int width, int height)
//    {
//        Width = width;
//        Height = height;
//    }

//    public void Area()
//    {
//        Console.WriteLine($"Are Result: {Width} * {Height} = {Width * Height}");
//    }

//    public void Perimeter()
//    {
//        Console.WriteLine($"Perimeter Result: 2 * ({Width} + {Height}) = {2*(Width + Height)}");
//    }
//}



// static class MathHelper
//{
//    static double pi;
//	static MathHelper()
//	{
//		pi= Math.PI;
//	}

//	static void Sin(double x)
//	{
//		double angle = x * (pi / 180.0);
//		double sinangle=Math.Sin(angle);
//		Console.WriteLine(sinangle);
//	}
//	static void Cos(double x)
//	{
//        double angle = x * (pi / 180.0);
//        double cosangle = Math.Cos(angle);
//        Console.WriteLine(cosangle);
//    }
//	static void Tan(double x)
//	{
//		double angle = x * (pi / 180.0);
//        double tanangle = Math.Tan(angle);
//        Console.WriteLine(tanangle);
//    }
//}



