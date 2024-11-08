public class Pessoa{

    public string Nome;
    public string Morada;
    public string NumeroTelemovel;

    public List<Animal> Animais { get; set; }

    public Pessoa(string _Nome,string _Morada,string _NumeroTelemovel){
        Nome=_Nome;
        Morada=_Morada;
        NumeroTelemovel=_NumeroTelemovel;
        Animais = new List<Animal>();
    }

    public void AdicionarAnimal(Animal animal){
        Animais.Add(animal);
    }
     public void ExibirAnimais()
    {
        Console.WriteLine($"Animais de {Nome}:");
        if (Animais.Count == 0)
        {
            Console.WriteLine("Nenhum animal associado.");
        }
        else
        {
            foreach (var animal in Animais)
            {
                animal.RetornarNomeAnimal();
            }
        }
    }
}
