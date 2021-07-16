﻿using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ReporsitoryInterfaces
{
    public interface IMovieRepository:IAsyncRepository<Movie>
    {

        Task<List<Movie>> GetHighest30GrossingMovies();
    }
}
