using DocumentFlow.Abstractions.Common;
using DocumentFlow.Abstractions.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFlow.Document.Core.Entities
{
    public class Document : BaseEntity
    {
        public Document(string name, DocumentFlowEnum status)
        {
            Name = name;
            Status = status;
        }
        public Document()
        {

        }

        public string Name { get; private set; }
        public DocumentFlowEnum Status { get; private set; }
    }
}
