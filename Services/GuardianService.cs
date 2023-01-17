using LGC_Check_In.Data;
using LGC_Check_In.Models;

namespace LGC_Check_In.Services
{
    public class GuardianService : IGuardianService
    {
        private readonly DatabaseContext _context;

        public GuardianService(DatabaseContext context) 
        {
            _context= context;
        }

        public bool AddUpdate(Guardian guardian)
        {
            try
            {
                if (guardian.RecordID == 0)
                {
                    _context.Guardians.Add(guardian);
                }
                else
                {
                    _context.Guardians.Update(guardian);
                }
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var guardian = FindByID(id);
                if (guardian == null)
                {
                    return false;
                }
                _context.Guardians.Remove(guardian);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Guardian FindByID(int id)
        {
            return _context.Guardians.Find(id);
        }

        public List<Guardian> GetAll()
        {
            return _context.Guardians.ToList();
        }
    }
}
