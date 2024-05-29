using Microsoft.AspNetCore.Mvc;
using NeighbourComplaintRegistrationSystem.Models;

namespace NeighbourComplaintRegistrationSystem.Controllers
{ 
    
    [Route("/[Controller]/[Action]")]        
    public class ApiController : Controller
    {

        public async Task<JsonResult> AddComplaint([FromBody]Models.Complaint complaint, [FromServices] Services.ComplaintService complaintService)
        {
            return Json(await complaintService.InsertNewComplaintAsync(complaint));
        }

        public async Task<JsonResult> UpdateComplaint([FromBody] Models.Complaint complaint, [FromServices] Services.ComplaintService complaintService)
        {
            return Json(await complaintService.UpdateComplaintAsync(complaint));
        }

        public async Task<JsonResult> UpdateStatus([FromBody] Models.Complaint complaint, [FromServices] Services.ComplaintService complaintService)
        {
            return Json(await complaintService.UpdateStatusAsync(complaint));
        }


        public async Task<JsonResult> GetComplaintsByName([FromBody] Models.Complaint complaint, [FromServices] Services.ComplaintService complaintService)
        {
            return Json(await complaintService.GetComplaintsByNameAsync(complaint));
        }


        ////The following Tasks don't work yet:

        //public async Task<JsonResult> GetAllComplaintsOrdered([FromBody] Models.Complaint complaint, [FromServices] Services.ComplaintService complaintService)
        //{
        //    return Json(await complaintService.GetAllComplaintsOrderedAsync(complaint));
        //}
        //// Error 415: Unsupported Media Type (although I did not send any)


        //public async Task<JsonResult> GetComplaintsByDate([FromBody] Models.Complaint complaint, [FromServices] Services.ComplaintService complaintService)
        //{
        //    return Json(await complaintService.GetComplaintsByDateAsync(complaint));
        //} 
        //// Error Message: "SqlDateTime overflow. Must be between 1/1/1753 12:00:00 AM and 12/31/9999 11:59:59 PM."
    }
}

