using System;

namespace Library
{
    public static class LibraryClass
    {
        public static string Foo(string username)
        {
            return DateTime.Now.ToString() + $"Hello, {username}";
        }
    }
}
