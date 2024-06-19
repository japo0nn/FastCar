using FastCarServer.Application.Common.DTO.Abstract;
using FastCarServer.Application.Common.DTO.CarAbstract;

namespace FastCarServer.Application.Common.DTO
{
    public class CarDto : MainDto
    {
        public List<PropertyDto> Properties { get; set; }
    }
}
