namespace CentralTelefonicaLab.Edu.Kinal.Lab.Entities
{
    public class LlamadaLocal : Llamada
    {
        public double Precio {get;set;} = 0.25;
        public LlamadaLocal() :base()
        {

        }
        public LlamadaLocal(string numeroOrigen, string numeroDestino, double duracion)
        : base(numeroOrigen, numeroDestino, duracion)
        {

        }
        public override double CalcularPrecio()
        {
            return this.Precio * this.Duracion;
        }
        override
        public string ToString()
        {
            return $"Llamada Local - Origen: {this.NumeroOrigen} destino: {this.NumeroDestino} duración {this.Duracion}";
        }
    }
}