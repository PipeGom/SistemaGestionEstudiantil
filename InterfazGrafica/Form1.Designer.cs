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
            this.grbMatricular.SuspendLayout();
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
            this.grbMatricular.Location = new System.Drawing.Point(197, 74);
            this.grbMatricular.Name = "grbMatricular";
            this.grbMatricular.Size = new System.Drawing.Size(797, 508);
            this.grbMatricular.TabIndex = 30;
            this.grbMatricular.TabStop = false;
            this.grbMatricular.Visible = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 668);
            this.Controls.Add(this.grbMatricular);
            this.Controls.Add(this.btnMatricular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbMatricular.ResumeLayout(false);
            this.grbMatricular.PerformLayout();
            this.ResumeLayout(false);

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
    }
}