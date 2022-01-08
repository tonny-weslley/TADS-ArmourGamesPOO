﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmourGames
{
    class Jogo
    {
        //propriedades do objeto
        string nome, descricao;
        Dev dev;
        Categoria categoria;
        double valor;
        int numUser;
        //========================

        //getters
        public string getNome()
        {
            return this.nome;
        }
        public string getDescricao()
        {
            return this.descricao;
        }
        public Dev getDev()
        {
            return this.dev;
        }
        public Categoria getCategoria()
        {
            return this.categoria;
        }
        public double getValor()
        {
            return this.valor;
        }
        public int getNumUser()
        {
            return this.numUser;
        }
        //setters
        private void setNome(string nome)
        {
            this.nome = nome;
        }
        private void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        private void setDev (Dev dev)
        {
            this.dev = dev;
        }
        private void setCategoria(Categoria categoria)
        {
            this.categoria = categoria;
        }
        private void setValor(double valor)
        {
            this.valor = valor;
        }
        private void setNumUser(int numUser)
        {
            this.numUser = numUser;
        }
        //========================
    }
}