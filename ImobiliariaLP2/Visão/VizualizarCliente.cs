﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImobiliariaLP2.Modelo;
using ImobiliariaLP2.DAO;
using ImobiliariaLP2.Visão;

namespace ImobiliariaLP2.Visão
{
    public partial class VizualizarCliente : Form
    {
        public VizualizarCliente()
        {
            InitializeComponent();
        }

        public VizualizarCliente(Cliente c)
        {
            InitializeComponent();
            SetDTO(c);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ClienteDAO cDAO = new ClienteDAO();
            cDAO.Atualizar(GetDTO());

            MessageBox.Show("Cadastro atualizado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxID.Clear();
            textBoxNome.Clear();
            maskedTextBoxCpf.Clear();
            textBoxRg.Clear();
            textBoxEmail.Clear();
            maskedTextBoxTelefone.Clear();

        }

        private Cliente GetDTO()
        {
            Cliente c = new Cliente();
            c.Id = int.Parse(textBoxID.Text);
            c.Nome = textBoxNome.Text;
            c.Cpf = maskedTextBoxCpf.Text;
            c.Rg = textBoxRg.Text;
            c.Email = textBoxEmail.Text;
            c.Telefone = maskedTextBoxTelefone.Text;

            return c;
        }

        private void SetDTO(Cliente c)
        {
            textBoxID.Text = c.Id.ToString();
            textBoxNome.Text = c.Nome;
            maskedTextBoxCpf.Text = c.Cpf;
            textBoxRg.Text = c.Rg;
            textBoxEmail.Text = c.Email;
            maskedTextBoxTelefone.Text = c.Telefone; 
        }
    }
}
