using EmployeeAttendance.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using EmployeeAttendance.Infrastructure.Data;
using EmployeeAttendance.Domain.Entities;
using EmployeeAttendance.Application.DTOs;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EmployeeAttendance.Infrastructure.Implementations
{
    public class EmployeeRepository : IEmployee
    {
        private readonly EmployeeDbContext employeeDbcontext;

        public EmployeeRepository(EmployeeDbContext employeeDbcontext)
        {
            this.employeeDbcontext = employeeDbcontext;
        }
        public async Task<ServiceResponse> AddAsync(Employee employee)
        {
            employeeDbcontext.Employees.Add(employee);
            await SavechangesAsync();
            return new ServiceResponse(true, "Added");
        }

        public async Task<ServiceResponse> DeleteAsync(int id)
        {
            var employee = await employeeDbcontext.Employees.FindAsync(id);
            if (employee == null)
                return new ServiceResponse(false, "User Not Found");
            employeeDbcontext.Remove(employee);
            await SavechangesAsync();
            return new ServiceResponse(true, "Deleted");


        }

        public async Task<List<Employee>> GetAsync() => await employeeDbcontext.Employees.AsNoTracking().ToListAsync();


        public async Task<Employee> GetByIdAsync(int id) => await employeeDbcontext.Employees.FindAsync(id); 
    

        public async Task<ServiceResponse> UpdateAsync(Employee employee)
        {
            employeeDbcontext.Update(employee);
            await SavechangesAsync();
            return new ServiceResponse(true, "Updated");
        }
        private async Task SavechangesAsync()=>await employeeDbcontext.SaveChangesAsync();
    }
}
