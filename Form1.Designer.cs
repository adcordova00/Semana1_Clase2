namespace Semana1_Clase2
{
    partial class FormAlumnos
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
            colorDialog1 = new ColorDialog();
            lst_alumnos = new ListBox();
            btn_agregar = new Button();
            label1 = new Label();
            txt_cedula = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_nombres = new TextBox();
            txt_apellidos = new TextBox();
            txt_direccion = new TextBox();
            txt_telefono = new TextBox();
            btn_cancelar = new Button();
            btn_eliminar = new Button();
            dtp_fecha = new DateTimePicker();
            btn_modificar = new Button();
            SuspendLayout();
            // 
            // lst_alumnos
            // 
            lst_alumnos.FormattingEnabled = true;
            lst_alumnos.Location = new Point(356, 21);
            lst_alumnos.Name = "lst_alumnos";
            lst_alumnos.Size = new Size(299, 304);
            lst_alumnos.TabIndex = 0;
            lst_alumnos.SelectedIndexChanged += lst_alumnos_SelectedIndexChanged;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(189, 274);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(94, 29);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 21);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 2;
            label1.Text = "Ingreso de Alumnos";
            // 
            // txt_cedula
            // 
            txt_cedula.Location = new Point(176, 61);
            txt_cedula.MaxLength = 17;
            txt_cedula.Name = "txt_cedula";
            txt_cedula.Size = new Size(125, 27);
            txt_cedula.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 101);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 68);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 5;
            label3.Text = "Cedula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 134);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 6;
            label4.Text = "Apellidos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 170);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 7;
            label5.Text = "Direccion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(91, 204);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 8;
            label6.Text = "Telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 233);
            label7.Name = "label7";
            label7.Size = new Size(146, 20);
            label7.TabIndex = 9;
            label7.Text = "Fecha de nacimiento";
            // 
            // txt_nombres
            // 
            txt_nombres.Location = new Point(176, 94);
            txt_nombres.MaxLength = 200;
            txt_nombres.Name = "txt_nombres";
            txt_nombres.Size = new Size(125, 27);
            txt_nombres.TabIndex = 10;
            // 
            // txt_apellidos
            // 
            txt_apellidos.Location = new Point(176, 127);
            txt_apellidos.MaxLength = 200;
            txt_apellidos.Name = "txt_apellidos";
            txt_apellidos.Size = new Size(125, 27);
            txt_apellidos.TabIndex = 11;
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(176, 160);
            txt_direccion.MaxLength = 200;
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(125, 27);
            txt_direccion.TabIndex = 12;
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(176, 193);
            txt_telefono.MaxLength = 200;
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(125, 27);
            txt_telefono.TabIndex = 13;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(189, 319);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(94, 29);
            btn_cancelar.TabIndex = 15;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(679, 21);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(94, 29);
            btn_eliminar.TabIndex = 16;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // dtp_fecha
            // 
            dtp_fecha.Location = new Point(176, 226);
            dtp_fecha.Name = "dtp_fecha";
            dtp_fecha.Size = new Size(125, 27);
            dtp_fecha.TabIndex = 17;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(679, 68);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(94, 29);
            btn_modificar.TabIndex = 18;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // FormAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_modificar);
            Controls.Add(dtp_fecha);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_cancelar);
            Controls.Add(txt_telefono);
            Controls.Add(txt_direccion);
            Controls.Add(txt_apellidos);
            Controls.Add(txt_nombres);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_cedula);
            Controls.Add(label1);
            Controls.Add(btn_agregar);
            Controls.Add(lst_alumnos);
            Name = "FormAlumnos";
            Text = "Alumnos";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private ListBox lst_alumnos;
        private Button btn_agregar;
        private Label label1;
        private TextBox txt_cedula;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_nombres;
        private TextBox txt_apellidos;
        private TextBox txt_direccion;
        private TextBox txt_telefono;
        private Button btn_cancelar;
        private Button btn_eliminar;
        private DateTimePicker dtp_fecha;
        private Button btn_modificar;
    }
}
