using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Paymenttransactionlog
    {
        public int Paymenttransactionlogid { get; set; }
        public int? Userid { get; set; }
        public int? Productid { get; set; }
        public DateTime? Purchasedate { get; set; }
        public string AddressName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressZip { get; set; }
        public string AddressCountry { get; set; }
        public string AddressCountryCode { get; set; }
        public string AddressStatus { get; set; }
        public string PayerEmail { get; set; }
        public string ResidenceCountry { get; set; }
        public int? Quantity { get; set; }
        public string PaymentStatus { get; set; }
        public double? PaymentFee { get; set; }
        public string PayerStatus { get; set; }
        public string PaymentType { get; set; }
        public DateTime? PaymentDate { get; set; }
        public double? McGross { get; set; }
        public double? PaymentGross { get; set; }
        public int? ItemNumber { get; set; }
        public string OptionName1 { get; set; }
        public string ItemName { get; set; }
        public int? BtnId { get; set; }
        public string Custom { get; set; }
        public double? ShippingDiscount { get; set; }
        public string TxnId { get; set; }
        public double? HandlingAmount { get; set; }
        public double? Tax { get; set; }
        public double? Discount { get; set; }
        public string VerifySign { get; set; }
        public string TestIpn { get; set; }
        public string IpnTrackId { get; set; }
        public string TransactionSubject { get; set; }
        public double? InsuranceAmount { get; set; }
        public string ProtectionEligibility { get; set; }
        public string OptionSelection1 { get; set; }
        public string Charset { get; set; }
        public string PayerId { get; set; }
        public double? Shipping { get; set; }
        public double? McFee { get; set; }
        public string Business { get; set; }
        public string ReceiverEmail { get; set; }
        public string ShippingMethod { get; set; }
        public string McCurrency { get; set; }
        public string NotifyVersion { get; set; }
        public string TxnType { get; set; }
        public string ReceiverId { get; set; }
        public string ParentTxnId { get; set; }
        public string Shippingaddress { get; set; }
    }
}
