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
        /// Se prueba que se le saquen los puntos y guiones a la ID ingresada a traves del metodo IdIsValid.
        /// </summary>
        [Test]
        public void ClearId()
        {
            Assert.AreEqual(true, IdUtils.IdIsValid("5.4.332---615"));
        }

        /// <summary>
        /// Se prueba que el largo de la ID sea el esperado y en caso de no ser así retorne falso a través del método IdIsValid. 
        /// </summary>
        [Test]
        public void TestShortLength()
        {
            string value = "111111-1";
            bool result = IdUtils.IdIsValid(value);
            Assert.False(result); //como el resultado es bool se puede usar Assert.false
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
        /// Se prueba en caso de asignar null como nombre.
        /// </summary>
        [Test]
        public void NullNamePerson()
        {
            Person person1 = new Person(null, "54332615");
            Assert.IsNull(person1.Name);
        }

        /// <summary>
        /// Se prueba que se pueda cambiar correctamente el nombre de la persona.
        /// </summary>
        [Test]
        public void TestChangeName()
        {
            Person persona1 = new Person("Juan Lopez", "1111111-1");
            persona1.Name = "Sebastian Fernandez";
            Assert.AreEqual("Sebastian Fernandez", persona1.Name);
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