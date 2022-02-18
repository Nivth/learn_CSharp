using System;

namespace CSharp// <-class. namespace harus sama sama yang di Program.cs
{
    class Chef
    {
        public void make_chicken()
        {
            Console.WriteLine("The chef makes chicken");
        }
        public void make_salad()
        {
            Console.WriteLine("The chef makes salad");
        }
        public virtual void make_special_dish() //virtual itu bisa di ubah
        {
            Console.WriteLine("The chef makes bbq ribs");
        }
    }
}
