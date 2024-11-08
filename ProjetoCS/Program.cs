// See https://aka.ms/new-console-template for more information

//1. Para cada animal ser adimitir o cao deve ter Nome ,Raça se existir e um identificador unico

Raça raca = new Raça("Bulldog","Nada");
Animal Teste = new Animal(1111111,"Arroz",raca,null);
Animal Teste1 = new Animal(1111112,"Jordan",null,null);

Teste.RetornarTodasInformações();   
Validacoes.EspacoEntreOperacoes(1);

Teste1.RetornarTodasInformações();
Validacoes.EspacoEntreOperacoes(1);


// 2.Para cada Dono quer armazenar o nome , morada , nº telemovel e deve existir um identificador unico 

Pessoa Andre= new Pessoa("Andre","Rua das Larangeiras",912032832);
Pessoa João= new Pessoa("João","Rua das Crocodilos",912032131);
Andre.RetornarTodasInformacoes();
Validacoes.EspacoEntreOperacoes(1);


//3. Um animal pode nao ter dono 

Animal Teste3 = new Animal(1111111,"Barriguinhas",raca,null); // Sem dono
Animal Teste4 = new Animal(1111112,"Foguete",raca,Andre);

Teste3.RetornarTodasInformações();
Validacoes.EspacoEntreOperacoes(2);

Teste4.RetornarTodasInformações();
Validacoes.EspacoEntreOperacoes(2);

//4. Deve ser possivel adicionar informações sobre uma raça especifica mesmo que não haja um animal com a raça
Raça raca1 = new Raça("Pincha",null);

//Adicionar retornar dados
raca1.AtualizarInformacoesRaca("Teste");



//5)Cada Consulta deve ter um Responsavel Clinico , todas as consultas devem ter um veterinario associado

Veterinario Veterinario1= new Veterinario(1,João);
Consulta consulta1=new Consulta( Convert.ToDateTime("08/11/2024"),Convert.ToDateTime("09/11/2024"),Andre,Teste3,Veterinario1);

//6)Para cada vetirinário , quer armazenar : o seu nome , morada , telemovel e identificador unico 
Veterinario1.RetornarTodosDados();


/*7)Durante a consulta podem ser detetadas diversas condições medicas , cada uma delas deve ser identificada por um nome comum e nome especifico .Não podem existir 
condições medicas iguais*/

//8)Devem ser armazenadas as condições medicas mais comuns de cada raça


