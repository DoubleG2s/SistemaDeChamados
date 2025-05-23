using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using SistemaDeChamados;

namespace Tests
{
    [TestClass]
    public class FormDetalheChamadoTests
    {
        private class ChamadoFalso
        {
            public int Id { get; set; } = 1;
            public string Titulo { get; set; } = "Problema no sistema";
            public DateTime Data_Registro { get; set; } = new DateTime(2025, 5, 22, 14, 30, 0);
            public string Descricao { get; set; } = "Erro ao abrir o programa.";
            public string Usuario_Nome { get; set; } = "João da Silva";
            public int Usuario_Id { get; set; } = 100;
        }

        [TestMethod]
        public void FormDetalheChamado_PreencheLabelsCorretamente()
        {
            // Arrange
            var chamadoFake = new ChamadoFalso();

            // Act
            var form = new FormDetalheChamado(chamadoFake);

            // Aguardar renderização dos controles
            form.Show();
            Application.DoEvents();

            // Assert
            var labelId = GetPrivateLabel(form, "labelId");
            var labelTitulo = GetPrivateLabel(form, "labelTitulo");
            var labelDataRegistro = GetPrivateLabel(form, "labelDataRegistro");
            var labelDescri = GetPrivateLabel(form, "labelDescri");
            var labelUsuario = GetPrivateLabel(form, "labelUsuario");

            Assert.AreEqual("#1", labelId?.Text);
            Assert.AreEqual("Problema no sistema", labelTitulo?.Text);
            Assert.AreEqual("22/05/2025 14:30", labelDataRegistro?.Text);
            Assert.AreEqual("Erro ao abrir o programa.", labelDescri?.Text);
            Assert.AreEqual("João da Silva", labelUsuario?.Text);

            form.Close();
        }

        private Label GetPrivateLabel(Form form, string labelName)
        {
            var field = typeof(FormDetalheChamado).GetField(labelName,
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            return field?.GetValue(form) as Label;
        }
    }
}
