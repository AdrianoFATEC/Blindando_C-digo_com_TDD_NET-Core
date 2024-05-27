using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int somar(int v1, int v2)
        {
            int resultado = v1 + v2;
            listaHistorico.Insert(0, "Resultado: " + resultado + " Data: " + data);
            return resultado;
        }
        
        public int subtrair(int v1, int v2)
        {
            int resultado = v1 - v2;
            listaHistorico.Insert(0, "Resultado: " + resultado + " Data: " + data);
            return resultado;
        }

        public int multiplicar(int v1, int v2)
        {
            int resultado = v1 * v2;
            listaHistorico.Insert(0, "Resultado: " + resultado + " Data: " + data);
            return resultado;
        }

        public int dividir(int v1, int v2)
        {
            int resultado = v1 / v2;
            listaHistorico.Insert(0, "Resultado: " + resultado + " Data: " + data);
            return resultado;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        } 
    }
}
