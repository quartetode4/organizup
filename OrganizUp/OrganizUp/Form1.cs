using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizUp
{
    public partial class Form1 : Form
    {
        public class Usuario
        {
            string nome;
            string senha;

            public void FazerLogin()
            {

            }
        }
        public class Calendario
        {
            DateTime dia;
            string horarioAulas;

            public void MarcaAtividade()
            {

            }
            public void MarcaFalta()
            {

            }
        }
        public class Materia
        {
            string nomeMateria;
            int faltaMateria;
            double notaMateria;

            public void QtdFaltas()
            {

            }
            public void MediaNotas()
            {

            }

        }
        public class Chat
        {
            string usuario;

            public void DigitarChat()
            {

            }
        }
        public class Atividades
        {
            string materiaAtividade;
        }
        public class ProvaEscrita : Atividades
        {
            string conteudoProva;

            public void EscreveConteudo()
            {

            }
        }
        public class Trabalho : Atividades
        {
            string temaTrabalho;

            public void EscreveTema()
            {

            }
        }
        public class Exercicio : Atividades
        {
            string assuntoExercicio;

            public void EscreveAssunto()
            {

            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
