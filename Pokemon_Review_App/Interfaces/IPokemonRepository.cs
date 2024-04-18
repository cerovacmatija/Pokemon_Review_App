﻿using Pokemon_Review_App.Models;

namespace Pokemon_Review_App.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
    }
}
