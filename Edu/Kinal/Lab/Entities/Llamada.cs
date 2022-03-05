using CentralTelefonicaLab.Edu.Kinal.Lab.Interfaces;

namespace CentralTelefonicaLab.Edu.Kinal.Lab.Entities
{
    public abstract class Llamada: ICentralTelefonica
    {
        private int contador;
        private double acumulador;
        public string NumeroOrigen { get; set; }
        public string NumeroDestino { get; set; }
        public double Duracion { get; set; }
        public int Contador 
        { 
            get 
            { 
                return this.contador; 
            }  
            set 
            { 
                this.contador = this.contador + value; 
            } 
        }  
        public double Acumulador 
        { 
            get
            {
                return this.acumulador;
            }  
            set 
            {
                this.acumulador = this.acumulador + value;
            }  
        }

        public abstract double CalcularPrecio();

        public int GetTotalLlamadas()
        {
            return this.Contador;
        }

        public double GetTotalFacturas()
        {
            return this.Acumulador;
        }

        public void RegistrarLlamada(Llamada registro)
        {
            Console.WriteLine(registro);
            this.Contador = 1;
            this.Acumulador = registro.CalcularPrecio();
        }

        public Llamada()
        {
            Console.WriteLine("Iniciando central telefonica");    
        }
        public Llamada(string numeroOrigen, string numeroDestino, double duracion)
        {
            this.NumeroOrigen = numeroOrigen;
            this.NumeroDestino = numeroDestino;
            this.Duracion = duracion;
        }

        public Llamada(string numeroOrigen, string numeroDestino)
        {
            this.NumeroOrigen = numeroOrigen;
            this.NumeroDestino = numeroDestino;
        }

    }
}

