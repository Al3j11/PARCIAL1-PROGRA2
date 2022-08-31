namespace PARCIAL_PROGRA_2
{
    public partial class PARCIAL1 : Form
    {
        public PARCIAL1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textFilasM1.Clear();
            textColumnasM1.Clear();
            textFilasM2.Clear();
            textColumnasM2.Clear();
            textFilasM1.Focus();
        }

    }
}