//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PassportRecognize.Controls.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public int ID { get; set; }
        public Nullable<int> HumanID { get; set; }
        public Nullable<int> FlightId { get; set; }
    
        public virtual Flight Flight { get; set; }
        public virtual Human Human { get; set; }
    }
}
