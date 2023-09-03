using EBBS.Modoel.input;
using EBBS.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EBBSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddUserDetailsByAdminController : ControllerBase
    {

       IEBBDetailservices  _EBBDetailservices;

            public AddUserDetailsByAdminController(IEBBDetailservices userDetailsService)
            {
                _EBBDetailservices = userDetailsService;
            }

            // GET: api/<UserDetailsController>


            /// <summary>
            ///  To Get all the Active User Details 
            /// </summary>
            /// <returns>this will return the user data as object</returns>
            /// 

            /// <remarks>
            /// Sample request:
            ///
            /// POST /Todo
            /// {
            /// "id": 1,
            /// "name": "Item1",
            /// "isComplete": true
            /// }
            ///
            /// </remarks>
            /// <param name="name"></param> 
            /// <response code="201">Returns the newly created item</response>
            /// <response code="202">Update </response>
            /// <response code="203">already exists </response>
            /// <response code="204">faild to update the data </response>
            /// <response code="400">If the item is null</response>


            [HttpGet]
            [ActionName("GetUserDetails")]
            public async Task<IActionResult> GetUserDetailsAsync()
            {
                return Ok(await _EBBDetailservices.GetUserDetailsAsync());
            }

     

        [HttpGet]
            [ActionName("GetUserDetailsByIdAsync")]
            public async Task<IActionResult> GetUserDetailsByIdAsync( int id)
            {
                return Ok(await _EBBDetailservices.GetUserDetailsByIdAsync(id));
            }

            /// <summary>
            ///  To save the user daa to database  
            /// </summary>
            /// <returns>this will return the user data as object</returns>
            /// <remarks>
            /// Sample request:
            ///
            /// POST /Todo
            ///  {
            ///   "id": 0,
            ///  "firstName": "Demo",
            ///  "lastName": "Admin",
            ///   "age": 30,
            ///  "address1": "Athanavoor",
            ///  "address1": "Yelagiri Hills"
            /// }
            /// </remarks> 
            /// <response code="201">Returns the newly created item</response>
            /// <response code="202">Update </response>
            /// <response code="203">already exists </response>
            /// <response code="204">faild to update the data </response>
            /// <response code="400">If the item is null</response>
            // POST api/<UserDetailsController>
            //[HttpPost]
            //[ActionName("InsertUserDetailsAsync")]
            //[ProducesResponseType(StatusCodes.Status201Created)]
            //[ProducesResponseType(StatusCodes.Status400BadRequest)]
            //public async Task<IActionResult> SaveUserDetailsAsync([FromBody] UserRentalDetailDTO obj)
            //{
            //    return Ok(await _userDetailsService.SaveUserDetailsAsync(obj));
            //}


            // PUT api/<UserDetailsController>/5
            /// <summary>
            /// 
            /// </summary>
            /// <param name="id"></param>
            /// <param name="obj"></param>
            /// <returns></returns>
            ////[HttpPut("{id}")]
            ////[ActionName("UpdateUserDetailsAsync")]

            ////public async Task<IActionResult> UpdateUserDetailsAsync(int id, [FromBody] UserRentalDetailDTO obj)
            ////{
            ////    obj.Customer_id = id;
            ////    return Ok(await _userDetailsService.SaveUserDetailsAsync(obj));
            ////}


            // DELETE api/<UserDetailsController>/5 
            [HttpDelete]
            [ActionName("DeleteUserDetailsByIdAsync")]
            public async Task<IActionResult> DeleteUserDetailsByIdAsync( int id)
            {
                return Ok(await _EBBDetailservices.DeleteUserDetailsByIdAsync(id));
            }


            [HttpPost]
            [ActionName("InsertOrUpdateAsync")]
            public async Task<IActionResult> InsertOrUpdateAsync( EBBSDTO obj)
            {
            //obj.Customer_id = id;
            return Ok(await _EBBDetailservices.InsertOrUpdateAsync(obj));
        }

    }
    }
