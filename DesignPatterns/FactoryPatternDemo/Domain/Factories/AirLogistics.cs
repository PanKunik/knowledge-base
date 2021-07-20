using Domain.Common;
using Domain.Entities;

namespace Domain.Factories
{
    public class AirLogistics : Logistics
    {
        // AirLogistic Factory - method describe how to create 'Aeroplane' class instance.
        protected override ITransport CreateTransport()
        {
            return new Aeroplane();
        }
    }
}
