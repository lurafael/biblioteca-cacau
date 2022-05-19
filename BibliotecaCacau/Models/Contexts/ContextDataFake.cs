﻿using BibliotecaBookHub.Models.Contracts;
using BibliotecaBookHub.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaBookHub.Models.Contexts
{
    public class ContextDataFake : IContextData
    {
        private static List<LivroDTO> livros;

        public ContextDataFake()
        {
            livros = new List<LivroDTO>();
            InitializeData();
        }

        private static void InitializeData()
        {
            livros.Add(new LivroDTO { Nome = "Implementando Domain-Driven Design", Autor = "Vaugh Vernon", Editora = "Alta Books" });
            livros.Add(new LivroDTO { Nome = "Domain-Driven Design", Autor = "Eric Evans", Editora = "Alta Books" });
            livros.Add(new LivroDTO { Nome = "Redes Guia Prático", Autor = "Carlos E. Morimoto", Editora = "Sul Editores" });
            livros.Add(new LivroDTO { Nome = "PHP Programando com Orientação a Objetos", Autor = "Pablo Dall'Oglio", Editora = "Novatec" });
            livros.Add(new LivroDTO { Nome = "Introdução a Programação com Python", Autor = "Nilo N. C. Menezes", Editora = "Novatec" });
        }

        public void AtualizarLivro(LivroDTO livro)
        {
            try
            {
                var objPesquisa = PesquisarLivroPorId(livro.Id);
                livros.Remove(objPesquisa);

                objPesquisa.Nome = livro.Nome;
                objPesquisa.Editora = livro.Editora;
                objPesquisa.Autor = livro.Autor;

                CadastrarLivro(objPesquisa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CadastrarLivro(LivroDTO livro)
        {
            try
            {
                livros.Add(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeletarLivro(string id)
        {
            try
            {
                var objPesquisa = PesquisarLivroPorId(id);
                livros.Remove(objPesquisa); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LivroDTO> ListarLivro()
        {
            try
            {
                return livros
                    .OrderBy(x => x.Nome)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public LivroDTO PesquisarLivroPorId(string id)
        {
            try
            {
                return livros.FirstOrDefault(x => x.Id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
