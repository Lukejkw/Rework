namespace Rework.EntityFramework
{
    namespace PMS.Data.Contract
    {
        /// <summary>
        /// IEntity exposes the standard properties that are implemented on all database-peristed objects.
        /// </summary>
        /// <remarks>
        /// This interface deals with creation and modification dates, and who created or last modified it.
        /// Version is for dealing with concurrency in Web Api scenarios.
        /// </remarks>
        public interface IEntity
        {
            object Id { get; set; }
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="T">A generically typed property which is the primary key</typeparam>
        /// <remarks>
        /// By making it generic, we can utilize an int, long or Guid, depending on the needs of the entity.
        /// </remarks>
        public interface IEntity<T> : IEntity
        {
            new T Id { get; set; }
        }
    }
}