using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL4_103022400020
{
    public class DoorMachine
    {
        public enum State { Terkunci, Terbuka }
        public enum Trigger { KunciPintu, BukaPintu }

        public State currentState = State.Terkunci;

        public void AktivasiTrigger(Trigger trigger)
        {
            if (currentState == State.Terkunci && trigger == Trigger.BukaPintu)
            {
                currentState = State.Terbuka;
                Console.WriteLine("Pintu terbuka");
            }
            else if (currentState == State.Terbuka && trigger == Trigger.BukaPintu)
            {
                currentState = State.Terkunci;
                Console.WriteLine("Pintu tebuka");
            }
            else if (currentState == State.Terbuka && trigger == Trigger.KunciPintu)
            {
                currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
            else if (currentState == State.Terkunci && trigger == Trigger.KunciPintu)
            {
                currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
        }
    }
}
