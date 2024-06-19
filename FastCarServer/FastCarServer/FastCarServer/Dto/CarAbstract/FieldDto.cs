using FastCarServer.WebAPI.Dto.Abstract;
using FastCarServer.WebAPI.Enums;

namespace FastCarServer.WebAPI.Dto.CarAbstract
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
