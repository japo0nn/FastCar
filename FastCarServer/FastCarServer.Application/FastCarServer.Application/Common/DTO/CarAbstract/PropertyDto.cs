using FastCarServer.Application.Common.DTO.Abstract;
using FastCarServer.Core.Enums;

namespace FastCarServer.Application.Common.DTO.CarAbstract
{
    public class PropertyDto : MainDto
    {
        public Guid CarFieldId { get; set; }
        public FieldDto Field { get; set; }
        public string? StringValue { get; set; }
        public int? IntValue { get; set; }
        public float? FloatValue { get; set; }

        public PropertyDto()
        {
            if (Field.FieldType == FieldType.String || Field.FieldType == FieldType.Option)
            {
                IntValue = null;
                FloatValue = null;
            }
            if (Field.FieldType == FieldType.Int)
            {
                StringValue = null;
                FloatValue = null;
            }
            if (Field.FieldType == FieldType.Float)
            {
                IntValue = null;
                StringValue = null;
            }
        }
    }
}
