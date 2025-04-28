using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class Users
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public bool IsSuperUser { get; set; }

    public int? AffiliateId { get; set; }

    public string? Email { get; set; }

    public string DisplayName { get; set; } = null!;

    public bool UpdatePassword { get; set; }

    public string? LastIpaddress { get; set; }

    public bool IsDeleted { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public Guid? PasswordResetToken { get; set; }

    public DateTime? PasswordResetExpiration { get; set; }

    public virtual ICollection<ContentWorkflowStatePermission> ContentWorkflowStatePermission { get; } = new List<ContentWorkflowStatePermission>();

    public virtual ICollection<CoreMessagingSubscriptions> CoreMessagingSubscriptions { get; } = new List<CoreMessagingSubscriptions>();

    public virtual ICollection<DesktopModulePermission> DesktopModulePermission { get; } = new List<DesktopModulePermission>();

    public virtual ICollection<FolderPermission> FolderPermission { get; } = new List<FolderPermission>();

    public virtual ICollection<ModulePermission> ModulePermission { get; } = new List<ModulePermission>();

    public virtual ICollection<PasswordHistory> PasswordHistory { get; } = new List<PasswordHistory>();

    public virtual ICollection<PersonaBarMenuPermission> PersonaBarMenuPermission { get; } = new List<PersonaBarMenuPermission>();

    public virtual ICollection<PortalPermission> PortalPermission { get; } = new List<PortalPermission>();

    public virtual ICollection<Profile> Profile { get; } = new List<Profile>();

    public virtual ICollection<Relationships> Relationships { get; } = new List<Relationships>();

    public virtual ICollection<TabPermission> TabPermission { get; } = new List<TabPermission>();

    public virtual ICollection<UserAuthentication> UserAuthentication { get; } = new List<UserAuthentication>();

    public virtual ICollection<UserPortals> UserPortals { get; } = new List<UserPortals>();

    public virtual ICollection<UserProfile> UserProfile { get; } = new List<UserProfile>();

    public virtual ICollection<UserRelationshipPreferences> UserRelationshipPreferences { get; } = new List<UserRelationshipPreferences>();

    public virtual ICollection<UserRelationships> UserRelationshipsRelatedUser { get; } = new List<UserRelationships>();

    public virtual ICollection<UserRelationships> UserRelationshipsUser { get; } = new List<UserRelationships>();

    public virtual ICollection<UserRoles> UserRoles { get; } = new List<UserRoles>();

    public virtual ICollection<UsersOnline> UsersOnline { get; } = new List<UsersOnline>();
}
