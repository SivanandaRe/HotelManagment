﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HotelManagement_Context : DbContext
    {
        public HotelManagement_Context()
            : base("name=HotelManagement_Context")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAddress> tblAddresses { get; set; }
        public virtual DbSet<tblAddressType> tblAddressTypes { get; set; }
        public virtual DbSet<tblCollection> tblCollections { get; set; }
        public virtual DbSet<tblCustomer> tblCustomers { get; set; }
        public virtual DbSet<tblEmployee> tblEmployees { get; set; }
        public virtual DbSet<tblGender> tblGenders { get; set; }
        public virtual DbSet<tblInventry> tblInventries { get; set; }
        public virtual DbSet<tblInvoice> tblInvoices { get; set; }
        public virtual DbSet<tblMenuItem> tblMenuItems { get; set; }
        public virtual DbSet<tblOrderDelivery> tblOrderDeliveries { get; set; }
        public virtual DbSet<tblOrder> tblOrders { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }
        public virtual DbSet<tblRole> tblRoles { get; set; }
    }
}
