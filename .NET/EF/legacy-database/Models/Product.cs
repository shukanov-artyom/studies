using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductAndGroupPermission = new HashSet<ProductAndGroupPermission>();
            ProductAndRole = new HashSet<ProductAndRole>();
            ProductAndTestQuestionFlagPermission = new HashSet<ProductAndTestQuestionFlagPermission>();
            ProductAndUserTestPermission = new HashSet<ProductAndUserTestPermission>();
            ProductAndVideoCategoryTypePermission = new HashSet<ProductAndVideoCategoryTypePermission>();
            ProductAndVideoPermission = new HashSet<ProductAndVideoPermission>();
            ProductReferenceProduct = new HashSet<ProductReference>();
            ProductReferenceReferencedProduct = new HashSet<ProductReference>();
            Userandproduct = new HashSet<Userandproduct>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int WebsiteId { get; set; }
        public decimal? Price { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Mailchimpid { get; set; }
        public int? Producttypeid { get; set; }
        public DateTime? Marketingstartdate { get; set; }
        public int? NumdaysExpirereminder { get; set; }
        public int? LengthDays { get; set; }
        public string Newusersstarttype { get; set; }
        public string Paypallink { get; set; }
        public string Paypalbuttonid { get; set; }
        public string SuccessText { get; set; }
        public string Logolink { get; set; }
        public string PrimaryButtonLink { get; set; }
        public string PrimaryButtonTitle { get; set; }
        public bool? IsPrimaryButtonEnabled { get; set; }
        public bool IsVcRenewal { get; set; }
        public int? PermissionTierId { get; set; }

        public Users CreatedByNavigation { get; set; }
        public PermissionTier PermissionTier { get; set; }
        public Producttype Producttype { get; set; }
        public Website Website { get; set; }
        public ICollection<ProductAndGroupPermission> ProductAndGroupPermission { get; set; }
        public ICollection<ProductAndRole> ProductAndRole { get; set; }
        public ICollection<ProductAndTestQuestionFlagPermission> ProductAndTestQuestionFlagPermission { get; set; }
        public ICollection<ProductAndUserTestPermission> ProductAndUserTestPermission { get; set; }
        public ICollection<ProductAndVideoCategoryTypePermission> ProductAndVideoCategoryTypePermission { get; set; }
        public ICollection<ProductAndVideoPermission> ProductAndVideoPermission { get; set; }
        public ICollection<ProductReference> ProductReferenceProduct { get; set; }
        public ICollection<ProductReference> ProductReferenceReferencedProduct { get; set; }
        public ICollection<Userandproduct> Userandproduct { get; set; }
    }
}
