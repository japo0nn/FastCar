using FastCarServer.Core.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCarServer.Core.Data.CarAbstract
{
    public class FieldOption : Entity
    {
        public string Option { get; set; }

        public Guid FieldId { get; set; }
        public Field Field { get; set; }
    }
}
