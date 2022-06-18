//Função intercalaListas recebe 3 parametros de listas tipo int: As duas listas, não apenas de 30 números mas de qualquer tamanho, e a lista que irá receber as duas e intercalar.
void intercalaListas(List<int> lista1, List<int> lista2, List<int> listaIntercalada)
{
    //O For lê um elemento de cads lista e os adiciona intercalando na listaIntercalada
    for(int i = 0; i < lista1.Count; i++){
        listaIntercalada.Add(lista1[i]);
        listaIntercalada.Add(lista2[i]);
}
}

//Teste para ver se está tudo ok;
//Declaro 3 listas de inteiros
List<int> listaI = new List<int>();
List<int> listaII = new List<int>();
List<int> listaIII = new List<int>();

//Adicionando os 30 números nas duas listas que devem estar preenchidas;
listaI.AddRange(new int[]{
    1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53, 55, 57, 59});
listaII.AddRange(new int[]{
    2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60});

//chamando o método criado para intercalar as listas e adicionar em uma terceira;
intercalaListas(listaI, listaII, listaIII);

//printando o conteudo intercalado da terceira lista
foreach (int i in listaIII) {
//    Console.WriteLine(i);
}

//Função que recebe 2 parâmetros, um array do tipo int e um número inteiro. 
void Pesquisar(int[] vet, int n) {
    //Verificando se o array contém o número esperado
    if (vet.Contains(n))
    {
      // Caso tenha, será escrito na tela que tem e em que posição está.
        int x = Array.IndexOf(vet, n);
        Console.WriteLine($"O valor pesquisado foi encontrado na posição {x}");
    }
    //Caso não tenha, será passado em mensagem na tela.
    else { Console.WriteLine("O array não contém o valor pesquisado"); }
}

//-------------Testando para ver se esta tudo ok-----------------
//Declarando o array.
int[] array = new int[] { 9, 7, 2, 16, 4 };

//Chamando a função.
Pesquisar(array, 16);