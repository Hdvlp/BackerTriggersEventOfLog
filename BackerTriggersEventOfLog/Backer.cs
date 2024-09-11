using System;

namespace BackerSystem
{
    public class Backer
    {
        public event EventHandler<EventArgs>? Backed;
        public Backer()
        {
            Console.WriteLine("Constructed Backer.");
        }

        public void BackerRun()
        {
            Console.WriteLine("Progress: Backing... up...");
            OnBackedUp();

        }



        protected virtual void OnBackedUp()
        {
            if (Backed != null)
            {
                Console.WriteLine("Finished backing up");
                Backed(this, EventArgs.Empty);
            }
        }
    }
}