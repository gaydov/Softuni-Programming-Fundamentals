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

    public class Launcher
    {
        public static void Main()
        {
            Dictionary<int, Event> idsWithEvents = new Dictionary<int, Event>();

            Regex idWithEventName = new Regex(@"[0-9]+ #\w+");
            Regex participantsRegex = new Regex(@"@\S+");

            string input = Console.ReadLine();

            while (!input.Equals("Time for Code"))
            {
                Match idWithEvent = idWithEventName.Match(input);

                if (idWithEvent.Success)
                {
                    string[] idWithEventNameArr = idWithEvent.ToString().Split(new char[] { ' ', '#' }, StringSplitOptions.RemoveEmptyEntries);
                    int currentEventID = int.Parse(idWithEventNameArr[0]);
                    string currentEventName = idWithEventNameArr[1];
                    MatchCollection participantsMatches = participantsRegex.Matches(input);
                    List<string> participants = participantsMatches.Cast<Match>().Select(m => m.Value).ToList();

                    if (idsWithEvents.ContainsKey(currentEventID))
                    {
                        if (idsWithEvents[currentEventID].Name.Equals(currentEventName))
                        {
                            idsWithEvents[currentEventID].Participants.AddRange(participants);
                        }
                        else
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                    }
                    else
                    {
                        Event currentEvent = new Event
                        {
                            Name = currentEventName,
                            Participants = participants
                        };

                        idsWithEvents.Add(currentEventID, currentEvent);
                    }
                }

                input = Console.ReadLine();
            }

            // If there are two or more participants with the same name for event we must distinct them:
            foreach (Event eventEntry in idsWithEvents.Values)
            {
                List<string> distinctParticipants = eventEntry.Participants.Distinct().ToList();
                eventEntry.Participants = distinctParticipants;
            }

            foreach (KeyValuePair<int, Event> eventEntry in idsWithEvents.OrderByDescending(e => e.Value.Participants.Count).ThenBy(e => e.Value.Name))
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
