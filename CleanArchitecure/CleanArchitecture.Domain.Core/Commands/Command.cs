using CleanArchitecture.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Core.Commands
{
    public abstract class Command: Message
    {
        public Command()
        {
            Timestamp = DateTime.UtcNow;
        }

        public DateTime Timestamp { get; protected set; }
    }
}
