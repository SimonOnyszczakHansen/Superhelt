namespace Superhelt
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public class superhelt
        {
            //Det her er vores variabler hvor vi definere hvilke kendetegn vores superhelt skal have
            private string _ability;
            private string _anonymity;
            private string _costume;
            private string _archNemesis;
            private string _weakness;
            private string _name;

            //Her indkapsler vi vores variabler
            public string Ability 
            {
                get => _ability; 
                set => _ability = value;
            }
            public string Anonymity 
            {
                get => _anonymity;
                set => _anonymity = value;
            }
            public string Costume 
            {
                get => _costume;
                set => _costume = value;
            }
            public string ArchNemesis 
            {
                get => _archNemesis;
                set => _archNemesis = value;
            }
            public string Weakness 
            {
                get => _weakness;
                set => _weakness = value;
            }
            public string Name 
            {
                get => _name;
                set => _name = value;
            }
            
            //Her laver vi vores metoder hvor vi skriver hvad helten kan gøre
            public void powers()
            {
                Console.WriteLine("uses powers");
            }
            public void stop()
            {
                Console.WriteLine("Stops using powers");
            }
            public void control()
            {
                Console.WriteLine("Controls where and when to use powers");
            }

        }
           
    }
}