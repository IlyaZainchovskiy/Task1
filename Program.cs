using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть ім'я: ");
            string name = Console.ReadLine();

            Console.Write("Введіть вік: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введіть курс: ");
            int course = int.Parse(Console.ReadLine());

            Console.Write("Введіть рейтинг: ");
            double rating = double.Parse(Console.ReadLine());

            Student student = new Student(name, age, course, rating);

            Console.WriteLine("\nІнформація про студента");
            Console.WriteLine($"Ім'я: {student.Name}");
            Console.WriteLine($"Вік: {student.Age}");
            Console.WriteLine($"Курс: {student.Course}");
            Console.WriteLine($"Рейтинг: {student.Rating}");

            Console.Write("Статус: ");
            student.StudentRating();

            Console.WriteLine($"Роль: {student.GetRole(student.Course)}");
            Console.WriteLine("\nХочете відредагувати дані студента? (Y/N)");
            string ans = Console.ReadLine();
            if (ans == "Y")
            {
                Console.Write("Нове ім'я: ");
                string newName = Console.ReadLine();

                Console.Write("Новий вік: ");
                int newAge = int.Parse(Console.ReadLine());

                Console.Write("Новий рейтинг: ");
                double newRating = double.Parse(Console.ReadLine());

                student.EditStudent(newName, newAge, newRating);

                Console.WriteLine("\n=== Оновлена інформація ===");
                Console.WriteLine($"Ім'я: {student.Name}");
                Console.WriteLine($"Вік: {student.Age}");
                Console.WriteLine($"Курс: {student.Course}");
                Console.WriteLine($"Рейтинг: {student.Rating}");

                Console.Write("Статус: ");
                student.StudentRating();

                Console.WriteLine($"Роль: {student.GetRole(student.Course)}");
            }
        }
     }
}
    class Student
    {
        private string name;
        private int age;
        private int course;
        private double rating;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Course { get => course; set => course = value; }
        public double Rating { get => rating; set => rating = value; }
        
        
        public Student(string name, int age, int course, double rating)
        {
            this.name = name;
            this.age = age;
            this.course = course;
            this.rating = rating;
        }
        public void EditStudent(string name, int age, double rating)
        {
            this.name = name;
            this.age = age;
            this.rating = rating;
        }
        public void StudentRating()
        {
            if (rating >= 82)
                Console.WriteLine("Відмінник");
            else if (rating >= 60)
                Console.WriteLine("Перездача");
            else
                Console.WriteLine("Погано");
        }
        public string GetRole(int course)
        {
            if (course <= 4)
                return "Бакалавр";
            else
                return "Магістр";
        }
    }

