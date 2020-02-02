﻿using System.Threading.Tasks;
using BASRemote.Objects;

namespace BASRemote.Common
{
    public interface IBasThread
    {
        /// <summary>
        /// 
        /// </summary>
        bool IsRunning { get; }

        /// <summary>
        /// 
        /// </summary>
        int Id { get; }

        /// <summary>
        ///     Asynchronously calls the BAS function and returns the result.
        /// </summary>
        /// <param name="functionName">
        ///     BAS function name as string.
        /// </param>
        /// <param name="functionParams">
        ///     BAS function arguments list.
        /// </param>
        Task<object> RunFunctionAsync(string functionName, Params functionParams);

        /// <summary>
        ///     Asynchronously calls the BAS function and returns the promise.
        /// </summary>
        /// <param name="functionName">
        ///     BAS function name as string.
        /// </param>
        /// <param name="functionParams">
        ///     BAS function arguments list.
        /// </param>
        IPromise<object> RunFunction(string functionName, Params functionParams);

        void Stop();
    }
}