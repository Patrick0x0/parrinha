public class Reptil : Animal
{
    public Reptil(string nome, int idade) : base(nome, idade) { }

    public override string EmitirSom()
    {
        return "ssssssss";
    }
}

public class cobra : Reptil
{
    public double Comprimento { get; set; }
    public cobra(string nome, int idade, double comprimento) : base(nome, idade)
    {
        Comprimento = comprimento;
    }
    public override string EmitirSom()
    {
        return "ssssssss";
    }
}