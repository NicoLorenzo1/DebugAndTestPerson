using System;

namespace UnitTestAndDebug
{
    public class Person
    {
        public Person(string name, string id)
        {
            this.Name = name;
            this.ID = id;
        }

        private string name;

        private string id;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
        }

        /// <summary>
        /// Modifique el método "IntroduceYourself" agregandole solamente un return con la linea que debía imprimir 
        /// por pantalla a efectos de poder realizar un testCase llamado "CorrectPrint" y verificar que el string se forme correctamente.
        /// </summary>
        /// <returns></returns>
        public string IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name} y mi cédula es {this.ID}");
            return $"Soy {this.Name} y mi cédula es {this.ID}";
        }
    }
}
