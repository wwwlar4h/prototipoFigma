﻿using System.Windows.Forms;
using System;

public static class Validacoes
{
    public static bool ValidaCpf(string cpf)
    {
        int num = 10;
        int num2 = 11;
        int soma = 0;
        int dig = 0;
        int resto = 0;

        cpf = cpf.Replace(",", "");
        cpf = cpf.Replace(",", "");
        cpf = cpf.Replace("-", "");

        if (cpf.Length != 11) { return false; }

        for (int i = 0; i < 9; i++)
        {
            soma += Convert.ToInt32(cpf[i].ToString()) * num;
            num--;
        }
        resto = soma % 11;

        if (resto < 2)
        {
            dig = 0;
        }
        else /*if (resto >= 2)*/
        {
            dig = 11 - resto;
        }

        //Segundo dígito
        soma = 0;
        int dig2 = 0;

        for (int i = 0; i < 10; i++)
        {
            soma += Convert.ToInt32(cpf[i].ToString()) * num2;
            num2--;
        }

        int res2 = soma % 11;

        if (res2 < 2)
        {
            dig2 = 0;
        }
        else /*if (resto >= 2)*/
        {
            dig2 = 11 - res2;
        }

        int digVerI = Convert.ToInt32(cpf[9].ToString());
        int digVerII = Convert.ToInt32(cpf[10].ToString());

        if (dig == digVerI && dig2 == digVerII)
        {
            MessageBox.Show(" CPF válido!");
            return true;
        }
        else
        {
            MessageBox.Show(" CPF inválido!");
            return false;
        }
    
    }
}