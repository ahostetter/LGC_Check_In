using LGC_Check_In.Models;

namespace LGC_Check_In.Services
{
    public interface IGuardianService
    {
        bool AddUpdate(Guardian guardian);
        bool Delete(int id);
        Guardian FindByID(int id);
        List<Guardian> GetAll();
    }
}
