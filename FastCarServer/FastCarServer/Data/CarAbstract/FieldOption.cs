using FastCarServer.Data.Abstract;

namespace FastCarServer.Data.CarAbstract
{
    public class FieldOption : Entity
    {
        public string Option { get; set; }

        public Guid FieldId { get; set; }
        public Field Field { get; set; }
    }
}
