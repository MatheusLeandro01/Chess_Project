namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; } //lembrando que utilizando a restrição protected, apenas as subclasses de peca(e a propria clase peca) porderão utilizar essa propriedade;
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca() { }
        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            Posicao = posicao;
            Cor = cor;
            QteMovimentos = 0; //irá se iniciar em 0;
            Tab = tab;
        }
    }
}
