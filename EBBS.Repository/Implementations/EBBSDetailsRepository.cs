using Dapper;
using EBBS.DBEngine;
using EBBS.Modoel.input;
using EBBS.Modoel.output;
using EBBS.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBBS.Repository
{
    public class EBBSDetailsRepository : IEBBSDetailsRepository
    {
        ISQLServerHandler _serverHandler;

        public EBBSDetailsRepository(ISQLServerHandler serverHandler)
        {
            this._serverHandler = serverHandler;
        }


        public async Task<EBBSResult> GetUserDetailsAsync()
        {
            var userDetailResult = new EBBSResult();
            try
            {
                using (_serverHandler.Connection)
                {
                    userDetailResult.userDetailList = (await _serverHandler.QueryAsync<EBBSDTO>("[dbo].[GetEBBS]")).ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return userDetailResult;
        }

        public async Task<EBBSDTO> GetUserDetailsByIdAsync(int Id)
        {
            EBBSDTO userDetail = new EBBSDTO();
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@Cust_id", Id, DbType.Int16);

                using (_serverHandler.Connection)
                {
                    userDetail = (await _serverHandler.QuerySingleAsync<EBBSDTO>("[dbo].[GetByIdEBBS]", dynamicParameters));
                }
            }
            catch (Exception ex)
            {
            }
            return userDetail;
        }


        public async Task<int> DeleteUserDetailsByIdAsync(int Id)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@Cust_id", Id, DbType.Int32);

                response = await _serverHandler.ExecuteScalarAsync<int>("[dbo].[EBBSdelete]", dynamicParameters);

            }
            catch (Exception ex)
            {
            }

            return response;
        }
        //public async Task<int> SaveUserDetailsAsync(UserRentalDetailDTO user)
        //{
        //    int response = 0;
        //    try
        //    {
        //        DynamicParameters dynamicParameters = new DynamicParameters();
        //        dynamicParameters.Add("@Cust_id", user.Customer_id, DbType.Int32);
        //        dynamicParameters.Add("@Customer_name", user.Customer_name, DbType.String);
        //        dynamicParameters.Add("@Equipment_name", user.Equipment_name, DbType.String);
        //        dynamicParameters.Add("@Equipment_model", user.Equipment_model, DbType.String);
        //        dynamicParameters.Add("@Rental_date", user.Rental_date, DbType.String);
        //        dynamicParameters.Add("@Rturn_date", user.Rturn_date, DbType.String);
        //        dynamicParameters.Add("@Customer_address", user.Customer_address, DbType.String);
        //        dynamicParameters.Add("@Customer_phone", user.Customer_phone, DbType.Int64);

        //        response = await _serverHandler.ExecuteScalarAsync<int>("[dbo].[Saveuser]", dynamicParameters);

        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return response;
        //}

        public async Task<int> InsertOrUpdateAsync(EBBSDTO user)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@Cust_id", user.id, DbType.Int32);
                dynamicParameters.Add("@serviceNumber", user.ServiceType, DbType.Int64);
                dynamicParameters.Add("@consumedUnit", user.serviceNumber, DbType.Int32);
                dynamicParameters.Add("@fromUnit", user.consumedUnit, DbType.Int32);
                dynamicParameters.Add("@toUnit", user.fromUnit, DbType.Int32);
                dynamicParameters.Add("@pricePerUint", user.toUnit, DbType.Int32);
                dynamicParameters.Add("@pricePerUint", user.toUnit, DbType.Int32);


                response = await _serverHandler.ExecuteScalarAsync<int>("[dbo].[InsertorUpdate]", dynamicParameters);

            }
            catch (Exception ex)
            {
            }
            return response;
        }
    }
}
