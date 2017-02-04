using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RoliTheCoder
{
    public class Event
    {
        public string Name { get; set; }
        public List<string> Participants { get; set; }
    }
    public class RoliTheCoder
    {
        public static void Main()
        {
            Dictionary<int, Event> IDsWithEvents = new Dictionary<int, Event>();

            Regex IDwithEventName = new Regex(@"[0-9]+ #\w+");
            Regex participantsRegex = new Regex(@"@\S+");

            string input = Console.ReadLine();

            while (!input.Equals("Time for Code"))
            {
                Match IDwithEvent = IDwithEventName.Match(input);

                if (IDwithEvent.Success)
                {
                    string[] idWithEventNameArr = IDwithEvent.ToString().Split(new char[] { ' ', '#' }, StringSplitOptions.RemoveEmptyEntries);
                    int currentEventID = int.Parse(idWithEventNameArr[0]);
                    string currentEventName = idWithEventNameArr[1];
                    MatchCollection participantsMatches = participantsRegex.Matches(input);
                    List<string> participants = participantsMatches.Cast<Match>().Select(m => m.Value).ToList();

                    if (IDsWithEvents.ContainsKey(currentEventID))
                    {
                        if (IDsWithEvents[currentEventID].Name.Equals(currentEventName))
                        {
                            IDsWithEvents[currentEventID].Participants.AddRange(participants);
                        }
                        else
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                    }
                    else
                    {
                        Event currentEvent = new Event();
                        currentEvent.Name = currentEventName;
                        currentEvent.Participants = participants;

                        IDsWithEvents.Add(currentEventID, currentEvent);
                    }
                }

                input = Console.ReadLine();
            }

            // If there are two or more participants with the same name for event we must distinct them:
            foreach (Event eventEntry in IDsWithEvents.Values)
            {
                List<string> distinctParticipants = eventEntry.Participants.Distinct().ToList();
                eventEntry.Participants = distinctParticipants;
            }

            foreach (KeyValuePair<int, Event> eventEntry in IDsWithEvents.OrderByDescending(e => e.Value.Participants.Count).ThenBy(e => e.Value.Name))
            {
                Console.WriteLine($"{eventEntry.Value.Name} - {eventEntry.Value.Participants.Count()}");

                foreach (string participant in eventEntry.Value.Participants.OrderBy(p => p))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
