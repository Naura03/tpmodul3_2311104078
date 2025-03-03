using System;

class DoorMachine
{
    public enum State { Terkunci, Terbuka }

    private State currentState;

    public DoorMachine()
    {
        currentState = State.Terkunci;
    }

    public void BukaPintu()
    {
        if (currentState == State.Terkunci)
        {
            currentState = State.Terbuka;
            Console.WriteLine("Pintu terbuka");
        }
    }

    public void KunciPintu()
    {
        if (currentState == State.Terbuka)
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
    }
}
