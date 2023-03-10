using LuckySister.Console;
using UpSchool.Domain.Entities;

var selectionManager = new SelectionManager();

selectionManager.AddAttendee("Ayfer Yıldırım");
selectionManager.AddAttendee("Aybike Boran");
selectionManager.AddAttendee("Öznur Fidan");
selectionManager.AddAttendee("Merve Albayrak");
selectionManager.AddAttendee("Dilara Demirhan");

int luckyCount = 3;

selectionManager.MakeSelection(luckyCount);

var lukiestOnes = selectionManager.GetTheLuckyOnes();

lukiestOnes.ForEach(x => Console.WriteLine(x.FullName));

Console.ReadLine();































/*
List<Attendee> attendees = new List<Attendee>();
SelectionManager selection = new SelectionManager(attendees);
selection.AddAttendee("Mustafa Aslantaş");

 */



/*
var attendee = new Attendee()
{
    Id = Guid.NewGuid(),
    FullName = "Şeyma Aslantaş",
    CreatedOn = DateTime.Now,
};
selection.AddAttendee(attendee);
selection.AddAttendee(attendee);
selection.AddAttendee(attendee);
selection.AddAttendee(attendee);
selection.AddAttendee(attendee);
selection.AddAttendee(attendee);
selection.AddAttendee(attendee);
selection.AddAttendee(attendee);

var Count = selection.GetAttendeesCount();
*/
