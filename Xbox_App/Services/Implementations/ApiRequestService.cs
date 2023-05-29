using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbox_App.Models;
using Xbox_App.Services.Interfaces;

namespace Xbox_App.Services.Implementations
{
    public class ApiRequestService : IApiRequestService
    {
        public Task<T> GetData<T>() where T : BaseModel
        {
            throw new NotImplementedException();
        }
    }
}
