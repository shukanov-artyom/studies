using System;

namespace TaskAsyncPatternTest
{
    public class MethodWrapper<TInput, TOutput>
    {
        private Func<TInput, TOutput> method;

        public MethodWrapper(Func<TInput, TOutput> method)
        {
            this.method = method;
        }

        public IAsyncResult BeginExecute(TInput argument, AsyncCallback clb, object state)
        {
            return method.BeginInvoke(argument, clb, state);
        }

        public TOutput EndExecute(IAsyncResult asyncResult)
        {
            return method.EndInvoke(asyncResult);
        }
    }
}
