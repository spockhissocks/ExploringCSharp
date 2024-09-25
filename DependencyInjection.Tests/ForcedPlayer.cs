using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Tests
{
    public class ForcedPlayer : IPlayer
    {
        private Choice _choice;

        public ForcedPlayer(Choice choice) 
        {
            _choice = choice;
        }
        public Choice GetChoice()
        {
            return _choice;
        }
    }
}
