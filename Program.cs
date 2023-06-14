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
void CreatarrayInt(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i<array.GetLength(0);i++)
    {
        for (int j = 0; j<array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(-100,100);
            
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
void Printarray2(double[] array)
{
    
    for (int i = 0; i<array.Length;i++)
    {
        Console.Write($"{array[i]}  ");
        
    }   
    Console.WriteLine();
    
}

void Task47()
{
    int m = InText("Введите m - колличество строк массива");
    int n = InText("Введите n - колличество столбцов массива");

    double[,]  numbers= new double[m,n];
    Creatarray(numbers);
    Printarray(numbers);      
    
    

}  
void Task50()
{
    int m = new Random().Next(1,10);
    int n = new Random().Next(1,10);
    double[,]  numbers= new double[m,n];
    Creatarray(numbers);
    int a = InText("Введите индекс строки");
    int b = InText("Введите индекс столбца"); 
    Printarray(numbers);   
    if (numbers.GetLength(0)>a && numbers.GetLength(0)>b)
    {
        Console.Write($"{numbers[a,b]}  ");

    }
    else Console.Write($"Нет элемента массива с идексоми [{a},{b}] ");

} 
void Task52()
{
    int m = new Random().Next(1,10);
    int n = new Random().Next(1,10);
    int[,]  numbers= new int[m,n];
    CreatarrayInt(numbers);
    double[] middle = new double[n];
    double sum = 0;

    for (int x = 0;x<n;x++)
    {
        for (int i = 0;i<m;i++)
        {
            for (int j = 0;j<n;j++)
            {
                sum = sum + numbers[i,j];
            }
            middle[x]=Math.Round(sum/m,2);


        }

    }
    
    Console.Write("Среднее арифметическое столбов массива равно ");
    Printarray2(middle);

}

Task47();
Task50();
Task52();