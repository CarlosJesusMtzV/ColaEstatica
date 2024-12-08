namespace ColaEstatica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] cola = new int[10];
        private int frente = -1, final = -1;

        // Operaci�n Enqueue (Insertar)
        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (final == cola.Length - 1)
            {
                MessageBox.Show("La cola est� llena.");
                return;
            }

            if (int.TryParse(txtValor.Text, out int valor))
            {
                if (frente == -1) frente = 0; // Inicializar frente si la cola estaba vac�a
                cola[++final] = valor;
                MostrarCola();
                txtValor.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor v�lido.");
            }
        }

        // Operaci�n Dequeue (Eliminar)
        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (frente == -1 || frente > final)
            {
                MessageBox.Show("La cola est� vac�a.");
                return;
            }

            MessageBox.Show($"Elemento eliminado: {cola[frente++]}");
            MostrarCola();
        }

        // Operaci�n Peek (Obtener elemento al frente)
        private void btnPeekCola_Click(object sender, EventArgs e)
        {
            if (frente == -1 || frente > final)
            {
                MessageBox.Show("La cola est� vac�a.");
                return;
            }

            MessageBox.Show($"Elemento al frente: {cola[frente]}");
        }

        // Mostrar contenido de la cola
        private void MostrarCola()
        {
            lstCola.Items.Clear();
            for (int i = frente; i <= final; i++)
            {
                lstCola.Items.Add(cola[i]);
            }
        }
    }
}
