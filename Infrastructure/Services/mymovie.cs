using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
namespace Infrastructure.Services
{
    public class mymovie
    {
        public List<wenyimv> getmv()
        {
            var mv = new List<wenyimv> { new wenyimv { Id=1,Title="ascas"} };
            return mv;
        }
    }
}
