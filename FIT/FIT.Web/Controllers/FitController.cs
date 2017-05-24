using Microsoft.AspNetCore.Mvc;
using Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIT.Web.Controllers
{
    [Route("api/[controller]")]
    public class FitController : Controller
    {
        IUnitOfWork iuow;

        public FitController(IUnitOfWork iuow)
        {
            this.iuow = iuow;
        }

        [Route("getAllBooking")]
        [HttpGet]
        public IActionResult GetAllRegistrations()
        {
          
           return Ok(iuow.BookingRepository.Get(orderBy: o => o.OrderBy(od => od.Company.Name),includeProperties:"Event,Company.Contact.Person,Company.Address,Location.Area.Event,Presentation,Category").ToList());
        }

        [Route("getAreas")]
        [HttpGet]
        public IActionResult GetAreas(string designation="1.Stock")
        {
           return Ok(iuow.LocationRepository.Get(includeProperties: "Area.Event") .ToList());
        }

        public IActionResult GetCategories()
        {
            return Ok(iuow.CategoryRepository.Get(includeProperties: "Location"));
        }


        /*[("updateBookingStatusAccept/{id}")]
        public IActionResult UpdateBookingStatusAccept(int id)
        {

            Booking updater = iuow.BookingRepository.GetById(id);
            updater.isAccepted = true;
            iuow.BookingRepository.Update(updater);
            iuow.Save();
            return Ok();

        }

        [HttpPost("updateBookingStatusDeclined/{id}")]
        public IActionResult UpdateBookingStatusDeclined(int id)
        {

            Booking updater = iuow.BookingRepository.GetById(id);
            updater.isAccepted = false;
            iuow.BookingRepository.Update(updater);
            iuow.Save();
            return Ok();

        }*/
        [HttpDelete("booking/{id}")]
        public IActionResult DeleteBooking(int id)
        {
            iuow.BookingRepository.Delete(id);
            iuow.Save();
            return Ok();
        }

        /*[HttpPost("createNewBooking")]
        public IActionResult CreateNewBooking([FromBody] string jsonString)
        {
            JObject json = JObject.Parse(jsonString);

            Booking newBooking = new Booking();
            Company newComp = new Company();
            Address newAddress = new Address();
            Category newCategory = new Category();
            newCategory.Name = "standard";
            newCategory.Price = 200.00;
            newCategory.Description = "einfacher standplatz";
            Event FIT = new Event();
            FIT.Date = DateTime.Now;
            FIT.IsLocked = false;
            FIT.RegistrationEnd = DateTime.Now;
            FIT.RegistrationStart = DateTime.MinValue;
            
            
            
            DetailAllocation valueLocAustria = new DetailAllocation();
            DetailAllocation valueLocInt = new DetailAllocation();
            Detail locationsAustria = new Detail();
            Detail internatLocations = new Detail();

            DetailAllocation valueHolidayWorkAndDiplomaThesis = new DetailAllocation();
            DetailAllocation valueTechnicalDevision = new DetailAllocation();
            Detail holidayWorkAndDiplomaThesis = new Detail();
            Detail technicalDevision = new Detail();

            Person representer1 = new Person();
            Person contact1 = new Person();

            Contact contactPerson = new Contact();
            Representative representer = new Representative();
            Presentation newPres = null;
            

            newComp.Name = json.GetValue("CompanyName").ToString();
            newAddress.Street = json.GetValue("Street").ToString();
            newAddress.Number = json.GetValue("StreetNumber").ToString();
            newAddress.PostalCode = json.GetValue("ZipConde").ToString();
            newAddress.City = json.GetValue("City").ToString();
            newComp.Address = newAddress;
            newComp.PhoneNumber = json.GetValue("Phonenumber").ToString();
            newComp.Email = json.GetValue("Email").ToString();
            newComp.Homepage = json.GetValue("Homepage").ToString();
            newComp.SubjectAreas = json.GetValue("SubjectArea").ToString();
            valueLocAustria.Booking = newBooking;
            valueLocAustria.Detail = locationsAustria;
            locationsAustria.Description = "Niederlassungen Österreich";
            valueLocAustria.Text = json.GetValue("LocationDeatilsAustria").ToString(); // string looks like 3;Perg,Linz,Wels  <Number of Allocations>;<First alloc name >,<second alloc name>,<third alloc name>
            valueLocInt.Booking = newBooking;
            valueLocInt.Detail = internatLocations;
            internatLocations.Description = "Niederlassungen International";
            valueLocInt.Text = json.GetValue("LocationDetailsInternational").ToString(); // same like valueLocAustria 3;australia,germany,russia
            valueHolidayWorkAndDiplomaThesis.Booking = newBooking;
            valueHolidayWorkAndDiplomaThesis.Detail = holidayWorkAndDiplomaThesis;
            holidayWorkAndDiplomaThesis.Description = "DiplomarbeitenUndFerialjobs";                            
            valueHolidayWorkAndDiplomaThesis.Text = json.GetValue("HolidayWorkAndDiplomaThesis").ToString(); // should be yes,yes or no,yes depending on how the checkboxeswere matched 
            valueTechnicalDevision.Booking = newBooking;
            valueTechnicalDevision.Detail = technicalDevision;
            technicalDevision.Description = "TechnicalDevision";
            valueTechnicalDevision.Text = json.GetValue("TechnicalDevision").ToString(); // should be yes,yes,yes or no,yes,no depending on how matched
            // Same like the details was done can be done for Resources like wlan or chairs or tables etc....
            contactPerson.Person = contact1;
            representer.Person = representer1;
            contact1.FirstName = json.GetValue("ContactPersonFirstName").ToString();
            contact1.LastName = json.GetValue("ContactPersonLastName").ToString();
            contact1.Email = json.GetValue("ContactPersonEmail").ToString();
            contact1.PhoneNumber = json.GetValue("ContactPersonPhoneNumber").ToString();
            representer1.FirstName = json.GetValue("Representer1PersonFirstName").ToString();
            representer1.LastName = json.GetValue("Representer1PersonLastName").ToString();
            // email and phonenumber can be applied to representers if wanted and multiple representers can be added if wanted
            // representer1.Email = json.GetValue("Representer1PersonEmail").ToString();
            // representer1.PhoneNumber = json.GetValue("Representer1PersonPhoneNumber").ToString();

            newBooking.Category = newCategory;
            newBooking.Company = newComp;
            newBooking.Event = FIT;
            newBooking.isAccepted = false;
            newBooking.Location = null;
            newBooking.Presentation = newPres;

            iuow.AdressRepository.Insert(newAddress);
            iuow.BookingRepository.Insert(newBooking);
            iuow.CategoryRepository.Insert(newCategory);
            iuow.CompanyRepository.Insert(newComp);
            iuow.ContactRepository.Insert(contactPerson);
            iuow.DetailAllocationRepository.Insert(valueHolidayWorkAndDiplomaThesis);
            iuow.DetailAllocationRepository.Insert(valueTechnicalDevision);
            iuow.DetailRepository.Insert(holidayWorkAndDiplomaThesis);
            iuow.DetailRepository.Insert(technicalDevision);
            iuow.PersonRepository.Insert(representer1);
            iuow.PersonRepository.Insert(contact1);
            iuow.EventRepository.Insert(FIT);
            iuow.PresentationRepository.Insert(newPres);
            iuow.RepresentativeRepository.Insert(representer);
            iuow.Save();



            return Ok();
        }*/
        
    }
}
