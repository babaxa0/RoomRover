//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoomRover.AddBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Finance
    {
        public int id_finance { get; set; }
        public int income { get; set; }
        public int consumption { get; set; }
        public int profit { get; set; }
        public int id_admin { get; set; }
        public System.DateTime Date_Finance { get; set; }
    
        public virtual Admin Admin { get; set; }
    }
}
