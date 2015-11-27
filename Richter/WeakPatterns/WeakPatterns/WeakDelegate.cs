using System;
using System.Collections.Generic;
using System.Reflection;

namespace WeakPatterns
{
    public class WeakDelegate<TDelegate> where TDelegate : class
    {
        private readonly List<MethodTarget> targets = new List<MethodTarget>();

        public WeakDelegate()
        {
            if (!typeof(TDelegate).IsSubclassOf(typeof(Delegate)))
            {
                throw new InvalidOperationException("Incorrect delegate type");
            }
        }

        public void Append(TDelegate target)
        {
            if (target == null)
            {
                return;
            }
            foreach (Delegate d in (target as Delegate).GetInvocationList())
            {
                targets.Add(new MethodTarget(d));
            }
        }

        public void Remove(TDelegate target)
        {
            if (target == null)
            {
                return;
            }
            foreach (Delegate d in (target as Delegate).GetInvocationList())
            {
                MethodTarget found = targets.Find(w => d.Target.Equals(w.Reference.Target) && 
                    d.Method.MethodHandle.Equals(w.Method.MethodHandle));
                if (found != null)
                {
                    targets.Remove(found);
                }
            }
        }

        public TDelegate Target
        {
            get
            {
                var deadRefs = new List<MethodTarget>();
                Delegate result = null;
                foreach (MethodTarget mt in targets)
                {
                    WeakReference target = mt.Reference;
                    if (target != null && target.IsAlive)
                    {
                        // recreate delegate
                        // delegate 'this' object 
                        object thisObject = mt.Reference.Target;
                        Delegate dlg = Delegate.CreateDelegate(typeof (TDelegate), thisObject, mt.Method);
                        result = Delegate.Combine(result, dlg);
                    }
                    else
                    {
                        deadRefs.Add(mt);
                    }
                }
                foreach (MethodTarget deadRef in deadRefs)
                {
                    targets.Remove(deadRef);
                }
                return result as TDelegate;
            }
            set
            {
                targets.Clear();
                Append(value);
            }
        }
    }

    /// <summary>
    /// Хранит слабую ссылку на объект и информацию о методе, который надо вызвать на этом объекте.
    /// </summary>
    internal class MethodTarget
    {
        private WeakReference reference;
        private MethodInfo methodInfo;

        public MethodTarget(Delegate d)
        {
            reference = new WeakReference(d.Target);
            Method = d.Method;
        }

        public WeakReference Reference
        {
            get
            {
                return reference;
            }
            set
            {
                reference = value;
            }
        }

        public MethodInfo Method
        {
            get
            {
                return methodInfo;
            }
            set
            {
                methodInfo = value;
            }
        }
    }
}
