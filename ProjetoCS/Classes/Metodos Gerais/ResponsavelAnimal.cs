public class Responsavel {

    public void CriarResponsavel(Pessoa pessoa, Animal animal){
        pessoa.AdicionarAnimal(animal);
        animal.AtualizarResponsavel(pessoa);
    }
}