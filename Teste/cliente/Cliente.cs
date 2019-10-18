using System;

namespace Mcbonalds
{
    public class Cliente
    {
        // Propriedades
        public string Endereco; //Nome do cliente
        public string Nome; //Endereco do cliente
        public string Telefone; //Telefone do cliente
        public  string Email;   //Email do cliente ao sistema
        public string Senha;    //senha de acesso do cliente ao sistema
        public DateTime DataNascimento;     //Data de nascimento do cliente

        //Construtores
        public Cliente(string Nome, string Telefone, string Email){
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Email = Email;
        }
    }
}