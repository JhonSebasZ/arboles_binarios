namespace fase4_jhon_sebastian_zuñiga
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar una contraseña");
                txtContrasena.Focus();
                return;
            }
            if(txtContrasena.Text != "123")
            {
                MessageBox.Show("Contraseña incorrecta");
                txtContrasena.Focus();
                return;
            }

            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}