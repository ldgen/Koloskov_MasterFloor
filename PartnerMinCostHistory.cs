//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Koloskov_MasterFloor
{
    using System;
    using System.Collections.Generic;
    
    public partial class PartnerMinCostHistory
    {
        public string ArticleNumber { get; set; }
        public Nullable<int> PartnerID { get; set; }
        public decimal MinCost { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Partners Partners { get; set; }
        public virtual Products Products { get; set; }
    }
}