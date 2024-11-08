public class Animal
{

    #region Atributos
    private int NumeroChip;

    public string NomeAnimal;

    private Raça NomeRaca;

    private Pessoa Responsavel;
    #endregion


    #region  Construtor
     public Animal(int _NumeroChip, string _Nome, Raça? _NomeRaca = null, Pessoa? _Responsavel = null)
    {
        NumeroChip = _NumeroChip;
        NomeAnimal = _Nome;
        NomeRaca = _NomeRaca;
        Responsavel = _Responsavel;
    }
    #endregion


    #region Metodos para retorna de Dados

    public void RetornarNomeAnimal()
    {
        Console.WriteLine("Nome do Animal:"+NomeAnimal+".") ;
    }

    public void RetornarNumeroChip()
    {
            Console.WriteLine("Nome do Chip:"+NumeroChip+".") ;
    }

    public void  RetornarRaca()
    {
        if(NomeRaca==null){
            Console.WriteLine("Sem Raça Atribuda") ;
        }else{
            Console.WriteLine("Nome da Raça:"+NomeRaca.Nome+".") ;
          
        }
    }

    public void RetornarResponsavel()
    {
        if(Responsavel==null){
            Console.WriteLine("Responsavel não atribuido") ;
            
        }else{
             Console.WriteLine("Nome:"+Responsavel.Nome+".") ;
           
        }
    }

    public void RetornarTodasInformações(){

    }
    #endregion  


}