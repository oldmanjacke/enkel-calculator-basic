using System;

namespace enkel_räknare
{
    internal class ConsolePrompt
    {
        private object p;

        public ConsolePrompt(object p)
        {
            this.p = p;
        }

        internal object Prompt<T>(object p1, object required, object p2, object p3, Func<object, bool> p4)
        {
            throw new NotImplementedException();
        }
    }
}