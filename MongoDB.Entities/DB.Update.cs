﻿namespace MongoDB.Entities
{
    public static partial class DB
    {
        /// <summary>
        /// Represents an update command
        /// <para>TIP: Specify a filter first with the .Match() method. Then set property values with .Modify() and finally call .Execute() to run the command.</para>
        /// </summary>
        /// <typeparam name="T">Any class that implements IEntity</typeparam>
        public static Update<T> Update<T>() where T : IEntity
        {
            return new Update<T>();
        }

        /// <summary>
        /// Update and retrieve the first document that was updated.
        /// <para>TIP: Specify a filter first with the .Match(). Then set property values with .Modify() and finally call .Execute() to run the command.</para>
        /// </summary>
        /// <typeparam name="T">Any class that implements IEntity</typeparam>
        /// <typeparam name="TProjection">The type to project to</typeparam>
        public static UpdateAndGet<T, TProjection> UpdateAndGet<T, TProjection>() where T : IEntity
        {
            return new UpdateAndGet<T, TProjection>();
        }

        /// <summary>
        /// Update and retrieve the first document that was updated.
        /// <para>TIP: Specify a filter first with the .Match(). Then set property values with .Modify() and finally call .Execute() to run the command.</para>
        /// </summary>
        /// <typeparam name="T">Any class that implements IEntity</typeparam>
        public static UpdateAndGet<T> UpdateAndGet<T>() where T : IEntity
        {
            return new UpdateAndGet<T>();
        }
    }
}
