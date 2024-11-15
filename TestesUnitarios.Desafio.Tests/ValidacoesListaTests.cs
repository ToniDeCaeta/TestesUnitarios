using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista(); // instancia a Classe a ser testada

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 }; //preparamos o cenario para os testes
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);  //a instancia, puxa o metodo e aplica na noss lista

        // Assert
        Assert.Equal(resultadoEsperado, resultado); //Metodo Assert retorna  comparação dos 2 parametros. 
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 }; //criou a lista e determinou o cenario.
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar); //puxou o metodo e passou  lista e o numero desejado como parametro

        // Assert
        Assert.True(resultado); //retorna um Bool, se a comparação for verdadeira. 
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 }; //criou a lista e definiu o cenario de teste 
        var numeroParaProcurar = 10;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.False(resultado);  //Assert, é o resultado esperado, nesse caso um false. 
    }

    //TODO: Corrigir a anotação [Fact]
    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        
        // Act
        var resultado = _validacoes.MultiplicarNumerosLista(lista, 2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado); //o resultado, deve ser = ao resultadoEsperado. 
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(9, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(-8, resultado);
    }
}
