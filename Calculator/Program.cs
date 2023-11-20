using System;
using System.Data;

class Program
{
    static void Main()
    {
        Console.Write("Введите выражение: ");
        string expression = Console.ReadLine();

        try
        {
            DataTable table = new DataTable();
            table.Columns.Add("", typeof(double), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);

            double result = (double)row[0];

            Console.WriteLine("Результат: " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}