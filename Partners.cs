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
    using System.Linq;

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

        private int PartnerDiscount
        {
            get
            {

                if (Koloskov_MasterFloorEntities.GetContext().PartnerProduct.Where(p => p.Partner == PartnerID).Count() > 0)
                {
                    var PartnerProdQuantity = Koloskov_MasterFloorEntities.GetContext().PartnerProduct.Where(p => p.Partner == PartnerID).Sum(p => p.Quantity);
                    Console.WriteLine(PartnerProdQuantity);
                    if (PartnerProdQuantity >= 10000 && PartnerProdQuantity < 50000)
                    {
                        return 5;
                    }
                    else if (PartnerProdQuantity >= 50000 && PartnerProdQuantity < 300000)
                    {
                        return 10;
                    }
                    else if (PartnerProdQuantity >= 300000)
                    {
                        return 15;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return -1;
                }

            }
        }

        public string PartnerDiscountDisplay
        {
            get
            {
                if (PartnerDiscount == 0)
                {
                    return "Нет скидки";
                }
                else if (PartnerDiscount == -1)
                {
                    return "Нет продаж";
                }
                else
                {
                    return PartnerDiscount.ToString() + "%";
                }
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
