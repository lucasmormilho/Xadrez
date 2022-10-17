﻿
namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; } //somente pela subclasse
        public int qteMovimentos { get; protected set; } //somente pela subclasse
        public Tabuleiro tab { get; protected set; } //somente pela subclasse

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0; //ja inicia em zero
        }
    }
}
