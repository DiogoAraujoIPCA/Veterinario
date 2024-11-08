public   partial class   Pessoa
{
    
   
     public void AdicionarAnimal(Animal animal)
    {
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