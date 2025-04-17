using Npgsql;
using SistemaDeChamados.Forms.OptionsConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeChamados.Forms
{
    public partial class FormConfigura : Form
    {
        private Form activeForm;
        private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=SeF2ew5xutre;Database=db_sistema_chamados";
        public FormConfigura()
        {
            InitializeComponent();
            CarregarUsuarios();
            EstilizarDataGridView();
        }

        // Método para carregar os usuários no DataGridView
        private void CarregarUsuarios()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT ID, NOME, LOGIN, TIPO_USUARIO, STATUS FROM USUARIOS";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (var da = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvUsuarios.DataSource = dt; // 'dgvUsuarios' é o nome do DataGridView
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EstilizarDataGridView()
        {
            dgvUsuarios.EnableHeadersVisualStyles = false;

            // Estilo de fundo transparente (herda do form/painel pai)
            dgvUsuarios.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            dgvUsuarios.DefaultCellStyle.ForeColor = Color.White;
            dgvUsuarios.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dgvUsuarios.DefaultCellStyle.SelectionBackColor = Color.FromArgb(102, 0, 204); // roxo
            dgvUsuarios.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 0, 128);
            dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            // Aumentar altura do cabeçalho
            dgvUsuarios.ColumnHeadersHeight = 45;

            // Bordas e grade
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsuarios.GridColor = Color.FromArgb(80, 80, 80);

            // Scrollbars
            dgvUsuarios.ScrollBars = ScrollBars.Both;

            // Tamanho automático de colunas
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Remover linha de inserção nova (última linha em branco)
            dgvUsuarios.AllowUserToAddRows = false;

            // Remover coluna de seleção (setinha lateral)
            dgvUsuarios.RowHeadersVisible = false;

            // Bordas das células suavizadas (simulação)
            dgvUsuarios.DefaultCellStyle.Padding = new Padding(5);
        }


        // Método que pode ser chamado após o cadastro de um usuário para atualizar o DataGridView
        //private void AtualizarUsuarios()
        //{
        //    CarregarUsuarios();
        //}

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Adiciona ao painel correto
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FormConfigura_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dgvUsuarios.Hide();
        }

        private void lblAlterarSenha_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formAlteraSenha(), sender);
        }

        private void lblViewTable_Click(object sender, EventArgs e)
        {
            // Percorre todos os controles do panelDesktop
            foreach (Control ctrl in panelDesktop.Controls)
            {
                // Se o controle for um Form, fecha ele
                if (ctrl is Form)
                {
                    ((Form)ctrl).Close();
                }
            }
            // Exibe o DataGridView
            dgvUsuarios.Show();
        }
    }
}
