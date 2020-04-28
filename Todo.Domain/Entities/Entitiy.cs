using System;
using System.Diagnostics.CodeAnalysis;

namespace Todo.Domain.Entities
{
    public abstract class Entitiy : IEquatable<Entitiy>
    {
        public Entitiy()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public bool Equals([AllowNull] Entitiy other)
        {
            return Id == other.Id;
        }
    }
}
