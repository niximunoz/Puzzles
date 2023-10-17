//Matriz Aleatoria
static void RandomArray(int[] numbers)
{
    Random rand = new Random();
    numbers[0] = rand.Next(5, 26);
    int sum = numbers[0];
    int minValue = numbers[0];
    int maxValue = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        numbers[i] = rand.Next(5, 26);
        sum += numbers[i];
        if (numbers[i] > maxValue)
        {
            maxValue = numbers[i];
        }
        if (numbers[i] < minValue)
        {
            minValue = numbers[i];
        }
    }
    Console.WriteLine($"Suma de todos los valores : {sum}");
    Console.WriteLine($"Valor Mínimo : {minValue}");
    Console.WriteLine($"Valor Máximo : {maxValue}");
}
int[] numArray = new int[10];
RandomArray(numArray);

//Lanzamiento de Moneda

static string TossCoin()
{
    Console.WriteLine("¡Tirando una moneda!");
    Random rand = new Random();
    int valRandom = rand.Next(0, 2);
    // Console.WriteLine(valRandom);
    if (valRandom == 0)
    {
        return "Cara";
    }
    else
    {
        return "Cruz";
    }
}

string result = TossCoin();
Console.WriteLine(result);

//Opcional
static double TossMultipleCoins(int num)
{
    int cara = 0;

    for (int i = 0; i < num; i++)
    {
        string result = TossCoin();
        Console.WriteLine(result);
        if (result == "Cara")
        {
            cara++;
        }
    }

    // relación entre caras y el total de lanzamientos
    double relacion = (double)cara / num;
    return relacion;
}

double result2 = TossMultipleCoins(10);
Console.WriteLine($"relación entre caras y el total de lanzamientos: {result2}");

//Nombres

static List<string> nombresList(List<string> nombres)
{
    List<string> nombres2 = new List<string>();
    for (int i = 0; i < nombres.Count; i++)
    {
        if (nombres[i].Length > 5)
        {
            nombres2.Add(nombres[i]);
        }
    }
    return nombres2;

}

List<string> nombres = new List<string>();
nombres.Add("Todd");
nombres.Add("Tiffany");
nombres.Add("Charlie");
nombres.Add("Ginebra");
nombres.Add("Sydney");

List<string> resultsName = nombresList(nombres);
Console.WriteLine("Lista que solo incluya nombres de más de 5 caracteres​:");
foreach (string name in resultsName)
{
    Console.WriteLine(name);
}

Random random = new Random();
resultsName.Sort((x, y) => random.Next(-1, 2));

Console.WriteLine("Lista barajada:");
foreach (string name in resultsName)
{
    Console.WriteLine(name);
}