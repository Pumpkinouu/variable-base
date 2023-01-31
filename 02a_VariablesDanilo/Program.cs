namespace _02a_VariablesDanilo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "les Variables en c#";
            //Commamnde pour le titre de la console5

            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║Introduction aux variables et typage dans c#║");
            Console.WriteLine("╚════════════════════════════════════════════╝");


            
            Console.Write("Merci de me donner un nombre : ");
            string Nombre = Console.ReadLine();
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("Vous avez choisi : {0}",Nombre);
            Console.ReadLine();
            
        }
    }
}