namespace ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Lista lista = new Lista();
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void sumatotal()
        {
           decimal TOTAL = 0;

         
            foreach(DataGridViewRow row in dgvProds.Rows)
            {
               
                TOTAL += Convert.ToDecimal(row.Cells["Column2"].Value);
            }
            txtpuntuacion.Text = Convert.ToString(TOTAL);
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            TextWriter regitra = new StreamWriter(txtubicacion.Text +"\\" +"base_de_informacion.txt", true);

            try
            {

               

                lista.insertar("" + txtnombre.Text, double.Parse(txtgana.Text), double.Parse(txtpierde.Text));

                btnlista_Click(sender, e);
              
                regitra.WriteLine(txtnombre.Text + ","+ txtgana.Text + ","+ txtpierde.Text  );
                regitra.Close();
                sumatotal();
                txtnombre.Clear();
                txtgana.Clear();
                txtpierde.Clear();

              

            }



            catch (Exception)
            {
                MessageBox.Show("ingrese sus datos",
               "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlista_Click(object sender, EventArgs e)
        {
           

            lista.desplegar(dgvProds);

         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}