using MauiMicroMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbox_App.Services.Interfaces;

namespace Xbox_App.ViewModels
{
    public class BaseViewModel : MauiMicroViewModel
    {
        public readonly IApiRequestService _requestService;

        public BaseViewModel(IApiRequestService requestService, ViewModelContext context) : base(context)
        {
            _requestService = requestService;
        }
    }
}
