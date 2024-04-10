using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iVertion.Domain.Validation
{
    public class IdentityValidation
    {
        public static bool CnpjVaidator(string cnpj){
			int[] multiplier1 = new int[12] {5,4,3,2,9,8,7,6,5,4,3,2};
			int[] multiplier2 = new int[13] {6,5,4,3,2,9,8,7,6,5,4,3,2};
			int sum;
			int rest;
			string digit;
			string tempCnpj;
			cnpj = cnpj.Trim();
			cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
			if (cnpj.Length != 14)
			   return false;
			tempCnpj = cnpj.Substring(0, 12);
			sum = 0;
			for(int i=0; i<12; i++)
			   sum += int.Parse(tempCnpj[i].ToString()) * multiplier1[i];
			rest = (sum % 11);
			if ( rest < 2)
			   rest = 0;
			else
			   rest = 11 - rest;
			digit = rest.ToString();
			tempCnpj = tempCnpj + digit;
			sum = 0;
			for (int i = 0; i < 13; i++)
			   sum += int.Parse(tempCnpj[i].ToString()) * multiplier2[i];
			rest = (sum % 11);
			if (rest < 2)
			    rest = 0;
			else
			   rest = 11 - rest;
			digit = digit + rest.ToString();
			return cnpj.EndsWith(digit);            
        }
        public static bool ValidarCpf(string cpf)
        {
        cpf = cpf.Trim().Replace(".", "").Replace("-", "");

        if (cpf.Length != 11)
        {
            return false;
        }
        for (int i = 1; i < cpf.Length; i++)
        {
            if (cpf[i] != cpf[0])
            {
            break;
            }

            if (i == cpf.Length - 1)
            {
            return false;
            }
        }
        int[] multiplier1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        int[] multiplier2 = new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        int sum1 = 0;
        for (int i = 0; i < 9; i++)
        {
            sum1 += int.Parse(cpf[i].ToString()) * multiplier1[i];
        }

        int rest1 = sum1 % 11;
        int digit1 = rest1 < 2 ? 0 : 11 - rest1;

        int sum2 = 0;
        for (int i = 0; i < 10; i++)
        {
            sum2 += int.Parse(cpf[i].ToString()) * multiplier2[i];
        }

        int rest2 = sum2 % 11;
        int digit2 = rest2 < 2 ? 0 : 11 - rest2;

        return cpf.Equals(cpf.Substring(0, 9) + digit1.ToString() + digit2.ToString());
        }
    }
}