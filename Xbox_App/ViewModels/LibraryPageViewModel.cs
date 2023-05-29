using MauiMicroMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbox_App.Services.Interfaces;

namespace Xbox_App.ViewModels
{
    public class LibraryPageViewModel : BaseViewModel
    {
        public LibraryPageViewModel(IApiRequestService apiRequestService, ViewModelContext context) : base(apiRequestService, context)
        {
        }
    }
}
