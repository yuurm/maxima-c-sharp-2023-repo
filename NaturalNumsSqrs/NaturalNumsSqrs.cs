class NaturalNumsSqrs
{
    static void Main(string[] args)    
    {  

        Console.Write("Введите предел: "); 

        int n = Convert.ToInt32(Console.ReadLine());  
        int x = 1;    

        int y = 1;

        while (y < n)  
        {  

            Console.Write($"{y} ");  
            x++;    
            y = (int)Math.Pow(x, 2);   
        }                                                               
    }                          
}                              