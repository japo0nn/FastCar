using FastCarServer.Core.Data.Abstract;
using FastCarServer.Core.Enums;

namespace FastCarServer.Core.Data.CarAbstract
{
    public class Property : Entity
    {
        public Guid CarFieldId { get; set; }
        public Field Field { get; set; }
        public string? StringValue { get; set; }
        public int? IntValue { get; set; }
        public float? FloatValue { get; set; }

        public Property()
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
