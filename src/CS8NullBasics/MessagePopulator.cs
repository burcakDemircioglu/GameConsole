using System;
using System.Reflection;

namespace CS8NullBasics
{
    class MessagePopulator
    {
        public static void Populate(Message message)
        {
            message.GetType().InvokeMember("From",
            BindingFlags.Instance
            | BindingFlags.Public
            | BindingFlags.SetProperty,
            Type.DefaultBinder, message, new[]{"Burcak {set using reflection}"});
        }
    }
}
