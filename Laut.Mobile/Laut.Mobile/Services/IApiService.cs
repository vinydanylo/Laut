using Laut.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laut.Mobile.Services
{
    public interface IApiService
    {
        Task<List<News>> GetNews();
    }
}
