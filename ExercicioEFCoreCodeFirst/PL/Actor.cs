using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEFCoreCodeFirst.PL
{
    public class Actor
    {
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
        public object ActorId { get; internal set; }
    }
}
