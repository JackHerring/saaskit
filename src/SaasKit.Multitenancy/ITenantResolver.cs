﻿using Microsoft.AspNet.Http;
using System.Threading.Tasks;

namespace SaasKit.Multitenancy
{
    public interface ITenantResolver<TTenant>
    {
        Task<TenantContext<TTenant>> ResolveAsync(HttpContext context);
    }
}