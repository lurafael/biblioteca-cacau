﻿using BibliotecaBookHub.Models.DTO;
using System.Collections.Generic;


namespace BibliotecaBookHub.Models.Contracts.Services
{
    public interface IUsuarioService : IGenericService<UsuarioDTO, int>
    {
        UsuarioDTO EfetuarLogin(UsuarioDTO usuario);
    }
}
