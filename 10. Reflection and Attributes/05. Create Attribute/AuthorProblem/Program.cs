using System;

namespace AuthorProblem
{
    [Author("Victor")]
    internal class StartUp
    {
        [Author("George")]
        static void Main(string[] args)
        {

        }
    }
    class AuthorAttribute : Attribute
    {
        public AuthorAttribute(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}