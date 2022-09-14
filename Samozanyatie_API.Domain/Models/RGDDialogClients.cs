using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samozanyatie_API.Domain.Models
{
    public class RGDialogsClients
    {
        /// <summary>
        /// Primary Id
        /// </summary>
        public Guid IDUnique { get; set; }

        /// <summary>
        /// Dialog Id
        /// </summary>
        public Guid IDRGDialog { get; set; }

        /// <summary>
        /// Client Id
        /// </summary>
        public Guid IDClient { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        public DateTime? DateEvent { get; set; }
     

    }
}
