using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.Messaging.Events
{
    public record MaterialInfoEvent: IntegrationEvent
    {
        public string MaterialCode { set; get; }
        public string MaterialName { set; get; }
        public string Description { set; get; }
    }
}
