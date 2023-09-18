using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNomeProprio
{
    internal class NomeProprio
    {
        string nome_completo { get; set; }
        string[] nome_paper { get; set; }


        public NomeProprio(string nome_completo)
        {
            this.nome_completo = nome_completo;
            this.nome_paper = nome_completo.Split(' ');
        }
        public void ImprimeNomePaper()
        {
            Console.Write(nome_paper[nome_paper.Length - 1] + ", ");
            for (int i = 0; i < nome_paper.Length - 1; i++)
            {
                if ((i == nome_paper.Length - 2) & (nome_paper.Length != 2) )
                    Console.Write(nome_paper[i][0] + ".");
                else
                    Console.Write(nome_paper[i] + " ");
            }
        }


    }
}
