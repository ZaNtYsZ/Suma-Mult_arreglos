using Ejercicio_1.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Ejercicio_1
{
    public partial class PrincipalForm : Form
    {
        private LanzadorDados lanzador;

        public PrincipalForm()
        {
            InitializeComponent();
            lanzador = new LanzadorDados(); // Inicializa la clase LanzadorDados
        }

        // Método que se ejecuta cuando el usuario presiona el botón "Ejecutar Lanzamiento"
        private void btnLanzar_Click(object sender, EventArgs e)
        {
            // Ejecuta el lanzamiento
            var (primerDado, segundoDado, resultadoSuma) = lanzador.Lanzar();

            // Actualiza las etiquetas con los resultados
            lblPrimerDado.Text = $"Dado 1: {primerDado}";
            lblSegundoDado.Text = $"Dado 2: {segundoDado}";
            lblResultado.Text = $"Suma: {resultadoSuma}";

            // Mostrar el conteo acumulado de resultados
            MostrarSumaAcumulada();
        }

        // Método para mostrar el conteo acumulado de los resultados
        private void MostrarSumaAcumulada()
        {
            int[] sumaAcumulada = lanzador.ObtenerSumaAcumulada();

            // Limpiar el ListBox antes de mostrar los conteos actualizados
            lstResultadoSuma.Items.Clear();
            lstResultadoSuma.Items.Add("Suma\tConteo");

            for (int i = 0; i < sumaAcumulada.Length; i++)
            {
                int suma = i + 2;
                int conteo = sumaAcumulada[i];
                lstResultadoSuma.Items.Add($"{suma}\t{conteo}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
