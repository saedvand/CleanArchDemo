using CleanArch.Domain.Core.Events;
using System;

namespace CleanArch.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
