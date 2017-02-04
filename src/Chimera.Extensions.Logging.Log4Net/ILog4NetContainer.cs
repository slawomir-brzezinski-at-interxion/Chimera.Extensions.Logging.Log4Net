namespace Chimera.Extensions.Logging.Log4Net
{
    using log4net.Repository;

    /// <summary>
    /// Represents a type used for log4net repository initialization and creation.
    /// </summary>
    public interface ILog4NetContainer
    {
        /// <summary>
        /// Gets a value indicating whether this instance is initialized.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is initialized; otherwise, <c>false</c>.
        /// </value>
        bool IsInitialized { get; }

        /// <summary>
        /// Gets the logger repository.
        /// </summary>
        /// <value>
        /// The logger repository.
        /// </value>
        ILoggerRepository LoggerRepository { get; }

        /// <summary>
        /// Initializes this instance of log4net.
        /// </summary>
        void Initialize();
    }
}