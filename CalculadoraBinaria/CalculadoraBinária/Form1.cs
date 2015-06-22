using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBinária
{
    public partial class calculadoraBinaria : Form
    {
        Calculador calculator = new Calculador();
        Double value = 0;
        string operation = "";
        public calculadoraBinaria()
        {
            InitializeComponent();
        }

        private void AddZero(object sender, EventArgs e)
        {
            BinarioText.Text += "0";
        }

        private void AddOne(object sender, EventArgs e)
        {
            BinarioText.Text += "1";
        }

        public static string InverterString(string str)
        {
            int tamanho = str.Length;
            char[] caracteres = new char[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                caracteres[i] = str[tamanho - 1 - i];
            }
            return new string(caracteres);
        }

        public static int BinarioParaDecimal(string valorBi)
        {
            int expoente = 0;
            int numero;
            int soma = 0;
            string numeroInvertido = InverterString(valorBi);
            for (int i = 0; i < numeroInvertido.Length; i++)
            {
                numero = Convert.ToInt32(numeroInvertido.Substring(i, 1));
                soma += numero * (int)Math.Pow(2, expoente);
                expoente++;
            }
            return soma;
        }

        public static string BinarioParaHexadecimal(string binario)
        {
            StringBuilder resultado = new StringBuilder(binario.Length / 8 + 1);
            int mod4Len = binario.Length % 8;
            if (mod4Len != 0)
            {
                binario = binario.PadLeft(((binario.Length / 8) + 1) * 8, '0');
            }
            for (int i = 0; i < binario.Length; i += 8)
            {
                string eightBits = binario.Substring(i, 8);
                resultado.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
            }
            return resultado.ToString();
        }

        private void Binario(object sender, EventArgs e)
        {
            DecimalText.Text = BinarioParaDecimal(BinarioText.Text).ToString();
            HexadecimalText.Text = BinarioParaHexadecimal(BinarioText.Text).ToString();
        }

        public double sl;
        public string simbo;
        public double valor = 0;
        public double valor2 = 0;
        public double total = 0;
        private double soma(double valor, double valor2)
        {
            string atual = InverterString(valor.ToString());
            string atual2 = InverterString(valor2.ToString());
            bool carregado = false;
            string result = "";
            while (atual.Length > atual2.Length)
                atual2 += "0";
            while (atual.Length < atual2.Length)
                atual += "0";
            for (int i = 0; i < atual.Length; i++)
            {
                if (atual[i] != '0')
                    break;
                if (i.Equals(atual.Length))
                {
                    result = atual2;
                }
            }
            for (int i = 0; i < atual2.Length; i++)
            {
                if (atual2[i] != '0')
                    break;
                if (i.Equals(atual2.Length))
                {
                    result = atual;
                }
            }
            if (result.Equals(""))
            {
                for (int i = 0; i < atual.Length; i++)
                {
                    switch (atual[i])
                    {
                        case '1':
                            if (atual2[i].Equals('1'))
                            {
                                if (carregado)
                                    result += "1";
                                else
                                {
                                    result += "0";
                                    carregado = true;
                                }
                            }
                            else
                            {
                                if (carregado)
                                    result += "0";
                                else
                                    result += "1";
                            }
                            break;
                        case '0':
                            if (atual2[i].Equals('1'))
                            {
                                if (carregado)
                                    result += "0";
                                else
                                    result += "1";
                            }
                            else
                            {
                                if (carregado)
                                {
                                    result += "1";
                                    carregado = false;
                                }
                                else
                                    result += "0";
                            }
                            break;
                    }
                    if (carregado && i.Equals(atual.Length - 1))
                        result += "1";
                }
            }
            result = InverterString(result);
            return Convert.ToDouble(result);
        }
        public void calcular()
        {
            // pegar o valor atual
            valor2 = sl;
            // executar as contas no "total"
            switch (simbo)
            {
                case "+":
                    total = soma(valor, valor2);
                    break;
            }
        }
    }
}
    