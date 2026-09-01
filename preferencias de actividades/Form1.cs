namespace preferencias_de_actividades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonmostrarresumen_Click(object sender, EventArgs e)
        {
            //1.-validar el nombre
            if (string.IsNullOrEmpty(textBoxnombre.Text))
            {
                MessageBox.Show(
                    "Por favor, escribe tu nombre.",
                    "Validación de nombre",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtnombre.Focus();
            }
            //2- obtener las actividades seleccionadas
            List<string> groupBoxactividades = new List<string>();
            if (deportes.Checked)
            {
                groupBoxactividades.Add("Deportes");
            }
            if (checkBoxmusica.Checked)
            {
                groupBoxactividades.Add("Música");
            }
            if (checkBoxarte.Checked)
            {
                groupBoxactividades.Add("Arte");
            }
            if (checkBoxprogramacion.Checked)
            {
                groupBoxactividades.Add("Programación");
            }
            if (checkBoxlectura.Checked)
            {
                groupBoxactividades.Add("Lectura");
            }
            //al menos una actividad
            if (groupBoxactividades.Count == 0)
            {
                MessageBox.Show(
                    "Por favor, selecciona al menos una actividad.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            //4.- obtener modalidad seleccionada
            string modalidad = "";
            if (radioButtonpresencial.Checked)
            {
                modalidad = "Presencial";
            }
            else if (radioButtonlinea.Checked)
            {
                modalidad = "Virtual";
            }
            else if (radioButtonhibrida.Checked)
            {
                modalidad = "Híbrida";
            }
            else
            {
                MessageBox.Show(
                    "Por favor, selecciona una modalidad.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            //5.- mostrar resumen
            string resumen =
                "Resumen de preferencias\r\n" +
                "__________________________\r\n" +
                "Nombre: " + textBoxnombre.Text + "\r\n" +
                "Actividades: " + string.Join(", ", groupBoxactividades) + "\r\n" +
                "Modalidad: " + modalidad;
            textBoxresumen.Text = resumen;
        }

        private void buttonlimpiar_Click(object sender, EventArgs e)
        {
            //limpiar nombre 
            textBoxnombre.Clear();
            //limpiar actividades
            deportes.Checked = false;
            checkBoxmusica.Checked = false;
            checkBoxarte.Checked = false;
            checkBoxprogramacion.Checked = false;
            checkBoxlectura.Checked = false;
            //limpiar modalidad
            radioButtonpresencial.Checked = false;
            radioButtonlinea.Checked = false;
            radioButtonhibrida.Checked = false;
            //limpiar resumen
            textBoxresumen.Clear();
        }
    }
}           



