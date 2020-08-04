// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
// ------------------------------------------------------------

namespace ActorClient
{
    using System;
    using System.Threading.Tasks;
    using Dapr.Actors;
    using Dapr.Actors.Client;
    using IDemoActorInterface;

    /// <summary>
    /// Actor Client class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point.
        /// </summary>
        /// <param name="args">Arguments.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public static async Task Main(string[] args)
        {
            // Create an actor Id.
            var actorId = new ActorId("abc");

            // Make strongly typed Actor calls with Remoting.
            // DemoActor is the type registered with Dapr runtime in the service.
            var proxy = ActorProxy.Create<IDemoActor>(actorId, "DemoActor");
            await proxy.RegisterReminder();
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
