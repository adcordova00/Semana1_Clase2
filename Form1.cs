namespace Semana1_Clase2
{
    public partial class FormAlumnos : Form
    {
        bool estado = false;
        int posicion = -1;
        public FormAlumnos()
        {
            InitializeComponent();
        }

        private void lst_alumnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            var cedula = txt_cedula.Text;
            var nombres = txt_nombres.Text;
            var apellidos = txt_apellidos.Text;
            var direccion = txt_direccion.Text;
            var telefono = txt_telefono.Text;
            var fecha = dtp_fecha.Text;

            if (!string.IsNullOrWhiteSpace(cedula) &&
                !string.IsNullOrWhiteSpace(nombres) &&
                !string.IsNullOrWhiteSpace(apellidos) &&
                !string.IsNullOrWhiteSpace(direccion) &&
                !string.IsNullOrWhiteSpace(telefono))
            {
                string cadena = cedula + "|" + nombres + "|" + apellidos + "|" + direccion + "|" + telefono + "|" + fecha;
                if (estado == true)
                {
                    lst_alumnos.Items[posicion] = cadena;
                    estado = false;
                    posicion = -1;
                    MessageBox.Show("Elemento modificado");
                    LimpiarForm();
                }
                else
                {
                    lst_alumnos.Items.Add(cadena);
                    LimpiarForm();
                }
            }
            else
            {
                MessageBox.Show("Agregue todos los campos");
            }
        }

        public void LimpiarForm()
        {
            txt_cedula.Text = string.Empty;
            txt_nombres.Text = string.Empty;
            txt_apellidos.Text = string.Empty;
            txt_direccion.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            dtp_fecha.Text = string.Empty;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (lst_alumnos.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un alumno");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar al alumno?", "Alumnos", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    lst_alumnos.Items.RemoveAt(lst_alumnos.SelectedIndex);
                    MessageBox.Show("Se elimino con exito");
                }
                else
                {
                    MessageBox.Show("El usuario cancelo la operacion");
                }
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (lst_alumnos.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un alumno para modificar");
            }
            else
            {
                string seleccion = lst_alumnos.SelectedItem.ToString();
                string[] partesAlunmo = seleccion.Split(new string[] { "|" }, StringSplitOptions.None);
                txt_cedula.Text = partesAlunmo[0];
                txt_nombres.Text = partesAlunmo[1];
                txt_apellidos.Text = partesAlunmo[2];
                txt_direccion.Text = partesAlunmo[3];
                txt_telefono.Text = partesAlunmo[4];
                dtp_fecha.Text = partesAlunmo[5];
                estado = true;
                posicion = lst_alumnos.SelectedIndex;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }
    }
}
