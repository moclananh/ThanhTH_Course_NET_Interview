using System;


namespace _2.TodoAppConsole
{
    public class Tasks
    {
        public string Id { get; set; }
        public string TaskName {  get; set; }
        public string TaskDescription { get; set; }
        public int Priority { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {TaskName}, Description: {TaskDescription}, Priority: {Priority}";
        }
    }
}
