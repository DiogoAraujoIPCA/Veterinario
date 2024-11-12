public partial class Animal{
     #region Metodos para retorna de Dados

    public void  RetornarNomeAnimal()
    {
        Auxliar.EspacoEntreOperacoes(1);
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
        Auxliar.EspacoEntreOperacoes(1);
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
        Auxliar.EspacoEntreOperacoes(1);
         Console.WriteLine("Identificar Raca:");
        if (NomeRaca != null && NomeRaca.RetornarNomeRaca() != "Sem Raca Definida")
        {
             NomeRaca.RetornarNomeRacaUtilizador()   ;
            
        }
        else
        {
           Console.WriteLine("Sem Raca Atribuda") ;
        }
       
    }

    public void  RetornarResponsavel()
    {   
        Auxliar.EspacoEntreOperacoes(1);
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
        Auxliar.EspacoEntreOperacoes(2);
        Auxliar.IdentificacaoOperacao("Identificar todas informações animal:");
        RetornarNomeAnimal();
        RetornarNumeroChip();
        RetornarRaca();
        RetornarResponsavel();
          
    }
    #endregion

}