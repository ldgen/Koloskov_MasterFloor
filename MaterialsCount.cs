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
    
    public partial class MaterialsCount
    {
        public int ID { get; set; }
        public int MaterialID { get; set; }
        public System.DateTime Date { get; set; }
        public int Quantity { get; set; }
    
        public virtual Materials Materials { get; set; }
    }
}
