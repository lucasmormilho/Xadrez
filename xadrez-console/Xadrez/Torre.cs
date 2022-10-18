using tabuleiro;

namespace Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) // construtor para repassar para classe peça
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
