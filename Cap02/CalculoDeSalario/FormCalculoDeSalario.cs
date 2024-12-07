using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDeSalario
{
    public partial class FormCalculoDeSalario : Form
    {
        public FormCalculoDeSalario()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            RadioButton rbnTurno = gbxTurno.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);
            RadioButton rbnCategoria = gbxCategoria.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);
            RealizarProcessamento(rbnTurno, rbnCategoria, Convert.ToDouble(txtHorasTrabalhadas.Text),
                Convert.ToDouble(txtSalarioMinimo.Text));
        }

        private void RealizarProcessamento(RadioButton rbnTurno, RadioButton rbnCategoria, double horasTrabalhas,
            double valorSalarioMinimo)
        {
            double valorCoeficiente = GetCoeficiente(rbnTurno);
            double valorGratificacao = GetGratificacao(rbnTurno, horasTrabalhas);
            double valorSalarioBruto = horasTrabalhas * valorCoeficiente;
            double valorImposto = GetValorImposto(rbnCategoria, valorSalarioBruto);
            double valorAuxilioAlimentacao = GetValorAuxilioAlimentacao(rbnCategoria, valorSalarioBruto, valorSalarioMinimo);
            double valorSalarioLiquido = (valorSalarioBruto + (valorGratificacao + valorAuxilioAlimentacao)) - valorImposto;
            ApresentarResultados(valorCoeficiente, valorSalarioBruto, valorImposto, valorGratificacao
                , valorAuxilioAlimentacao, valorSalarioLiquido);
        }

        private double GetCoeficiente(RadioButton rbnTurno)
        {
            double valorCoeficiente = 0;
            switch (rbnTurno.Text)
            {
                case "Matutino":
                    valorCoeficiente = Convert.ToDouble(txtSalarioMinimo.Text) * 0.01;
                    break;
                case "Vespertino":
                    valorCoeficiente = Convert.ToDouble(txtSalarioMinimo.Text) * 0.02;
                    break;
                case "Noturno":
                    valorCoeficiente = Convert.ToDouble(txtSalarioMinimo.Text) * 0.03;
                    break;
            }
            return valorCoeficiente;
        }

        private double GetGratificacao(RadioButton rbnTurno, double horasTrabalhas)
        {
            double valorGratificacao = 30;
            if (rbnTurno.Text.Equals("Noturno") && horasTrabalhas > 80)
            {
                valorGratificacao = 50;
            }
            return valorGratificacao;
        }

        private double GetValorImposto(RadioButton rbnCategoria, double valorSalarioBruto)
        {
            double valorImposto = 0;
            switch (rbnCategoria.Text)
            {
                case "Calouro":
                    if (valorSalarioBruto < 300)
                    {
                        valorImposto = valorSalarioBruto * 0.01;
                    }
                    else
                    {
                        valorImposto = valorSalarioBruto * 0.02;
                    }
                    break;
                case "Veterano":
                    if (valorSalarioBruto < 400)
                    {
                        valorImposto = valorSalarioBruto * 0.03;
                    }
                    else
                    {
                        valorImposto = valorSalarioBruto * 0.04;
                    }
                    break;
            }
            return valorImposto;
        }

        private double GetValorAuxilioAlimentacao(RadioButton rbnCategoria, double valorSalarioBruto, double valorSalarioMinimo)
        {
            double valorAuxilioAlimentacao = (valorSalarioBruto / 3) / 2;
            if (rbnCategoria.Text.Equals("Calouro") && (valorSalarioBruto < (valorSalarioMinimo / 2)))
            {
                valorAuxilioAlimentacao = (valorSalarioBruto / 3);
            }
            return valorAuxilioAlimentacao;
        }

        private void ApresentarResultados(double valorCoeficiente, double valorSalarioBruto, double valorImposto, double valorGratificacao, double valorAuxilioAlimentacao, double valorSalarioLiquido)
        {
            lbxResumo.Items.Clear();
            txtSituacaoEstagiario.Text = GetSituacaoEstagiario(valorSalarioLiquido);
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor do coeficiente", valorCoeficiente));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Salário Bruto", valorSalarioBruto));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor do imposto", valorImposto));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor da gratificação", valorGratificacao));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor auxílio alimentação", valorAuxilioAlimentacao));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Salário líquido", valorSalarioLiquido));
        }

        private string GetSituacaoEstagiario(double valorSalarioLiquido)
        {
            if (valorSalarioLiquido < 350)
            {
                return "Mal remunerado";
            }

            if (valorSalarioLiquido < 600)
            {
                return "Normal";
            }

            return "Bem remunerado";
        }
    }
}
