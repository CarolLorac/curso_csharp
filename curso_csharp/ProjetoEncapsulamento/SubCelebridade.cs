namespace ProjetoEncapsulamento
{
    public class SubCelebridade
    {
        //Todo mundo
        public string InfoPublica = "Notícia";

        //Mesmo projeto
        internal ulong Telefone = 5519988776652;

        //Mesmo projeto ou herança
        protected internal string JeitoFalar = "Sotaque";

        //Herança
        protected string CorOlho = "Azul";

        //Herança apenas dentro do próprio projeto ou mesma classe
        protected private string SegredoFamilia = "Segredo da família";

        //Mesma classe
        private bool UsaPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SUBCELEBRIDADE");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(Telefone);
            Console.WriteLine(JeitoFalar);
            Console.WriteLine(CorOlho);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaPhotoshop);
        }
    }
}