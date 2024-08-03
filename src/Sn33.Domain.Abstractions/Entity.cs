﻿namespace Sn33.Domain.Abstractions;

public abstract class Entity<TId> : HasDomainEvents where TId : struct, IEquatable<TId>
{
    public TId Id { get; set; }
}