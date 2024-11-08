public partial class Raça
{

    public string RetornarNomeRaca()
    {
        if (Nome!=null){
            return Nome;
        }else{
            return "Sem Raça Definida";
        }
       
    }

    public void RetornarNomeRacaUtilizador()
    {

        if (Nome != null)
        {
            
            Console.WriteLine(Nome);
        }
        else
        {
            Console.WriteLine("Sem Raça Defifnida");
        }

    }

    public void RetornarInformacoesRaca()
    {

        
        if (Informacoes != null)
        {
              Console.WriteLine("Retornar Informações da Informacoes do animal:");
        Console.WriteLine(Informacoes);
        }
        else
        {
            Console.WriteLine("Sem informações");
        }
     
    }

    public void RetornarListaRaças()
    {
        Console.WriteLine("Retornar Lista de raças existentes:");
        foreach (Raça var in Raca)
        {
            var.RetornarNomeRaca();
        }
    }
}