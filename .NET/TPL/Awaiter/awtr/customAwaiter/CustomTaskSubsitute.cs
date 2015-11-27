using System;

namespace customAwaiter
{
    /// <summary>
    /// The only thing required from Task substitute is to return Awaiter substitute.
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    internal class CustomTaskSubsitute<TResult>
    {
        public CustomCompletionNotifier<TResult> GetAwaiter()
        {
            return new CustomCompletionNotifier<TResult>();
        }
    }
}
