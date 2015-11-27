using System;

namespace WeakPatterns
{
    public class Foo
    {
        private WeakDelegate<EventHandler> click = new WeakDelegate<EventHandler>(); 

        public event EventHandler Click
        {
            add
            {
                click.Append(value);
            }
            remove
            {
                click.Remove(value);
            }
        }

        public virtual void OnClick(EventArgs e)
        {
            EventHandler target = click.Target;
            if (target != null)
            {
                target.Invoke(this, e);
            }
        }
    }
}
