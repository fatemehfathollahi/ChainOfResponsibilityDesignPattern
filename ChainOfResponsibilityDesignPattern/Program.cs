using System;

namespace ChainOfResponsibilityDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var question = new ContextObject() { Question = "who is on edited in your team?" };
            TeamThree teamThree = new TeamThree(null, question);
            TeamTwo teamTwo = new TeamTwo(teamThree, question);
            TeamOne teamOne = new TeamOne(teamTwo, question);
            teamOne.HandleRequest();
            Console.ReadKey();
        }
    }
}
