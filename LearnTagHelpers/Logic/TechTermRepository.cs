using LearnTagHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnTagHelpers.Logic
{
    /// <summary>
    /// A class used to get and create techterm data. It is currently a dummy representation,
    /// only working in the RAM.
    /// </summary>
    public class TechTermRepository
    {
        //A static field such that the data is shared across instances of the repository class
        private static List<TechTerm> techTerms;
        
        //Initializes the list of techterms once before the first instance is created
        static TechTermRepository()
        {
            techTerms = new List<TechTerm>()
            {
                new TechTerm()
                {
                    Name = "Field",
                    Description = "En variabel oprettet direkte i klassen. Bør altid være private eller protected"
                },
                new TechTerm()
                {
                    Name = "Property",
                    Description = "En fleksibel måde til at læse, skrive og beregne data i et objekt."
                },
                new TechTerm()
                {
                    Name = "Class",
                    Description = "En skabelon for det man ønsker at oprette. Svarer til sin egen datatype og kan indeholde ting som fields, properties og methods"
                },
                new TechTerm()
                {
                    Name = "Object",
                    Description = "Instansen der oprettes ud fra en klasse."
                },
                new TechTerm()
                {
                    Name = "Variable",
                    Description = "En navngivet genvej til data."
                }
            };
        }
        public IReadOnlyList<TechTerm> TechTerms
        {
            get
            {
                return techTerms.AsReadOnly();
            }
        }

        public void Add(TechTerm techTerm)
        {
            if (techTerm != null)
            {
                techTerms.Add(techTerm);
            }
        }
    }
}
