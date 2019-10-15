using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityCodeFirst.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string F_Name { get; set; }
        public string Course { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data Source =LAPTOP-FPF5GBKU\SQLEXPRESS;Initial Catalog=Students;Trusted_Connection=True;");
            //optionsBuild.UseSqlServer(@"data source =LAPTOP-FPF5GBKU\SQLEXPRESS;Initial Catalog=User;Trusted_Connection=True;");

        }
    }
}
