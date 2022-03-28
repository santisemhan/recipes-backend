﻿namespace recipes_backend.Repositories.Interfaces
{
    using recipes_backend.Models.Domain;

    public interface IUsuarioRepository
    {
        /// <summary>
        ///     Busca un usuario teniendo en cuenta el id 
        ///     pasado por parametro
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <returns>
        ///     El usuario encontrado
        /// </returns>
        Task<Usuario> BuscarUsuario(int usuarioId);
    }
}
