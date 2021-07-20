﻿using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IGenreRepository : IAsyncRepository<Genre>
    {
        Task<List<Movie>> GetHighest30GrossingMoviesByGenre(int id);
    }
}