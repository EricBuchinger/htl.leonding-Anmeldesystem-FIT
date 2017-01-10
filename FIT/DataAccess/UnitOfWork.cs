using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UnitOfWork : IDisposable
    {
        private readonly FitContext _context = new FitContext();
        private bool _disposed;

        /// <summary>
        ///     Konkrete Repositories. Keine Ableitung erforderlich
        /// </summary>

        private GenericRepository<Address> _addressesRepository;
        private GenericRepository<Area> _areasRepository;
        private GenericRepository<Booking> _bookingsRepository;
        private GenericRepository<Company> _companiesRepository;
        private GenericRepository<Contact> _contactsRepository;
        private GenericRepository<Detail> _detailsRepository;
        private GenericRepository<DetailAllocation> _detailAllocationsRepository;
        private GenericRepository<Event> _eventsRepository;
        private GenericRepository<Lecturer> _lecturersRepository;
        private GenericRepository<Location> _locationsRepository;
        private GenericRepository<Person> _personsRepository;
        private GenericRepository<Presentation> _presentationsRepository;
        private GenericRepository<Representative> _representativesRepository;
        private GenericRepository<Resource> _resourcesRepository;
        private GenericRepository<ResourceBooking> _resourceBookingsRepository;

        public GenericRepository<Address> AddressRepository
        {
            get
            {
                return _addressesRepository = new GenericRepository<Address>(_context);
            }
        }
        public GenericRepository<Area> AreaRepository
        {
            get
            {
                return _areasRepository = new GenericRepository<Area>(_context);
            }
        }
        public GenericRepository<Booking> BookingRepository
        {
            get
            {
                return _bookingsRepository = new GenericRepository<Booking>(_context);
            }
        }
        public GenericRepository<Company> CompanyRepository
        {
            get
            {
                return _companiesRepository = new GenericRepository<Company>(_context);
            }
        }
        public GenericRepository<Contact> ContactRepository
        {
            get
            {
                return _contactsRepository = new GenericRepository<Contact>(_context);
            }
        }
        public GenericRepository<Detail> DeatilRepository
        {
            get
            {
                return _detailsRepository = new GenericRepository<Detail>(_context);
            }
        }
        public GenericRepository<DetailAllocation> DetailAllocationRepository
        {
            get
            {
                return _detailAllocationsRepository = new GenericRepository<DetailAllocation>(_context);
            }
        }
        public GenericRepository<Event> EventRepository
        {
            get
            {
                return _eventsRepository = new GenericRepository<Event>(_context);
            }
        }
        public GenericRepository<Lecturer> LecturerRepository
        {
            get
            {
                return _lecturersRepository = new GenericRepository<Lecturer>(_context);
            }
        }
        public GenericRepository<Location> LocationRepository
        {
            get
            {
                return _locationsRepository = new GenericRepository<Location>(_context);
            }
        }
        public GenericRepository<Person> PersonRepository
        {
            get
            {
                return _personsRepository = new GenericRepository<Person>(_context);
            }
        }
        public GenericRepository<Presentation> PresentationRepository
        {
            get
            {
                return _presentationsRepository = new GenericRepository<Presentation>(_context);
            }
        }
        public GenericRepository<Representative> RepresentativeRepository
        {
            get
            {
                return _representativesRepository = new GenericRepository<Representative>(_context);
            }
        }

        public GenericRepository<Resource> ResourceRepository
        {
            get
            {
                return _resourcesRepository = new GenericRepository<Resource>(_context);
            }
        }

        public GenericRepository<ResourceBooking> ResourceBookingRepository
        {
            get
            {
                return _resourceBookingsRepository = new GenericRepository<ResourceBooking>(_context);
            }
        }


        /// <summary>
        ///     Repository-übergreifendes Speichern der Änderungen
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
    }
}

//using SmartHome.Entity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SmartHome.DataAccess
//{
//    public class UnitOfWork : IDisposable
//    {
//        private readonly FitContext _context = new FitContext();
//        private bool _disposed;


//        public GenericRepository<Log> LogRepository
//        {
//            get
//            {
//                throw new NotImplementedException();
//            }
//        }
//        public GenericRepository<Measurement> MeasurementRepository
//        {
//            get
//            {
//                throw new NotImplementedException();
//            }
//        }
//        public GenericRepository<Sensor> SensorRepository
//        {
//            get
//            {
//                throw new NotImplementedException();
//            }
//        }

//        /// <summary>
//        ///     Repository-übergreifendes Speichern der Änderungen
//        /// </summary>
//        public void Save()
//        {
//             _context.SaveChanges();
//        }

//        public void Dispose()
//        {
//            Dispose(true);
//            GC.SuppressFinalize(this);
//        }

//        protected virtual void Dispose(bool disposing)
//        {
//            if (!_disposed)
//            {
//                if (disposing)
//                {
//                    _context.Dispose();
//                }
//            }
//            _disposed = true;
//        }
//    }
//}
