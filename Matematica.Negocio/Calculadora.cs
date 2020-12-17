using System.Numerics;

namespace Matematica.Negocio
{
    public class Calculadora
    {
        public Calculadora()
        {
        }
        //sumar
        public double Sumar(double primerNumero, double segundoNumero)
        {
            return primerNumero + segundoNumero;
        }
        //Suma de complejos
        public Complejo Sumar(Complejo primerComplejo, Complejo segundoComplejo)
        {
            var parteReal = primerComplejo.Real + segundoComplejo.Real;
            var parteImaginaria = primerComplejo.Imaginaria + segundoComplejo.Imaginaria;
            var nuevoComplejo = new Complejo(parteReal, parteImaginaria);

            return nuevoComplejo;
            
        }
        //Dividir
        public double Dividir(double dividendo, double divisor)
        {
            if(divisor == 0)
            {
                throw new System.ArgumentException();
            }
            return dividendo / divisor;
        }
        //resta 
        public object Restar(int primerNumero, int segundoNumero)
        {
            return primerNumero - segundoNumero;
        }
        //Resta de complejos
        public Complejo Restar(Complejo primerComplejo, Complejo segundoComplejo)
        {
            var parteReal = primerComplejo.Real - segundoComplejo.Real;
            var parteImaginaria = primerComplejo.Imaginaria - segundoComplejo.Imaginaria;
            var nuevoComplejo = new Complejo(parteReal, parteImaginaria);

            return nuevoComplejo;

        }
        //Multiplicar 
        public object Multiplicar(int primerNumero, int segundoNumero)
        {
            return primerNumero * segundoNumero;
        }
        //Multiplicacion de complejos
        public Complejo Multiplicar(Complejo primerComplejo, Complejo segundoComplejo)
        {
            var parteReal = primerComplejo.Real * segundoComplejo.Real;
            var parteImaginaria = primerComplejo.Imaginaria * segundoComplejo.Imaginaria;
            var nuevoComplejo = new Complejo(parteReal, parteImaginaria);

            return nuevoComplejo;

        }

    }
}