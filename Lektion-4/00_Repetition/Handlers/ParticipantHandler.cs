using _00_Repetition.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition.Helpers
{
    internal class ParticipantHandler
    {
        private static List<Participant> participantList = new List<Participant>();



        public static void AddParticipantToList(Participant participant)
        {
            participantList.Add(participant);
            
        }

        public static void RemoveParticipantFromList(string id)
        {
            var _id = Guid.Parse(id);

            participantList = participantList.Where(x => x.Id != _id).ToList();
            Console.WriteLine($"Particpant {participant.FullName} was removed from the participant list");                                                                             
        }
    }
}
