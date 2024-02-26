using Microsoft.VisualBasic;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        float[] salario;
        string[] nombre;
        int cont = 0;
        int n = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = int.Parse(textBox1.Text);
            salario = new float[n];
            nombre = new string[n];

            for (int i = 0; i < n; i++)
            {
                nombre[i] = Interaction.InputBox("Ingrese el nombre");
                salario[i] = float.Parse(Interaction.InputBox("Ingrese el sueldo"));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <n; i++)
            {
                listBox1.Items.Add(nombre[i]);
                listBox2.Items.Add(salario[i]);
            }
        }
    }
}
