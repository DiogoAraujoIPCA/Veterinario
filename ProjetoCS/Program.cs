// See https://aka.ms/new-console-template for more information


Organizacao Org1= new Organizacao("Org1","","@dada",91212121);
# region 1. Para cada animal ser adimitir o cao deve ter Nome ,Raca se existir e um identificador unico


Raca raca = new Raca("Bulldog","Nada");
Animal Teste = new Animal(1111111,"Arroz",raca,null);
Animal Teste1 = new Animal(1111112,"Jordan",null,null);

Teste.RetornarTodasInformações();   


Teste1.RetornarTodasInformações();


#endregion


#region  2.Para cada Dono quer armazenar o nome , morada , nº telemovel e deve existir um identificador unico 

Pessoa Andre= new Pessoa("Andre","Rua das Larangeiras",912032832);
Pessoa João= new Pessoa("João","Rua das Crocodilos",912032131);
Andre.RetornarTodasInformacoes(true);


#endregion


#region 3. Um animal pode nao ter dono 

Animal Teste3 = new Animal(1111111,"Barriguinhas",raca,null); // Sem dono
Animal Teste4 = new Animal(1111112,"Foguete",raca,Andre);

Teste3.RetornarTodasInformações();


Teste4.RetornarTodasInformações();


#endregion


#region 4. Deve ser possivel adicionar informações sobre uma Raca especifica mesmo que não haja um animal com a Raca
Raca raca1 = new Raca("Pincha",null);

//Adicionar retornar dados
raca1.AtualizarInformacoesRaca("Teste");

#endregion

#region 5) Cada Consulta deve ter um Responsavel Clinico , todas as consultas devem ter um veterinario associado

Veterinario Veterinario1= new Veterinario(1,João);
Consulta consulta1=new Consulta("Arroz", Convert.ToDateTime("08/11/2024"),Convert.ToDateTime("09/11/2024"),Andre,Teste3,Veterinario1);

#endregion

#region  6)Para cada vetirinário , quer armazenar : o seu nome , morada , telemovel e identificador unico 
Veterinario1.RetornarTodosDados(false);

#endregion

#region 7)Durante a consulta podem ser detetadas diversas condições medicas, cada uma delas deve ser identificada por um nome comum e nome especifico .Não podem existir condições medicas iguais

Consulta Consulta1= new Consulta("Teste",Convert.ToDateTime("23/12/2024"),Convert.ToDateTime("23/12/2024"),João,Teste3,Veterinario1);
Consulta Consulta2= new Consulta("Teste1",Convert.ToDateTime("23/12/2024"),Convert.ToDateTime("23/12/2024"),João,Teste3,Veterinario1);
Org1.adicionarConsulta(Consulta1);
Org1.adicionarConsulta(Consulta2);

Org1.RetornarListaConsultas();

Diagnostico Diagnostico1 =new Diagnostico("AAAA","BBBB");
Diagnostico Diagnostico2 =new Diagnostico("BBBB","CCCC");

Consulta1.AdicionarDiagnostico(Diagnostico1,raca);
Consulta1.AdicionarDiagnostico(Diagnostico2,raca);

//Consulta1.AdicionarDiagnostico(Diagnostico1,raca); ->Para testar condições iguais

//Consulta1.RetornarTodasInformacoesConsultaUtilizador();



/*
consulta1.ListarTodasCondicoesMedica();
Consulta1.AdicionarCondicaoMedica("Cego e Surdo ");
consulta1.CriarCondicaoMedica();
consulta1.ListarTodasCondicoesMedica();*/


#endregion


#region 8)Devem ser armazenadas as condições medicas mais comuns de cada Raca

//raca.ListarCondicoesComuns();

#endregion




