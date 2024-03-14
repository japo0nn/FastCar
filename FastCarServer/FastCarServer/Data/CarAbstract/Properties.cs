using FastCarServer.Data.Abstract;

namespace FastCarServer.Data.CarAbstract
{
    public class Properties : Entity
    {
        public Guid CarFieldId { get; set; }
        public Field Field { get; set; }
        public string? StringValue { get; set; }
        public int? IntValue { get; set; }
        public float? FloatValue { get; set; }

        public Properties()
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
