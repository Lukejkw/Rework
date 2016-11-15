using System;

namespace Rework.EntityFramework.PMS.Data.Contract
{
    public interface IAuditableEntity<T> : IEntity<T>
    {
        DateTime CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
        string CreatedBy { get; set; }
        string ModifiedBy { get; set; }
    }
}