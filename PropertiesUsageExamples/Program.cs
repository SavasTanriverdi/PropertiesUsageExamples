using System;

namespace PropertiesUsageExamples
{
    public class Person
    {
        private int age;
        private string name;

        // Name özelliği - otomatik özellik kullanımı
        public string Name
        {
            get => name;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty.");
                }
            }
        }

        // Age özelliği - doğrulama ile özel get ve set tanımlama
        public int Age
        {
            get => age;
            set
            {
                if (value >= 0 && value <= 120)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age must be between 0 and 120.");
                }
            }
        }

        // Only get özelliği - hesaplanan özellik
        public bool IsAdult => age >= 18;

        // Read-only bir özellik
        public string Country { get; } = "Unknown";

        // Constructor ile özelliklerin atanması
        public Person(string name, int age, string country)
        {
            Name = name;
            Age = age;
            Country = country;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Person nesnesi oluşturma ve özellikleri ayarlama
            Person person1 = new Person("Alice", 25, "USA");
            Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}, Country: {person1.Country}, IsAdult: {person1.IsAdult}");

            // Hatalı veri atamayı deneme
            person1.Name = ""; // Hatalı giriş, uyarı mesajı verir
            person1.Age = 150; // Hatalı yaş, uyarı mesajı verir

            // Doğru veri ile güncelleme
            person1.Name = "Bob";
            person1.Age = 30;
            Console.WriteLine($"Updated Name: {person1.Name}, Updated Age: {person1.Age}");
        }
    }
}
