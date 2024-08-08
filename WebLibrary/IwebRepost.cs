using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary
{
   public  class IwebRepost: Iwebpage
    {
        private readonly EFDbcontext reference;
        public IwebRepost(EFDbcontext ret)
        {
            reference = ret;

        }
        public IEnumerable<Webentity> Showall()
        {
            try
            {
                return reference.Webpage.ToList();

            }catch(Exception)
            {
                throw;
            }

        }
        public void Create(Webentity set)
        {
            reference.Add<Webentity>(set);
            reference.SaveChanges();
        }
    }
}
