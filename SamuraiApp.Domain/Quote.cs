using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiApp.Domain
{
    public class Quote
    {
        public int Id { get; set; } // Id property for tracking the Quote
        public string Text { get; set; } // Text property for spoken quote by the Samurai
        public Samurai Samurai { get; set; } // this is reference property back to Samurai
        public int SamuraiId { get; set; } // Explicit Integer property that will contain foreign key value
    }
}
