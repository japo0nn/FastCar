using FastCarServer.WebAPI.Dto.Abstract;
using FastCarServer.WebAPI.Dto.CarAbstract;

namespace FastCarServer.WebAPI.Dto
{
    public class CarDto : MainDto
    {
        public List<PropertyDto> Properties { get; set; }
    }
}
