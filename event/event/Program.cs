using System;
public class program

{
    public delegate void nofity();
    public static void bl_ProcessCompleted()
    {
        Console.WriteLine("Process Completed!");
    }
  
    public class logic
    {
        public event nofity processcompleted;

        public void startprocess()
        {
            Console.WriteLine("process started");

            onprocesscomplete();
        }

        public virtual void onprocesscomplete()
        {
            processcompleted?.Invoke();
        }

    }
    public static void Main(string[] srgs)
    {

        logic logic = new logic();
        logic.processcompleted += bl_ProcessCompleted;
        logic.startprocess();

    }
}