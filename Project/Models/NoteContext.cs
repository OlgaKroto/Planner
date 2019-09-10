using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class NoteContext : DbContext
    {
        public DbSet<Note> Notes { get; set; } //список записей, взаимодействие с набором объектов Note
    }
}