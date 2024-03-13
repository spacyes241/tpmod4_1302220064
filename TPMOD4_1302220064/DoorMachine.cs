using System;

public class DoorMachine
{
    private string stateAwal = "Terkunci";

    public void UbahState(string inputState)
    {
        if (inputState == "Terkunci")
        {
            Console.WriteLine("Pintu terkunci");
        }
        else if (inputState == "Terbuka")
        {
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            Console.WriteLine("Perintah tidak valid");
            return;
        }
        stateAwal = inputState;
    }
}

