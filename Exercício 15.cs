/* Simulação de sistema de controle de uma pista de decolagem de aviões. Inserindo número de avião e exibindo: quantidade na fila, decolagem autorizada, primeiro da fila e
lista de todos na fila */

namespace Exercicio15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int MAX = 50;
        class LLS_Fila
        {
            public int inicio = 0;
            public int fim = 0;
            public int[] vetor = new int[MAX];
        }
        bool EstaVazia(LLS_Fila f)
        {
            if (f.inicio == f.fim)
                return true;
            else
                return false;
        }
        bool EstaCheia(LLS_Fila f)
        {
            if (f.fim == MAX)
                return true;
            else
                return false;
        }
        void Insere(LLS_Fila f, int valor)
        {
            f.vetor[f.fim] = valor;
            f.fim = f.fim + 1;
        }
        int Remove(LLS_Fila f)
        {
            int valor = f.vetor[f.inicio];
            f.inicio = f.inicio + 1;
            return valor;
        }

        LLS_Fila fila = new LLS_Fila();

        private void B_Adiciona_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(TB_NumAviao.Text);
            if (!EstaCheia(fila))
                Insere(fila, n);
            else
                MessageBox.Show("Fila cheia!");

            TB_NumAviao.Clear();
            TB_NumAviao.Focus();
        }

        int QtdVlrFila(LLS_Fila f)
        {
            return (f.fim - f.inicio);
        }

        private void B_Quantidade_Click(object sender, EventArgs e)
        {
            int qtd = QtdVlrFila(fila);
            TB_QtdFila.Text = Convert.ToString(qtd);
        }

        private void B_Autoriza_Click(object sender, EventArgs e)
        {
            if (!EstaVazia(fila))
            {
                int n = Remove(fila);
                TB_AviaoDecolou.Text = Convert.ToString(n);
            }
            else
                MessageBox.Show("Fila vazia!");
        }

        int PrimeiroDaFila(LLS_Fila f)
        {
            return (f.vetor[f.inicio]);
        }

        private void B_Primeiro_Click(object sender, EventArgs e)
        {
            TB_PrimFila.Text = Convert.ToString(PrimeiroDaFila(fila));
        }

        private void B_Avioes_Click(object sender, EventArgs e)
        {
            int i;
            LB_Avioes.Items.Clear();
            for (i = fila.inicio; i <= fila.fim - 1; i++)
            {
                LB_Avioes.Items.Add(fila.vetor[i]);
            }
        }
    }
}
