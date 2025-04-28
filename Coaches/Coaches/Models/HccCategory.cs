using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccCategory
{
    public Guid Bvin { get; set; }

    public long StoreId { get; set; }

    public Guid? ParentId { get; set; }

    public int SortOrder { get; set; }

    public string ImageUrl { get; set; } = null!;

    public string BannerImageUrl { get; set; } = null!;

    public int SourceType { get; set; }

    public int DisplaySortOrder { get; set; }

    public string CustomPageUrl { get; set; } = null!;

    public int CustomPageNewWindow { get; set; }

    public int ShowInTopMenu { get; set; }

    public int Hidden { get; set; }

    public string TemplateName { get; set; } = null!;

    public string PostContentColumnId { get; set; } = null!;

    public string PreContentColumnId { get; set; } = null!;

    public DateTime LastUpdated { get; set; }

    public string RewriteUrl { get; set; } = null!;

    public int ShowTitle { get; set; }

    public DateTime CreationDate { get; set; }

    public virtual ICollection<HccCatalogRoles> HccCatalogRoles { get; } = new List<HccCatalogRoles>();

    public virtual ICollection<HccCategoryTranslations> HccCategoryTranslations { get; } = new List<HccCategoryTranslations>();

    public virtual ICollection<HccProductXcategory> HccProductXcategory { get; } = new List<HccProductXcategory>();
}
