//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ValievPractika2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kino
    {
        public int id { get; set; }
        public Nullable<int> id_Genre { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Movie_Date { get; set; }
        public Nullable<bool> Pushkin_card_status { get; set; }
    
        public virtual Genre Genre { get; set; }
    }
}
