using System;
using System.Threading;

namespace ChainOfResponsibilityDesignPattern
{
    public class TeamTwo : Handlerbase
    {
        public TeamTwo(Handlerbase nextHandler, ContextObject question) : base(nextHandler, question)
        { }

        public override void HandleRequest()
        {
            Console.WriteLine("Wating for team two to respond");

            Thread.Sleep(10000);

            Console.WriteLine("\t no response from team two.....");
            NextTeam.HandleRequest();
        }
    }
}
