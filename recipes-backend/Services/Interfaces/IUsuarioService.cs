﻿namespace recipes_backend.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task RecuperarContraseña(int usuarioId);
    }
}
