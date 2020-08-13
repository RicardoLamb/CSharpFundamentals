using System;

namespace Delegates
{
    class SimpleDelegateUse
    {
        static void Main(string[] args)
        {
            Person jon = new Person("Jon");
            Person tom = new Person("Tom");
            StringProcessor jonsVoice, tomsVoice, background;

            jonsVoice = new StringProcessor(jon.Say);
            tomsVoice = new StringProcessor(tom.Say);
            background = new StringProcessor(Background.Note);

            jonsVoice("Hello, son.");
            tomsVoice.Invoke("Hello, Daddy!");
            background("An airplane flies past.");

        }
    }
}
