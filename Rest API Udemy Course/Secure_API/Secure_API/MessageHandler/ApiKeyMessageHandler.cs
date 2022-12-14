using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using System.Web;

namespace Secure_API.MessageHandler
{
    public class ApiKeyMessageHandler : DelegatingHandler
    {
        private const string ApiKeyToCheck = "A1362BNDKL3327655968974SZNBVJHKLHHFLHLKF";
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            bool validKey = false;
            IEnumerable<string> requestHeaders;
            var checkApiExists = request.Headers.TryGetValues("ApiKey", out
           requestHeaders);
            if (checkApiExists)
            {
                if (requestHeaders.FirstOrDefault().Equals(ApiKeyToCheck))
                {
                    validKey = true;
                }
            }
            if (!validKey)
            {
                return request.CreateResponse(HttpStatusCode.Forbidden, "Api Key Not valid");
            }
            return await base.SendAsync(request, cancellationToken);
        }
    }
}