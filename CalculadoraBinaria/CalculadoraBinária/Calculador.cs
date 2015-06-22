using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBinária
{
    class Calculador
    {
        //public double sl;
        //public string simbo;
        //public double valor = 0;
        //public double valor2 = 0;
        //public double total = 0;
        //private double soma(double valor, double valor2)
        //{
        //    string atual = Inverter(valor.ToString());
        //    string atual2 = Inverter(valor2.ToString());
        //    bool carregado = false;
        //    string result = "";
        //    while (atual.Length > atual2.Length)
        //        atual2 += "0";
        //    while (atual.Length < atual2.Length)
        //        atual += "0";
        //    for (int i = 0; i < atual.Length; i++)
        //    {
        //        if (atual[i] != '0')
        //            break;
        //        if (i.Equals(atual.Length))
        //        {
        //            result = atual2;
        //        }
        //    }
        //    for (int i = 0; i < atual2.Length; i++)
        //    {
        //        if (atual2[i] != '0')
        //            break;
        //        if (i.Equals(atual2.Length))
        //        {
        //            result = atual;
        //        }
        //    }
        //    if (result.Equals(""))
        //    {
        //        for (int i = 0; i < atual.Length; i++)
        //        {
        //            switch (atual[i])
        //            {
        //                case '1':
        //                    if (atual2[i].Equals('1'))
        //                    {
        //                        if (carregado)
        //                            result += "1";
        //                        else
        //                        {
        //                            result += "0";
        //                            carregado = true;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        if (carregado)
        //                            result += "0";
        //                        else
        //                            result += "1";
        //                    }
        //                    break;
        //                case '0':
        //                    if (atual2[i].Equals('1'))
        //                    {
        //                        if (carregado)
        //                            result += "0";
        //                        else
        //                            result += "1";
        //                    }
        //                    else
        //                    {
        //                        if (carregado)
        //                        {
        //                            result += "1";
        //                            carregado = false;
        //                        }
        //                        else
        //                            result += "0";
        //                    }
        //                    break;
        //            }
        //            if (carregado && i.Equals(atual.Length - 1))
        //                result += "1";
        //        }
        //    }
        //    result = Inverter(result);
        //    return Convert.ToDouble(result);
        //}
        //public void calcular()
        //{
        //    // pegar o valor atual
        //    valor2 = sl;
        //    // executar as contas no "total"
        //    switch (simbo)
        //    {
        //        case "+":
        //            total = soma(valor, valor2);
        //            break;
        //    }
        //}
    }
}
