using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FitContext _context = new FitContext();
        private bool _disposed;

        /// <summary>
        ///     Konkrete Repositories. Keine Ableitung erforderlich
        /// </summary>

        private GenericRepository<Address> _addressRepository;
        private GenericRepository<Area> _areaRepository;
        private GenericRepository<Booking> _bookingRepository;
        private GenericRepository<Company> _companyRepository;
        private GenericRepository<Contact> _contactRepository;
        private GenericRepository<Detail> _detailRepository;
        private GenericRepository<DetailAllocation> _detailAllocationRepository;
        private GenericRepository<Event> _eventRepository;
        private GenericRepository<Lecturer> _lecturerRepository;
        private GenericRepository<Location> _locationRepository;
        private GenericRepository<Person> _personRepository;
        private GenericRepository<Presentation> _presentationRepository;
        private GenericRepository<Representative> _representativeRepository;
        private GenericRepository<Resource> _resourceRepository;
        private GenericRepository<ResourceBooking> _resourceBookingRepository;

        public IGenericRepository<Address> AdressRepository
        {
            get
            {
                if (_addressRepository == null)
                    _addressRepository = new GenericRepository<Address>(_context);
                return _addressRepository;
            }
        }

        public IGenericRepository<Area> AreaRepository
        {
            get
            {
                if (_areaRepository == null)
                    _areaRepository = new GenericRepository<Area>(_context);
                return _areaRepository;
            }
        }

        public IGenericRepository<Booking> BookingRepository
        {
            get
            {
                if (_bookingRepository == null)
                    _bookingRepository = new GenericRepository<Booking>(_context);
                return _bookingRepository;
            }
        }

        public IGenericRepository<Company> CompanyRepository
        {
            get
            {
                if (_companyRepository == null)
                    _companyRepository = new GenericRepository<Company>(_context);
                return _companyRepository;
            }
        }

        public IGenericRepository<Contact> ContactRepository
        {
            get
            {
                if (_contactRepository == null)
                    _contactRepository = new GenericRepository<Contact>(_context);
                return _contactRepository;
            }
        }

        public IGenericRepository<Detail> DetailRepository
        {
            get
            {
                if (_detailRepository == null)
                    _detailRepository = new GenericRepository<Detail>(_context);
                return _detailRepository;
            }
        }

        public IGenericRepository<DetailAllocation> DetailAllocationRepository
        {
            get
            {
                if (_detailAllocationRepository == null)
                    _detailAllocationRepository = new GenericRepository<DetailAllocation>(_context);
                return _detailAllocationRepository;
            }

        }

        public IGenericRepository<Event> EventRepository
        {
            get
            {
                if (_eventRepository == null)
                    _eventRepository = new GenericRepository<Event>(_context);
                return _eventRepository;
            }
        }

        public IGenericRepository<Lecturer> LectureRepository
        {
            get
            {
                if (_lecturerRepository == null)
                    _lecturerRepository = new GenericRepository<Lecturer>(_context);
                return _lecturerRepository;
            }
        }

        public IGenericRepository<Location> LocationRepository
        {
            get
            {
                if (_locationRepository == null)
                    _locationRepository = new GenericRepository<Location>(_context);
                return _locationRepository;
            }
        }

        public IGenericRepository<Person> PersonRepository
        {
            get
            {
                if (_personRepository == null)
                    _personRepository = new GenericRepository<Person>(_context);
                return _personRepository;
            }
        }

        public IGenericRepository<Presentation> PresentationRepository
        {
            get
            {
                if (_presentationRepository == null)
                    _presentationRepository = new GenericRepository<Presentation>(_context);
                return _presentationRepository;
            }
        }

        public IGenericRepository<Representative> RepresentativeRepository
        {
            get
            {
                if (_representativeRepository == null)
                    _representativeRepository = new GenericRepository<Representative>(_context);
                return _representativeRepository;
            }
        }

        public IGenericRepository<Resource> ResourceRepository
        {
            get
            {
                if (_resourceRepository == null)
                    _resourceRepository = new GenericRepository<Resource>(_context);
                return _resourceRepository;
            }
        }

        public IGenericRepository<ResourceBooking> ResourceBookingRepository
        {
            get
            {
                if (_resourceBookingRepository == null)
                    _resourceBookingRepository = new GenericRepository<ResourceBooking>(_context);
                return _resourceBookingRepository;
            }
        }



        public UnitOfWork(string connectionString)
        {
            _context = new FitContext(connectionString);
        }

        public UnitOfWork() : this("name=DefaultConnection")
        {

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

        public void DeleteDatabase()
        {
            _context.Database.Delete();
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
