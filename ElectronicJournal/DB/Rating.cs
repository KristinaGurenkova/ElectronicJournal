//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectronicJournal.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rating
    {
        public int idRating { get; set; }
        public Nullable<int> idDiscipline { get; set; }
        public Nullable<double> assessment { get; set; }
        public Nullable<int> idStudent { get; set; }
    
        public virtual Discipline Discipline { get; set; }
        public virtual Student Student { get; set; }
    }
}
