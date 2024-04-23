namespace Delegate__Action__Function__Predicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person{Name ="Mahir",Surname ="Musayev",Age=20},
                new Person{Name ="Inara",Surname ="Akhmedova",Age=20},
                new Person{Name ="Fuat",Surname ="Memmedov",Age=25},             
                new Person{Name ="Mahir",Surname ="Msyv",Age=23},
                new Person{Name ="Samir",Surname ="Kerimov",Age=20},
                new Person{Name ="Mahir",Surname ="ov",Age=22},
                new Person{Name ="Kenan",Surname ="Pasayev",Age=20}
            };
            var MahirPeople = people.FindAll(p => p.Name == "Mahir");
            Console.WriteLine("adi mahir olan sexsler");
            foreach (var item in MahirPeople)
            {
                Console.WriteLine($"{item.Name} {item.Surname} Yas :{item.Age}");
            }

            Console.WriteLine(" ");
            var SurnamePeople = people.FindAll(p => p.Surname.EndsWith("ov", StringComparison.OrdinalIgnoreCase) || p.Surname.EndsWith("ova", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Soyadı ov və ova ile biten telebeler:");
            foreach (var person in SurnamePeople)
            {
                Console.WriteLine($"{person.Name} {person.Surname}, Yaş: {person.Age}");
            }

            Console.WriteLine(" ");

            var twentyPlusPeople = people.FindAll(p => p.Age > 20);
            Console.WriteLine("Yaşı 20+ olanlar:");
            foreach (var person in twentyPlusPeople)
            {
                Console.WriteLine($"{person.Name} {person.Surname}, Yaş: {person.Age}");
            }
        }

    }
}
