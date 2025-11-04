using System;

class Program
{
    static string tochka(double x, double y)
    {
        double r2 = x * x + y * y; //квадрат расстояния до начала координат

        if (Math.Abs(r2 - 1) < 1e-9) //точка на окружности
        {
            if (x >= 0 || y >= 0) return "На границе"; //в первой или второй четверти
            else return "Нет"; //в третьей четверти
        }
        else if (r2 < 1) //точка внутри круга
        {
            if (x > 0 || y > 0) return "Да";
            else if (Math.Abs(x) < 1e-9 || Math.Abs(y) < 1e-9) return "На границе";
            else return "Нет";
        }
        else return "Нет"; //точка вне круга
    }

    static void Main()
    {
        Console.Write("Введите x: "); //ввод x
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите y: "); //ввод y
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(tochka(x, y)); //вывод результата
    }
}
