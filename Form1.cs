using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Titulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            aluno alunoObjeto = new aluno();
            alunoObjeto.nome = txtnome.Text ;
            alunoObjeto.nota1 = float.Parse(txtnota1.Text) ;
            alunoObjeto.nota2 = float.Parse(txtnota2.Text) ;
            alunoObjeto.nota3 = float.Parse(txtnota3.Text) ;
            
            alunoObjeto.media = (alunoObjeto.nota1 + alunoObjeto.nota2 + alunoObjeto.nota3) / 3f;

            if (alunoObjeto.media >= 6)
            {
                lblresultado.Text =  "APROVADO  "+ alunoObjeto.media;
                lblresultado.BackColor = Color.Green;
            }
            else if (alunoObjeto.media <=6)
            {
                lblresultado.Text =  "REPROVADO  " + alunoObjeto.media;
                lblresultado.BackColor = Color.Red;
            }

        }

    }
}
