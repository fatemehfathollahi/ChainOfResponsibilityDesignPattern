using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    public abstract class Handlerbase
    {
        public Handlerbase NextTeam { get; private set; }
        public ContextObject Question { get;  private set; }

        public Handlerbase(Handlerbase nextTeam, ContextObject question)
        {
            NextTeam = nextTeam;
            Question = question; 
        }

        public abstract void HandleRequest();
    }
}
