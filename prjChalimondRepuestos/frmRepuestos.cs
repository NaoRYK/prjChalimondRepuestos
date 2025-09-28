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
            Repuesto repuesto = new Repuesto();
            repuesto.marca = lstMarcas_carga.Text;
            repuesto.origen = lstOrigen_carga.Text;
            repuesto.numeroRepuesto = (int)numRepuesto_carga.Value;
            repuesto.descripcion = txtDesc_carga.Text;
            repuesto.precio = numPrecio_carga.Value;

            if (!ValidarCarga(repuesto)) return;

            repuestos[contadorRepuestos] = repuesto;
            contadorRepuestos++;

            MessageBox.Show("Repuesto cargado exitosamente.");

            lstMarcas_carga.SelectedIndex = -1;
            lstOrigen_carga.SelectedIndex = -1;
            txtDesc_carga.Clear();
            numRepuesto_carga.Value = 0;
            numPrecio_carga.Value = 0;

            lstMarcas_carga.Focus();
        }


        private bool ValidarCarga(Repuesto repuesto)
        {

            if (contadorRepuestos >= repuestos.Length)
            {
                MessageBox.Show("No se pueden cargar más de 100 repuestos");
                return false;
            }
            for (int i = 0; i < contadorRepuestos; i++)
            {
                if (repuestos[i].numeroRepuesto == repuesto.numeroRepuesto)
                {
                    MessageBox.Show("El numero de repuesto ya existe");
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


    }
}
