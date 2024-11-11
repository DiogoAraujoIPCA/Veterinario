using System.Data;

public  partial class Animal
{

    #region Atributos
    private int NumeroChip = 0 ;

    public string NomeAnimal;

    private Raça NomeRaca;

    private Pessoa Responsavel;

    private List<string> ListaDoencas;
   

    #endregion


    #region  Construtor
     public Animal(int _NumeroChip, string _Nome, Raça _NomeRaca = null, Pessoa _Responsavel = null)
    {
        NumeroChip = _NumeroChip;
        NomeAnimal = _Nome;
        NomeRaca = _NomeRaca;  // Pode ser null
        Responsavel = _Responsavel;  // Pode ser null
      
    }
    #endregion

  
   




   
}