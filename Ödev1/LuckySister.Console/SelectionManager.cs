using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool.Domain.Entities;

namespace LuckySister.Console
{
    public class SelectionManager
    {
        private List<Attendee> Attendees { get; set;}

        // LuckAttendees = SelectedAttendees
        private List<Attendee> SelectedAttendees { get; set;}
        private Random _random;

        public SelectionManager(List<Attendee> initialAttendees)
        { 
            
                Attendees = new List<Attendee>();  
                Attendees.AddRange(initialAttendees);   
                SelectedAttendees= new List<Attendee>();      
                 
            
        }
        public SelectionManager()
        {
            Attendees = new List<Attendee>();
            SelectedAttendees = new List<Attendee>();
            _random = new Random();
        }


        /*public SelectionManager()
        {
            Attendees = new List<Attendee>();
        }
        //Contructor
        */

        public void MakeSelection(int luckyCount)
        {
            if(luckyCount > Attendees.Count)
            {
                throw new Exception("LuckCount connat be more than the attendees count");
            }
            for (int i = 0; i < luckyCount; i++)
            {
                SelectedAttendees.Add(GetRandomAttendee());
            }
        }

        public List<Attendee> GetTheLuckyOnes()
        {
            return SelectedAttendees;
        }

        private Attendee GetRandomAttendee()
        {
            var randomIndex = _random.Next(Attendees.Count);//elimdeki listenin sayısı kadar sayı üret
            var attendee = Attendees[randomIndex];
            /*if (SelectedAttendees.Any(x => x.Id == attendee.Id))
            {
                return GetRandomAttendee(); 
            }
            else
            {
                return attendee;
            }*/

            return SelectedAttendees.Any(x=>x.Id == attendee.Id) ? GetRandomAttendee() : attendee;    
        } 

        public void AddAttendee(Attendee attendee)
        {
            Attendees.Add(attendee);
            System.Console.WriteLine("Yeni bir katılımcı ekledi");
        }

        public void AddAttendee(string FullName)
        {
            Attendee attendee= new Attendee() 
            {
                Id= Guid.NewGuid(), 
                FullName= FullName,
                CreatedOn= DateTime.Now,
            };  
            Attendees.Add(attendee);
            System.Console.WriteLine("Yeni bir katılımcı ekledi");
        }

        public int GetAttendeesCount()
        {
            return Attendees.Count; 
        }
    }
}
