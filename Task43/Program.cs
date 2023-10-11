// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int coefficient = 0;
const int constant = 1;
const int x_coord = 0;
const int y_coord = 1;
const int line1 = 0;
const int line2 = 1;

double[] lineData1 = InputLine(line1);
double[] lineData2 = InputLine(line2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений y={lineData1[coefficient]}*x+{lineData1[constant]} и y={lineData2[coefficient]}*x+{lineData2[constant]}");
    Console.WriteLine($" имеет координаты ({coord[x_coord]}, {coord[y_coord]})");
}

double[] InputLine(int numberLine)
{
    double[] lineData = new double[2];
    Console.WriteLine($"Введите коэффициент для {numberLine} прямой:");
    lineData[coefficient] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите константу для {numberLine} прямой:");
    lineData[constant] = Convert.ToInt32(Console.ReadLine());
    return lineData;
}

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[x_coord] = (lineData1[constant] - lineData2[constant]) / (lineData2[coefficient] - lineData1[coefficient]);
    coord[y_coord] = lineData1[constant] * coord[x_coord] + lineData1[constant];
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[coefficient] == lineData2[coefficient])
    {
        if (lineData1[constant] == lineData2[constant])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}