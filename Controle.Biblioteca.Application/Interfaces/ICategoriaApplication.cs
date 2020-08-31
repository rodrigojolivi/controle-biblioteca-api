﻿using Controle.Biblioteca.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Controle.Biblioteca.Application.Interfaces
{
    public interface ICategoriaApplication
    {
        Task<IEnumerable<CategoriaViewModel>> ListarTodasCategorias();
    }
}
