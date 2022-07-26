using System;

namespace Members_Finalizers_Destructors {
    internal class Program {
        static void Main(string[] args) {

            Members member1 = new Members();

            // true we are a friend so it will show salary
            // it will call the sharingprivateinfo method
            // you have to call a privat method from inside a public method in order to call
            // them from outside the class
            // so you would set a condition (like isfriend) that you would want to trigger
            // the calling of that private method (if you needed to for some reason)
            member1.Introducing(true);
            
        }
    }
}
