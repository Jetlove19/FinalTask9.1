using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask9._1
{
    [Serializable]
    public class StudentNotFoundException : Exception
    {
        public StudentNotFoundException()
        {

        }
        public StudentNotFoundException(string message) : base(message)
        {

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = { new ArgumentOutOfRangeException("Значение аргумента за пределами диапозона"), new FileLoadException("Ошибка скачивания файла"), new FileNotFoundException("Ошибка!Файл не найден"), new DivideByZeroException("Ошибка при делении на ноль!"), new StudentNotFoundException("Студент не найден") };

            foreach (var item in exceptions)
            {
                try
                {
                    throw item;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


    }
}
