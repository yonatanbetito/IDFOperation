namespace IDFOperationFirstStrike.AMAN
{
    internal class ReportMessage
    {
        public string TerroristName { get; set; } 
        public string Location { get; set; }
        public DateTime TimeStamp{ get; set; }

        public ReportMessage(string name,string location)
        {
            TerroristName = name;
            Location = location;
            TimeStamp = DateTime.Now;
        }
    }
}