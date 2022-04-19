using SistemaGestionEstudiantil;
namespace InterfazGrafica
{
    public partial class Form1 : Form
    {
        List<Estudiante> ListEstudiantes = new List<Estudiante>();
        private int IndiceBanda;
        private bool eliminado;
        public Form1()
        {
            InitializeComponent();
            IndiceBanda = 0;
            eliminado = false;
            Estudiante estudiante1 = new Estudiante("1039082377", "M", "Jhon", "4", "4.2", "Medallo", "José", "71980", "M", "321323112", "Padre");
            Estudiante estudiante2 = new Estudiante("103908212", "F", "maria", "6", "4.7", "Medallo", "Marta", "43434342", "F", "343421112", "Hermana");
            ListEstudiantes.Add(estudiante1);
            ListEstudiantes.Add(estudiante2);
            lstLista_estudiantes.Items.Add(estudiante1.Id);
            lstLista_estudiantes.Items.Add(estudiante2.Id);
            grbModificar.Visible = false;

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
                lstLista_estudiantes.Items.Add(nuevoEstudiante.Id);

                lblDebugger.Text = "Felicidades Se Matriculó el estudiante de manera exitosa!!";
                resetForm();
                timer1.Start();

            }
            else
            {
                MensajeError();
            }

        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            grbMatricular.Visible = true;
            grbModificar.Visible = false;    
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

        private void resetFormModificar()
        {
            txtModificarNombre.Clear();
            txtModificarPromedio.Clear();
            txtModificarSexo.Clear();
            txtModificarDirección.Clear();
            txtModificarGrado.Clear();
            txtModificarID.Clear();
            txtModificarContactoAcudiente.Clear();
            txtModificarIdAcudiente.Clear();
            txtModificarNombreAcudiente.Clear();
            txtModificarParentezcoAcudiente.Clear();
            txtModificarSexoAcudiente.Clear();
            eliminado = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetForm();
            txtNameEstudiante.Focus();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDebugger.Text = "";
        }

        private void txtIdEstudiante_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtIdEstudiante_Click(object sender, EventArgs e)
        {

        }

        private void grbMatricular_Enter(object sender, EventArgs e)
        {

        }

        private void lstLista_estudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {   
            if (!eliminado)
            {
                grbModificar2.Enabled = true;
                grbModificar2.Visible = true;
                btnModificarGuardar.Enabled = true;
                btnModificarCancelar.Enabled = true;
                btnModificarEliminar.Enabled = true;

                int IndiceEstudiante = lstLista_estudiantes.SelectedIndex;

                txtModificarNombre.Text = ListEstudiantes[IndiceEstudiante].Nombre;
                txtModificarID.Text = ListEstudiantes[IndiceEstudiante].Id;
                txtModificarGrado.Text = ListEstudiantes[IndiceEstudiante].GradoAcursar;
                txtModificarDirección.Text = ListEstudiantes[IndiceEstudiante].Direccion;
                txtModificarSexo.Text = ListEstudiantes[IndiceEstudiante].Sexo;
                txtModificarPromedio.Text = ListEstudiantes[IndiceEstudiante].Promedio;
                txtModificarNombreAcudiente.Text = ListEstudiantes[IndiceEstudiante].NombreAcudiente;
                txtModificarParentezcoAcudiente.Text = ListEstudiantes[IndiceEstudiante].ParentezcoAcudiente;
                txtModificarSexoAcudiente.Text = ListEstudiantes[IndiceEstudiante].SexoAcudiente;
                txtModificarIdAcudiente.Text = ListEstudiantes[IndiceEstudiante].IdAcudiente;
                txtModificarContactoAcudiente.Text = ListEstudiantes[IndiceEstudiante].ContactoAcudiente;
                
            }
            


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            grbModificar.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarGuardar_Click(object sender, EventArgs e)
        {
            if (txtModificarNombre.Text != "" && txtModificarID.Text != "" && txtModificarDirección.Text != "" &&
                txtModificarGrado.Text != "" && txtModificarIdAcudiente.Text != "" && txtModificarSexo.Text != ""
                && txtModificarPromedio.Text != "" && txtModificarSexoAcudiente.Text != "" && txtModificarParentezcoAcudiente.Text != "" &&
                txtModificarNombreAcudiente.Text != "" && txtModificarContactoAcudiente.Text != "")
            {
                int IndiceEstudiante = lstLista_estudiantes.SelectedIndex;
                ListEstudiantes[IndiceEstudiante].Nombre = txtModificarNombre.Text;
                ListEstudiantes[IndiceEstudiante].Id = txtModificarID.Text;
                ListEstudiantes[IndiceEstudiante].GradoAcursar = txtModificarGrado.Text;
                ListEstudiantes[IndiceEstudiante].Direccion = txtModificarDirección.Text;
                ListEstudiantes[IndiceEstudiante].Sexo = txtModificarSexo.Text;
                ListEstudiantes[IndiceEstudiante].Promedio = txtModificarPromedio.Text;
                ListEstudiantes[IndiceEstudiante].NombreAcudiente = txtModificarNombreAcudiente.Text;
                ListEstudiantes[IndiceEstudiante].ParentezcoAcudiente = txtModificarParentezcoAcudiente.Text;
                ListEstudiantes[IndiceEstudiante].SexoAcudiente = txtModificarSexoAcudiente.Text;
                ListEstudiantes[IndiceEstudiante].IdAcudiente = txtModificarIdAcudiente.Text;
                ListEstudiantes[IndiceEstudiante].ContactoAcudiente = txtModificarContactoAcudiente.Text;

                lstLista_estudiantes.Items[IndiceEstudiante] = txtModificarID.Text;

                string Advertencia = "Información Actualizada correctamente";
                string Titular = "Actualizado";
                MessageBox.Show(Advertencia, Titular);

            }
            else
            {
                MensajeError();
            }
        }


        private void MensajeError()
        {
            string Advertencia = "Por favor diligenciar los campos faltantes";
            string Titular = "Campos Vacios";
            MessageBox.Show(Advertencia, Titular);
        }
        private void txtModificarNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarEliminar_Click(object sender, EventArgs e)
        {
            eliminado = true;
            int IndiceEstudiante = lstLista_estudiantes.SelectedIndex;
            lstLista_estudiantes.Items.RemoveAt(IndiceEstudiante);
            ListEstudiantes.RemoveAt(IndiceEstudiante);
            resetFormModificar();
            
        }

        private void btnModificarCancelar_Click(object sender, EventArgs e)
        {
            int IndiceEstudiante = lstLista_estudiantes.SelectedIndex;
            txtModificarNombre.Text = ListEstudiantes[IndiceEstudiante].Nombre;
            txtModificarID.Text =  ListEstudiantes[IndiceEstudiante].Id;
            txtModificarGrado.Text = ListEstudiantes[IndiceEstudiante].GradoAcursar;
            txtModificarDirección.Text = ListEstudiantes[IndiceEstudiante].Direccion;
            txtModificarSexo.Text = ListEstudiantes[IndiceEstudiante].Sexo;
            txtModificarPromedio.Text = ListEstudiantes[IndiceEstudiante].Promedio;
            txtModificarNombreAcudiente.Text = ListEstudiantes[IndiceEstudiante].NombreAcudiente;
            txtModificarParentezcoAcudiente.Text = ListEstudiantes[IndiceEstudiante].ParentezcoAcudiente;
            txtModificarSexoAcudiente.Text = ListEstudiantes[IndiceEstudiante].SexoAcudiente;
            txtModificarIdAcudiente.Text = ListEstudiantes[IndiceEstudiante].IdAcudiente;
            txtModificarContactoAcudiente.Text = ListEstudiantes[IndiceEstudiante].ContactoAcudiente;

            // txtModificarNombre.Focus();
        }
    }
}