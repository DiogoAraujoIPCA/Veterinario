// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Pessoa Andre= new Pessoa("Andre","Rua das Larangeiras","912032832");

Animal Teste = new Animal(1111111,"Arroz",null,null);
Animal Teste1 = new Animal(1111112,"Arroz2",null,null);

Andre.AdicionarAnimal(Teste);
Andre.AdicionarAnimal(Teste1);
Andre.ExibirAnimais();
Teste.RetornarNomeAnimal();
Teste.RetornarRaca();