using Microsoft.OpenApi.Models;

namespace ConcessionariaOnline.Models
{
    internal class Info : OpenApiInfo
    {
        public new string Version { get; set; }
        public new string Title { get; set; }
        public new string Description { get; set; }
        public new string TermsOfService { get; set; }
        public new Contact Contact { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
    }
}