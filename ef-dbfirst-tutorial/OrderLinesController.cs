using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ef_dbfirst_tutorial.Models;
using System.Security.Cryptography;

namespace ef_dbfirst_tutorial; 
public class OrderLinesController {
    private readonly SalesdbContext _context;

    public OrderLinesController() {
        _context = new SalesdbContext();
    }

    public async Task<List<OrderLine>> GetAllAsync() {
        return await _context.OrderLines.ToListAsync();
    }
    public async Task<OrderLine?> GetByIdAsync(int id) {
        return await _context.OrderLines.FindAsync(id);
    }
    public async Task<bool> InsertAsync(Order order) {
        _context.Orders.Add(order);
        return await SaveDB();
    }
        public async Task<bool> DeleteAsync(int id) {
            var ordLine = await GetByIdAsync(id);
            if (ordLine is null) {
                return false;
            }
            _context.OrderLines.Remove(ordLine);
            return await SaveDB();
        }
    
    public async Task<bool> UpdateAsync(OrderLine orderline) {
        var ordLine = await GetByIdAsync(orderline.Id);
        if (ordLine is null) {
            return false;
        }
        _context.OrderLines.Remove(ordLine);
        return await SaveDB();
    }
    public async Task<bool> SaveDB() {
            var changes = await _context.SaveChangesAsync();
            return (changes == 1) ? true : false;
        }
    

}// end
