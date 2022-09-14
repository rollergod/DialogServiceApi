using Samozanyatie_API.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samozanyatie_API.Application.Interfaces
{
    public interface IGetDialog
    {
        public Guid GetDialogId(Guid[] clientIds);
    }
}
