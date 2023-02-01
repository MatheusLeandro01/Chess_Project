﻿namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro() { }

        public Tabuleiro(int linha, int coluna)
        {
            Linhas = linha;
            Colunas = coluna; 
            Pecas = new Peca[linha, coluna];
        }
    }
}
