//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;

//namespace EBBS_Project.Controllers
//{
//    public class DropdownController : Controller
//    {
      
//            // Action method to get data for the second dropdown
//            public ActionResult GetDataForSecondDropdown(string selectedValue)
//            {
//                // Assuming you have a data source, fetch data based on the selected value
//                List<SelectListItem> items = GetItemsBasedOnSelectedValue(selectedValue);

//                return Json(items, JsonRequestBehavior.AllowGet);
//            }

//            private List<SelectListItem> GetItemsBasedOnSelectedValue(string selectedValue)
//            {
//                // Perform logic to fetch items from a data source based on the selected value
//                // Example:
//                List<SelectListItem> items = new List<SelectListItem>
//        {
//            new SelectListItem { Value = "1", Text = "Item 1" },
//            new SelectListItem { Value = "2", Text = "Item 2" },
//            // Add more items here
//        };

//                return items;
//            }
//        }

//    }

