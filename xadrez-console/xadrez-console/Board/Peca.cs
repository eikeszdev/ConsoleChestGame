using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez_console.Board;

namespace Board
{
    internal class Peca
    {
        public Position position { get; set; }
        public Cor cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro tabuleiro{ get; protected set; }

        public Peca() { }
        
        public Peca(Position posicao, Tabuleiro tab, int qteMovimentos, Cor cor)
        {
            this.position = posicao;
            this.tabuleiro = tab;
            this.cor = cor;
            this.QteMovimentos = qteMovimentos;
        }
    }
}
