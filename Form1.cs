using Portal.Infrastructure;

namespace Portal
{
    public partial class Form1 : Form
    {
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();
        public Form1()
        {
            InitializeComponent();
            obterAlunos();
        }

        private void obterAlunos()
        {
            var repository = new AlunoRepository();
            Alunos = repository.GetAll();

            foreach (var aluno in Alunos)
            {
                lv_alunos.Items.Add(new ListViewItem(new string[] { aluno.Nome, aluno.Idade.ToString(),aluno.Curso }));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = txt_nome.Text;
                var idade = txt_idade.Text;
                var curso = txt_curso.Text;

                foreach (var item in Alunos)
                {
                    if (item.Nome == nome)
                    {
                        MessageBox.Show(nome + " já está cadastrado no sistema");
                        return;
                    }
                }

                var aluno = new Aluno(nome, idade, curso);
                Alunos.Add(aluno);
                var repository = new AlunoRepository();
                repository.Add(aluno);

                lv_alunos.Items.Add(new ListViewItem(new string[] {nome, idade, curso}));  
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}

