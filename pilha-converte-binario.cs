// Algoritmo que converte um número inteiro da base decimal para a base binária.

namespace exercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int MAX = 50;
        class LLS_Pilha
        {
            public int topo = 0;
            public int[] vetor = new int[MAX];
        }
        bool EstaVazia(LLS_Pilha p)
        {
            if (p.topo == 0)
                return true;
            else
                return false;
        }
        bool EstaCheia(LLS_Pilha p)
        {
            if (p.topo == MAX)
                return true;
            else
                return false;
        }
        void Insere(LLS_Pilha p, int valor)
        {
            p.vetor[p.topo] = valor;
            p.topo = p.topo + 1;
        }
        int Remove(LLS_Pilha p)
        {
            p.topo = p.topo - 1;
            return (p.vetor[p.topo]);
        }

        LLS_Pilha pilha = new LLS_Pilha();

        private void B_Processa_Click(object sender, EventArgs e)
        {
            int NumInt = Convert.ToInt32(TB_NumInt.Text);
            while (NumInt > 0)
            {
                Insere(pilha, NumInt % 2);
                NumInt = NumInt / 2;
            }
            int resto;
            string NumBin = "";
            while (EstaVazia(pilha) == false)
            {
                resto = Remove(pilha);
                NumBin = NumBin + Convert.ToString(resto);
            }
            TB_NumBin.Text = NumBin;
        }
    }
}
