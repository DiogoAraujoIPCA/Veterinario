public partial class Animal{
     #region Metodos para retorna de Dados

    public void  RetornarNomeAnimal()
    {
        Validacoes.EspacoEntreOperacoes(1);
        Console.WriteLine("Identificar Nome Animal:");
        if (NomeAnimal == null)
        {
            Console.WriteLine( "Nome Animal não atribudo");
        }
        else
        {
            Console.WriteLine( NomeAnimal );
        }

    }

    public void RetornarNumeroChip()
    {
        Validacoes.EspacoEntreOperacoes(1);
         Console.WriteLine("Identificar Numero Chip:");
        if (NumeroChip == 0 )
        {
            Console.WriteLine( "Sem Chip atribuido");
        }
        else
        {
             Console.WriteLine( NumeroChip );
        }
         

    }

    public void RetornarRaca()
    {
        Validacoes.EspacoEntreOperacoes(1);
         Console.WriteLine("Identificar Raça:");
        if (NomeRaca != null && NomeRaca.RetornarNomeRaca() != "Sem Raça Definida")
        {
             NomeRaca.RetornarNomeRacaUtilizador()   ;
            
        }
        else
        {
           Console.WriteLine("Sem Raça Atribuda") ;
        }
       
    }

    public void  RetornarResponsavel()
    {   
        Validacoes.EspacoEntreOperacoes(1);
        Console.WriteLine("Identificar Resposanvel:");
        if (Responsavel == null)
        {
            Console.WriteLine("Responsavel não atribuido") ;
        }
        else
        {
            Console.WriteLine( Responsavel ) ;
        }
   
    }

    public void RetornarTodasInformações()
    {
        Validacoes.IdentificacaoOperacao("Identificar todas informações animal:");
        RetornarNomeAnimal();
        RetornarNumeroChip();
        RetornarRaca();
        RetornarResponsavel();
          
    }
    #endregion

}