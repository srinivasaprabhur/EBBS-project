using EBBS.Framework;
using EBBS.Modoel.input;
using EBBS.Repository.Interfaces;
using EBBS.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBBS.Service.Implementations
{
    public class EBBDetailsServices: IEBBDetailservices
    {


        IEBBSDetailsRepository _IEBBSDetailsRepository;

        // IUserDetailsRepository _userDetailsRepository = new UserDetailsRepository();
        public EBBDetailsServices(IEBBSDetailsRepository userDetails)
        {
            this._IEBBSDetailsRepository = userDetails;
        }

        public async Task<ResultArgs> DeleteUserDetailsByIdAsync(int Id)
        {
            ResultArgs resultArgs = new ResultArgs();

            int result = await _IEBBSDetailsRepository.DeleteUserDetailsByIdAsync(Id);
            if (result == 0)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record Deleted Successfully";

            }
            else
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;



            //return resultArgs; 

        }

        public async Task<ResultArgs> GetUserDetailsAsync()
        {
            ResultArgs resultArgs = new ResultArgs();

            EBBSDTO obj = await _IEBBSDetailsRepository.GetUserDetailsAsync();
            if (obj != null)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record load Successfully";
                resultArgs.ResultData = obj.userDetailList;

            }
            else
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;
        }

        public async Task<ResultArgs> GetUserDetailsByIdAsync(int Id)
        {
            ResultArgs resultArgs = new ResultArgs();

            EBBSDTO obj = await _IEBBSDetailsRepository.GetUserDetailsByIdAsync(Id);
            if (obj != null)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record load Successfully";
                resultArgs.ResultData = obj;

            }
            else
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;
        }

        public async Task<ResultArgs> InsertOrUpdateAsync(EBBSDTO user)
        {
            ResultArgs resultArgs = new ResultArgs();

            int result = await _IEBBSDetailsRepository.InsertOrUpdateAsync(user);
            if (result == 0)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record Save Successfully";
            }
            else
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;
        }
    }
}
