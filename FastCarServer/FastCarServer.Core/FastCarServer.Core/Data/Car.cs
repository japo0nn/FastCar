using FastCarServer.Core.Data.Abstract;
using FastCarServer.Core.Data.CarAbstract;

namespace FastCarServer.Core.Data
{
    public class Car : Entity
    {
        public List<Property> Properties { get; set; }
    }
}
