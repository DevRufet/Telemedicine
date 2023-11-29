using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telemedicine
{
    public class TelemedicineContext:DbContext
    {
        public DbSet<Patient> Patients { get; set; }
    }
}
