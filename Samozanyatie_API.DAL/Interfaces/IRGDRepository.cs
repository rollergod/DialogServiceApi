using Samozanyatie_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samozanyatie_API.DAL.Interfaces
{
    public interface IRGDRepository
    {
        /// <summary>
        /// Фейк данные
        /// </summary>
        /// <returns></returns>
        public List<RGDialogsClients> Init();
    }
}
