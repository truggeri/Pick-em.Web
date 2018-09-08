using System;

namespace Pick_em.Lib.Models
{
    public abstract class BaseModel
    {
        public Guid Id;
        public DateTime Created;
        public DateTime Updated;
    }
}