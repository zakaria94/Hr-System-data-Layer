using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Tamplate.DAL.Enitity
{
    [Table("Department")]
    public class Department
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string DepartmentName { get; set; }

        [StringLength(50)]
        public string DepartmentCode { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
