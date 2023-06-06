using LogicaNegocio;

namespace ProyectoEscritorio
{
    public partial class Frm_Notas : Form
    {
        private ClsPromedio logicaPromedio;
        public Frm_Notas()
        {
            InitializeComponent();
            logicaPromedio = new ClsPromedio();
        }
        private void clearResult()
        {
            labelResult.Text = string.Empty;
            labelResult.BackColor = SystemColors.Info;
        }
        private void btnClearNotes_Click(object sender, EventArgs e)
        {
            if (txtListas.Items.Count > 0)
            {
                txtListas.Items.Clear();
                txtNotaSelecciona.Text = string.Empty;
                clearResult();
            }
        }

        private void validarNota(string notaS)
        {
            if (string.IsNullOrEmpty(notaS))
            {
                labelMessage.BackColor = Color.Red;
                labelMessage.ForeColor = Color.White;
                labelMessage.Text = "Debe ingresar una nota";
            }
            else
            {
                int nota = int.Parse(notaS);
                if (nota > 100)
                {
                    labelMessage.BackColor = Color.Red;
                    labelMessage.ForeColor = Color.White;
                    labelMessage.Text = "La nota debe ser igual o menor a 100";
                }
                else
                {
                    txtListas.Items.Add(nota);
                    txtNota.Text = string.Empty;
                    clearResult();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            validarNota(txtNota.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtListas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtListas.SelectedIndex != -1)
            {
                txtNotaSelecciona.Text = txtListas.Items[txtListas.SelectedIndex].ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtListas.Items.Count > 0)
            {
                double sumaNotas = SumarNotas();
                double promedio = logicaPromedio.calculoPromedio(sumaNotas, txtListas.Items.Count);
                labelMessage.Text = promedio + "Promedio";
            }
            else
            {
                labelMessage.Text = "No hay notas para calcular el promedio";
            }
        }

        private double SumarNotas()
        {
            double sumaNotas = 0;
            if (txtListas.Items.Count > 0)
            {

                for (int i = 0; i < txtListas.Items.Count; i++)
                {
                    double nota = Convert.ToInt32(txtListas.Items[i]);
                    sumaNotas += nota;
                }
                return sumaNotas;
            }
            else
            {
                labelMessage.BackColor = Color.Red;
                labelMessage.ForeColor = Color.White;
                labelMessage.Text = "La lista de notas está vacía.";
                return -1;
            }
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNota_TextChanged(object sender, EventArgs e)
        {
            if (txtNota.Text.Length > 3)
            {
                txtNota.Text = txtNota.Text.Substring(0, 3);
                txtNota.SelectionStart = 3;
                labelMessage.BackColor = Color.Red;
                labelMessage.ForeColor = Color.White;
                labelMessage.Text = "El numero debe ser menor a 3 caracteres";
            }
        }

       
        private void deleteSelected_Click(object sender, EventArgs e)
        {
            if (txtListas.SelectedIndex != -1)
            {
                txtListas.Items.RemoveAt(txtListas.SelectedIndex);
                txtNotaSelecciona.Text = string.Empty;
                clearResult();
            }
            else
            {
                MessageBox.Show("No has selecionado una nota");
            }

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (txtListas.Items.Count > 0)
            {
                double sumaNotas = SumarNotas();
                double promedio = logicaPromedio.calculoPromedio(sumaNotas, txtListas.Items.Count);
                labelResult.Text = promedio + "Promedio";
                logicaPromedio.calculoCondicion(promedio);
                if (logicaPromedio.getCondicion() == "Aprobado")
                {
                    labelResult.BackColor = logicaPromedio.getColor();
                }
                else
                {
                    labelResult.BackColor = logicaPromedio.getColor();
                }
            }
            else
            {
                labelMessage.Text = "No hay notas para calcular el promedio";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}