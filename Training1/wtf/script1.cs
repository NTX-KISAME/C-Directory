using System;
using System.ComponentModel;
using System.Threading;

public class script1
{
    // Private Variable
    private static string words1;
    private static int numbers1;


    public static void getSomeInput(string programName)
    {
        // Get Some Question
        Console.WriteLine(
            $"Hi there!, Welcome to {programName}!\n" + "To Start Please Type Your Name After beep Sounds");
        Thread.Sleep(2000);
        Console.Beep(120, 350);
        // Get Input for First Variable
        words1 = Console.ReadLine();
        // Last Question
        Console.WriteLine("Good!, Now If you hear Second Beep, Please Input Your Lucky Number");
        Thread.Sleep(2000);
        Console.Beep(120, 350);
        // Because Console.ReadLine Return a String even you type A Number
        // We Need to Convert it First before Insert the Data to Variable box
        numbers1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Good!, Let Me See Your Data");
        Thread.Sleep(2000);
        Console.WriteLine($"Is This Correct?\n Name:{words1}\n Lucky Number:{numbers1.ToString()}\n Type Y if Correct or Type N if Wrong");
        string choices = Console.ReadLine();
        
        // Use Switch Insted of If Chain
        switch (choices.ToLower())
        {
            case "y":
                Console.WriteLine("Ok!,Your Data is Now Submited to Server, and The Program Will now Close");
                Thread.Sleep(2000);
                break;
            case "n":
                Console.WriteLine("Starting from the Beginning");
                getSomeInput(programName);
                break;
                
        }
    }
}