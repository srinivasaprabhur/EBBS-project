using EBBS.Modoel.input;
using EBBS.Modoel.output;

namespace EBBS.Repository.Interfaces
{
    public interface IEBBSDetailsRepository
    {
        Task<EBBSResult> GetUserDetailsAsync();
        Task<EBBSDTO> GetUserDetailsByIdAsync(int Id);
        Task<int> DeleteUserDetailsByIdAsync(int Id);
        //Task<int> SaveUserDetailsAsync(UserRentalDetailDTO user);
        Task<int> InsertOrUpdateAsync(EBBSDTO user);
    }
}