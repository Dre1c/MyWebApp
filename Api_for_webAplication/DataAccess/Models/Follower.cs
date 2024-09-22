using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Follower
{
    public int FollowerId { get; set; }

    public int FollowingId { get; set; }

    public DateTime? FollowDate { get; set; }

    public virtual User FollowerNavigation { get; set; } = null!;

    public virtual User Following { get; set; } = null!;
}
