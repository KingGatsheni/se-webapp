using homecoming.webapp.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace homecoming.webapp.Controllers
{
    public class BookingController : Controller
    {
        private readonly UserManager<IdentityUser> manager;

        public BookingController(UserManager<IdentityUser> manager)
        {
            this.manager = manager;
        }
        public async Task<IActionResult> Accomodations(int id)
        {
            List<AccomodationViewModel> listOfAccomodationsByLocation = null;
            using(HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(Config.BaseUrl);
                HttpResponseMessage httpResponse = await client.GetAsync($"location/GetAccomByLocationId/{id}");
                if (httpResponse.IsSuccessStatusCode)
                {
                    listOfAccomodationsByLocation = await httpResponse.Content.ReadAsAsync<List<AccomodationViewModel>>();
                }
                else
                {
                    listOfAccomodationsByLocation = null;
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }
            ViewBag.numbers = DropDownListHelper.ListOfNumberOfRooms;
            return View(listOfAccomodationsByLocation);
        }

       
        public async Task<IActionResult> Reservation(int id)
        {
            RoomViewModel roomIfo = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Config.BaseUrl);
                var httpResponse = await client.GetAsync($"room/{id}");
                if (httpResponse.IsSuccessStatusCode)
                {
                    roomIfo = await httpResponse.Content.ReadAsAsync<RoomViewModel>();

                }
                else
                {
                    roomIfo = null;
                }
                ViewBag.numbers = DropDownListHelper.ListOfNumberOfRooms;
            }
            return View(roomIfo);
        }
       
       
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Reservation(BookingViewModel model, RoomViewModel room)
        {
            var BookingPrice = ((room.Price * room.Helper.RoomNumber) * model.NoOfDaysBooked);
            int customerId = 0;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Config.BaseUrl);
                var httpResponse = await client.GetAsync($"user/get/{manager.GetUserId(HttpContext.User)}");
                if (httpResponse.IsSuccessStatusCode)
                {
                    var item = await httpResponse.Content.ReadAsStringAsync();
                    customerId = int.Parse(item);
                }
                else
                {
                    customerId = -1;
                }
            }
            if (model != null)
            {
                using (var client = new HttpClient())
                {
                    var booking = new BookingViewModel() { CustomerId = customerId, RoomId = model.RoomId, NoOfRooms = room.Helper.RoomNumber, NoOfOccupants = model.NoOfOccupants, Check_In_Date = model.Check_In_Date, Check_Out_Date = model.Check_Out_Date, BookingPrice = BookingPrice };
                    client.BaseAddress = new Uri(Config.BaseUrl);
                    var json = JsonConvert.SerializeObject(booking);
                    var payload = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("booking", payload);
                    if (response.IsSuccessStatusCode)
                    {
                            var res = response.Content.ReadAsStringAsync().Result;
                            TempData["status"] = $"Sucessfully Placed your Reservation, 'Reservation Id: {Guid.NewGuid()}'";
                            return RedirectToAction("Success", "Booking", new { id = room.RoomId });
                    }
                   
                }
            }
            

            return NotFound("Error something went wrong while processing request please contact web administrator");
        }

        [Authorize]
        public async Task<IActionResult> Success(int id)
        {
            BookingViewModel booking = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Config.BaseUrl);
                var httpResponse = await client.GetAsync($"booking/history/{id}");
                if (httpResponse.IsSuccessStatusCode)
                {
                    booking = await httpResponse.Content.ReadAsAsync<BookingViewModel>();
                    
                }
                else
                {
                    booking = null;
                }
            }
            return View(booking);
        }
    }
}
