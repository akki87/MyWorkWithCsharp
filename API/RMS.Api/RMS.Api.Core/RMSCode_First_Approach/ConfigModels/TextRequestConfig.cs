using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Api.Core.ConfigModels
{
    public class TextRequestConfig
    {
        public string BaseUrl { get; set; } = null;
        public int PhoneNumberId { get; set; }
        public string TextMetricesApiKey { get; set; } = null;
    }
}
