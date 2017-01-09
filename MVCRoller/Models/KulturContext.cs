using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCRoller.Models
{
    public class KulturContext:DbContext
    {
       
            public DbSet<Kultur> KulturListe { get; set; }
        
    }
}