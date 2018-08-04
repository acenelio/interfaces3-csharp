using System;

namespace Course.Devices {
    class Printer : Device, IPrinter {

        public override void ProcessDoc(string document) {
            Console.WriteLine("Printer processing: " + document);
        }

        public void Print(string document) {
            Console.WriteLine("Printer print " + document);
        }
    }
}
