using System;
using System.Collections.Generic;
using System.Text;

namespace MyDiary.Contacts.SharedKernel
{
    public abstract class BaseDomainEvent
    {
        public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
    }
}
