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
    
    public partial class Materials
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Materials()
        {
            this.MaterialsCount = new HashSet<MaterialsCount>();
            this.Products = new HashSet<Products>();
            this.SupplyHistory = new HashSet<SupplyHistory>();
        }
    
        public int MaterialID { get; set; }
        public int MaterialType { get; set; }
        public string MaterialName { get; set; }
        public int MaterialSupplier { get; set; }
        public int MaterialPackageQuantity { get; set; }
        public int MaterialMeasurementUnit { get; set; }
        public string MaterialDescription { get; set; }
        public byte[] MaterialImage { get; set; }
        public decimal MaterialPrice { get; set; }
        public int MaterialQuantityInStock { get; set; }
        public int MinimumAcceptableQuantity { get; set; }
    
        public virtual MaterialsType MaterialsType { get; set; }
        public virtual MeasurementUnits MeasurementUnits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialsCount> MaterialsCount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Products> Products { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplyHistory> SupplyHistory { get; set; }
    }
}
