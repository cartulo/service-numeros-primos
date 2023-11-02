using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace service_numeros_primos.Modelo
{
    public class Validacao
    {
        public int valorFormatado;
        public String mensagem;

        public String validar(String valor)
        {
            this.mensagem = "";

            try
            {
                this.valorFormatado = Convert.ToInt32(valor);
            }
            catch (Exception e)
            {
                this.mensagem = "Número inválido inserido";
            }

            return mensagem;
        }
    }
}