namespace preferencias_de_actividades
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
            textBoxnombre = new TextBox();
            txtnombre = new Label();
            buttonmostrarresumen = new Button();
            buttonlimpiar = new Button();
            labelresumen = new Label();
            texresumen = new Label();
            groupBoxactividades = new GroupBox();
            checkBoxlectura = new CheckBox();
            checkBoxprogramacion = new CheckBox();
            checkBoxarte = new CheckBox();
            checkBoxmusica = new CheckBox();
            deportes = new CheckBox();
            groupBoxmodALIDAD = new GroupBox();
            radioButtonlinea = new RadioButton();
            radioButtonhibrida = new RadioButton();
            radioButtonpresencial = new RadioButton();
            textBoxresumen = new TextBox();
            groupBoxactividades.SuspendLayout();
            groupBoxmodALIDAD.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxnombre
            // 
            textBoxnombre.BackColor = SystemColors.ButtonHighlight;
            textBoxnombre.Location = new Point(219, 44);
            textBoxnombre.Name = "textBoxnombre";
            textBoxnombre.Size = new Size(132, 23);
            textBoxnombre.TabIndex = 0;
            // 
            // txtnombre
            // 
            txtnombre.AutoSize = true;
            txtnombre.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtnombre.Location = new Point(15, 42);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(198, 22);
            txtnombre.TabIndex = 1;
            txtnombre.Text = "Nombre del estudiante:";
            txtnombre.Click += label1_Click;
            // 
            // buttonmostrarresumen
            // 
            buttonmostrarresumen.Location = new Point(118, 351);
            buttonmostrarresumen.Name = "buttonmostrarresumen";
            buttonmostrarresumen.Size = new Size(124, 23);
            buttonmostrarresumen.TabIndex = 4;
            buttonmostrarresumen.Text = "Mostrar resumen";
            buttonmostrarresumen.UseVisualStyleBackColor = true;
            buttonmostrarresumen.Click += buttonmostrarresumen_Click;
            // 
            // buttonlimpiar
            // 
            buttonlimpiar.Location = new Point(300, 351);
            buttonlimpiar.Name = "buttonlimpiar";
            buttonlimpiar.Size = new Size(75, 23);
            buttonlimpiar.TabIndex = 5;
            buttonlimpiar.Text = "Limpiar";
            buttonlimpiar.UseVisualStyleBackColor = true;
            buttonlimpiar.Click += buttonlimpiar_Click;
            // 
            // labelresumen
            // 
            labelresumen.AutoSize = true;
            labelresumen.Location = new Point(33, 399);
            labelresumen.Name = "labelresumen";
            labelresumen.Size = new Size(0, 15);
            labelresumen.TabIndex = 6;
            // 
            // texresumen
            // 
            texresumen.AutoSize = true;
            texresumen.Location = new Point(63, 416);
            texresumen.Name = "texresumen";
            texresumen.Size = new Size(56, 15);
            texresumen.TabIndex = 7;
            texresumen.Text = "resumen:";
            // 
            // groupBoxactividades
            // 
            groupBoxactividades.BackColor = SystemColors.Control;
            groupBoxactividades.Controls.Add(checkBoxlectura);
            groupBoxactividades.Controls.Add(checkBoxprogramacion);
            groupBoxactividades.Controls.Add(checkBoxarte);
            groupBoxactividades.Controls.Add(checkBoxmusica);
            groupBoxactividades.Controls.Add(deportes);
            groupBoxactividades.Location = new Point(33, 125);
            groupBoxactividades.Name = "groupBoxactividades";
            groupBoxactividades.Size = new Size(251, 180);
            groupBoxactividades.TabIndex = 8;
            groupBoxactividades.TabStop = false;
            groupBoxactividades.Text = "Actividades favoritas (puedes elegir varias)";
            groupBoxactividades.Enter += groupBox1_Enter;
            // 
            // checkBoxlectura
            // 
            checkBoxlectura.AutoSize = true;
            checkBoxlectura.Location = new Point(21, 138);
            checkBoxlectura.Name = "checkBoxlectura";
            checkBoxlectura.Size = new Size(65, 19);
            checkBoxlectura.TabIndex = 4;
            checkBoxlectura.Text = "Lectura";
            checkBoxlectura.UseVisualStyleBackColor = true;
            // 
            // checkBoxprogramacion
            // 
            checkBoxprogramacion.AutoSize = true;
            checkBoxprogramacion.Location = new Point(21, 113);
            checkBoxprogramacion.Name = "checkBoxprogramacion";
            checkBoxprogramacion.Size = new Size(101, 19);
            checkBoxprogramacion.TabIndex = 3;
            checkBoxprogramacion.Text = "Programacion";
            checkBoxprogramacion.UseVisualStyleBackColor = true;
            // 
            // checkBoxarte
            // 
            checkBoxarte.AutoSize = true;
            checkBoxarte.Location = new Point(21, 88);
            checkBoxarte.Name = "checkBoxarte";
            checkBoxarte.Size = new Size(48, 19);
            checkBoxarte.TabIndex = 2;
            checkBoxarte.Text = "Arte";
            checkBoxarte.UseVisualStyleBackColor = true;
            // 
            // checkBoxmusica
            // 
            checkBoxmusica.AutoSize = true;
            checkBoxmusica.Location = new Point(21, 62);
            checkBoxmusica.Name = "checkBoxmusica";
            checkBoxmusica.Size = new Size(64, 19);
            checkBoxmusica.TabIndex = 1;
            checkBoxmusica.Text = "Música";
            checkBoxmusica.UseVisualStyleBackColor = true;
            // 
            // deportes
            // 
            deportes.AutoSize = true;
            deportes.Location = new Point(20, 37);
            deportes.Name = "deportes";
            deportes.Size = new Size(73, 19);
            deportes.TabIndex = 0;
            deportes.Text = "Deportes";
            deportes.UseVisualStyleBackColor = true;
            // 
            // groupBoxmodALIDAD
            // 
            groupBoxmodALIDAD.BackColor = SystemColors.Control;
            groupBoxmodALIDAD.Controls.Add(radioButtonlinea);
            groupBoxmodALIDAD.Controls.Add(radioButtonhibrida);
            groupBoxmodALIDAD.Controls.Add(radioButtonpresencial);
            groupBoxmodALIDAD.Location = new Point(325, 125);
            groupBoxmodALIDAD.Name = "groupBoxmodALIDAD";
            groupBoxmodALIDAD.Size = new Size(200, 180);
            groupBoxmodALIDAD.TabIndex = 9;
            groupBoxmodALIDAD.TabStop = false;
            groupBoxmodALIDAD.Text = "Modalidad preferida";
            // 
            // radioButtonlinea
            // 
            radioButtonlinea.AutoSize = true;
            radioButtonlinea.Location = new Point(13, 113);
            radioButtonlinea.Name = "radioButtonlinea";
            radioButtonlinea.Size = new Size(66, 19);
            radioButtonlinea.TabIndex = 2;
            radioButtonlinea.TabStop = true;
            radioButtonlinea.Text = "En linea";
            radioButtonlinea.UseVisualStyleBackColor = true;
            // 
            // radioButtonhibrida
            // 
            radioButtonhibrida.AutoSize = true;
            radioButtonhibrida.Location = new Point(13, 69);
            radioButtonhibrida.Name = "radioButtonhibrida";
            radioButtonhibrida.Size = new Size(64, 19);
            radioButtonhibrida.TabIndex = 1;
            radioButtonhibrida.TabStop = true;
            radioButtonhibrida.Text = "Hibrida";
            radioButtonhibrida.UseVisualStyleBackColor = true;
            // 
            // radioButtonpresencial
            // 
            radioButtonpresencial.AutoSize = true;
            radioButtonpresencial.Location = new Point(13, 35);
            radioButtonpresencial.Name = "radioButtonpresencial";
            radioButtonpresencial.Size = new Size(78, 19);
            radioButtonpresencial.TabIndex = 0;
            radioButtonpresencial.TabStop = true;
            radioButtonpresencial.Text = "Presencial";
            radioButtonpresencial.UseVisualStyleBackColor = true;
            // 
            // textBoxresumen
            // 
            textBoxresumen.Location = new Point(54, 434);
            textBoxresumen.Multiline = true;
            textBoxresumen.Name = "textBoxresumen";
            textBoxresumen.Size = new Size(438, 132);
            textBoxresumen.TabIndex = 10;
            textBoxresumen.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(556, 595);
            Controls.Add(textBoxresumen);
            Controls.Add(groupBoxmodALIDAD);
            Controls.Add(groupBoxactividades);
            Controls.Add(texresumen);
            Controls.Add(labelresumen);
            Controls.Add(buttonlimpiar);
            Controls.Add(buttonmostrarresumen);
            Controls.Add(txtnombre);
            Controls.Add(textBoxnombre);
            Name = "Form1";
            Text = " Preferencias de Actividades";
            Load += Form1_Load;
            groupBoxactividades.ResumeLayout(false);
            groupBoxactividades.PerformLayout();
            groupBoxmodALIDAD.ResumeLayout(false);
            groupBoxmodALIDAD.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxnombre;
        private Label txtnombre;
        private Button buttonmostrarresumen;
        private Button buttonlimpiar;
        private Label labelresumen;
        private Label texresumen;
        private GroupBox groupBoxactividades;
        private CheckBox checkBoxlectura;
        private CheckBox checkBoxprogramacion;
        private CheckBox checkBoxarte;
        private CheckBox checkBoxmusica;
        private CheckBox deportes;
        private GroupBox groupBoxmodALIDAD;
        private RadioButton radioButtonlinea;
        private RadioButton radioButtonhibrida;
        private RadioButton radioButtonpresencial;
        private TextBox textBoxresumen;
    }
}
