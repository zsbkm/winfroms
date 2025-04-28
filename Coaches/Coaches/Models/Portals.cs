using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class Portals
{
    public int PortalId { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public int UserRegistration { get; set; }

    public int BannerAdvertising { get; set; }

    public int? AdministratorId { get; set; }

    public string? Currency { get; set; }

    public decimal HostFee { get; set; }

    public int HostSpace { get; set; }

    public int? AdministratorRoleId { get; set; }

    public int? RegisteredRoleId { get; set; }

    public Guid Guid { get; set; }

    public string? PaymentProcessor { get; set; }

    public string? ProcessorUserId { get; set; }

    public string? ProcessorPassword { get; set; }

    public int? SiteLogHistory { get; set; }

    public string DefaultLanguage { get; set; } = null!;

    public int TimezoneOffset { get; set; }

    public string HomeDirectory { get; set; } = null!;

    public int PageQuota { get; set; }

    public int UserQuota { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public int? PortalGroupId { get; set; }

    public int? HomeTabId { get; set; }

    public virtual ICollection<AnonymousUsers> AnonymousUsers { get; } = new List<AnonymousUsers>();

    public virtual ICollection<CoreMessagingSubscriptions> CoreMessagingSubscriptions { get; } = new List<CoreMessagingSubscriptions>();

    public virtual ICollection<Files> Files { get; } = new List<Files>();

    public virtual ICollection<FolderMappings> FolderMappings { get; } = new List<FolderMappings>();

    public virtual ICollection<Folders> Folders { get; } = new List<Folders>();

    public virtual ICollection<MobilePreviewProfiles> MobilePreviewProfiles { get; } = new List<MobilePreviewProfiles>();

    public virtual ICollection<MobileRedirections> MobileRedirections { get; } = new List<MobileRedirections>();

    public virtual ICollection<PersonaBarMenuPermission> PersonaBarMenuPermission { get; } = new List<PersonaBarMenuPermission>();

    public virtual ICollection<PortalAlias> PortalAlias { get; } = new List<PortalAlias>();

    public virtual ICollection<PortalDesktopModules> PortalDesktopModules { get; } = new List<PortalDesktopModules>();

    public virtual ICollection<PortalLanguages> PortalLanguages { get; } = new List<PortalLanguages>();

    public virtual ICollection<PortalLocalization> PortalLocalization { get; } = new List<PortalLocalization>();

    public virtual ICollection<PortalPermission> PortalPermission { get; } = new List<PortalPermission>();

    public virtual ICollection<PortalSettings> PortalSettings { get; } = new List<PortalSettings>();

    public virtual ICollection<Profile> Profile { get; } = new List<Profile>();

    public virtual ICollection<ProfilePropertyDefinition> ProfilePropertyDefinition { get; } = new List<ProfilePropertyDefinition>();

    public virtual ICollection<Relationships> Relationships { get; } = new List<Relationships>();

    public virtual ICollection<RoleGroups> RoleGroups { get; } = new List<RoleGroups>();

    public virtual ICollection<Roles> Roles { get; } = new List<Roles>();

    public virtual ICollection<SiteLog> SiteLog { get; } = new List<SiteLog>();

    public virtual ICollection<SystemMessages> SystemMessages { get; } = new List<SystemMessages>();

    public virtual ICollection<Tabs> Tabs { get; } = new List<Tabs>();

    public virtual ICollection<UrlTracking> UrlTracking { get; } = new List<UrlTracking>();

    public virtual ICollection<Urls> Urls { get; } = new List<Urls>();

    public virtual ICollection<UserPortals> UserPortals { get; } = new List<UserPortals>();

    public virtual ICollection<UsersOnline> UsersOnline { get; } = new List<UsersOnline>();
}
