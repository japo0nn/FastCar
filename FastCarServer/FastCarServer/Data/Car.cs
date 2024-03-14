using FastCarServer.Data.Abstract;
using FastCarServer.Data.CarAbstract;

namespace FastCarServer.Data
{
    public class Car : Entity
    {
        public List<Properties> Properties { get; set; }
    }
}
