Random dice = new Random();

//Declarando variables
int numTareas = 5;
float sumPuntosSophia = 0f;
float sumPuntosAndrew = 0f;
float sumPuntosEmma = 0f;
float sumPuntosLogan = 0f;
float promedioSophia = 0f;
float promedioAndrew = 0f;
float promedioEmma = 0f;
float promedioLogan = 0f;

//Declarando las puntuaciones de los alumnos
int[] sophiaPuntos = {dice.Next(dice.Next(0, 101), 101), dice.Next(dice.Next(0, 101), 101), dice.Next(dice.Next(0, 101), 101), dice.Next(dice.Next(0, 101), 101), dice.Next(dice.Next(0, 101), 101)};
int[] andrewPuntos = {dice.Next(dice.Next(0, 101), 101), dice.Next(dice.Next(0, 101), 101), dice.Next(dice.Next(0, 101), 101), dice.Next(dice.Next(0, 101), 101), dice.Next(dice.Next(0, 101), 101)};
int[] emmaPuntos = {dice.Next(dice.Next(0, 101), 101), dice.Next(dice.Next(0, 101), 101), dice.Next(dice.Next(0, 101), 101), dice.Next(dice.Next(0, 101), 101), dice.Next(dice.Next(0, 101), 101)};
int[] loganPuntos = {dice.Next(dice.Next(0, 101), 101), dice.Next(dice.Next(0, 101), 101), dice.Next(dice.Next(0, 101), 101), dice.Next(dice.Next(0, 101), 101), dice.Next(dice.Next(0, 101), 101)};

//Sumando las calificaciones totales de los alumnos y mostrando el promedio y la calificacion en letras

// ------------------------------------ Sophia -------------------------------------//
foreach (float punto in sophiaPuntos)
{
    sumPuntosSophia += punto;
}

promedioSophia = sumPuntosSophia / numTareas;
Console.WriteLine("Estudiante\tPuntuación");
switch (promedioSophia)
{
    case float num when num <= 59f:
        Console.WriteLine($"Sophia\t\t{promedioSophia}\t\tF");
        break;
    case float num when num <= 62f:
        Console.WriteLine($"Sophia\t\t{promedioSophia}\t\tD-");
        break;
    case float num when num <= 66f:
        Console.WriteLine($"Sophia\t\t{promedioSophia}\t\tD");
        break;
    case float num when num <= 69f:
        Console.WriteLine($"Sophia\t\t{promedioSophia}\t\tD+");
        break;
    case float num when num <= 72f:
        Console.WriteLine($"Sophia\t\t{promedioSophia}\t\tC-");
        break;
    case float num when num <= 76f:
        Console.WriteLine($"Sophia\t\t{promedioSophia}\t\tC");
        break;
    case float num when num <= 79f:
        Console.WriteLine($"Sophia\t\t{promedioSophia}\t\tC+");
        break;
    case float num when num <= 82f:
        Console.WriteLine($"Sophia\t\t{promedioSophia}\t\tB-");
        break;
    case float num when num <= 86f:
        Console.WriteLine($"Sophia\t\t{promedioSophia}\t\tB");
        break;
    case float num when num <= 89f:
        Console.WriteLine($"Sophia\t\t{promedioSophia}\t\tB+");
        break;
    case float num when num <= 92f:
        Console.WriteLine($"Sophia\t\t{promedioSophia}\t\tA-");
        break;
    case float num when num <= 96f:
        Console.WriteLine($"Sophia\t\t{promedioSophia}\t\tA");
        break;
    case float num when num <= 100f:
        Console.WriteLine($"Sophia\t\t{promedioSophia}\t\tA+");
        break;
}

// ------------------------------------ Andrew -------------------------------------//
foreach (float punto in andrewPuntos)
{
    sumPuntosAndrew += punto;
}

promedioAndrew = sumPuntosAndrew / numTareas;
Console.WriteLine("Estudiante\tPuntuación");
switch (promedioAndrew)
{
    case float num when num <= 59f:
        Console.WriteLine($"Andrew\t\t{promedioAndrew}\t\tF");
        break;
    case float num when num <= 62f:
        Console.WriteLine($"Andrew\t\t{promedioAndrew}\t\tD-");
        break;
    case float num when num <= 66f:
        Console.WriteLine($"Andrew\t\t{promedioAndrew}\t\tD");
        break;
    case float num when num <= 69f:
        Console.WriteLine($"Andrew\t\t{promedioAndrew}\t\tD+");
        break;
    case float num when num <= 72f:
        Console.WriteLine($"Andrew\t\t{promedioAndrew}\t\tC-");
        break;
    case float num when num <= 76f:
        Console.WriteLine($"Andrew\t\t{promedioAndrew}\t\tC");
        break;
    case float num when num <= 79f:
        Console.WriteLine($"Andrew\t\t{promedioAndrew}\t\tC+");
        break;
    case float num when num <= 82f:
        Console.WriteLine($"Andrew\t\t{promedioAndrew}\t\tB-");
        break;
    case float num when num <= 86f:
        Console.WriteLine($"Andrew\t\t{promedioAndrew}\t\tB");
        break;
    case float num when num <= 89f:
        Console.WriteLine($"Andrew\t\t{promedioAndrew}\t\tB+");
        break;
    case float num when num <= 92f:
        Console.WriteLine($"Andrew\t\t{promedioAndrew}\t\tA-");
        break;
    case float num when num <= 96f:
        Console.WriteLine($"Andrew\t\t{promedioAndrew}\t\tA");
        break;
    case float num when num <= 100f:
        Console.WriteLine($"Andrew\t\t{promedioAndrew}\t\tA+");
        break;
}

// ------------------------------------ Emma -------------------------------------//
foreach (float punto in emmaPuntos)
{
    sumPuntosEmma += punto;
}

promedioEmma = sumPuntosEmma / numTareas;
Console.WriteLine("Estudiante\tPuntuación");
switch (promedioEmma)
{
    case float num when num <= 59f:
        Console.WriteLine($"Emma\t\t{promedioEmma}\t\tF");
        break;
    case float num when num <= 62f:
        Console.WriteLine($"Emma\t\t{promedioEmma}\t\tD-");
        break;
    case float num when num <= 66f:
        Console.WriteLine($"Emma\t\t{promedioEmma}\t\tD");
        break;
    case float num when num <= 69f:
        Console.WriteLine($"Emma\t\t{promedioEmma}\t\tD+");
        break;
    case float num when num <= 72f:
        Console.WriteLine($"Emma\t\t{promedioEmma}\t\tC-");
        break;
    case float num when num <= 76f:
        Console.WriteLine($"Emma\t\t{promedioEmma}\t\tC");
        break;
    case float num when num <= 79f:
        Console.WriteLine($"Emma\t\t{promedioEmma}\t\tC+");
        break;
    case float num when num <= 82f:
        Console.WriteLine($"Emma\t\t{promedioEmma}\t\tB-");
        break;
    case float num when num <= 86f:
        Console.WriteLine($"Emma\t\t{promedioEmma}\t\tB");
        break;
    case float num when num <= 89f:
        Console.WriteLine($"Emma\t\t{promedioEmma}\t\tB+");
        break;
    case float num when num <= 92f:
        Console.WriteLine($"Emma\t\t{promedioEmma}\t\tA-");
        break;
    case float num when num <= 96f:
        Console.WriteLine($"Emma\t\t{promedioEmma}\t\tA");
        break;
    case float num when num <= 100f:
        Console.WriteLine($"Emma\t\t{promedioEmma}\t\tA+");
        break;
}

// ------------------------------------ Logan -------------------------------------//
foreach (float punto in loganPuntos)
{
    sumPuntosLogan += punto;
}

promedioLogan = sumPuntosLogan / numTareas;
Console.WriteLine("Estudiante\tPuntuación");
switch (promedioLogan)
{
    case float num when num <= 59f:
        Console.WriteLine($"Logan\t\t{promedioLogan}\t\tF");
        break;
    case float num when num <= 62f:
        Console.WriteLine($"Logan\t\t{promedioLogan}\t\tD-");
        break;
    case float num when num <= 66f:
        Console.WriteLine($"Logan\t\t{promedioLogan}\t\tD");
        break;
    case float num when num <= 69f:
        Console.WriteLine($"Logan\t\t{promedioLogan}\t\tD+");
        break;
    case float num when num <= 72f:
        Console.WriteLine($"Logan\t\t{promedioLogan}\t\tC-");
        break;
    case float num when num <= 76f:
        Console.WriteLine($"Logan\t\t{promedioLogan}\t\tC");
        break;
    case float num when num <= 79f:
        Console.WriteLine($"Logan\t\t{promedioLogan}\t\tC+");
        break;
    case float num when num <= 82f:
        Console.WriteLine($"Logan\t\t{promedioLogan}\t\tB-");
        break;
    case float num when num <= 86f:
        Console.WriteLine($"Logan\t\t{promedioLogan}\t\tB");
        break;
    case float num when num <= 89f:
        Console.WriteLine($"Logan\t\t{promedioLogan}\t\tB+");
        break;
    case float num when num <= 92f:
        Console.WriteLine($"Logan\t\t{promedioLogan}\t\tA-");
        break;
    case float num when num <= 96f:
        Console.WriteLine($"Logan\t\t{promedioLogan}\t\tA");
        break;
    case float num when num <= 100f:
        Console.WriteLine($"Logan\t\t{promedioLogan}\t\tA+");
        break;
}

Console.ReadKey();