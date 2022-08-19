
namespace curso_csharp.OrientacaoObjetos
{
    public abstract class Celular
    {
        public abstract string Assistente();

        public virtual string Tocar()
        {
            return "Plim plim!!";
        }
    }

    class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Olá, sou a Bixby";
        }

        public override string Tocar()
        {
            return "Alo alo";
        }
    }

    class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Oii, sou a Siri";
        }
    }

    class ClasseAbstrata
    {
        public static void Executar()
        {
            List<Celular> celulares = new List<Celular>
            {
                new Samsung(),
                new Iphone()           
            };

            foreach(var celular in celulares)
            {
                Console.WriteLine($"Assistente {celular.GetType().Name}: {celular.Assistente()}  {celular.Tocar()}");
            }
        }
    }
}
