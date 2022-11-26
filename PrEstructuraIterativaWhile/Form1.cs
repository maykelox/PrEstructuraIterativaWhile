namespace PrEstructuraIterativaWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            int stock;
            int cantpersonas, cantentregada;

            // Entrada de datos

            stock = Convert.ToInt32(txtStockInicial.Text);
            cantpersonas = 0;

            //Empezamos a repartir vacunas

            while(stock >= 10)
            {
                cantentregada = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese cantidad entregada" + (cantpersonas+1), "Reparto de vacunas"));

                //Validad cantidad entregadas sea menor o igual que la cantidad entregada

                if (stock >= cantentregada)
                {
                    cantpersonas = cantpersonas + 1;
                    stock = stock - cantentregada;

                }
                else
                {
                    MessageBox.Show("No hay suficiente stock", "Reparto de vacunas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            MessageBox.Show("El stock es inferior a 10 units", "Reparto De Vacunas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Salida de informacion

            txtStock.Text = Convert.ToString(stock);
            txtCantidadPersonas.Text = Convert.ToString(cantpersonas);



        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtStockInicial.Clear();
            txtStock.Clear();
            txtCantidadPersonas.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}