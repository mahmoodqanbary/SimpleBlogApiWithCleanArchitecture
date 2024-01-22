using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Common
{
    public interface IEntity
    {
    }
    public abstract class BaseEntity<TKey> : IEntity
    {
        [Key]
        public TKey Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }

    public abstract class BaseEntity : BaseEntity<int>
    {
    }
}
