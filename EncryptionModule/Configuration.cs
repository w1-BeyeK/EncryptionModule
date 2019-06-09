namespace EncryptionModule
{
    public class Configuration
    {
        private const string defaultPassPhrase = "HR$2pIjHR$2pIj12";
        private const int defaultBlockSize = 128;
        private const int defaultKeySize = 128;
        private const int defaultDerivationIterations = 1000;


        public Configuration(string passPhrase, int keySize, int blockSize, int derivationIterations)
        {
            PassPhrase = passPhrase;
            KeySize = keySize;
            BlockSize = blockSize;
            DerivationIterations = derivationIterations;
        }

        public static Configuration Standard = new Configuration(defaultPassPhrase, defaultKeySize, defaultBlockSize, defaultDerivationIterations);
        public static Configuration WithPassword(string passPhrase)
        {
            Configuration configuration = Standard;
            configuration.PassPhrase = passPhrase;

            return configuration;
        }

        public string PassPhrase { get; set; }
        public int KeySize { get; set; }
        public int BlockSize { get; set; }
        public int DerivationIterations { get; set; }
    }
}