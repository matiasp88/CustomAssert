using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MatiasPili1216.AssertThrowException
{
    /// <summary>
    /// A collection of helper classes to test various conditions within unit tests. If the condition being tested is not met, an custom exception is thrown.
    /// </summary>
    public static class Assert
    {
        /// <summary>
        ///Comprueba si dos valores especificados son iguales y produce una excepción si no lo son. Los tipos numéricos distintos se tratan como diferentes aunque sus valores lógicos sean iguales. 42L no es igual que 42.
        /// </summary>
        /// <typeparam name="T">Tipo de datos, que se comparan</typeparam>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="expected">Primer valor para comparar. Este es el valor que la prueba espera.</param>
        /// <param name="actual">Segundo valor para comparar. Este es el valor generado por el código sometido a prueba.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual no es igual a expected. El mensaje se muestra en los resultados de las pruebas.</param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception>Thrown if expected is not equal to actual.</exception>
        public static void AreEqual<T, E>(T expected, T actual, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        ///Comprueba si dos valores especificados son iguales y produce una excepción si no lo son. Los tipos numéricos distintos se tratan como diferentes aunque sus valores lógicos sean iguales. 42L no es igual que 42.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="expected">Primer valor para comparar. Este es el valor que la prueba espera.</param>
        /// <param name="actual">Segundo valor para comparar. Este es el valor generado por el código sometido a prueba.</param>
        /// <exception>Thrown if expected is not equal to actual.</exception>
        public static void AreEqual<E>(object expected, object actual) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        ///Comprueba si dos valores especificados son iguales y produce una excepción si no lo son. Los tipos numéricos distintos se tratan como diferentes aunque sus valores lógicos sean iguales. 42L no es igual que 42.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="expected">Primer valor para comparar. Este es el valor que la prueba espera.</param>
        /// <param name="actual">Segundo valor para comparar. Este es el valor generado por el código sometido a prueba.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual no es igual a expected. El mensaje se muestra en los resultados de las pruebas.</param>
        /// <exception>Thrown if expected is not equal to actual.</exception>
        public static void AreEqual<E>(object expected, object actual, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        ///Comprueba si dos valores especificados son iguales y produce una excepción si no lo son. Los tipos numéricos distintos se tratan como diferentes aunque sus valores lógicos sean iguales. 42L no es igual que 42.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="expected">Primer valor para comparar. Este es el valor que la prueba espera.</param>
        /// <param name="actual">Segundo valor para comparar. Este es el valor generado por el código sometido a prueba.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual no es igual a expected. El mensaje se muestra en los resultados de las pruebas.</param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception>Thrown if expected is not equal to actual.</exception>
        public static void AreEqual<E>(object expected, object actual, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si los valores float especificados son iguales y produce una excepción si no lo son.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="expected">Primer valor float para comparar. Este es el valor float que la prueba espera.</param>
        /// <param name="actual">Segundo valor float para comparar. Este es el valor float generado por el código sometido a prueba.</param>
        /// <param name="delta">Precisión requerida. Se iniciará una excepción solamente si actual difiere de expected por más de delta.</param>
        /// <exception>Thrown if expected is not equal to actual.</exception>
        public static void AreEqual<E>(float expected, float actual, float delta) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual, delta);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si los valores float especificados son iguales y produce una excepción si no lo son.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="expected">Primer valor float para comparar. Este es el valor float que la prueba espera.</param>
        /// <param name="actual">Segundo valor float para comparar. Este es el valor float generado por el código sometido a prueba.</param>
        /// <param name="delta">Precisión requerida. Se iniciará una excepción solamente si actual difiere de expected por más de delta.</param>
        /// <param name="message"> Mensaje que se va a incluir en la excepción cuando actual difiere de expected por más de delta. El mensaje se muestra en los resultados de las pruebas.</param>
        /// <exception>Thrown if expected is not equal to actual.</exception>
        public static void AreEqual<E>(float expected, float actual, float delta, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual, delta, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si los valores float especificados son iguales y produce una excepción si no lo son.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="expected">Primer valor float para comparar. Este es el valor float que la prueba espera.</param>
        /// <param name="actual">Segundo valor float para comparar. Este es el valor float generado por el código sometido a prueba.</param>
        /// <param name="delta">Precisión requerida. Se iniciará una excepción solamente si actual difiere de expected por más de delta.</param>
        /// <param name="message"> Mensaje que se va a incluir en la excepción cuando actual difiere de expected por más de delta. El mensaje se muestra en los resultados de las pruebas.</param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception>Thrown if expected is not equal to actual.</exception>
        public static void AreEqual<E>(float expected, float actual, float delta, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual, delta, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si los valores double especificados son iguales y produce una excepción si no lo son.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="expected">Primer valor double para comparar. Este es el valor double que la prueba espera.</param>
        /// <param name="actual">Segundo valor double para comparar. Este es el valor double generado por el código sometido a prueba.</param>
        /// <param name="delta">Precisión requerida. Se iniciará una excepción solamente si actual difiere de expected por más de delta.</param>
        /// <exception>Thrown if expected is not equal to actual.</exception>
        public static void AreEqual<E>(double expected, double actual, double delta) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual, delta);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si los valores double especificados son iguales y produce una excepción si no lo son.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="expected">Primer valor double para comparar. Este es el valor double que la prueba espera.</param>
        /// <param name="actual">Segundo valor double para comparar. Este es el valor double generado por el código sometido a prueba.</param>
        /// <param name="delta">Precisión requerida. Se iniciará una excepción solamente si actual difiere de expected por más de delta.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual difiere de expected por más de delta. El mensaje se muestra en los resultados de las pruebas.</param>
        /// <exception>Thrown if expected is not equal to actual.</exception>
        public static void AreEqual<E>(double expected, double actual, double delta, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual, delta, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si las cadenas especificadas son iguales y produce una excepción si no lo son. Se usa la referencia cultural invariable para la comparación.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="expected">Primera cadena para comparar. Esta es la cadena que la prueba espera.</param>
        /// <param name="actual"> Segunda cadena para comparar. Esta es la cadena generada por el código sometido a prueba.</param>
        /// <param name="ignoreCase">Valor booleano que indica una comparación donde se distingue o no mayúsculas de minúsculas. (true indica una comparación que no distingue mayúsculas de minúsculas).</param>
        /// <exception>Thrown if expected is not equal to actual.</exception>
        public static void AreEqual<E>(string expected, string actual, bool ignoreCase) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual, ignoreCase);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si las cadenas especificadas son iguales y produce una excepción si no lo son. Se usa la referencia cultural invariable para la comparación.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="expected">Primera cadena para comparar. Esta es la cadena que la prueba espera.</param>
        /// <param name="actual"> Segunda cadena para comparar. Esta es la cadena generada por el código sometido a prueba.</param>
        /// <param name="ignoreCase">Valor booleano que indica una comparación donde se distingue o no mayúsculas de minúsculas. (true indica una comparación que no distingue mayúsculas de minúsculas).</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual no es igual a expected. El mensaje se muestra en los resultados de las pruebas.</param>
        /// <exception>Thrown if expected is not equal to actual.</exception>
        public static void AreEqual<E>(string expected, string actual, bool ignoreCase, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual, ignoreCase, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si las cadenas especificadas son iguales y produce una excepción si no lo son. Se usa la referencia cultural invariable para la comparación.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="expected">Primera cadena para comparar. Esta es la cadena que la prueba espera.</param>
        /// <param name="actual"> Segunda cadena para comparar. Esta es la cadena generada por el código sometido a prueba.</param>
        /// <param name="ignoreCase">Valor booleano que indica una comparación donde se distingue o no mayúsculas de minúsculas. (true indica una comparación que no distingue mayúsculas de minúsculas).</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual no es igual a expected. El mensaje se muestra en los resultados de las pruebas.</param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception>Thrown if expected is not equal to actual.</exception>
        public static void AreEqual<E>(string expected, string actual, bool ignoreCase, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual, ignoreCase, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si las cadenas especificadas son iguales y produce una excepción si no lo son.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="expected">Primera cadena para comparar. Esta es la cadena que la prueba espera.</param>
        /// <param name="actual"> Segunda cadena para comparar. Esta es la cadena generada por el código sometido a prueba.</param>
        /// <param name="ignoreCase">Valor booleano que indica una comparación donde se distingue o no mayúsculas de minúsculas. (true indica una comparación que no distingue mayúsculas de minúsculas).</param>
        /// <param name="culture">Objeto CultureInfo que proporciona información de comparación específica de la referencia cultural.</param>
        /// <exception>Thrown if expected is not equal to actual.</exception>
        public static void AreEqual<E>(string expected, string actual, bool ignoreCase, CultureInfo culture) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual, ignoreCase, culture);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si las cadenas especificadas son iguales y produce una excepción si no lo son.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="expected">Primera cadena para comparar. Esta es la cadena que la prueba espera.</param>
        /// <param name="actual"> Segunda cadena para comparar. Esta es la cadena generada por el código sometido a prueba.</param>
        /// <param name="ignoreCase">Valor booleano que indica una comparación donde se distingue o no mayúsculas de minúsculas. (true indica una comparación que no distingue mayúsculas de minúsculas).</param>
        /// <param name="culture">Objeto CultureInfo que proporciona información de comparación específica de la referencia cultural.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual no es igual a expected. El mensaje se muestra en los resultados de las pruebas.</param>
        /// <exception>Thrown if expected is not equal to actual.</exception>
        public static void AreEqual<E>(string expected, string actual, bool ignoreCase, CultureInfo culture, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual, ignoreCase, culture, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si las cadenas especificadas son iguales y produce una excepción si no lo son.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="expected">Primera cadena para comparar. Esta es la cadena que la prueba espera.</param>
        /// <param name="actual"> Segunda cadena para comparar. Esta es la cadena generada por el código sometido a prueba.</param>
        /// <param name="ignoreCase">Valor booleano que indica una comparación donde se distingue o no mayúsculas de minúsculas. (true indica una comparación que no distingue mayúsculas de minúsculas).</param>
        /// <param name="culture">Objeto CultureInfo que proporciona información de comparación específica de la referencia cultural.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual no es igual a expected. El mensaje se muestra en los resultados de las pruebas.</param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception>Thrown if expected is not equal to actual.</exception>
        public static void AreEqual<E>(string expected, string actual, bool ignoreCase, CultureInfo culture, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual, ignoreCase, culture, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        ///Comprueba si dos valores especificados son iguales y produce una excepción si no lo son. Los tipos numéricos distintos se tratan como diferentes aunque sus valores lógicos sean iguales. 42L no es igual que 42.
        /// </summary>
        /// <typeparam name="T">Tipo de datos, que se comparan</typeparam>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="expected">Primer valor para comparar. Este es el valor que la prueba espera.</param>
        /// <param name="actual">Segundo valor para comparar. Este es el valor generado por el código sometido a prueba.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual no es igual a expected. El mensaje se muestra en los resultados de las pruebas.</param>
        /// <exception>Thrown if expected is not equal to actual.</exception>
        public static void AreEqual<T, E>(T expected, T actual, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual<T>(expected, actual, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        ///Comprueba si dos valores especificados son iguales y produce una excepción si no lo son. Los tipos numéricos distintos se tratan como diferentes aunque sus valores lógicos sean iguales. 42L no es igual que 42.
        /// </summary>
        /// <typeparam name="T">Tipo de datos, que se comparan</typeparam>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="expected">Primer valor para comparar. Este es el valor que la prueba espera.</param>
        /// <param name="actual">Segundo valor para comparar. Este es el valor generado por el código sometido a prueba.</param>
        /// <exception>Thrown if expected is not equal to actual.</exception>
        public static void AreEqual<T, E>(T expected, T actual) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si los valores double especificados son iguales y produce una excepción si no lo son.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="expected">Primer valor double para comparar. Este es el valor double que la prueba espera.</param>
        /// <param name="actual">Segundo valor double para comparar. Este es el valor double generado por el código sometido a prueba.</param>
        /// <param name="delta">Precisión requerida. Se iniciará una excepción solamente si actual difiere de expected por más de delta.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual difiere de expected por más de delta. El mensaje se muestra en los resultados de las pruebas.</param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception>Thrown if expected is not equal to actual.</exception>
        public static void AreEqual<E>(double expected, double actual, double delta, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual, delta, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si las cadenas especificadas son distintas y produce una excepción  si son iguales. Para la comparación, se usa la referencia cultural invariable.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="notExpected">Primera cadena para comparar. Esta es la cadena que la prueba espera que no coincida con actual.</param>
        /// <param name="actual">Segunda cadena para comparar. Esta es la cadena generada por el código sometido a prueba.</param>
        /// <param name="ignoreCase">Valor booleano que indica una comparación donde se distingue o no mayúsculas de minúsculas. (true indica una comparación que no distingue mayúsculas de minúsculas).</param>
        /// <exception> Thrown if notExpected is equal to actual.</exception>
        public static void AreNotEqual<E>(string notExpected, string actual, bool ignoreCase) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(notExpected, actual, ignoreCase);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        ///Comprueba si los valores float especificados son distintos y produce una excepción si son iguales.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="notExpected"></param>
        /// <param name="actual">Segundo valor float para comparar. Este es el valor float generado por el código sometido a prueba.</param>
        /// <param name="delta">Precisión requerida. Se iniciará una excepción solamente si actual difiere de notExpected por un máximo de delta</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual es igual a notExpected o difiere por menos de delta. El mensaje se muestra en los resultados de las pruebas.</param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception> Thrown if notExpected is equal to actual.</exception>
        public static void AreNotEqual<E>(float notExpected, float actual, float delta, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(notExpected, actual, delta, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        ///Comprueba si los valores float especificados son distintos y produce una excepción si son iguales.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="notExpected"></param>
        /// <param name="actual">Segundo valor float para comparar. Este es el valor float generado por el código sometido a prueba.</param>
        /// <param name="delta">Precisión requerida. Se iniciará una excepción solamente si actual difiere de notExpected por un máximo de delta</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual es igual a notExpected o difiere por menos de delta. El mensaje se muestra en los resultados de las pruebas.</param>
        /// <exception> Thrown if notExpected is equal to actual.</exception>
        public static void AreNotEqual<E>(float notExpected, float actual, float delta, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(notExpected, actual, delta, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        ///Comprueba si los valores float especificados son distintos y produce una excepción si son iguales.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="notExpected">Primer valor float para comparar. Este es el valor float que la prueba espera que no coincida con actual.</param>
        /// <param name="actual">Segundo valor float para comparar. Este es el valor float generado por el código sometido a prueba.</param>
        /// <param name="delta">Precisión requerida. Se iniciará una excepción solamente si actual difiere de notExpected por un máximo de delta</param>
        /// <exception> Thrown if notExpected is equal to actual.</exception>
        public static void AreNotEqual<E>(float notExpected, float actual, float delta) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(notExpected, actual, delta);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si los valores double especificados son distintos y produce una excepción si son iguales.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="notExpected">Primer valor double para comparar. Este es el valor double que la prueba espera que no coincida con actual.</param>
        /// <param name="actual">Segundo valor double para comparar. Este es el valor double generado por el código sometido a prueba.</param>
        /// <param name="delta">Precisión requerida. Se iniciará una excepción solamente si actual difiere de notExpected por un máximo de delta.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual es igual a notExpected o difiere por menos de delta. El mensaje se muestra en los resultados de las pruebas.</param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception> Thrown if notExpected is equal to actual.</exception>
        public static void AreNotEqual<E>(double notExpected, double actual, double delta, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(notExpected, actual, delta, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si las cadenas especificadas son distintas y produce una excepción  si son iguales. Para la comparación, se usa la referencia cultural invariable.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="notExpected">Primera cadena para comparar. Esta es la cadena que la prueba espera que no coincida con actual.</param>
        /// <param name="actual">Segunda cadena para comparar. Esta es la cadena generada por el código sometido a prueba.</param>
        /// <param name="ignoreCase">Valor booleano que indica una comparación donde se distingue o no mayúsculas de minúsculas. (true indica una comparación que no distingue mayúsculas de minúsculas).</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual es igual a notExpected. El mensaje se muestra en los resultados de las pruebas.</param>
        /// <exception> Thrown if notExpected is equal to actual.</exception>
        public static void AreNotEqual<E>(string notExpected, string actual, bool ignoreCase, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(notExpected, actual, ignoreCase, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si dos objetos especificados son distintos y produce una excepción si lo son. Los tipos numéricos distintos se tratan como tipos diferentes aunque sus valores lógicos sean iguales. 42L no es igual que 42.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="notExpected">Primer objeto para comparar. Este es el valor que la prueba espera que no coincida con actual.</param>
        /// <param name="actual">Segundo objeto para comparar. Este es el objeto generado por el código sometido a prueba.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual es igual a notExpected. El mensaje se muestra en los resultados de las pruebas.</param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception> Thrown if notExpected is equal to actual.</exception>
        public static void AreNotEqual<E>(object notExpected, object actual, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(notExpected, actual, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si los valores double especificados son distintos y produce una excepción si son iguales.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="notExpected">Primer valor double para comparar. Este es el valor double que la prueba espera que no coincida con actual.</param>
        /// <param name="actual">Segundo valor double para comparar. Este es el valor double generado por el código sometido a prueba.</param>
        /// <param name="delta">Precisión requerida. Se iniciará una excepción solamente si actual difiere de notExpected por un máximo de delta.</param>
        /// <param name="message">
        ///     Mensaje que se va a incluir en la excepción cuando actual es igual a notExpected
        ///     o difiere por menos de delta. El mensaje se muestra en los resultados de las
        ///     pruebas.
        ///     </param>
        /// <exception> Thrown if notExpected is equal to actual.</exception>
        public static void AreNotEqual<E>(double notExpected, double actual, double delta, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(notExpected, actual, delta, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        ///     Comprueba si dos objetos especificados son distintos y produce una excepción
        ///     si lo son. Los tipos numéricos distintos se tratan como tipos diferentes aunque
        ///     sus valores lógicos sean iguales. 42L no es igual que 42. 
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="notExpected">Primer objeto para comparar. Este es el valor que la prueba espera que no coincida con actual.</param>
        /// <param name="actual">Segundo objeto para comparar. Este es el objeto generado por el código sometido a prueba.</param>
        /// <param name="message">
        ///     Mensaje que se va a incluir en la excepción cuando actual es igual a notExpected.
        ///     El mensaje se muestra en los resultados de las pruebas.
        ///     </param>
        /// <exception> Thrown if notExpected is equal to actual.</exception>
        public static void AreNotEqual<E>(object notExpected, object actual, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(notExpected, actual, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>Comprueba si las cadenas especificadas son distintas y produce una excepción
        ///     si son iguales. Para la comparación, se usa la referencia cultural invariable.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="notExpected">Primera cadena para comparar. Esta es la cadena que la prueba espera que no coincida con actual.</param>
        /// <param name="actual">Segunda cadena para comparar. Esta es la cadena generada por el código sometido a prueba.</param>
        /// <param name="ignoreCase">Valor booleano que indica una comparación donde se distingue o no mayúsculas
        ///     de minúsculas. (true indica una comparación que no distingue mayúsculas de minúsculas).</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual es igual a notExpected.
        ///     El mensaje se muestra en los resultados de las pruebas.</param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception> Thrown if notExpected is equal to actual.</exception>
        public static void AreNotEqual<E>(string notExpected, string actual, bool ignoreCase, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(notExpected, actual, ignoreCase, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si las cadenas especificadas son distintas y produce una excepción si son iguales.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="notExpected">Primera cadena para comparar. Esta es la cadena que la prueba espera que no coincida con actual.</param>
        /// <param name="actual">Segunda cadena para comparar. Esta es la cadena generada por el código sometido a prueba.</param>
        /// <param name="ignoreCase">Valor booleano que indica una comparación donde se distingue o no mayúsculas
        ///     de minúsculas. (true indica una comparación que no distingue mayúsculas de minúsculas).</param>
        /// <param name="culture">Objeto CultureInfo que proporciona información de comparación específica de la
        ///     referencia cultural.</param>
        /// <exception> Thrown if notExpected is equal to actual.</exception>
        public static void AreNotEqual<E>(string notExpected, string actual, bool ignoreCase, CultureInfo culture) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(notExpected, actual, ignoreCase, culture);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        ///  Comprueba si las cadenas especificadas son distintas y produce una excepción
        ///     si son iguales.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="notExpected">Primera cadena para comparar. Esta es la cadena que la prueba espera que no coincida con actual.</param>
        /// <param name="actual">Segunda cadena para comparar. Esta es la cadena generada por el código sometido a prueba.</param>
        /// <param name="ignoreCase">Valor booleano que indica una comparación donde se distingue o no mayúsculas
        ///     de minúsculas. (true indica una comparación que no distingue mayúsculas de minúsculas).
        ///     </param>
        /// <param name="culture">Objeto CultureInfo que proporciona información de comparación específica de la referencia cultural.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual es igual a notExpected.
        /// El mensaje se muestra en los resultados de las pruebas.
        /// </param>
        /// <exception>Thrown if notExpected is equal to actual</exception>
        public static void AreNotEqual<E>(string notExpected, string actual, bool ignoreCase, CultureInfo culture, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(notExpected, actual, ignoreCase, culture, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        ///     Comprueba si dos valores especificados son distintos y produce una excepción
        ///     si son iguales. Los tipos numéricos distintos se tratan como diferentes aunque
        ///     sus valores lógicos sean iguales. 42L no es igual que 42.
        /// </summary>
        /// <typeparam name="T">The type of values to compare.</typeparam>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="notExpected">Primera cadena para comparar. Esta es la cadena que la prueba espera que no coincida con actual.</param>
        /// <param name="actual">Segunda cadena para comparar. Esta es la cadena generada por el código sometido a prueba.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual es igual a notExpected.
        /// El mensaje se muestra en los resultados de las pruebas.
        /// </param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception>Thrown if notExpected is equal to actual.</exception>
        public static void AreNotEqual<T, E>(T notExpected, T actual, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual<T>(notExpected, actual, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        ///     Comprueba si dos valores especificados son distintos y produce una excepción
        ///     si son iguales. Los tipos numéricos distintos se tratan como diferentes aunque
        ///     sus valores lógicos sean iguales. 42L no es igual que 42.
        /// </summary>
        /// <typeparam name="T">The type of values to compare.</typeparam>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="notExpected">Primera cadena para comparar. Esta es la cadena que la prueba espera que no coincida con actual.</param>
        /// <param name="actual">Segunda cadena para comparar. Esta es la cadena generada por el código sometido a prueba.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual es igual a notExpected.
        /// El mensaje se muestra en los resultados de las pruebas.
        /// </param>
        /// <exception>Thrown if notExpected is equal to actual.</exception>
        public static void AreNotEqual<T, E>(T notExpected, T actual, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(notExpected, actual, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        ///     Comprueba si dos valores especificados son distintos y produce una excepción
        ///     si son iguales. Los tipos numéricos distintos se tratan como diferentes aunque
        ///     sus valores lógicos sean iguales. 42L no es igual que 42.
        /// </summary>
        /// <typeparam name="T">The type of values to compare.</typeparam>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="notExpected">Primera cadena para comparar. Esta es la cadena que la prueba espera que no coincida con actual.</param>
        /// <param name="actual">Segunda cadena para comparar. Esta es la cadena generada por el código sometido a prueba.</param>
        /// <exception>Thrown if notExpected is equal to actual.</exception>
        public static void AreNotEqual<T, E>(T notExpected, T actual) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual<T>(notExpected, actual);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        ///  Comprueba si las cadenas especificadas son distintas y produce una excepción
        ///     si son iguales.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="notExpected">Primera cadena para comparar. Esta es la cadena que la prueba espera que no coincida con actual.</param>
        /// <param name="actual">Segunda cadena para comparar. Esta es la cadena generada por el código sometido a prueba.</param>
        /// <param name="ignoreCase">Valor booleano que indica una comparación donde se distingue o no mayúsculas
        ///     de minúsculas. (true indica una comparación que no distingue mayúsculas de minúsculas).
        ///     </param>
        /// <param name="culture">Objeto CultureInfo que proporciona información de comparación específica de la referencia cultural.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual es igual a notExpected.
        /// El mensaje se muestra en los resultados de las pruebas.
        /// </param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception>Thrown if notExpected is equal to actual.</exception>
        public static void AreNotEqual<E>(string notExpected, string actual, bool ignoreCase, CultureInfo culture, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            if (culture == null) { throw new ArgumentNullException(nameof(culture)); }

            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(notExpected, actual, ignoreCase, culture, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        ///     Comprueba si dos objetos especificados son distintos y produce una excepción
        ///     si lo son. Los tipos numéricos distintos se tratan como tipos diferentes aunque
        ///     sus valores lógicos sean iguales. 42L no es igual que 42.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="notExpected">Primer objeto para comparar. Este es el valor que la prueba espera que no coincida con actual.</param>
        /// <param name="actual">Segundo objeto para comparar. Este es el objeto generado por el código sometido a prueba.</param>
        /// <exception>Thrown if notExpected is equal to actual.</exception>
        public static void AreNotEqual<E>(object notExpected, object actual) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(notExpected, actual);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si los valores double especificados son distintos y produce una excepción
        ///     si son iguales.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="notExpected">Primer valor double para comparar. Este es el valor double que la prueba espera
        ///     que no coincida con actual.</param>
        /// <param name="actual">Segundo valor double para comparar. Este es el valor double generado por el código
        ///     sometido a prueba.</param>
        /// <param name="delta">Precisión requerida. Se iniciará una excepción solamente si actual difiere de
        ///     notExpected por un máximo de delta.</param>
        /// <exception>Thrown if notExpected is equal to actual.</exception>
        public static void AreNotEqual<E>(double notExpected, double actual, double delta) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(notExpected, actual, delta);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        ///  Comprueba si dos objetos especificados hacen referencia a objetos diferentes
        ///     y produce una excepción si ambas entradas hacen referencia al mismo objeto.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="notExpected">Primer objeto para comparar. Este es el valor que la prueba espera que no coincida
        ///     con actual.</param>
        /// <param name="actual">Segundo objeto para comparar. Este es el valor generado por el código sometido
        ///     a prueba.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual es igual que notExpected.
        ///     El mensaje se muestra en los resultados de las pruebas.</param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception>Thrown if notExpected refers to the same object as actual.</exception>
        public static void AreNotSame<E>(object notExpected, object actual, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotSame(notExpected, actual, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        ///  Comprueba si dos objetos especificados hacen referencia a objetos diferentes
        ///     y produce una excepción si ambas entradas hacen referencia al mismo objeto.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="notExpected">Primer objeto para comparar. Este es el valor que la prueba espera que no coincida
        ///     con actual.</param>
        /// <param name="actual">Segundo objeto para comparar. Este es el valor generado por el código sometido
        ///     a prueba.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual es igual que notExpected.
        ///     El mensaje se muestra en los resultados de las pruebas.</param>
        /// <exception>Thrown if notExpected refers to the same object as actual.</exception>
        public static void AreNotSame<E>(object notExpected, object actual, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotSame(notExpected, actual, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        ///  Comprueba si dos objetos especificados hacen referencia a objetos diferentes
        ///     y produce una excepción si ambas entradas hacen referencia al mismo objeto.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="notExpected">Primer objeto para comparar. Este es el valor que la prueba espera que no coincida
        ///     con actual.</param>
        /// <param name="actual">Segundo objeto para comparar. Este es el valor generado por el código sometido
        ///     a prueba.</param>
        /// <exception>Thrown if notExpected refers to the same object as actual.</exception>
        public static void AreNotSame<E>(object notExpected, object actual) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotSame(notExpected, actual);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si dos objetos especificados hacen referencia al mismo objeto y produce
        ///     una excepción si ambas entradas no hacen referencia al mismo objeto.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="expected">Primer objeto para comparar. Este es el valor que la prueba espera.</param>
        /// <param name="actual">Segundo objeto para comparar. Este es el valor generado por el código sometido
        ///     a prueba.</param>
        /// <exception>Thrown if expected does not refer to the same object as actual.</exception>
        public static void AreSame<E>(object expected, object actual) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreSame(expected, actual);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si dos objetos especificados hacen referencia al mismo objeto y produce
        ///     una excepción si ambas entradas no hacen referencia al mismo objeto.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="expected">Primer objeto para comparar. Este es el valor que la prueba espera.</param>
        /// <param name="actual">Segundo objeto para comparar. Este es el valor generado por el código sometido
        ///     a prueba.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual no es igual que expected.
        ///     El mensaje se muestra en los resultados de las pruebas.</param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception>Thrown if expected does not refer to the same object as actual.</exception>
        public static void AreSame<E>(object expected, object actual, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreSame(expected, actual, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si dos objetos especificados hacen referencia al mismo objeto y produce
        ///     una excepción si ambas entradas no hacen referencia al mismo objeto.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="expected">Primer objeto para comparar. Este es el valor que la prueba espera.</param>
        /// <param name="actual">Segundo objeto para comparar. Este es el valor generado por el código sometido
        ///     a prueba.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando actual no es igual que expected.
        ///     El mensaje se muestra en los resultados de las pruebas.</param>
        /// <exception>Thrown if expected does not refer to the same object as actual.</exception>
        public static void AreSame<E>(object expected, object actual, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreSame(expected, actual, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Produce una excepción Especificada.
        /// </summary>
        /// <param name="message">Mensaje que se va a incluir en la excepción. El mensaje se muestra en los resultados de las pruebas.></param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        public static void Custom<E>(string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            throw (E)Activator.CreateInstance(typeof(E), new object[] { string.Format(message, parameters) });
        }

        /// <summary>
        /// Produce una excepción Especificada.
        /// </summary>
        public static void Custom<E>() where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            E customException = new E();

            throw (E)Activator.CreateInstance(typeof(E), new object[] { $"Error de {customException.GetType().Name}" });
        }

        /// <summary>
        /// Produce una excepción Especificada.
        /// </summary>
        /// <param name="message">Mensaje que se va a incluir en la excepción. El mensaje se muestra en los resultados de las pruebas.></param>
        public static void Custom<E>(string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            throw (E)Activator.CreateInstance(typeof(E), new object[] { message });
        }

        /// <summary>
        /// Comprueba si la condición especificada es false y produce una excepción si la
        ///     condición es true.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="condition">Condición que la prueba espera que sea false.</param>
        /// <exception>Thrown if condition is true.</exception>
        public static void IsFalse<E>(bool condition) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(condition);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si la condición especificada es false y produce una excepción si la
        ///     condición es true.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="condition">Condición que la prueba espera que sea false.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando condition es true. El mensaje
        ///     se muestra en los resultados de las pruebas.</param>
        /// <exception>Thrown if condition is true.</exception>
        public static void IsFalse<E>(bool condition, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(condition, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si la condición especificada es false y produce una excepción si la
        ///     condición es true.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="condition">Condición que la prueba espera que sea false.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando condition es true. El mensaje
        ///     se muestra en los resultados de las pruebas.</param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception>Thrown if condition is true.</exception>
        public static void IsFalse<E>(bool condition, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(condition, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si la condición especificada es false y produce una excepción si la
        ///     condición es true.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="conditions">Condición que la prueba espera que sea false.</param>
        /// <exception>Thrown if condition is true.</exception>
        public static void AreAllFalse<E>(IEnumerable<bool> conditions) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                bool condition = conditions.All(x => !x);
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(condition);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si la condición especificada es false y produce una excepción si la
        ///     condición es true.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="conditions">Condición que la prueba espera que sea false.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando condition es true. El mensaje
        ///     se muestra en los resultados de las pruebas.</param>
        /// <exception>Thrown if condition is true.</exception>
        public static void AreAllFalse<E>(IEnumerable<bool> conditions, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                bool condition = conditions.All(x => !x);
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(condition, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si la condición especificada es false y produce una excepción si la
        ///     condición es true.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="conditions">Condición que la prueba espera que sea false.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando condition es true. El mensaje
        ///     se muestra en los resultados de las pruebas.</param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception>Thrown if condition is true.</exception>
        public static void AreAllFalse<E>(IEnumerable<bool> conditions, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                bool condition = conditions.All(x => !x);
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(condition, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si el objeto especificado es una instancia del tipo esperado y produce
        ///     una excepción si el tipo esperado no se encuentra en la jerarquía de herencia
        ///     del objeto.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="value">El objeto que la prueba espera que sea del tipo especificado.</param>
        /// <param name="expectedType">Tipo esperado de value.</param>
        /// <exception>Thrown if value is null or expectedType is not in the inheritance hierarchy of value.</exception>
        public static void IsInstanceOfType<E>(object value, Type expectedType) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsInstanceOfType(value, expectedType);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si el objeto especificado es una instancia del tipo esperado y produce
        ///     una excepción si el tipo esperado no se encuentra en la jerarquía de herencia
        ///     del objeto.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="value">El objeto que la prueba espera que sea del tipo especificado.</param>
        /// <param name="expectedType">Tipo esperado de value.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando value no es una instancia
        ///     de expectedType. El mensaje se muestra en los resultados de las pruebas.</param>
        /// <exception>Thrown if value is null or expectedType is not in the inheritance hierarchy of value.</exception>
        public static void IsInstanceOfType<E>(object value, Type expectedType, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsInstanceOfType(value, expectedType, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si el objeto especificado es una instancia del tipo esperado y produce
        ///     una excepción si el tipo esperado no se encuentra en la jerarquía de herencia
        ///     del objeto.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="value">El objeto que la prueba espera que sea del tipo especificado.</param>
        /// <param name="expectedType">Tipo esperado de value.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando value no es una instancia
        ///     de expectedType. El mensaje se muestra en los resultados de las pruebas.</param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception>Thrown if value is null or expectedType is not in the inheritance hierarchy of value.</exception>
        public static void IsInstanceOfType<E>(object value, Type expectedType, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsInstanceOfType(value, expectedType, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si el objeto especificado no es una instancia del tipo incorrecto y
        ///     produce una excepción si el tipo especificado se encuentra en la jerarquía de
        ///     herencia del objeto.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="value">El objeto que la prueba espera que no sea del tipo especificado.</param>
        /// <param name="wrongType">El tipo que value no debe tener.</param>
        /// <exception>Thrown if value is not null and wrongType is in the inheritance hierarchy of value.</exception>
        public static void IsNotInstanceOfType<E>(object value, Type wrongType) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotInstanceOfType(value, wrongType);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si el objeto especificado no es una instancia del tipo incorrecto y
        ///     produce una excepción si el tipo especificado se encuentra en la jerarquía de
        ///     herencia del objeto.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="value">El objeto que la prueba espera que no sea del tipo especificado.</param>
        /// <param name="wrongType">El tipo que value no debe tener.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando value es una instancia de
        ///     wrongType. El mensaje se muestra en los resultados de las pruebas.</param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception>Thrown if value is not null and wrongType is in the inheritance hierarchy of value.</exception>
        public static void IsNotInstanceOfType<E>(object value, Type wrongType, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotInstanceOfType(value, wrongType, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si el objeto especificado no es una instancia del tipo incorrecto y
        ///     produce una excepción si el tipo especificado se encuentra en la jerarquía de
        ///     herencia del objeto.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="value">El objeto que la prueba espera que no sea del tipo especificado.</param>
        /// <param name="wrongType">El tipo que value no debe tener.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando value es una instancia de
        ///     wrongType. El mensaje se muestra en los resultados de las pruebas.</param>
        /// <exception>Thrown if value is not null and wrongType is in the inheritance hierarchy of value.</exception>
        public static void IsNotInstanceOfType<E>(object value, Type wrongType, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotInstanceOfType(value, wrongType, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si el objeto especificado no es NULL y produce una excepción si lo es.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="value">El objeto que la prueba espera que no sea NULL.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando value es NULL. El mensaje
        ///     se muestra en los resultados de las pruebas.</param>
        /// <exception>Thrown if value is null.</exception>
        public static void IsNotNull<E>(object value, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(value, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si el objeto especificado no es NULL y produce una excepción si lo es.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="value">El objeto que la prueba espera que no sea NULL.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando value es NULL. El mensaje
        ///     se muestra en los resultados de las pruebas.</param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception>Thrown if value is null.</exception>
        public static void IsNotNull<E>(object value, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(value, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si el objeto especificado no es NULL y produce una excepción si lo es.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="value">El objeto que la prueba espera que no sea NULL.</param>
        /// <exception>Thrown if value is null.</exception>
        public static void IsNotNull<E>(object value) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(value);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si el objeto especificado es NULL y produce una excepción si no lo es.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="value"> El objeto que la prueba espera que sea NULL.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando value no es NULL. El mensaje
        ///     se muestra en los resultados de las pruebas.</param>
        /// <exception>Thrown if value is not null.</exception>
        public static void IsNull<E>(object value, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNull(value, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si el objeto especificado es NULL y produce una excepción si no lo es.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="value"> El objeto que la prueba espera que sea NULL.</param>
        /// <exception>Thrown if value is not null.</exception>
        public static void IsNull<E>(object value) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNull(value);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si el objeto especificado es NULL y produce una excepción si no lo es.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="value"> El objeto que la prueba espera que sea NULL.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando value no es NULL. El mensaje
        ///     se muestra en los resultados de las pruebas.</param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception>Thrown if value is not null.</exception>
        public static void IsNull<E>(object value, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNull(value, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si la condición especificada es true y produce una excepción si la condición es false.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="condition">Condición que la prueba espera que sea true.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando condition es false. El mensaje
        ///     se muestra en los resultados de las pruebas.</param>
        /// <exception>Thrown if condition is false.</exception>
        public static void IsTrue<E>(bool condition, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(condition, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si la condición especificada es true y produce una excepción si la condición es false.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="condition">Condición que la prueba espera que sea true.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando condition es false. El mensaje
        ///     se muestra en los resultados de las pruebas.</param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception>Thrown if condition is false.</exception>
        public static void IsTrue<E>(bool condition, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(condition, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si la condición especificada es true y produce una excepción si la condición es false.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="condition">Condición que la prueba espera que sea true.</param>
        /// <exception>Thrown if condition is false.</exception>
        public static void IsTrue<E>(bool condition) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(condition);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si la condición especificada es true y produce una excepción si la condición es false.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="conditions">Condición que la prueba espera que sea true.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando condition es false. El mensaje
        ///     se muestra en los resultados de las pruebas.</param>
        /// <exception>Thrown if condition is false.</exception>
        public static void AreAllTrue<E>(IEnumerable<bool> conditions, string message) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                bool condition = conditions.All(x => x);
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(condition, message);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si la condición especificada es true y produce una excepción si la condición es false.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="conditions">Condición que la prueba espera que sea true.</param>
        /// <param name="message">Mensaje que se va a incluir en la excepción cuando condition es false. El mensaje
        ///     se muestra en los resultados de las pruebas.</param>
        /// <param name="parameters">Matriz de parámetros que se usa al formatear message.</param>
        /// <exception>Thrown if condition is false.</exception>
        public static void AreAllTrue<E>(IEnumerable<bool> conditions, string message, params object[] parameters) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                bool condition = conditions.All(x => x);
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(condition, message, parameters);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }

        /// <summary>
        /// Comprueba si la condición especificada es true y produce una excepción si la condición es false.
        /// </summary>
        /// <typeparam name="E">Tipo de exepción a lanzar</typeparam>
        /// <param name="conditions">Condición que la prueba espera que sea true.</param>
        /// <exception>Thrown if condition is false.</exception>
        public static void AreAllTrue<E>(IEnumerable<bool> conditions) where E : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException, new()
        {
            try
            {
                bool condition = conditions.All(x => x);
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(condition);
            }
            catch (Exception e)
            {
                throw (E)Activator.CreateInstance(typeof(E), new object[] { e.Message, e.InnerException });
            }
        }
    }
}
