﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImobiliariaLP2.Visão
{
    public partial class RelatoriosV : Form
    {
        public RelatoriosV()
        {
            InitializeComponent();
        }

        private void RltVendasP_Click(object sender, EventArgs e)
        {
            this.Dispose();
            RelatorioVendaPeridoV rvp = new RelatorioVendaPeridoV();
            rvp.ShowDialog();   
        }

        private void btnRltVendasF_Click(object sender, EventArgs e)
        {
            this.Dispose();
            RelatorioVendaFuncV rvf = new RelatorioVendaFuncV();
            rvf.ShowDialog();
        }

        private void btnRltImoveisDisp_Click(object sender, EventArgs e)
        {
            this.Dispose();
            RelatorioImoveisDisponivelV rid = new RelatorioImoveisDisponivelV();
            rid.ShowDialog();
        }

        private void btn_voltarMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aula13_11 a = new aula13_11();
            a.ShowDialog();
        }
    }
}
