using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARRO.Clases
{
    class ClsAutomotor
    {

        public string marca { get; }
        public int vel_max { get; }
        public string color { get; set; }
        private int velocidadActual = 0;
        public bool encendido { get; set; } = false;


        public ClsAutomotor(string marcaCarro, int maxVel)
        {
            this.vel_max = maxVel;
            this.marca = marcaCarro;
        }


        public string encender()
        {
            string respuesta = "";
            if (encendido)
            {

                encendido = false;

                respuesta = "Apagado";
            }
            else
            {
                
                encendido = true;
                respuesta = "Encendido";
            }
            velocidadActual = 0;
            return respuesta;
        }

        public string DeterMarcha()
        {
          
            if (velocidadActual > 0)
            {
                velocidadActual = velocidadActual - 5;
                return $"Vas a {velocidadActual} KPH";
            }
            else
            {
                velocidadActual = 0;
                return $"Vas a {velocidadActual} KPH";
            }

        }

        public string Acelerar()
        {
          
            if (velocidadActual > vel_max)
            {
                velocidadActual = vel_max;
                return $"Ha llegado a la velocidad maxima: {vel_max} KPH";

            }
            else
            {
                velocidadActual = velocidadActual + 5;
                return $"Vas a {velocidadActual} KPH";
            }

        }

        public string Sugcambio()
        {
            if (velocidadActual < 10)
            {
                return " ";
            }
            else if (velocidadActual >= 10 && velocidadActual <=29 )
            {
                return "Coloque 2 marcha";
            }
            else if(velocidadActual >=30  && velocidadActual <= 39)
            {
                return "Coloque 3 marcha";
            }
            else if (velocidadActual >=40 && velocidadActual <=  49)
            {
                return "Coloque 4 marcha";
            }
            else
            {
                return "Coloque 5 marcha";
            }
            
        }

        public bool cambio()
        {
            if (velocidadActual == 10)
            {
                return true;
               
            }
            else if (velocidadActual == 30)
            {
                return true;

            }
            else if (velocidadActual == 40)
            {
                return true;

            }
            else if (velocidadActual == 50)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public bool ApaEncen()
        {
            if (velocidadActual == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
