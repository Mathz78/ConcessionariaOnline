using Microsoft.OpenApi.Models;

namespace ConcessionariaOnline.Models
{
    internal class Info : OpenApiInfo
    {
        public string Version { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TermsOfService { get; set; }
        public Contact Contact { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
    }
}