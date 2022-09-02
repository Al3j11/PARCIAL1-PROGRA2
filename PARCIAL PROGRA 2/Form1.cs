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
            Application.Restart();
        }
        


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if ((textFilasM1.Text.Trim() == "") || (textColumnasM1.Text.Trim() == "") || (textColumnasM2.Text.Trim() == "") || (textFilasM2.Text.Trim() == ""))
            {
                MessageBox.Show("Campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else {

                int filas = Convert.ToInt32(textFilasM1.Text);
                int columnas = Convert.ToInt32(textColumnasM1.Text);
                int filasB = Convert.ToInt32(textFilasM2.Text);
                int columnasB = Convert.ToInt32(textColumnasM2.Text);




                TextBox[,] textBoxesA, textBoxesB, textBoxesRAB, textBoxesRBA;
                textBoxesA = new TextBox[filas, columnas];
                textBoxesB = new TextBox[filasB, columnasB];
                textBoxesRAB = new TextBox[filas, columnas];
                textBoxesRBA = new TextBox[filas, columnas];

                for (int x = 0; x < filas; x++)
                {
                    for (int y = 0; y < columnas; y++)
                    {
                        textBoxesA[x, y] = new TextBox();
                        textBoxesA[x, y].Text = "";
                        textBoxesA[x, y].Width = 40;
                        textBoxesA[x, y].Location = new Point(100 + 100 * y, 100 + 50 * x);
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
                        textBoxesB[x, y].Width = 40;
                        textBoxesB[x, y].Location = new Point(100 + 100 * (columnas + 2) + 100 * y, 20 + 50 * (filas + 2) + 50 * x);
                        textBoxesB[x, y].TabIndex = 100 + x + 2 * y;

                        Controls.Add(textBoxesB[x, y]);

                       


                    }

                    
                }
                
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int filas = Convert.ToInt32(textFilasM1.Text);
            int columnas = Convert.ToInt32(textColumnasM1.Text);
            int filasB = Convert.ToInt32(textFilasM2.Text);
            int columnasB = Convert.ToInt32(textColumnasM2.Text);

            TextBox[,] textBoxesA, textBoxesB, textBoxesRAB, textBoxesRBA;
            textBoxesA = new TextBox[filas, columnas];
            textBoxesB = new TextBox[filasB, columnasB];
            textBoxesRAB = new TextBox[filas, columnas];
            textBoxesRBA = new TextBox[filas, columnas];

            for (int x = 0; x < filas; x++)
            {
                for (int y = 0; y < columnas; y++)
                {
                    textBoxesRAB[x, y] = new TextBox();
                    textBoxesRAB[x, y].Text = "";
                    textBoxesRAB[x, y].Width = 40;
                    textBoxesRAB[x, y].Location = new Point(100 + 100 * (columnas + 2) + 100 * y, 50 + 50 * (filas + 0)  - 50 * x);
                    textBoxesRAB[x, y].TabIndex = 100 + x + 2 * y;

                    Controls.Add(textBoxesRAB[x, y]);




                }
            }
            for (int x = 0; x < filasB; x++)
            {
                for (int y = 0; y < columnasB; y++)

                {

                    textBoxesRBA[x, y] = new TextBox();
                    textBoxesRBA[x, y].Text = "";
                    textBoxesRBA[x, y].Width = 40;
                    textBoxesRBA[x, y].Location = new Point(100 + 0 * (columnas + 0) + 100 * y, 25 + 50 * (filas + 2) + 50 * x);
                    textBoxesRBA[x, y].TabIndex = 100 + x + 2 * y;

                    Controls.Add(textBoxesRBA[x, y]);




                }
            }
        }

        private void PARCIAL1_Load(object sender, EventArgs e)
        {

        }
    }
}
