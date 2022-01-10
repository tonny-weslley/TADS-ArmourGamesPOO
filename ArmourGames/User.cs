﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmourGames
{

    // A Classe User é uma generalização.
    abstract class User
    {
        // definindo as propriedades do Objeto
        string nome, login, senha;
        List<Jogo> biblioteca = new List<Jogo>();
        double saldo;
        //========================

        //getters
        public string getNome()
        {
            return this.nome;
        }
        public string getLogin()
        {
            return this.login;
        }
        public string getSenha()
        {
            return this.senha;
        }
        public List<Jogo> getBiblioteca()
        {
            return this.biblioteca;
        }
        public double getSaldo()
        {
            return this.saldo;
        }
        //setters
        protected void setNome(string nome)
        {
            this.nome = nome;
        }
        protected void setLogin(string login)
        {
            this.login = login;
        }
        protected void setSenha(string senha)
        {
            this.senha = senha;
        }
        protected void setBiblioteca(List<Jogo> biblioteca)
        {
            this.biblioteca = biblioteca;
        }
        protected void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }
    }
}
