using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Xml.Linq;

namespace ABCComplaintManagementSystem.Components.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        public DbSet<Companies> Companies { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<InternalUsers> InternalUsers { get; set; }
        public DbSet<Audits> Audits { get; set; }
        public DbSet<Complaints> Complaints { get; set; }
    }

    public class Companies
    {
        [Key]
        public int CompanyID { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyDescription { get; set; }
        public string ExternalAccountReferenceModel { get; set; }
    }
    public class Roles
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public string? RoleDescription { get; set; }
    }
    public class InternalUsers
    {
        [Key]
        public int InternalUserID { get; set; }
        public string ExternalAccountReference { get; set; }
        public int CompanyID { get; set; }
        public int RoleID { get; set; }
    }
    public class Audits
    {
        [Key]
        public int LogID { get; set; }
        public string ExternalAccountReference { get; set; }
        public int? InternalUserID { get; set; }
    }
    public class Complaints
    {
        [Key]
        public int ComplaintID { get; set; }
        public int? LogID { get; set; }
        public int? HelpDeskAgentInternalUserID { get; set; }
        public int? SupportPersonInternalUserID { get; set; }
        public string? ComplaintDescription { get; set; }
        public string? ComplaintTitle { get; set; }
        public string? ArtifactFile { get; set; }
        public string? DateCreated { get; set; }
        public string? LastUpdated { get; set; }
        public string? DateClosed { get; set; }
        public int? Status { get; set; }
        public int? Resolved { get; set; }
        public string? ResolvedText { get; set; }
    }


}
