using Ensaf.SharedKernel;
using Ensaf.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensaf.Core.PostAggregate
{
    public class Post : BaseEntity, IAggregateRoot
    {
        public string Title { get; private set; }
        public string Body { get; private set; }
    }
}
