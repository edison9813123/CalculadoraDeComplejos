using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matematica.Negocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Matematica.Test
{
    [TestClass]
    public class CalculadoraTest
    {
        //Suma de dos numeros//

        [TestMethod]
        public void SumaDeDosNumeros()
        {
            var primerNumero = 18;
            var segundoNumero = 3.1;
            var esperado = 21.1;

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.Sumar(primerNumero, segundoNumero);

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        //Resta de dos numero//
        public void RestaDeDosNumeros()
        {
            var primerNumero = 18;
            var segundoNumero = 2;
            var esperado = 16;

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.Restar(primerNumero, segundoNumero);

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        //Multiplicacion de dos numeros//
        public void MultiplicacionDeDosNumeros()
        {
            var primerNumero = 18;
            var segundoNumero = 2;
            var esperado = 36;

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.Multiplicar(primerNumero, segundoNumero);

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        //Division de dos numeros//
        public void DivisionDeDosNumeros()
        {
            var primerNumero = 18;
            var segundoNumero = 6;
            var esperado = 3;

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.Dividir(primerNumero, segundoNumero);

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        //Suma de numeros complejos//
        public void SumarComplejos()
        {
            Complejo complejo1 = new Complejo(3, 2);
            Complejo complejo2 = new Complejo(1.5, 6);
            Complejo esperado = new Complejo(4.5, 8);

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.Sumar(complejo1, complejo2);

            Assert.AreEqual(esperado.Real, resultado.Real);
        }
        //resta de dos numeros Complejos
        public void RestarComplejos()
        {
            Complejo complejo1 = new Complejo(3, 2);
            Complejo complejo2 = new Complejo(1.5, 6);
            Complejo esperado = new Complejo(4.5, 8);

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.Restar(complejo1, complejo2);

            Assert.AreEqual(esperado.Real, resultado.Real);
        }
        /*public void TruncarNumeros()
        {
            var numeroIngresado = 1.222222;
            var numeroEsperado = 1.22;

            var calculadora = new Calculadora();
            var resultado = calculadora.Truncar(numeroIngresado);

            Assert.AreEqual(numeroEsperado, resultado);

        }*/
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]

        //Division por cero//
        public void DividirPorCero()
        {
            
            var dividendo = 5;
            var divisor = 0;

            var calculadora = new Calculadora() ;
            _ = calculadora.Dividir(dividendo, divisor);
        }
        [TestMethod]

        //Division de dos numeros//
        public void DivisionDosNumeros()
        {
            var numero1 = 10;
            var numero2 = 1;
            var esperado = 10;

            var calculadora = new Calculadora();
            var resultado = calculadora.Dividir(numero1, numero2);

            Assert.AreEqual(esperado, resultado);
        }

        public void Scalar()
        {
            Random rnd = new Random();
            int productoEscalar = 0, n;
            Console.WriteLine("Por favor ingrese el valor de n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int[] w = new int[n];

            for (int i = 0; i < 0; i++) {
                v[i] = (int)(rnd.Next(1, 101));
                w[i] = (int)(rnd.Next(1, 101));
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + "\t");

            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(w[i] + "\t");

            }
            for (int i = 0; i < n; i++)
            {
                productoEscalar = productoEscalar + v[i] * w[i];
                Console.WriteLine("\n El producto escalar entre los dos vectores es :" + productoEscalar);
              Console.ReadKey();
            }
        }
    }
}
