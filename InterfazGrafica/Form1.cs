using SistemaGestionEstudiantil;
namespace InterfazGrafica
{
    public partial class Form1 : Form
    {
        List<Estudiante> ListEstudiantes = new List<Estudiante>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Estudiante nuevoEstudiante = new Estudiante();
            if (txtIdEstudiante.Text != "" && txtSexoEstudiante.Text != "" && txtNameEstudiante.Text != "" &&
                txtGradoEstudiante.Text != "" && txtPromedioEstudiante.Text != "" && txtDireccionEstudiante.Text != ""
                && txtNameAcudiente.Text != "" && txtIdAcudiente.Text != "" && txtSexoAcudiente.Text != "" &&
                txtContactoAcudiente.Text != "" && txtParentezcoAcudiente.Text != "")
            {
                nuevoEstudiante.matricularUnEstudiante(txtIdEstudiante.Text, txtSexoEstudiante.Text,
                txtNameEstudiante.Text, txtGradoEstudiante.Text, txtPromedioEstudiante.Text,
                txtDireccionEstudiante.Text, txtNameAcudiente.Text, txtIdAcudiente.Text, txtSexoAcudiente.Text,
                txtContactoAcudiente.Text, txtParentezcoAcudiente.Text);

                ListEstudiantes.Add(nuevoEstudiante);

                lblDebugger.Text = "Felicidades Se Matriculó el estudiante de manera exitosa!!" + nuevoEstudiante.Nombre;

            }
            else
            {
                string Advertencia = "Por favor diligenciar los campos faltantes";
                string Titular = "Campos Vacios";
                MessageBox.Show(Advertencia, Titular);
            }

        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            grbMatricular.Visible = true;
            txtNameEstudiante.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void resetForm()
        {
            txtIdEstudiante.Clear();
            txtSexoEstudiante.Clear();
            txtNameEstudiante.Clear();
            txtGradoEstudiante.Clear();
            txtPromedioEstudiante.Clear();
            txtDireccionEstudiante.Clear();
            txtNameAcudiente.Clear();
            txtIdAcudiente.Clear();
            txtSexoAcudiente.Clear();
            txtContactoAcudiente.Clear();
            txtParentezcoAcudiente.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetForm();
            txtNameEstudiante.Focus();

        }
    }
}