public partial class Veterinario {

   protected  int ID_Veterinario;
    
   protected Pessoa _Pessoa;

public Veterinario (int id , Pessoa _PessoaParam){
    ID_Veterinario=id;
    _Pessoa=_PessoaParam;
}

public void RetornarTodosDados(){
    Console.Write("ID Vet:"+ID_Veterinario+"");
    _Pessoa.RetornarTodasInformacoes();
}
}

