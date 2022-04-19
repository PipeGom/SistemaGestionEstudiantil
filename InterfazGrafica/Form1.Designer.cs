namespace InterfazGrafica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnMatricular = new System.Windows.Forms.Button();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lbltitle3 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblNameEstudiante = new System.Windows.Forms.Label();
            this.lblDireccionEstudiante = new System.Windows.Forms.Label();
            this.lblIdEstudiante = new System.Windows.Forms.Label();
            this.lblGradoEstudiante = new System.Windows.Forms.Label();
            this.lblSexoEstudiante = new System.Windows.Forms.Label();
            this.lblPromedioEstudiante = new System.Windows.Forms.Label();
            this.lblParentezcoAcudiente = new System.Windows.Forms.Label();
            this.lblContactoAcudiente = new System.Windows.Forms.Label();
            this.lblSexoAcudiente = new System.Windows.Forms.Label();
            this.lblIdAcudiente = new System.Windows.Forms.Label();
            this.lblNameAcudiente = new System.Windows.Forms.Label();
            this.txtNameEstudiante = new System.Windows.Forms.TextBox();
            this.txtParentezcoAcudiente = new System.Windows.Forms.TextBox();
            this.txtContactoAcudiente = new System.Windows.Forms.TextBox();
            this.txtSexoAcudiente = new System.Windows.Forms.TextBox();
            this.txtIdAcudiente = new System.Windows.Forms.TextBox();
            this.txtPromedioEstudiante = new System.Windows.Forms.TextBox();
            this.txtDireccionEstudiante = new System.Windows.Forms.TextBox();
            this.txtGradoEstudiante = new System.Windows.Forms.TextBox();
            this.txtSexoEstudiante = new System.Windows.Forms.TextBox();
            this.txtIdEstudiante = new System.Windows.Forms.TextBox();
            this.txtNameAcudiente = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblDebugger = new System.Windows.Forms.Label();
            this.grbMatricular = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.grbModificar = new System.Windows.Forms.GroupBox();
            this.grbModificar2 = new System.Windows.Forms.GroupBox();
            this.btnModificarEliminar = new System.Windows.Forms.Button();
            this.btnModificarCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModificarGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModificarParentezcoAcudiente = new System.Windows.Forms.TextBox();
            this.txtModificarContactoAcudiente = new System.Windows.Forms.TextBox();
            this.txtModificarSexoAcudiente = new System.Windows.Forms.TextBox();
            this.txtModificarIdAcudiente = new System.Windows.Forms.TextBox();
            this.txtModificarNombreAcudiente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModificarPromedio = new System.Windows.Forms.TextBox();
            this.txtModificarDirección = new System.Windows.Forms.TextBox();
            this.txtModificarGrado = new System.Windows.Forms.TextBox();
            this.txtModificarSexo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtModificarID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtModificarNombre = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLista_estudiantes = new System.Windows.Forms.ListBox();
            this.grbMatricular.SuspendLayout();
            this.grbModificar.SuspendLayout();
            this.grbModificar2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMatricular
            // 
            this.btnMatricular.Location = new System.Drawing.Point(42, 52);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(94, 29);
            this.btnMatricular.TabIndex = 0;
            this.btnMatricular.Text = "Matricular";
            this.btnMatricular.UseVisualStyleBackColor = true;
            this.btnMatricular.Click += new System.EventHandler(this.btnMatricular_Click);
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Location = new System.Drawing.Point(10, 42);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(296, 20);
            this.lblTitle1.TabIndex = 1;
            this.lblTitle1.Text = "Ingrese los siguientes datos del estudiante :";
            // 
            // lbltitle3
            // 
            this.lbltitle3.AutoSize = true;
            this.lbltitle3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbltitle3.Location = new System.Drawing.Point(57, 455);
            this.lbltitle3.Name = "lbltitle3";
            this.lbltitle3.Size = new System.Drawing.Size(420, 20);
            this.lbltitle3.TabIndex = 2;
            this.lbltitle3.Text = "*La información aquí suministrada será para uso interno.";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Location = new System.Drawing.Point(423, 42);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(296, 20);
            this.lblTitle2.TabIndex = 3;
            this.lblTitle2.Text = "Ingrese los siguientes datos del acudiente : ";
            this.lblTitle2.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNameEstudiante
            // 
            this.lblNameEstudiante.AutoSize = true;
            this.lblNameEstudiante.Location = new System.Drawing.Point(57, 107);
            this.lblNameEstudiante.Name = "lblNameEstudiante";
            this.lblNameEstudiante.Size = new System.Drawing.Size(71, 20);
            this.lblNameEstudiante.TabIndex = 4;
            this.lblNameEstudiante.Text = "Nombre :";
            // 
            // lblDireccionEstudiante
            // 
            this.lblDireccionEstudiante.AutoSize = true;
            this.lblDireccionEstudiante.Location = new System.Drawing.Point(57, 258);
            this.lblDireccionEstudiante.Name = "lblDireccionEstudiante";
            this.lblDireccionEstudiante.Size = new System.Drawing.Size(79, 20);
            this.lblDireccionEstudiante.TabIndex = 5;
            this.lblDireccionEstudiante.Text = "Dirección :";
            this.lblDireccionEstudiante.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblIdEstudiante
            // 
            this.lblIdEstudiante.AutoSize = true;
            this.lblIdEstudiante.Location = new System.Drawing.Point(57, 140);
            this.lblIdEstudiante.Name = "lblIdEstudiante";
            this.lblIdEstudiante.Size = new System.Drawing.Size(33, 20);
            this.lblIdEstudiante.TabIndex = 6;
            this.lblIdEstudiante.Text = "Id : ";
            this.lblIdEstudiante.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblGradoEstudiante
            // 
            this.lblGradoEstudiante.AutoSize = true;
            this.lblGradoEstudiante.Location = new System.Drawing.Point(57, 217);
            this.lblGradoEstudiante.Name = "lblGradoEstudiante";
            this.lblGradoEstudiante.Size = new System.Drawing.Size(112, 20);
            this.lblGradoEstudiante.TabIndex = 7;
            this.lblGradoEstudiante.Text = "Grado a cursar :";
            // 
            // lblSexoEstudiante
            // 
            this.lblSexoEstudiante.AutoSize = true;
            this.lblSexoEstudiante.Location = new System.Drawing.Point(57, 177);
            this.lblSexoEstudiante.Name = "lblSexoEstudiante";
            this.lblSexoEstudiante.Size = new System.Drawing.Size(48, 20);
            this.lblSexoEstudiante.TabIndex = 8;
            this.lblSexoEstudiante.Text = "Sexo :";
            // 
            // lblPromedioEstudiante
            // 
            this.lblPromedioEstudiante.AutoSize = true;
            this.lblPromedioEstudiante.Location = new System.Drawing.Point(57, 301);
            this.lblPromedioEstudiante.Name = "lblPromedioEstudiante";
            this.lblPromedioEstudiante.Size = new System.Drawing.Size(81, 20);
            this.lblPromedioEstudiante.TabIndex = 9;
            this.lblPromedioEstudiante.Text = "Promedio :";
            this.lblPromedioEstudiante.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblParentezcoAcudiente
            // 
            this.lblParentezcoAcudiente.AutoSize = true;
            this.lblParentezcoAcudiente.Location = new System.Drawing.Point(423, 258);
            this.lblParentezcoAcudiente.Name = "lblParentezcoAcudiente";
            this.lblParentezcoAcudiente.Size = new System.Drawing.Size(88, 20);
            this.lblParentezcoAcudiente.TabIndex = 10;
            this.lblParentezcoAcudiente.Text = "Parentezco :";
            // 
            // lblContactoAcudiente
            // 
            this.lblContactoAcudiente.AutoSize = true;
            this.lblContactoAcudiente.Location = new System.Drawing.Point(423, 217);
            this.lblContactoAcudiente.Name = "lblContactoAcudiente";
            this.lblContactoAcudiente.Size = new System.Drawing.Size(76, 20);
            this.lblContactoAcudiente.TabIndex = 11;
            this.lblContactoAcudiente.Text = "Contacto :";
            // 
            // lblSexoAcudiente
            // 
            this.lblSexoAcudiente.AutoSize = true;
            this.lblSexoAcudiente.Location = new System.Drawing.Point(423, 177);
            this.lblSexoAcudiente.Name = "lblSexoAcudiente";
            this.lblSexoAcudiente.Size = new System.Drawing.Size(48, 20);
            this.lblSexoAcudiente.TabIndex = 12;
            this.lblSexoAcudiente.Text = "Sexo :";
            // 
            // lblIdAcudiente
            // 
            this.lblIdAcudiente.AutoSize = true;
            this.lblIdAcudiente.Location = new System.Drawing.Point(423, 143);
            this.lblIdAcudiente.Name = "lblIdAcudiente";
            this.lblIdAcudiente.Size = new System.Drawing.Size(33, 20);
            this.lblIdAcudiente.TabIndex = 13;
            this.lblIdAcudiente.Text = "Id : ";
            // 
            // lblNameAcudiente
            // 
            this.lblNameAcudiente.AutoSize = true;
            this.lblNameAcudiente.Location = new System.Drawing.Point(423, 107);
            this.lblNameAcudiente.Name = "lblNameAcudiente";
            this.lblNameAcudiente.Size = new System.Drawing.Size(71, 20);
            this.lblNameAcudiente.TabIndex = 14;
            this.lblNameAcudiente.Text = "Nombre :";
            // 
            // txtNameEstudiante
            // 
            this.txtNameEstudiante.Location = new System.Drawing.Point(181, 104);
            this.txtNameEstudiante.Name = "txtNameEstudiante";
            this.txtNameEstudiante.Size = new System.Drawing.Size(125, 27);
            this.txtNameEstudiante.TabIndex = 15;
            // 
            // txtParentezcoAcudiente
            // 
            this.txtParentezcoAcudiente.Location = new System.Drawing.Point(517, 255);
            this.txtParentezcoAcudiente.Name = "txtParentezcoAcudiente";
            this.txtParentezcoAcudiente.Size = new System.Drawing.Size(125, 27);
            this.txtParentezcoAcudiente.TabIndex = 18;
            // 
            // txtContactoAcudiente
            // 
            this.txtContactoAcudiente.Location = new System.Drawing.Point(517, 217);
            this.txtContactoAcudiente.Name = "txtContactoAcudiente";
            this.txtContactoAcudiente.Size = new System.Drawing.Size(125, 27);
            this.txtContactoAcudiente.TabIndex = 19;
            // 
            // txtSexoAcudiente
            // 
            this.txtSexoAcudiente.Location = new System.Drawing.Point(517, 177);
            this.txtSexoAcudiente.Name = "txtSexoAcudiente";
            this.txtSexoAcudiente.Size = new System.Drawing.Size(125, 27);
            this.txtSexoAcudiente.TabIndex = 20;
            // 
            // txtIdAcudiente
            // 
            this.txtIdAcudiente.Location = new System.Drawing.Point(517, 144);
            this.txtIdAcudiente.Name = "txtIdAcudiente";
            this.txtIdAcudiente.Size = new System.Drawing.Size(125, 27);
            this.txtIdAcudiente.TabIndex = 21;
            // 
            // txtPromedioEstudiante
            // 
            this.txtPromedioEstudiante.Location = new System.Drawing.Point(181, 298);
            this.txtPromedioEstudiante.Name = "txtPromedioEstudiante";
            this.txtPromedioEstudiante.Size = new System.Drawing.Size(125, 27);
            this.txtPromedioEstudiante.TabIndex = 22;
            // 
            // txtDireccionEstudiante
            // 
            this.txtDireccionEstudiante.Location = new System.Drawing.Point(181, 255);
            this.txtDireccionEstudiante.Name = "txtDireccionEstudiante";
            this.txtDireccionEstudiante.Size = new System.Drawing.Size(125, 27);
            this.txtDireccionEstudiante.TabIndex = 23;
            // 
            // txtGradoEstudiante
            // 
            this.txtGradoEstudiante.Location = new System.Drawing.Point(181, 214);
            this.txtGradoEstudiante.Name = "txtGradoEstudiante";
            this.txtGradoEstudiante.Size = new System.Drawing.Size(125, 27);
            this.txtGradoEstudiante.TabIndex = 24;
            // 
            // txtSexoEstudiante
            // 
            this.txtSexoEstudiante.Location = new System.Drawing.Point(181, 174);
            this.txtSexoEstudiante.Name = "txtSexoEstudiante";
            this.txtSexoEstudiante.Size = new System.Drawing.Size(125, 27);
            this.txtSexoEstudiante.TabIndex = 25;
            // 
            // txtIdEstudiante
            // 
            this.txtIdEstudiante.Location = new System.Drawing.Point(181, 140);
            this.txtIdEstudiante.Name = "txtIdEstudiante";
            this.txtIdEstudiante.Size = new System.Drawing.Size(125, 27);
            this.txtIdEstudiante.TabIndex = 26;
            this.txtIdEstudiante.Click += new System.EventHandler(this.txtIdEstudiante_Click);
            this.txtIdEstudiante.TextChanged += new System.EventHandler(this.txtIdEstudiante_TextChanged);
            // 
            // txtNameAcudiente
            // 
            this.txtNameAcudiente.Location = new System.Drawing.Point(517, 107);
            this.txtNameAcudiente.Name = "txtNameAcudiente";
            this.txtNameAcudiente.Size = new System.Drawing.Size(125, 27);
            this.txtNameAcudiente.TabIndex = 27;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(423, 350);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 29);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblDebugger
            // 
            this.lblDebugger.AutoSize = true;
            this.lblDebugger.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDebugger.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDebugger.Location = new System.Drawing.Point(181, 403);
            this.lblDebugger.Name = "lblDebugger";
            this.lblDebugger.Size = new System.Drawing.Size(0, 19);
            this.lblDebugger.TabIndex = 29;
            // 
            // grbMatricular
            // 
            this.grbMatricular.Controls.Add(this.btnCancelar);
            this.grbMatricular.Controls.Add(this.lblTitle1);
            this.grbMatricular.Controls.Add(this.lblDebugger);
            this.grbMatricular.Controls.Add(this.lblNameEstudiante);
            this.grbMatricular.Controls.Add(this.btnGuardar);
            this.grbMatricular.Controls.Add(this.lblIdEstudiante);
            this.grbMatricular.Controls.Add(this.txtParentezcoAcudiente);
            this.grbMatricular.Controls.Add(this.txtContactoAcudiente);
            this.grbMatricular.Controls.Add(this.txtSexoAcudiente);
            this.grbMatricular.Controls.Add(this.txtIdAcudiente);
            this.grbMatricular.Controls.Add(this.txtNameAcudiente);
            this.grbMatricular.Controls.Add(this.lblSexoEstudiante);
            this.grbMatricular.Controls.Add(this.txtPromedioEstudiante);
            this.grbMatricular.Controls.Add(this.txtDireccionEstudiante);
            this.grbMatricular.Controls.Add(this.txtGradoEstudiante);
            this.grbMatricular.Controls.Add(this.txtSexoEstudiante);
            this.grbMatricular.Controls.Add(this.lblParentezcoAcudiente);
            this.grbMatricular.Controls.Add(this.lblContactoAcudiente);
            this.grbMatricular.Controls.Add(this.lblSexoAcudiente);
            this.grbMatricular.Controls.Add(this.lblIdAcudiente);
            this.grbMatricular.Controls.Add(this.lblNameAcudiente);
            this.grbMatricular.Controls.Add(this.txtIdEstudiante);
            this.grbMatricular.Controls.Add(this.lblGradoEstudiante);
            this.grbMatricular.Controls.Add(this.lblDireccionEstudiante);
            this.grbMatricular.Controls.Add(this.lblPromedioEstudiante);
            this.grbMatricular.Controls.Add(this.txtNameEstudiante);
            this.grbMatricular.Controls.Add(this.lblTitle2);
            this.grbMatricular.Controls.Add(this.lbltitle3);
            this.grbMatricular.Location = new System.Drawing.Point(197, 87);
            this.grbMatricular.Name = "grbMatricular";
            this.grbMatricular.Size = new System.Drawing.Size(797, 495);
            this.grbMatricular.TabIndex = 30;
            this.grbMatricular.TabStop = false;
            this.grbMatricular.Visible = false;
            this.grbMatricular.Enter += new System.EventHandler(this.grbMatricular_Enter);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(548, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar ";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(42, 116);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 29);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(42, 181);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 29);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // grbModificar
            // 
            this.grbModificar.AutoSize = true;
            this.grbModificar.Controls.Add(this.grbModificar2);
            this.grbModificar.Controls.Add(this.label1);
            this.grbModificar.Controls.Add(this.lstLista_estudiantes);
            this.grbModificar.Location = new System.Drawing.Point(158, 68);
            this.grbModificar.Name = "grbModificar";
            this.grbModificar.Size = new System.Drawing.Size(989, 520);
            this.grbModificar.TabIndex = 33;
            this.grbModificar.TabStop = false;
            this.grbModificar.Text = "Modificar Datos del Estudiante";
            // 
            // grbModificar2
            // 
            this.grbModificar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbModificar2.Controls.Add(this.btnModificarEliminar);
            this.grbModificar2.Controls.Add(this.btnModificarCancelar);
            this.grbModificar2.Controls.Add(this.label2);
            this.grbModificar2.Controls.Add(this.label3);
            this.grbModificar2.Controls.Add(this.label4);
            this.grbModificar2.Controls.Add(this.btnModificarGuardar);
            this.grbModificar2.Controls.Add(this.label5);
            this.grbModificar2.Controls.Add(this.txtModificarParentezcoAcudiente);
            this.grbModificar2.Controls.Add(this.txtModificarContactoAcudiente);
            this.grbModificar2.Controls.Add(this.txtModificarSexoAcudiente);
            this.grbModificar2.Controls.Add(this.txtModificarIdAcudiente);
            this.grbModificar2.Controls.Add(this.txtModificarNombreAcudiente);
            this.grbModificar2.Controls.Add(this.label6);
            this.grbModificar2.Controls.Add(this.txtModificarPromedio);
            this.grbModificar2.Controls.Add(this.txtModificarDirección);
            this.grbModificar2.Controls.Add(this.txtModificarGrado);
            this.grbModificar2.Controls.Add(this.txtModificarSexo);
            this.grbModificar2.Controls.Add(this.label7);
            this.grbModificar2.Controls.Add(this.label8);
            this.grbModificar2.Controls.Add(this.label9);
            this.grbModificar2.Controls.Add(this.label10);
            this.grbModificar2.Controls.Add(this.label11);
            this.grbModificar2.Controls.Add(this.txtModificarID);
            this.grbModificar2.Controls.Add(this.label12);
            this.grbModificar2.Controls.Add(this.label13);
            this.grbModificar2.Controls.Add(this.label14);
            this.grbModificar2.Controls.Add(this.txtModificarNombre);
            this.grbModificar2.Controls.Add(this.label15);
            this.grbModificar2.Controls.Add(this.label16);
            this.grbModificar2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grbModificar2.Enabled = false;
            this.grbModificar2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbModificar2.Location = new System.Drawing.Point(20, 73);
            this.grbModificar2.Name = "grbModificar2";
            this.grbModificar2.Size = new System.Drawing.Size(638, 421);
            this.grbModificar2.TabIndex = 31;
            this.grbModificar2.TabStop = false;
            // 
            // btnModificarEliminar
            // 
            this.btnModificarEliminar.Enabled = false;
            this.btnModificarEliminar.Location = new System.Drawing.Point(396, 350);
            this.btnModificarEliminar.Name = "btnModificarEliminar";
            this.btnModificarEliminar.Size = new System.Drawing.Size(94, 29);
            this.btnModificarEliminar.TabIndex = 31;
            this.btnModificarEliminar.Text = "Eliminar";
            this.btnModificarEliminar.UseVisualStyleBackColor = true;
            this.btnModificarEliminar.Click += new System.EventHandler(this.btnModificarEliminar_Click);
            // 
            // btnModificarCancelar
            // 
            this.btnModificarCancelar.Enabled = false;
            this.btnModificarCancelar.Location = new System.Drawing.Point(504, 350);
            this.btnModificarCancelar.Name = "btnModificarCancelar";
            this.btnModificarCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnModificarCancelar.TabIndex = 30;
            this.btnModificarCancelar.Text = "Cancelar ";
            this.btnModificarCancelar.UseVisualStyleBackColor = true;
            this.btnModificarCancelar.Click += new System.EventHandler(this.btnModificarCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datos del estudiante :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(181, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre :";
            // 
            // btnModificarGuardar
            // 
            this.btnModificarGuardar.Enabled = false;
            this.btnModificarGuardar.Location = new System.Drawing.Point(289, 350);
            this.btnModificarGuardar.Name = "btnModificarGuardar";
            this.btnModificarGuardar.Size = new System.Drawing.Size(94, 29);
            this.btnModificarGuardar.TabIndex = 28;
            this.btnModificarGuardar.Text = "Actualizar";
            this.btnModificarGuardar.UseVisualStyleBackColor = true;
            this.btnModificarGuardar.Click += new System.EventHandler(this.btnModificarGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Id : ";
            // 
            // txtModificarParentezcoAcudiente
            // 
            this.txtModificarParentezcoAcudiente.Location = new System.Drawing.Point(444, 250);
            this.txtModificarParentezcoAcudiente.Name = "txtModificarParentezcoAcudiente";
            this.txtModificarParentezcoAcudiente.Size = new System.Drawing.Size(125, 27);
            this.txtModificarParentezcoAcudiente.TabIndex = 18;
            // 
            // txtModificarContactoAcudiente
            // 
            this.txtModificarContactoAcudiente.Location = new System.Drawing.Point(444, 211);
            this.txtModificarContactoAcudiente.Name = "txtModificarContactoAcudiente";
            this.txtModificarContactoAcudiente.Size = new System.Drawing.Size(125, 27);
            this.txtModificarContactoAcudiente.TabIndex = 19;
            // 
            // txtModificarSexoAcudiente
            // 
            this.txtModificarSexoAcudiente.Location = new System.Drawing.Point(444, 174);
            this.txtModificarSexoAcudiente.Name = "txtModificarSexoAcudiente";
            this.txtModificarSexoAcudiente.Size = new System.Drawing.Size(125, 27);
            this.txtModificarSexoAcudiente.TabIndex = 20;
            // 
            // txtModificarIdAcudiente
            // 
            this.txtModificarIdAcudiente.Location = new System.Drawing.Point(444, 137);
            this.txtModificarIdAcudiente.Name = "txtModificarIdAcudiente";
            this.txtModificarIdAcudiente.Size = new System.Drawing.Size(125, 27);
            this.txtModificarIdAcudiente.TabIndex = 21;
            // 
            // txtModificarNombreAcudiente
            // 
            this.txtModificarNombreAcudiente.Location = new System.Drawing.Point(444, 104);
            this.txtModificarNombreAcudiente.Name = "txtModificarNombreAcudiente";
            this.txtModificarNombreAcudiente.Size = new System.Drawing.Size(125, 27);
            this.txtModificarNombreAcudiente.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sexo :";
            // 
            // txtModificarPromedio
            // 
            this.txtModificarPromedio.Location = new System.Drawing.Point(181, 298);
            this.txtModificarPromedio.Name = "txtModificarPromedio";
            this.txtModificarPromedio.Size = new System.Drawing.Size(125, 27);
            this.txtModificarPromedio.TabIndex = 22;
            // 
            // txtModificarDirección
            // 
            this.txtModificarDirección.Location = new System.Drawing.Point(181, 255);
            this.txtModificarDirección.Name = "txtModificarDirección";
            this.txtModificarDirección.Size = new System.Drawing.Size(125, 27);
            this.txtModificarDirección.TabIndex = 23;
            // 
            // txtModificarGrado
            // 
            this.txtModificarGrado.Location = new System.Drawing.Point(181, 214);
            this.txtModificarGrado.Name = "txtModificarGrado";
            this.txtModificarGrado.Size = new System.Drawing.Size(125, 27);
            this.txtModificarGrado.TabIndex = 24;
            // 
            // txtModificarSexo
            // 
            this.txtModificarSexo.Location = new System.Drawing.Point(181, 174);
            this.txtModificarSexo.Name = "txtModificarSexo";
            this.txtModificarSexo.Size = new System.Drawing.Size(125, 27);
            this.txtModificarSexo.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Parentezco :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Contacto :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(350, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Sexo :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(350, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Id : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(350, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Nombre :";
            // 
            // txtModificarID
            // 
            this.txtModificarID.Location = new System.Drawing.Point(181, 140);
            this.txtModificarID.Name = "txtModificarID";
            this.txtModificarID.Size = new System.Drawing.Size(125, 27);
            this.txtModificarID.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Grado a cursar :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(57, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Dirección :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 301);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Promedio :";
            // 
            // txtModificarNombre
            // 
            this.txtModificarNombre.Location = new System.Drawing.Point(181, 104);
            this.txtModificarNombre.Name = "txtModificarNombre";
            this.txtModificarNombre.Size = new System.Drawing.Size(125, 27);
            this.txtModificarNombre.TabIndex = 15;
            this.txtModificarNombre.TextChanged += new System.EventHandler(this.txtModificarNombre_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(350, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "Datos del Acudiente ";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(57, 455);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(420, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "*La información aquí suministrada será para uso interno.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escoja el ID del estudiante a modificar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstLista_estudiantes
            // 
            this.lstLista_estudiantes.FormattingEnabled = true;
            this.lstLista_estudiantes.ItemHeight = 20;
            this.lstLista_estudiantes.Location = new System.Drawing.Point(664, 96);
            this.lstLista_estudiantes.Name = "lstLista_estudiantes";
            this.lstLista_estudiantes.Size = new System.Drawing.Size(304, 384);
            this.lstLista_estudiantes.TabIndex = 0;
            this.lstLista_estudiantes.SelectedIndexChanged += new System.EventHandler(this.lstLista_estudiantes_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 668);
            this.Controls.Add(this.grbModificar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.grbMatricular);
            this.Controls.Add(this.btnMatricular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbMatricular.ResumeLayout(false);
            this.grbMatricular.PerformLayout();
            this.grbModificar.ResumeLayout(false);
            this.grbModificar.PerformLayout();
            this.grbModificar2.ResumeLayout(false);
            this.grbModificar2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMatricular;
        private Label lblTitle1;
        private Label lbltitle3;
        private Label lblTitle2;
        private Label lblNameEstudiante;
        private Label lblDireccionEstudiante;
        private Label lblIdEstudiante;
        private Label lblGradoEstudiante;
        private Label lblSexoEstudiante;
        private Label lblPromedioEstudiante;
        private Label lblParentezcoAcudiente;
        private Label lblContactoAcudiente;
        private Label lblSexoAcudiente;
        private Label lblIdAcudiente;
        private Label lblNameAcudiente;
        private TextBox txtNameEstudiante;
        private TextBox txtParentezcoAcudiente;
        private TextBox txtContactoAcudiente;
        private TextBox txtSexoAcudiente;
        private TextBox txtIdAcudiente;
        private TextBox txtPromedioEstudiante;
        private TextBox txtDireccionEstudiante;
        private TextBox txtGradoEstudiante;
        private TextBox txtSexoEstudiante;
        private TextBox txtIdEstudiante;
        private TextBox txtNameAcudiente;
        private Button btnGuardar;
        private Label lblDebugger;
        private GroupBox grbMatricular;
        private Button btnCancelar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Button btnBuscar;
        private Button btnModificar;
        private GroupBox grbModificar;
        private ListBox lstLista_estudiantes;
        private Label label1;
        private GroupBox grbModificar2;
        private Button btnModificarCancelar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnModificarGuardar;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox10;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBox11;
        private Label label15;
        private Label label16;
        private TextBox txtModificarParentezcoAcudiente;
        private TextBox txtModificarContactoAcudiente;
        private TextBox txtModificarSexoAcudiente;
        private TextBox txtModificarIdAcudiente;
        private TextBox txtModificarNombreAcudiente;
        private TextBox txtModificarPromedio;
        private TextBox txtModificarDirección;
        private TextBox txtModificarGrado;
        private TextBox txtModificarSexo;
        private TextBox txtModificarID;
        private TextBox txtModificarNombre;
        private Button btnModificarEliminar;
    }
}