namespace FluentHttp
{
    /// <summary>
    /// Response status
    /// </summary>
    public enum ResponseStatus
    {
        /// <summary>
        /// Response not started.
        /// </summary>
        Non,

        /// <summary>
        /// Web request completed successfully.
        /// </summary>
        Completed,

        /// <summary>
        /// Error occured executing web request.
        /// </summary>
        Error,

        /// <summary>
        /// Web request cancelled.
        /// </summary>
        Cancelled
    }
}