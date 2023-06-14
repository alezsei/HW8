int InText(string Text)
{
    Console.WriteLine(Text);
    return Convert.ToInt32(Console.ReadLine());
}


void Creatarray(double[,] array)
{
    Random rand = new Random();
    for (int i = 0; i<array.GetLength(0);i++)
    {
        for (int j = 0; j<array.GetLength(1);j++)
        {
            array[i,j] = rand.Next(-100, 100) + rand.NextDouble();
            array[i,j] = Math.Round(array[i,j],1);
        }
        
    }
}

void Printarray(double[,] array)
{
    
    for (int i = 0; i<array.GetLength(0);i++)
    {
        
        for (int j = 0; j<array.GetLength(1);j++)
        {
           Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}


void Task47()
{
    int m = InText("Введите m - колличество строк массива");
    int n = InText("Введите n - колличество столбцов массива");

    double[,]  numbers= new double[m,n];
    Creatarray(numbers);
    Printarray(numbers);      
    
    

}   
Task47();