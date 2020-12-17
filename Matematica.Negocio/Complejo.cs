namespace Matematica.Negocio
{
    public class Complejo
    {
        

        public Complejo(double real, double imaginaria)
        {
            Real = real;
            Imaginaria = imaginaria;
           
        }

        public double Imaginaria { get; internal set; }
        public double Real { get; internal set; }
    }
}