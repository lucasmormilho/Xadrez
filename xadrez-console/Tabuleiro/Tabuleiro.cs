﻿

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

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

    }

}
