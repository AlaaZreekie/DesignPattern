using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral._ٍState
{
    public class Documente
    {
        public DocumantStates State { get; set; }
        public UserRoles CurrentUserRole { get; set; }

        public void Publish()
        {
            if(State == DocumantStates.Draft) 
                State = DocumantStates.Moderation;
            else if (State == DocumantStates.Moderation)
            {
                if(CurrentUserRole == UserRoles.Admin)
                {
                    State = DocumantStates.Published;
                }
            }
            else if (State == DocumantStates.Published)
            {
                //Do nothing
            }

        }
    }
}
