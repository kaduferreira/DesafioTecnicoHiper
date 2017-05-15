using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnicoHiperClassLibrary
{
    public class Bussola
    {
        private ArrayList Seq = new ArrayList() { "N", "L", "S", "O" };

        private string Ponteiro { get; set; } = "N";
        private string Resultado { get; set; }

        /// <summary>
        /// Vira para a direita e retorna a nova posição.
        /// </summary>
        private void VirarParaDireita()
        {
            int localizacao = Seq.LastIndexOf(Ponteiro);

            if (localizacao + 1 == Seq.Count)
                Ponteiro = Seq[0].ToString();
            else
                Ponteiro = Seq[localizacao + 1].ToString();

            Resultado += Ponteiro;
        }

        /// <summary>
        /// Vira para a esquerda e retorna a nova posição.
        /// </summary>
        private void VirarParaEsquerda()
        {
            int localizacao = Seq.LastIndexOf(Ponteiro);

            if (localizacao == 0)
                Ponteiro = Seq[3].ToString();
            else
                Ponteiro = Seq[localizacao - 1].ToString();

            Resultado += Ponteiro;
        }


        public string DefineOrientacao(string sequencia)
        {
            foreach (var letra in sequencia.ToCharArray())
            {
                if(letra.ToString() == "D")
                {
                    VirarParaDireita();
                }
                else if (letra.ToString() == "E")
                {
                    VirarParaEsquerda();
                }
            }

            return Resultado;
        }
    }
}