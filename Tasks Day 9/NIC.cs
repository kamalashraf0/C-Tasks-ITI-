namespace Tasks_Day_9
{
    public class NIC
    {
        public string Manufacture { get; set; }
        public string MACAddress { get; set; }
        public NICcardType NICtype { get; set; }

        private NIC()
        {

        }

        public static NIC Instance { get; private set; } = new NIC();
    }

    public enum NICcardType
    {

        Ethernet,
        TokenRing

    }
}
