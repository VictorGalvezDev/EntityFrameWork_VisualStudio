using Pr0221.Modelo;

namespace Pr0221
{
    public partial class Form1 : Form
    {
        private Modelo.AppContext appContext;
        public Form1()
        {
            InitializeComponent();
            appContext = new Modelo.AppContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = appContext.Clientes.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modelo.Cliente cliente = new Cliente();
            cliente.Nombre = "jajajaj";
            Data.DataClientes.GetInstance().InsertarCliente(cliente);
        }
    }
}