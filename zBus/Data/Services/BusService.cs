﻿using Microsoft.EntityFrameworkCore;
using zBus.Models;

namespace zBus.Data.Services
{
    public class BusService : IBusService
    {
        private readonly AppDbContext _context;

        public BusService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Bus _bus)
        {
            _context.Buses.Add(_bus);
            _context.SaveChanges();
        }

        public bool Delete(int id)
        {
            try
            {
                var _bus = _context.Buses.FirstOrDefault(x => x.BusId == id)!;

                _context.Buses.Remove(_bus!);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex) {

                return false;
            }
        }

        public async Task<IEnumerable<Bus>> GetAll()
        {
            var Buss = await _context.Buses.ToListAsync();
            return Buss;
        }

        public Bus GetById(int id)
        {
            return _context.Buses.FirstOrDefault(x => x.BusId == id)!;
        }

        public void Update(int id, Bus _bus)
        {
            var old= _context.Buses.FirstOrDefault(x => x.BusId == id)!;
            old.BusModel=_bus.BusModel;
            old.WifiAvailable = _bus.WifiAvailable;
            old.BusPicture= _bus.BusPicture;
            old.NumberOfSeats= _bus.NumberOfSeats;
            old.DriverId= _bus.DriverId;
            old.AirConditioningAvailable= _bus.AirConditioningAvailable;
            old.RestroomAvailable= _bus.RestroomAvailable;
            _context.Buses.Update(old);
            _context.SaveChanges();
        }
    }
}
