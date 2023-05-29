using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbox_App.Models;

namespace Xbox_App.Services.Interfaces
{
    public interface IApiRequestService
    {
        Task<T> GetData<T>(string url) where T : BaseModel;
        Task<List<T>> GetListedData<T>(string url) where T : BaseModel;
    }
}
