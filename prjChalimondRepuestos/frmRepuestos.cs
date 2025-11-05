namespace prjChalimondRepuestos
{
    public partial class frmRepuestos : Form
    {

        struct Repuesto
        {
            public string marca;
            public string origen;
            public int numeroRepuesto;
            public string descripcion;
            public decimal precio;
        }
        Repuesto[] repuestos = new Repuesto[100];
        int contadorRepuestos = 0;

        private void frmRepuestos_Load(object sender, EventArgs e)
        {

            //carga

            btnCarga.Enabled = false;
            lstMarcas_carga.SelectedIndexChanged += (s, e) => VerificarControlesCarga();
            txtDesc_carga.TextChanged += (s, e) => VerificarControlesCarga();
            numRepuesto_carga.ValueChanged += (s, e) => VerificarControlesCarga();
            numPrecio_carga.ValueChanged += (s, e) => VerificarControlesCarga();


            //consulta
            btnConsulta.Enabled = false;


            lstMarca_consulta.SelectedIndexChanged += (s, e) => VerificarControlesConsulta();
            optImporta_consulta.CheckedChanged += (s, e) => VerificarControlesConsulta();
            optNacional_consulta.CheckedChanged += (s, e) => VerificarControlesConsulta();

        }




        public frmRepuestos()
        {
            InitializeComponent();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            CargarRepuesto();
        }

        private void CargarRepuesto()
        {
            Repuesto objRepuesto = new Repuesto();
            objRepuesto.marca = lstMarcas_carga.Text;
            objRepuesto.origen = lstOrigen_carga.Text;
            objRepuesto.numeroRepuesto = (int)numRepuesto_carga.Value;
            objRepuesto.descripcion = txtDesc_carga.Text;
            objRepuesto.precio = numPrecio_carga.Value;

            if (!ValidarCarga(objRepuesto)) return;

            repuestos[contadorRepuestos] = objRepuesto;
            contadorRepuestos++;

            MessageBox.Show("Repuesto cargado exitosamente.", "Operacion exitosa",  MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpiar();
        }


        private bool ValidarCarga(Repuesto objRepuesto)
        {

            if (contadorRepuestos >= repuestos.Length)
            {
                MessageBox.Show("No se pueden cargar más de 100 repuestos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            for (int i = 0; i < contadorRepuestos; i++)
            {
                if (repuestos[i].numeroRepuesto == objRepuesto.numeroRepuesto)
                {
                    MessageBox.Show("El numero de repuesto ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }



        private void VerificarControlesCarga()
        {
            bool completo = true;

            if (string.IsNullOrWhiteSpace(lstMarcas_carga.Text))
                completo = false;

            if (string.IsNullOrWhiteSpace(txtDesc_carga.Text))
                completo = false;

            if (numRepuesto_carga.Value <= 0)
                completo = false;

            if (numPrecio_carga.Value <= 0)
                completo = false;

            btnCarga.Enabled = completo;
        }

        // Consulta


        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultarRepuesto();
        }


        private void ConsultarRepuesto()
        {
            Limpiar();
            lstRepuestos_consulta.Items.Clear();


            string marcaFiltrada = lstMarca_consulta.Text;
            string origenFiltrado = optImporta_consulta.Checked ? "Importado" : "Nacional";

            for (int i = 0; i < contadorRepuestos; i++)
            {
                if (repuestos[i].marca == marcaFiltrada && repuestos[i].origen == origenFiltrado)
                {
                    Repuesto repuesto = repuestos[i];
                    lstRepuestos_consulta.Items.Add($"{repuesto.numeroRepuesto} -- {repuesto.descripcion} -- {repuesto.precio}");
                }
                else
                {
                    lstRepuestos_consulta.Items.Add("No hay repuestos disponibles para esa busqueda");
                }
            }


            lstMarca_consulta.Focus();

        }

        private void VerificarControlesConsulta()
        {
            bool completo = true;
            if (string.IsNullOrWhiteSpace(lstMarca_consulta.Text))
                completo = false;
            if (!optImporta_consulta.Checked && !optNacional_consulta.Checked) completo = false;


            if (contadorRepuestos <= 0) completo = false;
            btnConsulta.Enabled = completo;
        }


        private void Limpiar()
        {

            lstMarcas_carga.SelectedIndex = -1;
            lstOrigen_carga.SelectedIndex = -1;
            txtDesc_carga.Clear();
            numRepuesto_carga.Value = 0;
            numPrecio_carga.Value = 0;

            lstMarcas_carga.Focus();
            lstRepuestos_consulta.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            
        }
    }
}
