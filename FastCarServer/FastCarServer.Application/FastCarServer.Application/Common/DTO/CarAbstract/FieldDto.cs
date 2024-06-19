using FastCarServer.Application.Common.DTO.Abstract;
using FastCarServer.Core.Enums;

namespace FastCarServer.Application.Common.DTO.CarAbstract
{
    public class FieldDto : MainDto
    {
        public string FieldName { get; set; }
        public FieldType FieldType { get; set; }
        public string? UnitOfMeasure { get; set; }
        public OptionType? OptionType { get; set; }

        public List<FieldOptionDto> FieldOptions { get; set; }
    }
}
