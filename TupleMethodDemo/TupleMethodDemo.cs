class TupleMethodDemo
{

    static void Main(string[] args)
    {
        PrintStudent(("Zhorik", 52)); 
        PrintStudent(("Volodjka", 63));
        
        

        Console.WriteLine(ShowMeResult());


        var tupleResult = ShowMeResult();
        
        Console.WriteLine($"{tupleResult.Item1}, {tupleResult.Item2}");



    }


    static  void PrintStudent((string name, int age) student)
    {
        Console.WriteLine($"{student.name} - {student.age}");
    }
    
    
    static  (int, double) ShowMeResult()
    {
        var result = (314, 3.14);
        return result;
    }


}