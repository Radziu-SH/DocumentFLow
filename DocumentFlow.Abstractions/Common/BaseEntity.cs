using DocumentFlow.Abstractions.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFlow.Abstractions.Common
{
    public class BaseEntity
    {
        public Guid Id { get; private set; }
        public string CreateBy { get; private set; }
        public DateTime CreateDate { get; private set; }
        public EntityStatusEnum EntityStatus { get; private set; }

        public void Create()
        {
            Id = Guid.NewGuid();
            CreateBy = "SYSTEM";
            CreateDate = DateTime.Now;
            EntityStatus = EntityStatusEnum.Active;
        }
    }
}
