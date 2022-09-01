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

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if ((textFilasM1.Text.Trim() == "") || (textColumnasM1.Text.Trim() == "")|| (textColumnasM2.Text.Trim() == "")|| (textFilasM2.Text.Trim() == ""))
            {
                MessageBox.Show("Campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else { 
            int filas = Convert.ToInt32(textFilasM1.Text);
            int columnas = Convert.ToInt32(textColumnasM1.Text);
            int filasB = Convert.ToInt32(textFilasM2.Text);
            int columnasB = Convert.ToInt32(textColumnasM2.Text);


            TextBox[,] textBoxesA, textBoxesB;
            textBoxesA = new TextBox[filas, columnas];
            textBoxesB = new TextBox[filasB, columnasB];

            for (int x = 0; x < filas; x++)
            {
                for (int y = 0; y < columnas; y++)
                {
                    textBoxesA[x, y] = new TextBox();
                    textBoxesA[x, y].Text = "";
                    textBoxesA[x, y].Width = 50;
                    textBoxesA[x, y].Location = new Point(200 + 100 * y, 200 + 50 * x);
                    textBoxesA[x, y].TabIndex = 100 + x + 2 * y;

                    Controls.Add(textBoxesA[x, y]);


                }

            }
            for (int x = 0; x < filasB; x++)
            {
                    for (int y = 0; y < columnasB; y++)
                    {
                        textBoxesB[x, y] = new TextBox();
                        textBoxesB[x, y].Text = "";
                        textBoxesB[x, y].Width = 50;
                        textBoxesB[x, y].Location = new Point(100 + 100 * (columnas + 2) + 100 * y, 150 + 50 * (filas + 2) + 50 * x);
                        textBoxesB[x, y].TabIndex = 100 + x + 2 * y;

                        Controls.Add(textBoxesB[x, y]);
                    }

                }
            }
        }
    }
}