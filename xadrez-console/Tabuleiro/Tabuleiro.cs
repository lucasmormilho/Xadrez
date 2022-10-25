

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;//matriz de peças

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas]; //recebe a matriz
        }


        public Peca peca(int linha, int coluna) //operação que acessa a peça pois ela é private
        {
            return pecas[linha, coluna];
        }

        //melhorias
        //sobrecarga do metodo peça
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public void colocarPeca(Peca p, Posicao pos) 
        {
            if (existePeca(pos))//só posso colocar aonde não tenha nenhuma peça
            {
                throw new TabuleiroExceptions("Já existe uma peça nessa posição!");
            }
            
            pecas[pos.linha, pos.coluna] = p; //jogando peça P na matriz nessa posição
            p.posicao = pos;
        }

        //tratamento para excessão
        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas  || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        //tratamento para excessão
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroExceptions("Posição invalida!");
            }
        }

        //tratamento para excessão
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos); //valida primeiro a posição (exceção da exceção)
            return peca(pos) != null;

        }

    }

}
