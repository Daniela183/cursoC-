
using Exercicio02;

Console.WriteLine("Exercício 02\n");
Console.WriteLine("Crie um programa para gerenciar um álbum de fotos usando os coceitos da programação orientada a objetos. Para começar, crie uma classe " +
    "chamada LivroFotos com um atributo privado numPaginas do tipo int. Defina também um método público GetNumeroPaginas que retornará o número de páginas " +
    "do álbum de fotos O construtor padrão deverá criar um álbum com 16 páginas a classe deve possuir um construtor adicional, com o qual podemos especificar o número de páginas que queremos " +
    "no álbum. Crie também uma classe SuperLivroFotos cujo construtor criará um álbum com 64 páginas. Por fim, execute as seguintes ações:" +
    "\n- Criar um álbum de fotos padrão e exibir o número de páginas \n- Criar um álbum de fotos com 24 páginas e exibir o número de páginas " +
    "\n- Criar um álbum de fotos grande e exibir o número de páginas.\n");

LivroFotos meuAlbum1 = new LivroFotos();
Console.Write("Criando um Livro de fotos com ");
Console.Write(meuAlbum1.GetNumeroPaginas());

Console.Write(" páginas.\n");
LivroFotos meuAlbum2 = new LivroFotos(24);

Console.Write("Criando um Livro de fotos com ");
Console.Write(meuAlbum2.GetNumeroPaginas());

Console.Write(" páginas.\n");
SuperLivroFotos meuSuperAlbum1 = new SuperLivroFotos();

Console.Write("Criando um Livro de fotos com ");
Console.Write(meuSuperAlbum1.GetNumeroPaginas());


Console.Write(" páginas.\n");
Console.ReadLine();