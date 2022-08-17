// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("\n Введите координаты двух точек в трехмерном пространстве");
int x1 = Coordinate("x1", "A");
int y1 = Coordinate("y1", "A");

int x2 = Coordinate("x2", "B");
int y2 = Coordinate("y2", "B");


int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2,
                double y1, double y2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                     Math.Pow((y2 - y1), 2));
}

double segmentLength = Math.Round(Decision(x1, x2, y1, y2), 2);

Console.WriteLine($"Расстояние между точками {segmentLength}");
