using System;

namespace ConsoleNet
{
    internal class Person
    {
        public string Name { get; internal set; }
        public string SurName { get; internal set; }
        public string Message { get; internal set; }
        public DateTime BirthDate { get; internal set; }
        public int ID { get; internal set; }
    }
}