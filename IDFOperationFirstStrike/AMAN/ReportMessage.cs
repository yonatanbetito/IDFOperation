using System;
using IDFOperationFirstStrike.HAMAS;

namespace IDFOperationFirstStrike.AMAN
{
    public class ReportMessage
    {
        public Terrorist Target { get; }
        public string Location { get; }
        public DateTime TimeStamp { get; }

        public ReportMessage(Terrorist target, string location, DateTime timeStamp)
        {
            Target = target;
            Location = location;
            TimeStamp = timeStamp;
        }

        public override string ToString()
        {
            return $"Target: {Target.getName()}, Location: {Location}, Time: {TimeStamp}";
        }
    }
}