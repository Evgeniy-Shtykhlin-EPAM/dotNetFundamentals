using System;

namespace StandartLibrary
{
    public static class LibraryClass
    {
        public static string AddDateTimeNowToPhrase(string username)
        {
            return DateTime.Now.ToString() + $" Hello, {username}";
        }
    }
}
