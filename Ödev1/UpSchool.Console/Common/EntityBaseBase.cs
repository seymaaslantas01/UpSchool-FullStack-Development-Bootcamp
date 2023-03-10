using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpSchool.Console.Common
{
    public class EntityBaseBase : IEntityBase
    {
        public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsDeleted { get; set; }
    }
}
