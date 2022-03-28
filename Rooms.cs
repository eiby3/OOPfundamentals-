using System;
namespace fundamentosOrientacaoOBJ
{
    public class Rooms
    {
        public Rooms(int seats)
        {
            Seats = seats;
            seatsInUse = 0;
        }
        public int Seats { get; set; }
        private int seatsInUse = 0;

        public void Reserve()
        {
            seatsInUse++;
            if (seatsInUse > Seats)
            {
                OnRoomSoldOut(EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Assento reservado");
            }
        }
        //Events
        public event EventHandler RoomSoldOutEvent;
        protected virtual void OnRoomSoldOut(EventArgs e)
        {
            EventHandler handler = RoomSoldOutEvent;
            handler?.Invoke(this, e);
        }
    }
}