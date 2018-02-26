/*
 Programa criado por: Vinícius Bastos da Silva.
 Livre para uso e modificação pessoal ou comercial,
 apenas mantenha o nome do criador no código-fonte.
 */


using System;
using System.Windows.Forms;

namespace NewGuid
{
    public partial class FormPrincipal : Form
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private Guid _guidAtual;
        private Guid GuidAtual
        {
            get => _guidAtual;
            set
            {
                _guidAtual = value;
                txtGuid.Text = _guidAtual.ToString();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
            => GuidAtual = Guid.NewGuid();

        private void btnCopiar_Click(object sender, EventArgs e)
            => Clipboard.SetText(GuidAtual.ToString());

        private void btnGerarNovo_Click(object sender, EventArgs e)
            => GuidAtual = Guid.NewGuid();

        private void btnFechar_Click(object sender, EventArgs e)
            => Close();
        
        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.C:
                    btnCopiar.PerformClick();
                    break;
                case Keys.N:
                case Keys.G:
                    btnGerarNovo.PerformClick();
                    break;
                case Keys.F:
                case Keys.Escape:
                    btnFechar.PerformClick();
                    break;
            }
        }
    }
}
