using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eurofins.GMA.Application.Contracts.Dtos
{
    public class AssetDto
    {
        public int Id { get; set; }
        public string? AssetId { get; set; }
        public string? FileName { get; set; }
        public string? MimeType { get; set; }
        public string? Email { get; set; }
        public string? Country { get; set; }
        public string? Description { get; set; }
        public string? CreatedBy { get; set; }
    }
}
