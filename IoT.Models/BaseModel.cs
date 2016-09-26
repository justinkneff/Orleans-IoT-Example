using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoT.Models
{
    [Serializable]
    public abstract class BaseModel
    {
        public bool IsNew => !Created.HasValue;

        public Guid Id { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
