using Domain.Common;
using Domain.Entities;

namespace Domain.Factories
{
    public class SeaLogistics : Logistics
    {
        // RoadLogistic Factory - method that describe how to create 'Truck' class instance.
        protected override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
