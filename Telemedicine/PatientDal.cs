using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telemedicine
{
    public class PatientDal
    {
        public List<Patient> GetAll()
        {
            using (TelemedicineContext context = new TelemedicineContext())
            {
                return context.Patients.ToList();
            }
        }
        public void Add(Patient patient)
        {
            using (TelemedicineContext context = new TelemedicineContext())
            {
                context.Patients.Add(patient);
                context.SaveChanges();
            }
        }
        public void Update(Patient patient)
        {
            using (TelemedicineContext context = new TelemedicineContext())
            {
                var entity = context.Entry(patient);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Patient patient)
        {
            using(TelemedicineContext context = new TelemedicineContext())
            {
                var entity = context.Entry(patient);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
