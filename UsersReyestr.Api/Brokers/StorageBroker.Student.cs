﻿using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using UsersReyestr.Api.Models.Students;

namespace UsersReyestr.Api.Brokers
{
    public partial class StorageBroker
    {
        public DbSet<Student> Students { get; set; }

        public async ValueTask<Student> InsertStudentAsync(Student student) =>
            await InsertAsync(student);

        public async ValueTask<IQueryable<Student>> SelectAllStudentsAsync()=>
             await SelectAllAsync<Student>();

        public async ValueTask<Student> SelectStudentByIdAsync(int studentId)=>
            await SelectAsync<Student>(studentId);

        public async ValueTask<Student> UpdateStudentAsync(Student student)=>
            await UpdateAsync(student);

        public async ValueTask<Student> DeleteStudentAsync(Student student)=>
            await DeleteAsync(student);
    }
}
