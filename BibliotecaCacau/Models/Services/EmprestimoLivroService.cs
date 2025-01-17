﻿using BibliotecaBookHub.Models.Contracts.Repositories;
using BibliotecaBookHub.Models.DTO;
using BibliotecaCacau.Models.DTO;
using System;
using System.Collections.Generic;

namespace BibliotecaBookHub.Models.Contracts.Services
{
    public class EmprestimoLivroService : IEmprestimoLivroService
    {
        private readonly IEmprestimoLivroRepository _emprestimoLivroRepository;

        public EmprestimoLivroService(IEmprestimoLivroRepository emprestimoLivroRepository)
        {
            _emprestimoLivroRepository = emprestimoLivroRepository;
        }


        public void EfetuarDevolucao(int emprestimoId, string livroId)
        {
            try
            {
                _emprestimoLivroRepository.EfetuarDevolucao(emprestimoId, livroId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EfetuarEmprestimo(EmprestimoLivroDTO emprestimoLivro)
        {
            try
            {
                var entidade = emprestimoLivro.ConverterParaEntidade();
                entidade.RealizarEmprestimo();
                _emprestimoLivroRepository.EfetuarEmprestimo(entidade);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ConsultaEmprestimoDTO> ConsultarEmprestimos()
        {
            return _emprestimoLivroRepository.ConsultarEmprestimos();
        }

        public ConsultaEmprestimoDTO PesquisarEmprestimo(string nomeLivro, string nomeCliente, DateTime dataEmprestimo)
        {
            return _emprestimoLivroRepository.PesquisarEmprestimo(nomeLivro, nomeCliente, dataEmprestimo);
        }

        public void AtualizarStatusEmprestimoLivros()
        {
            _emprestimoLivroRepository.AtualizarStatusEmprestimoLivros();
        }
    }
}
