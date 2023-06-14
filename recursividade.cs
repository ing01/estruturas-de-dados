// Implementar código em formulário que exiba resultados para: potências, cubos, MDC, série de Fibonacci recursiva e iterativa e números inteiros para binários

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B_Potencia(object sender, EventArgs e)
        {
            int Base = Convert.ToInt32(TB_Base.Text);
            int Expoente = Convert.ToInt32(TB_Expoente.Text);
            int s = ExibePotenciaRec(Base, Expoente);
            LB_Resultados.Items.Clear();
            LB_Resultados.Items.Add(s);
            TB_Base.Focus();
            TB_Base.Clear();
            TB_Expoente.Clear();
        }

        int ExibePotenciaRec(int NB, int NumE)
        {
            if (NumE == 0)
            {
                return 1;
            }
            else
            {
                return NB * ExibePotenciaRec(NB, NumE - 1);
            }
        }

        int i = 0;
        private void B_Cubos(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(TB_nCubos.Text);
            int s = ExibeCubos(n, i);
            TB_nCubos.Clear();
            TB_nCubos.Focus();
            LB_Resultados.Items.Clear();
            LB_Resultados.Items.Add(s);
        }

        int ExibeCubos(int n, int i)
        {
            if (n > 0 && i == 0)
            {
                return ExibeCubos(n * n * n, i += 1);
            }
            else
            {
                return n;
            }
        }

        private void B_MDC(object sender, EventArgs e)
        {
            int numX = Convert.ToInt32(TB_X.Text);
            int numY = Convert.ToInt32(TB_Y.Text);
            int s = ExibeMDC(numX, numY);
            LB_Resultados.Items.Clear();
            LB_Resultados.Items.Add(s);
            TB_X.Focus();
            TB_X.Clear();
            TB_Y.Clear();
        }

        int ExibeMDC(int numX, int numY)
        {
            if (numX == numY)
            {
                return numX;
            }
            else if (numX < numY)
            {
                return ExibeMDC(numY, numX);
            }
            else
            {
                return ExibeMDC(numX - numY, numY);
            }
        }

        private void B_Fibonacci(object sender, EventArgs e)
        {
            int fib = Convert.ToInt32(TB_Fibo.Text);
            int s = ExibeFibo(fib);
            TB_Fibo.Focus();
            TB_Fibo.Clear();
            LB_Resultados.Items.Clear();
            LB_Resultados.Items.Add(s);
        }

        int ExibeFibo(int fib)
        {
            if (fib == 0 || fib == 1)
            {
                return fib;
            }
            else if (fib >= 2)
            {
                return ExibeFibo(fib - 1) + ExibeFibo(fib - 2);
            }
            else
            {
                return 404;
            }
        }

        private void B_Binario(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TB_Numero.Text);
            ExibeBin(num);
            TB_Numero.Focus();
            TB_Numero.Clear();
        }

        int ExibeBin(int num)
        {
            if (num > 0)
            {
                LB_Resultados.Items.Clear();
                ExibeBin(num / 2);
                LB_Resultados.Items.Add(num % 2);
            }
            return (num % 2);
        }

        private void B_FiboIt(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(TB_Fibo.Text);
            ExibeFiboInt(n);
            TB_Fibo.Focus();
            TB_Fibo.Clear();
        }
        void ExibeFiboInt(int n)
        {
            int num1 = 0, num2 = 1, aux;
            for (int i = 0; i < n - 1; i++)
            {
                aux = num1;
                num1 = num2;
                num2 = num1 + aux;
            }
            LB_Resultados.Items.Add(num2);
        }
    }
}
