using EBBS.Framework;
using EBBS.Modoel.input;

namespace EBBS.Service.Interfaces
{
    public interface IEBBDetailservices
    {
        Task<ResultArgs> GetUserDetailsAsync();
        Task<ResultArgs> GetUserDetailsByIdAsync(int Id);
        Task<ResultArgs> DeleteUserDetailsByIdAsync(int Id);
        //Task<ResultArgs> SaveUserDetailsAsync(UserRentalDetailDTO user);
        Task<ResultArgs> InsertOrUpdateAsync(EBBSDTO user);

        
    }
}