namespace CSharp
{
    class ItalianChef : Chef // inheritance
    {
        public void make_pasta()
        {
            Console.WriteLine("The chef makes pasta");
        }
        public override void make_special_dish() //bisa di timpa / override
        {
            Console.WriteLine("The chef makes chicken parm");
        }
    }
}