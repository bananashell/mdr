namespace mdr.Server {
    public class Config   {
        public CacheConfig Cache { get;set; }
    }
    
    public class CacheConfig
    {
        public bool Enabled { get; set; }
        public string Url { get; set; }
    }
}