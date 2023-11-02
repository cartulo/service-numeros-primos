using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace service_numeros_primos.Modelo
{
    public class Negocio
    {
        public String verificarNumeroPrimo(int numero)
        {
            String resposta = "É primo";

            // https://imasters.com.br/c-sharp/c-verificando-se-um-numero-e-primo
            for (int divisor = 2; divisor <= Math.Sqrt(numero); divisor++)
            {
                if (numero % divisor == 0)
                {
                    resposta = "Não é primo";
                    break;
                }
            }

            return resposta;
        }
    }
}