// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
// ------------------------------------------------------------

namespace DaprDemoActor
{
    using System;
    using System.Threading.Tasks;
    using Dapr.Actors;
    using Dapr.Actors.Runtime;
    using IDemoActorInterface;

    /// <summary>
    /// Actor Implementation.
    /// Following example shows how to use Actor Reminders as well.
    /// For Actors to use Reminders, it must derive from IRemindable.
    /// If you don't intend to use Reminder feature, you can skip implementing IRemindable and reminder specific methods which are shown in the code below.
    /// </summary>
    public class DemoActor : Actor, IDemoActor, IRemindable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DemoActor"/> class.
        /// </summary>
        /// <param name="service">Actor Service hosting the actor.</param>
        /// <param name="actorId">Actor Id.</param>
        public DemoActor(ActorService service, ActorId actorId)
            : base(service, actorId)
        {
        }
        
        /// <inheritdoc/>
        public async Task RegisterReminder()
        {
            Console.WriteLine("--------- REMINDER REGISTERED ---------");
            await this.RegisterReminderAsync("TestReminder", null, TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(5));
        }

        /// <inheritdoc/>
        public async Task ReceiveReminderAsync(string reminderName, byte[] state, TimeSpan dueTime, TimeSpan period)
        {
            Console.WriteLine("--------- REMINDER RECEIVED AND UNREGISTERED ---------");
            await UnregisterReminderAsync("TestReminder");
        }
    }
}
