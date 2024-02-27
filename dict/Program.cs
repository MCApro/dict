using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> avtomobillar = new Dictionary<string, int>
        {
            { "Toyota Camry", 40000 },
            { "Toyota Corolla", 30000 },
            { "Damas", 100000000 },
            { "Tiko", 100000000 },
            {"Ford Mustang", 50000 },
            {"Honda Civic", 30000},
       
            { "Audi Q5",60000},
            { "Lexus LFA", 400000},
            { "Audi A8",90000},
            { "Rolls-Royce La Rose Noire Droptail",30000000},
            { "Rolls-Royce Boat Tail",28000000},
            { "Bugatti la Voiture Noire",18100000},
            { "Pagani Zonda HP Barchetta",17900000},
            { "McLaren Elva",1700000},
            { "Czinger 21C",1700000},
            { "Ferrari Monza SP1 ",1700000},
            { "Lamborghini Urus",211321},
            { "Lamborghini Huracan Evo",264969},
            { "Model S",74990},
            { "Model X",79990},
            { "Model Y",49000},
            { "Ferrari 812 GTS",429815},
            { "Ferrari Roma",247310},
            { "Tahoe",70000},
            { "Chevrolet Camaro",40000},
            { "Chevrolet Equinox",45000},
            
        };
        Console.WriteLine("Bor avtomobillar: " +  avtomobillar.Count);
        Console.WriteLine("Mavjud summa");
        int minNarx = Convert.ToInt32(Console.ReadLine());
        avtomobillar = avtomobillar.Where(avtomobill => avtomobill.Value <= minNarx).ToDictionary();

      
        Console.WriteLine("Tavsiya etiladigan avtomobillar soni: " + avtomobillar.Count());
        Console.WriteLine("Avtomabillar ro’yxati:");
        foreach (var avtomobil in avtomobillar)
        {
            Console.WriteLine($"{avtomobil.Key}, narxi: {avtomobil.Value}");

        }
    }
}
