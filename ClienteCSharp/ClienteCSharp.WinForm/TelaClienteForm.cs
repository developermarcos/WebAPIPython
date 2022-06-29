using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace ClienteCSharp.WinForm
{
    public partial class TelaClienteForm : Form
    {
        ModelClienteAPI clienteAPI;
        public TelaClienteForm()
        {
            InitializeComponent();
            clienteAPI = new ModelClienteAPI();
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            string textoCpf = txtBoxCPF.Text;
            labelStatusCpf.Text = "Pesquisando...";
            if (textoCpf == "")
                return;
            int cpf = Convert.ToInt32(textoCpf);

            var resultado = await clienteAPI.ValidaCpfAsync(cpf);
            if(resultado == "true\n")
            {
                labelStatusCpf.Text = "Válido";
                return;
            }
            labelStatusCpf.Text = "Inválido";
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            string textoID = txtBoxID.Text;

            txtBoxResultado.Text = "Esperando resposta...";

            if (textoID == "")
                return;

            int ID = Convert.ToInt32(textoID);

            
            if (rBtnGet.Checked == true)
            {
                var resultado = await clienteAPI.SelecionarPorIDAsync(ID);

                txtBoxResultado.Text = resultado;
            }

            if(rBtnPost.Checked == true)
            {
                string nome = txtBoxNome.Text;

                string idade = txtBoxIdade.Text;

                var resultado = await clienteAPI.InserirUserAsync(ID, nome, idade);

                txtBoxResultado.Text = resultado;
            }

            if(rBtnPut.Checked == true)
            {
                string nome = txtBoxNome.Text;

                string idade = txtBoxIdade.Text;

                var resultado = await clienteAPI.EditarUserAsync(ID, nome, idade);

                txtBoxResultado.Text = resultado;
            }

            if(rBtnDelete.Checked == true)
            {
                var resultado = await clienteAPI.DeleteUserAsync(ID);

                txtBoxResultado.Text = resultado;
            }
        }
    }
}