using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccStores
{
    public long Id { get; set; }

    public Guid StoreGuid { get; set; }

    public string StoreName { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string CustomUrl { get; set; } = null!;

    public int LastOrderNumber { get; set; }

    public virtual ICollection<HccOrderTransactions> HccOrderTransactions { get; } = new List<HccOrderTransactions>();

    public virtual ICollection<HccShippingZones> HccShippingZones { get; } = new List<HccShippingZones>();

    public virtual ICollection<HccStoreSettings> HccStoreSettings { get; } = new List<HccStoreSettings>();

    public virtual ICollection<HccStoresXusers> HccStoresXusers { get; } = new List<HccStoresXusers>();

    public virtual ICollection<HccTaxSchedules> HccTaxSchedules { get; } = new List<HccTaxSchedules>();

    public virtual ICollection<HccTaxes> HccTaxes { get; } = new List<HccTaxes>();
}
