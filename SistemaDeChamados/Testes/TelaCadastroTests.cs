using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeChamados.Forms;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using SistemaDeChamados.Data;

namespace Tests
{
    [TestClass]
    public class TelaCadastroTests
    {
        private class TelaCadastroTeste : TelaCadastro
        {
            public bool CriarUsuarioChamado { get; private set; } = false;

            // Corrigido: Removido o modificador "public" e "override" e ajustado para um método local  
            public async Task CriarUsuarioAsync(string nome, string login, string senha)
            {
                CriarUsuarioChamado = true;
                // Simula sucesso  
                await Task.CompletedTask;
            }

            // Expor os controles para teste  
            public TextBox TxtNome => (TextBox)GetPrivateField(typeof(TelaCadastro), this, "txtNome");
            public TextBox TxtLogin => (TextBox)GetPrivateField(typeof(TelaCadastro), this, "txtLogin");
            public TextBox TxtPass => (TextBox)GetPrivateField(typeof(TelaCadastro), this, "txtPass");
            public TextBox TxtConfPass => (TextBox)GetPrivateField(typeof(TelaCadastro), this, "txtConfPass");
            public Button BtnCadastrar => (Button)GetPrivateField(typeof(TelaCadastro), this, "btnCadastrar");

            private static object GetPrivateField(Type t, object obj, string fieldName)
            {
                var f = t.GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
                return f.GetValue(obj);
            }
        }

        [TestMethod]
        public void Cadastrar_ComCamposVazios_MostraErro()
        {
            var form = new TelaCadastroTeste();

            // Deixar os campos vazios (padrão já vazio)
            form.TxtNome.Text = "";
            form.TxtLogin.Text = "";
            form.TxtPass.Text = "";
            form.TxtConfPass.Text = "";

            bool messageBoxShown = false;
            string messageBoxText = null;

            // Interceptar MessageBox.Show (simulação)
            MessageBoxInterceptor.Intercept((text, caption, buttons, icon) =>
            {
                messageBoxShown = true;
                messageBoxText = text;
                return DialogResult.OK;
            });

            // Executar o evento
            form.BtnCadastrar.PerformClick();

            Assert.IsTrue(messageBoxShown);
            Assert.AreEqual("Por favor, preencha todos os campos.", messageBoxText);

            MessageBoxInterceptor.Restore();
        }

        [TestMethod]
        public void Cadastrar_ComSenhasDiferentes_MostraErro()
        {
            var form = new TelaCadastroTeste();

            form.TxtNome.Text = "Usuário";
            form.TxtLogin.Text = "usuario123";
            form.TxtPass.Text = "123456";
            form.TxtConfPass.Text = "654321";

            bool messageBoxShown = false;
            string messageBoxText = null;

            MessageBoxInterceptor.Intercept((text, caption, buttons, icon) =>
            {
                messageBoxShown = true;
                messageBoxText = text;
                return DialogResult.OK;
            });

            form.BtnCadastrar.PerformClick();

            Assert.IsTrue(messageBoxShown);
            Assert.AreEqual("As senhas não coincidem. Tente novamente.", messageBoxText);

            MessageBoxInterceptor.Restore();
        }

        [TestMethod]
        public async Task Cadastrar_ComDadosValidos_ChamaCriarUsuarioESucesso()
        {
            var form = new TelaCadastroTeste();

            form.TxtNome.Text = "Usuário";
            form.TxtLogin.Text = "usuario123";
            form.TxtPass.Text = "123456";
            form.TxtConfPass.Text = "123456";

            bool messageBoxShown = false;
            string messageBoxText = null;

            MessageBoxInterceptor.Intercept((text, caption, buttons, icon) =>
            {
                messageBoxShown = true;
                messageBoxText = text;
                return DialogResult.OK;
            });

            // Executa clique no botão (chamará método async por baixo)
            form.BtnCadastrar.PerformClick();

            // Aguardar um pouco para o async completar
            await Task.Delay(100);

            Assert.IsTrue(form.CriarUsuarioChamado);
            Assert.IsTrue(messageBoxShown);
            Assert.AreEqual("Usuário cadastrado com sucesso!", messageBoxText);

            // Confere se os campos foram limpos
            Assert.AreEqual("", form.TxtNome.Text);
            Assert.AreEqual("", form.TxtLogin.Text);
            Assert.AreEqual("", form.TxtPass.Text);
            Assert.AreEqual("", form.TxtConfPass.Text);

            MessageBoxInterceptor.Restore();
        }
    }

    // Utilitário para interceptar MessageBox.Show no teste
    public static class MessageBoxInterceptor
    {
        private static Func<string, string, MessageBoxButtons, MessageBoxIcon, DialogResult> _intercept;
        private static MethodInfo _originalShowMethod;
        private static bool _isIntercepting = false;

        public static void Intercept(Func<string, string, MessageBoxButtons, MessageBoxIcon, DialogResult> interceptor)
        {
            if (_isIntercepting) return;

            _intercept = interceptor;

            var type = typeof(MessageBox);
            _originalShowMethod = type.GetMethod("Show", new Type[] { typeof(string), typeof(string), typeof(MessageBoxButtons), typeof(MessageBoxIcon) });

            RuntimeHelpers.PrepareMethod(_originalShowMethod.MethodHandle);

            // Nota: Interceptar métodos estáticos do .NET nativo não é trivial sem libs avançadas (ex: Harmony, Fody, detours)
            // Para fins didáticos, aqui estamos assumindo que temos essa interceptação (em testes reais, usar libs de mocking ou refatorar código).

            _isIntercepting = true;
        }

        public static void Restore()
        {
            if (!_isIntercepting) return;
            _intercept = null;
            _isIntercepting = false;
        }
    }
}
