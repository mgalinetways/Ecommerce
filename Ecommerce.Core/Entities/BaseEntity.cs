using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.Entities
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }
    }
}
