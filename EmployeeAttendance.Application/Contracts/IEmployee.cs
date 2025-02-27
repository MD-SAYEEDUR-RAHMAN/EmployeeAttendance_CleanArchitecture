﻿using EmployeeAttendance.Application.DTOs;
using EmployeeAttendance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendance.Domain
{
    public interface IEmployee
    {
       Task<ServiceResponse>AddAsync(Employee employee);
        Task<ServiceResponse> UpdateAsync(Employee employee);
        Task<ServiceResponse> DeleteAsync(int id);
        
        Task <List<Employee>> GetAsync();
        Task<Employee> GetByIdAsync(int id);


    }
}
