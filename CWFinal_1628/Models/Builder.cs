using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CWFinal_1628.Models
{
    public class Builder:Person
    {
        public virtual ICollection<AssignProject> AssignProjects { get; set; }
        public virtual ICollection<Work> Works { get; set; }
    }
}