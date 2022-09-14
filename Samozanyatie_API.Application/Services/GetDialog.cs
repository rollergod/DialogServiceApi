using Samozanyatie_API.Application.Interfaces;
using Samozanyatie_API.DAL.Interfaces;
using Samozanyatie_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samozanyatie_API.Application.Services
{
    public class GetDialog : IGetDialog
    {

        private readonly IRGDRepository _repo;

        public GetDialog(IRGDRepository repo)
        {
            _repo = repo;
        }

        public Guid GetDialogId(Guid[] clientIds)
        {
            Guid resultId = Guid.Empty;

            var initialData = _repo.Init();

            var dialogGroups = initialData.GroupBy(d => d.IDRGDialog);

            foreach (var groupedClients in dialogGroups)
            {
                if (groupedClients.Count() != clientIds.Length)
                    continue;

                var returnValue = groupedClients.Select(obj => obj.IDClient)
                    .Intersect(clientIds)
                    .Count() == clientIds.Length;

                if (returnValue)
                    resultId = groupedClients.Key;
            }

            return resultId;
        }
    }
}
