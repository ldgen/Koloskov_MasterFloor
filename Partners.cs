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
    
    public partial class Partners
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partners()
        {
            this.PartnerMinCostHistory = new HashSet<PartnerMinCostHistory>();
            this.PartnerProduct = new HashSet<PartnerProduct>();
            this.PointSales = new HashSet<PointSales>();
        }
    
        public int PartnerID { get; set; }
        public int PartnerType { get; set; }
        public string PartnerCompanyName { get; set; }
        public string PartnerDirectorSurname { get; set; }
        public string PartnerDirectorName { get; set; }
        public string PartnerDirectorPatronymic { get; set; }
        public string PartnerEmail { get; set; }
        public string PartnerPhoneNumber { get; set; }
        public int PartnerCompanyAdressIndex { get; set; }
        public string PartnerCompanyAdressRegion { get; set; }
        public string PartnerCompanyAdressCity { get; set; }
        public string PartnerCompanyAdressStreet { get; set; }
        public string PartnerCompanyAdressHouse { get; set; }
        public string PartnerCompanyINN { get; set; }
        public double PartnerRating { get; set; }
        public byte[] PartnerLogo { get; set; }

        public string PartnerTypeString
        {
            get
            {
                return OrganizationForm.OrganizationTypeName;
            }
        }

        public int PartnerDiscount
        {
            get
            {
                int total = 0; foreach (PartnerProductSale productSales in this.PartnerProductSale)
                {
                    total += productSales.PartnerProductSaleCount * Convert.ToInt32(productSales.Product.ProductCost);
                }
                int sale = 0;
                if (total > 10000 && total < 50000)
                {
                    sale = 5;
                }
                else if (total > 50000 && total < 300000)
                {
                    sale = 10;
                }
                else if (total > 300000)
                {
                    sale = 15;
                }
                return sale;
            }
        }

        public virtual OrganizationForm OrganizationForm { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartnerMinCostHistory> PartnerMinCostHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartnerProduct> PartnerProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PointSales> PointSales { get; set; }
    }
}
