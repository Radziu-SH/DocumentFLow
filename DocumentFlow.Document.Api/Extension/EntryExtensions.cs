using DocumentFlow.Document.Core.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("DocumentFlow.Bootstrapper")]
namespace DocumentFlow.Document.Api.Extension
{
    internal static class EntryExtensions
    {
        public static IServiceCollection AddDocument(this IServiceCollection services)
        {
            services.AddCore();
            return services;
        }
    }
}
