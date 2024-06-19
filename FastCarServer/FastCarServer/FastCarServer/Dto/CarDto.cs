using FastCarServer.Dto.Abstract;
using FastCarServer.Dto.CarAbstract;

namespace FastCarServer.Dto
{
    public class CarDto : MainDto
    {
        public List<PropertyDto> Properties { get; set; }
    }
}
