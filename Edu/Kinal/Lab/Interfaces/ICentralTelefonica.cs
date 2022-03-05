

using CentralTelefonicaLab.Edu.Kinal.Lab.Entities;

namespace CentralTelefonicaLab.Edu.Kinal.Lab.Interfaces
{
    public interface ICentralTelefonica
    {
        public int Contador {get;set;}
        public double Acumulador {get;set;}
        public int GetTotalLlamadas();
        public double GetTotalFacturas();
        public void RegistrarLlamada(Llamada registro);
    }
}