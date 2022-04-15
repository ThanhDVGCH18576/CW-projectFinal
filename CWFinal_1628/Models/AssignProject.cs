using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CWFinal_1628.Models
{
    public enum TypeProject
    {
        NewBuild, Repair
    }
    public class AssignProject
    {
        [Key]
        public int AssignID { get; set; }

        [ForeignKey("Project")]
        public int ProjectID { get; set; }
        [ForeignKey("Builder")]
        public int BuilderID { get; set; }
        [ForeignKey("Supervisor")]
        public int SupervisorID { get; set; }

        [DisplayFormat(NullDisplayText = "Undefined")]
        public TypeProject? TypeProject { get; set; }

        public virtual Project Project { get; set; }
        public virtual Builder Builder { get; set; }
        public virtual Supervisor Supervisor { get; set; }
    }
}