// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
// ------------------------------------------------------------

namespace IDemoActorInterface
{
    using System.Threading.Tasks;
    using Dapr.Actors;

    /// <summary>
    /// Interface for Actor method.
    /// </summary>
    public interface IDemoActor : IActor
    {
        /// <summary>
        /// Registers a reminder.
        /// </summary>
        /// <returns>A task that represents the asynchronous save operation.</returns>
        Task RegisterReminder();
    }
}
