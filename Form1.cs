namespace pryTeatro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboZona.Items.Clear();
            cboZona.Items.Add("Azul");
            cboZona.Items.Add("Verde");
            cboZona.SelectedIndex = 0;



        }

        private void optQuenaken_CheckedChanged(object sender, EventArgs e)
        {
           


        }

        private void optOnas_CheckedChanged(object sender, EventArgs e)
        {


           
        }

        private void optTobas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboZona_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            if (optQuenaken.Checked)
            {
                switch (cboZona.SelectedIndex)
                {
                    case 0:
                        cboFila.Items.Clear();
                        cboAsiento.Items.Clear();

                        for (int i = 1; i <= 4; i++)
                        {
                            cboFila.Items.Add(i);
                        }

                        for(int j = 1; j <= 5; j++)
                        {
                            cboAsiento.Items.Add(j);
                        }

                        break;

                    case 1:
                        cboFila.Items.Clear();
                        cboAsiento.Items.Clear();
                        for (int i = 1; i <= 4; i++)
                        {
                            cboFila.Items.Add(i);
                        }

                        for (int j = 1; j <= 5; j++)
                        {
                            cboAsiento.Items.Add(j);
                        }

                        break;

                }
            }
            else
            {
                if (optOnas.Checked)
                {
                    switch (cboZona.SelectedIndex)
                    {
                        case 0:
                            cboFila.Items.Clear();
                            cboAsiento.Items.Clear();

                            for (int i = 1; i <= 10; i++)
                            {
                                cboFila.Items.Add(i);
                            }

                            for (int j = 1; j <= 4; j++)
                            {
                                cboAsiento.Items.Add(j);
                            }
                            break;

                        case 1:
                            cboFila.Items.Clear();
                            cboAsiento.Items.Clear();
                            for (int i = 1; i <= 5; i++)
                            {
                                cboFila.Items.Add(i);
                            }

                            for (int j = 1; j <= 5; j++)
                            {
                                cboAsiento.Items.Add(j);
                            }

                            break;

                    }
                }
                else
                {
                    switch (cboZona.SelectedIndex)
                    {
                        case 0:
                            cboFila.Items.Clear();
                            cboAsiento.Items.Clear();
                            for (int i = 1; i <= 5; i++)
                            {
                                cboFila.Items.Add(i);
                            }

                            for (int j = 1; j <= 3; j++)
                            {
                                cboAsiento.Items.Add(j);
                            }

                            break;

                        case 1:
                            cboFila.Items.Clear();
                            cboAsiento.Items.Clear();

                            for (int i = 1; i <= 5; i++)
                            {
                                cboFila.Items.Add(i);
                            }

                            for (int j = 1; j <= 5; j++)
                            {
                                cboAsiento.Items.Add(j);
                            }
                            break;

                    }
                }

            }
        }

        private void cboFila_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


    }
}
