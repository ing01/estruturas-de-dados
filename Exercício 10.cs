// Programa para reconhecer uma frase e exibi-la com as palavras invertidas.

namespace WindowsFormsApp2
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
            public char[] vetor;
        }

        void Inicializar(ref LLS_Pilha p)
        {
            p.topo = -1;
            p.vetor = new char[MAX];
        }
        bool EstaVazia(LLS_Pilha p)
        {
           return (p.topo == -1);
        }

        bool EstaCheia(LLS_Pilha p)
        {
            return (p.topo == MAX - 1);
        }

        void Insere(ref LLS_Pilha p, char valor)
        {
            p.vetor[++p.topo] = valor;
        }

        char Remove(ref LLS_Pilha p)
        {
            return (p.vetor[p.topo--]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fraseOr = TB_O.Text + "", textoI = "";
            int i = 0;

            while (i < fraseOr.Length)
            {
                if (fraseOr[i] == 32)
                {
                    while (!EstaVazia(p))
                    {
                        textoI += Remove(ref p);
                    }
                    textoI += "";
                }
                else
                {
                    Insere(ref p, fraseOr[i]);
                }
                i++;
            }
            TB_I.Text = textoI;
        }
    }
}
 
