using FastCarServer.Data.Abstract;
using FastCarServer.Enums;

namespace FastCarServer.Data.CarAbstract
{
    public class Field : Entity
    {
        public string FieldName { get; set; }
        public FieldType FieldType { get; set; }
        public string? UnitOfMeasure { get; set; }
        public OptionType? OptionType { get; set; }

        public List<FieldOption> FieldOptions { get; set; }
    }
}
