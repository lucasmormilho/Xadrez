
using tabuleiro;

namespace Xadrez
{
    class Rei : Peca //superclasse peça
    {
        public Rei(Tabuleiro tab, Cor cor): base(tab,cor) // construtor para repassar para classe peça
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
