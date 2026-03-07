using Cuentale.UI;

namespace Cuentale
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {


        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void clonarReposiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Hola! Soy Cuentale, tu asistente de IA para la gestión de proyectos.", "Bienvenido a Cuentale", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        private void label23_Click(object sender, EventArgs e)
        {
            // Esto abrirá la ventana que acaba de crear
            FormInventario ventanaInventario = new FormInventario();
            ventanaInventario.ShowDialog();
        }
    }
}
