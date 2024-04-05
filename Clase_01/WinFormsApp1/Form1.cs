using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Operacion> historial;
        
        public Form1()
        {
            InitializeComponent();
            this.historial = new List<Operacion>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelNumeroA_Click(object sender, EventArgs e)
        {

        }

        private void labelNumeroB_Click(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {

            //Captura de valores de textBox
            string sNumeroA = this.textBox1.Text;
            string sNumeroB = this.textBox2.Text;

            //Parseo a Int, ya que recibe strings
            int numeroA = int.Parse(sNumeroA);
            int numeroB = int.Parse(sNumeroB);
            char operacion = '+';

            //Almaceno el resultado de la suma de ambos numeros
            int resultado = numeroA + numeroB;

            //Transformamos resultado para mostrarlo en labelResultado
            this.labelResultado.Text = resultado.ToString();

            //asignamos los atributos del objeto operacion
            Operacion ultimaOperacion = new Operacion(numeroA, numeroB, operacion, resultado);

            this.historial.Add(ultimaOperacion);

            //mostramos historial en el dataGridView
            this.historialDataGridView.DataSource = null;
            this.historialDataGridView.DataSource = this.historial;


        }

    }
}
