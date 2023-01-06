using EdgeImport.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EdgeImport.Workflows
{
    /// <summary>
    /// 
    /// </summary>
    public interface IWorkflow
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task ExecuteAsync(IMessage message, CancellationToken cancellationToken);
    }
}
