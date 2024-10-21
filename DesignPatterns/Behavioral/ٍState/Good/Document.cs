using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral._ٍState.Good
{
    public class Document
    {
        public IState State { get; set; }
        public UserRoles CurrentUserRole { get; set; }

        public Document(UserRoles userRoles)
        {
            State = new DraftState(this);
            CurrentUserRole = userRoles;
        }


        public void Publish()
        {
            State.Publish();
        }
    }
}