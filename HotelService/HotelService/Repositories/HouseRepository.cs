﻿using HotelService.Data;
using HotelService.Interfaces;
using HotelService.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelService.Repositories
{
    public class HouseRepository : IHouseRepository
    {
        private readonly ApplicationDbContext _context;

        public HouseRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(House house)
        {
            _context.Houses.Add(house);
            await _context.SaveChangesAsync();

        }

        public async Task<List<House>> GetAllAsync()
        {
            return await _context.Houses
                   .OrderByDescending(h => h.Number)
                   .ToListAsync();
        }

        public async Task<House> GetByIdAsync(string id)
        {
            return await _context.Houses.FindAsync(id);
        }

        public async Task UpdateAsync(House house)
        {
            _context.Houses.Update(house);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(House house)
         {
                _context.Houses.Remove(house);
                await _context.SaveChangesAsync();
         }

        
    }
}
