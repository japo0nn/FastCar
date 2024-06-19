using FastCarServer.Core.Data.Abstract;
using FastCarServer.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCarServer.Core.Data.CarAbstract
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
