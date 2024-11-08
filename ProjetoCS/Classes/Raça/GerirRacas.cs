public partial class Raça{
     #region GerirRaças
    public void AdicionarRaça(Raça _Raca)
    {
        Raca.Add(_Raca);

    }

    public void ListarRaças()
    {
        if (Raca.Count == 0)
        {
            Console.WriteLine("Nenhuma Raça associado.");
        }
        else
        {
            foreach (var tipoRaca in Raca)
            {
               // tipoRaca.RetornarNomeAnimal();
            }
        }
    }
    #endregion
}