namespace FastCarServer.Dto.CarAbstract
{
    public class FieldOptionDto
    {
        public string Option { get; set; }

        public Guid FieldId { get; set; }
        public FieldDto Field { get; set; }
    }
}
