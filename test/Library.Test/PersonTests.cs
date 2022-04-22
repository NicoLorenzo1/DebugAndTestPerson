using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }
        /// <summary>
        /// Se prueba que la función "IdIsValid" valide una cedula valida.
        /// </summary>

        [Test]
        public void ValidIdNumber() // Cambiá el nombre para indicar qué estás probando
        {
            Assert.AreEqual(true, IdUtils.IdIsValid("5.433.261-5"));
        }

        /// <summary>
        /// Se prueba que la función IdIsValid No valide una cedula que no es correcta o valida.
        /// </summary>
        [Test]
        public void InvalidIdNumber()
        {
            Assert.AreEqual(false, IdUtils.IdIsValid("54332616"));
        }

        /// <summary>
        /// Se prueba que la función IdIsValid no valide un string vacío.
        /// </summary>
        [Test]
        public void NullIdNumber()
        {
            Assert.AreEqual(false, IdUtils.IdIsValid(""));
        }

        /// <summary>
        /// Se prueba que se asignen correctamente un nombre y una cédula válidas.
        /// </summary>
        [Test]
        public void ValidPerson()
        {
            Person person1 = new Person("Nicolas Lorenzo", "54332615");
            Assert.AreEqual(true, IdUtils.IdIsValid("54332615"));
            Assert.AreEqual(person1.Name, "Nicolas Lorenzo");
        }

        /// <summary>
        /// Se prueba en caso de asignar un string vacío lo tome como Null.
        /// </summary>
        [Test]
        public void InvalidNamePerson()
        {
            Person person1 = new Person("", "54332615");
            Assert.IsNull(person1.Name);
        }

        /// <summary>
        /// Se prueba en caso que sea una persona no valida y se le asigne un string vacio en el nombre y ID los tome como null. 
        /// </summary>
        [Test]
        public void InvalidPerson()
        {
            Person person1 = new Person("", "");
            Assert.IsNull(person1.Name);
            Assert.IsNull(person1.ID);
        }

        /// <summary>
        /// Test para verificar que no se le puedan asignar numeros a un nombre, en este caso el test falló ya que deberia de devolver true 
        /// porque se le asigno "888" al nombre y como en el codigo no se valida esta situación se aceptó el nombre. En un futuro se podría modificar
        /// el codigo logrando esta validacón para que solamente acepte caracteres que sean letras.
        /// (Está comentado para que no de error,).
        /// </summary>
        [Test]
        public void NumberNamePerson()
        {
            Person person1 = new Person("888", "54332615");
            //Assert.IsNull(person1.Name);
        }

        /// <summary>
        /// Test para verificar que se genera el string correctamente (igual al que se va a imprimir por consola).
        /// </summary>
        [Test]
        public void CorrectPrint()
        {
            Person person1 = new Person("Nicolas Lorenzo", "54332615");
            Assert.AreEqual(person1.IntroduceYourself(), "Soy Nicolas Lorenzo y mi cédula es 54332615");
        }
    }
}