using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// return rectangle's area with l = 20 width = 10 find area
// do not return rectangle's area just print where l = 10 and widh = 15.4
// write a function to return a string -> ABCD
namespace CompetativeCoding
{
    class PetOwner
    {
        public string Name { get; set; }
        public List<string> Pets { get; set; }
    }

    class Test
    {   
        static void Main() 
        {
            PetOwner[] petOwners =
         { new PetOwner { Name="Higa",
              Pets = new List<string>{ "Scruffy", "Sam" } },
          new PetOwner { Name="Ashkenazi",
              Pets = new List<string>{ "Walker", "Sugar" } },
          new PetOwner { Name="Price",
              Pets = new List<string>{ "Scratches", "Diesel" } },
          new PetOwner { Name="Hines",
              Pets = new List<string>{ "Dusty" } } };

            // Project the pet owner's name and the pet's name.
            var query =
                petOwners
                .SelectMany(petOwner => petOwner.Pets, (petName,petOwner) => new { petOwner, petName });
            Console.WriteLine(query);
            Console.ReadKey();
        }
    }
}
