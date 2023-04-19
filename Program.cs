class Program
{
    static void Main(string[] args)
    {
        MiniZoo miniZoo = new MiniZoo();

        Leao leao = new Leao("Leão", 2, 2);
        miniZoo.AdicionarAnimal(leao);
        cobra cobra = new cobra("cobra", 2, 2);
        miniZoo.AdicionarAnimal(cobra);
        miniZoo.EmitirSomDeTodosOsAnimais();
        miniZoo.ImprimirTodosOsAnimais();
    }
}
