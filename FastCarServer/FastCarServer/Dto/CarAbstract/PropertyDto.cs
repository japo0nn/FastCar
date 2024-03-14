using FastCarServer.Dto.Abstract;

namespace FastCarServer.Dto.CarAbstract
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
            if (Field.FieldType == Enums.FieldType.String || Field.FieldType == Enums.FieldType.Option)
            {
                IntValue = null;
                FloatValue = null;
            }
            if (Field.FieldType == Enums.FieldType.Int)
            {
                StringValue = null;
                FloatValue = null;
            }
            if (Field.FieldType == Enums.FieldType.Float)
            {
                IntValue = null;
                StringValue = null;
            }
        }
    }
}
