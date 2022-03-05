namespace CentralTelefonicaLab.Edu.Kinal.Lab.Entities
{
    public class LlamadaInterior : Llamada
    {
        public double PrecioUno {get;set;} = 0.2;
        public double PrecioDos {get;set;} = 0.35;
        public double PrecioTres {get;set;} = 0.85;
        public int Franja {get;set;}
        public LlamadaInterior() : base()
        {            
        }
        public LlamadaInterior(string numeroOrigen, string numeroDestino, double duracion, int franja)
        : base(numeroOrigen, numeroDestino, duracion)
        {
            this.Franja = franja;
        }
        override
        public string ToString()
        {
            return $"Llamada del interior - Origen: {this.NumeroOrigen} destino: {this.NumeroDestino} duración {this.Duracion}";
        }
        public override double CalcularPrecio()
        {
            double calculo = 0;
            if(this.Franja == 1)
            {
                calculo = this.Duracion * this.PrecioUno;
            }
            else if(this.Franja == 2)
            {
                calculo = this.Duracion * this.PrecioDos;
            }
            else if(this.Franja == 3)
            {
                calculo = this.Duracion * this.PrecioTres;
            }
            return calculo;
        }
    }
}