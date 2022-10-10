    class Program
    { 

    static void Main(string[] args)
        {



        Console.WriteLine("Enter 1st input");
        int s1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 2nd input");
        int s2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter operator");
        string action = Console.ReadLine();

        int result = 0;


        switch (action)
        {
            case "+":
            Console.WriteLine(Add(s1, s2));
                break;


            case "-":
                Console.WriteLine(Minus(s1, s2));
                break;


            case "*":
                Console.WriteLine(Kopaytirish(s1, s2));
                break;


            case "/":
                Console.WriteLine(Bolish(s1, s2));
                break;
        }


        }
    public static int Add(int num1, int num2)
        {
        return num1 + num2;
        }
    public static int Minus(int num1, int num2)
    {
        return num1 - num2;
    }
    public static int Kopaytirish(int num1, int num2)
    {
        return num1 * num2;
    }
    public static int Bolish(int num1, int num2)
    {
        return num1 / num2;
    }

}
