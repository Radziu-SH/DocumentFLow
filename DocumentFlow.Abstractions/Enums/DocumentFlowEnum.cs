using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFlow.Abstractions.Enums
{
    public enum DocumentFlowEnum
    {
        New = 1,
        SendToSupervisor = 2,
        SendToCTO = 3,
        SendToOpinion = 4,
        SendToCEO = 5,
        Finished = 6
    }
}
