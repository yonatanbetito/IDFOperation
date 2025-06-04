namespace IDFOperationFirstStrike.AMAN
{
    internal class ReportMessage
    {
        public string TerroristName;
        public string Location;
        public DateTime TimeStamp;

        public ReportMessage(string name,string location)
        {
            TerroristName = name;
            Location = location;
            TimeStamp = DateTime.Now;
        }
    }
}