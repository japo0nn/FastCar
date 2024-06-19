namespace FastCarServer.Application.Common.DTO.CarAbstract
{
    public class FieldOptionDto
    {
        public string Option { get; set; }

        public Guid FieldId { get; set; }
        public FieldDto Field { get; set; }
    }
}
