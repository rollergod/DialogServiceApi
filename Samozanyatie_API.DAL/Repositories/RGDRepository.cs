﻿using Samozanyatie_API.DAL.Interfaces;
using Samozanyatie_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samozanyatie_API.DAL.Repositories
{
    public class RGDRepository : IRGDRepository
    {
        public List<RGDialogsClients> Init()
        {
            List<RGDialogsClients> L1 = new List<RGDialogsClients>();

            var IDClient1 = new Guid("4b6a6b9a-2303-402a-9970-6e71f4a47151");

            var IDClient2 = new Guid("c72e5cb5-d6b4-4c0c-9992-d7ae1c53a820");

            var IDClient3 = new Guid("7de3299b-2796-4982-a85b-2d6d1326396e");

            var IDClient4 = new Guid("0a58955e-342f-4095-88c6-1109d0f70583");

            var IDClient5 = new Guid("50454d55-a73c-4cbc-be25-3c5729dcb82b");

            Guid IDRGDialog1 = new Guid("fcd6b112-1834-4420-bee6-70c9776f6378");

            L1.Add(new RGDialogsClients
            {

                IDUnique = Guid.NewGuid(),

                IDRGDialog = IDRGDialog1,

                IDClient = IDClient1

            });

            L1.Add(new RGDialogsClients
            {

                IDUnique = Guid.NewGuid(),

                IDRGDialog = IDRGDialog1,

                IDClient = IDClient2

            });

            L1.Add(new RGDialogsClients
            {

                IDUnique = Guid.NewGuid(),

                IDRGDialog = IDRGDialog1,

                IDClient = IDClient3

            });

            Guid IDRGDialog2 = new Guid("19f6f751-7f8d-41fa-8261-709028650592");

            L1.Add(new RGDialogsClients
            {

                IDUnique = Guid.NewGuid(),

                IDRGDialog = IDRGDialog2,

                IDClient = IDClient1

            });

            L1.Add(new RGDialogsClients
            {

                IDUnique = Guid.NewGuid(),

                IDRGDialog = IDRGDialog2,

                IDClient = IDClient2

            });

            Guid IDRGDialog3 = new Guid("83ebeb2b-c315-48a2-b6e5-f0324de57a9f");

            L1.Add(new RGDialogsClients
            {

                IDUnique = Guid.NewGuid(),

                IDRGDialog = IDRGDialog3,

                IDClient = IDClient3

            });

            L1.Add(new RGDialogsClients
            {

                IDUnique = Guid.NewGuid(),

                IDRGDialog = IDRGDialog3,

                IDClient = IDClient4

            });

            L1.Add(new RGDialogsClients
            {

                IDUnique = Guid.NewGuid(),

                IDRGDialog = IDRGDialog3,

                IDClient = IDClient5

            });


            Guid IDRGDialog4 = new Guid("123beb2f-c315-41a2-b2e5-f0324de55a9f");

            L1.Add(new RGDialogsClients
            {
                IDUnique = Guid.NewGuid(),
                IDRGDialog = IDRGDialog4,
                IDClient = IDClient1
            });

            L1.Add(new RGDialogsClients
            {
                IDUnique = Guid.NewGuid(),
                IDRGDialog = IDRGDialog4,
                IDClient = IDClient2
            });

            L1.Add(new RGDialogsClients
            {
                IDUnique = Guid.NewGuid(),
                IDRGDialog = IDRGDialog4,
                IDClient = IDClient3
            });

            return L1;

        }
    }
}