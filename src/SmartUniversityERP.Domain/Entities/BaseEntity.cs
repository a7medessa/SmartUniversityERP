using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUniversityERP.Domain.Entities;

public abstract class BaseEntity
{
    public int Id { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = string.Empty;

    public DateTime? LastModifiedDate { get; set; }

    public string? LastModifiedBy { get; set;}
}
