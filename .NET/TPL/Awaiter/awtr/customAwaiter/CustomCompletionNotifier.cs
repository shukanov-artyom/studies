using System;
using System.Runtime.CompilerServices;

namespace customAwaiter
{
    /// <summary>
    /// Task awaiter substitute implements INotifyCompletion
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    public class CustomCompletionNotifier<TResult> : INotifyCompletion
    {
        /// <summary>
        /// On completed.
        /// </summary>
        public void OnCompleted(Action continuation)
        {
            continuation.Invoke();
        }

        public TResult GetResult()
        {
            return default(TResult);
        }

        public bool IsCompleted
        {
            get
            {
                return true;
            }
        }
    }
}
