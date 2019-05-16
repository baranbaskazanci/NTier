using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Core.Entities
{

    class CoreEntity : ICoreEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIP { get; set; }
        public Guid CreatedBy { get; set; }




        public DateTime? ModifiedCreatedDate { get; set; }
        public string ModifiedCreatedComputerName { get; set; }
        public string ModifiedCreatedIP { get; set; }
        public Guid? ModifiedCreatedBy { get; set; }
    }
}
