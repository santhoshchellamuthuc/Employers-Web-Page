using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary
{
   public  class EFDbcontext:DbContext
    {
        public EFDbcontext(DbContextOptions refer) : base(refer)
        {

        }
        public virtual DbSet<Webentity> Webpage { get; set; }
    }
}
