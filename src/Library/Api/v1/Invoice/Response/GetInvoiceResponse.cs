using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
﻿namespace ME.Sdk.Library.Api.v1.Invoice.Response
{
    public class GetInvoiceResponse
    {
#if NET6_0_OR_GREATER
        public string? SerialNumber { get; set; }
        public string? InvoiceNumber { get; set; }
        public string? ClientSupplierId { get; set; }
        public string? Currency { get; set; }
        public string? UserLogin { get; set; }
#else
        public string SerialNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string ClientSupplierId { get; set; }
        public string Currency { get; set; }
        public string UserLogin { get; set; }
#endif
        public DateTime? IssueDate { get; set; }
        public double? TotalDue { get; set; }
        public double? NetPrice { get; set; }
        public double? InvoiceCharging { get; set; }
        public DateTime? CreationDate { get; set; }
        public int SupplierId { get; set; }
    }
}
