using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank2.Models
{
    public class ContaEspecial : ContaBancaria
    {
        public double Limite;
        public CobtaEspecial(int Agencia, int NumeroConta, String Titular) : base(Agencia, NumeroConta, Titular)
        {
            Limite = 0.0;
        } 
        public bool SetLimite(double valor)
        {
            if (valor >= 0)
            {
                Limite = valor;
                return true;
            }

            return false;
        }
        public override bool Saque(double valor)
        {
            if (valor >= 0)
            {
                Saldo -= valor;
                return true;
            }
        }
    }
}