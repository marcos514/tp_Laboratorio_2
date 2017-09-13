using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entidades.Calculadora;

namespace TP_1
{
    public partial class Form1 : Form
    {
        private Numeros numeroUno;
        private Numeros numeroDos;
        private Numeros resultado;
        private string operador;


        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// limpia el formulario 
        /// </summary>
        private void limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.lblResultado.Text="0";
            this.cmbOperacion.Text="";

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.numeroUno = new Numeros(this.txtNumero1.Text);
            this.numeroDos = new Numeros(this.txtNumero2.Text);
            this.operador = Calculadoras.validarOperador(this.cmbOperacion.Text);
            this.resultado = new Numeros(Calculadoras.operar(this.numeroUno, this.numeroDos, this.operador));
            
            this.txtNumero1.Text = this.numeroUno.getNumero().ToString();
            this.txtNumero2.Text = this.numeroDos.getNumero().ToString();
            this.cmbOperacion.Text = this.operador;
            this.lblResultado.Text = this.resultado.getNumero().ToString();  
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }
    }
}
