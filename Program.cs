﻿using Codes;

// FilaCircular fila = new FilaCircular(10);

// if (fila.IsEmpty())
// {
//     System.Console.WriteLine("Fila Vazia!");
// }
// else
// {
//     fila.ShowQueue();
// }
// for (int i = 2; i <= 12; i++)
// {
//     if (!fila.InQueue(i))
//     {
//         System.Console.WriteLine("Neste momento a fila se encontra cheia, \nnão entrará novos itens até que os primeiros itens saiam.\n");
//         break;
//     }
// }
// fila.ShowQueue();

// System.Console.WriteLine(fila.DeQueue());

// System.Console.WriteLine(fila.SearchQueue("Teste"));
// System.Console.WriteLine(fila.InQueue(500));
// fila.ShowQueue();
// System.Console.WriteLine(fila.DeQueue()); System.Console.WriteLine(fila.DeQueue());
// fila.ShowQueue();
// fila.InQueue('A');
// fila.InQueue(DateTime.Now);

// System.Console.WriteLine("\nMostrando a fila final:\n");
// fila.ShowQueue();

//Questão 02 - Calculadora Polonesa

CalculadoraPolonesa calc = new(10);

System.Console.WriteLine("Escreva uma função no estilo polones:");
calc.Insere(Console.ReadLine());

System.Console.WriteLine(calc.RetornaCalc());

// Questão 03 - Embaralhamento

// int[] s1 = { 1, 2, 3, 4, 5 };
// int[] s2 = { 6, 7, 8, 9, 10 };

// Pilha p1 = new(5);
// Pilha p2 = new(5);
// Pilha p3 = new(5);
// PushAll(s1, ref p1);
// PushAll(s2, ref p2);

// System.Console.WriteLine("Pilhas antes de embaralhar:");
// System.Console.WriteLine("Pilha 1:");
// p1.Show();
// System.Console.WriteLine("Pilha 2:");
// p2.Show();
// System.Console.WriteLine();

// for (int i = 0; i < 5; i++)
// {
//     p3.Push(p1.Pop());
// }
// for (int i = 0; i < 5; i++)
// {
//     p1.Push(p2.Pop());
// }

// System.Console.WriteLine("Pilhas depois de embaralhar:");
// p1.Show();
// System.Console.WriteLine();
// p3.Show();
// System.Console.WriteLine();


// static void PushAll(int[] s1, ref Pilha p1)
// {
//     foreach (var item in s1)
//     {
//         p1.Push(item);
//     }
// }
// Criptograma
// string mensagem = "Matheus está doente, e portanto não poderá frequentar as aulas dessa semana.";
// System.Console.WriteLine("Mensagem antes de codificar:\n\n" + mensagem);
// Criptograma cripto = new(mensagem.Split(" ").Length);
// System.Console.WriteLine("\nMensagem depois de codificar:\n\n" + cripto.Codifica(mensagem.Split(" ")));
// string codificada = cripto.Codifica(mensagem.Split(" "));

// System.Console.WriteLine($"\nTamanho da mensagem: {mensagem.Split(" ").Length}, tamanho da mensagem codificada: {codificada.Split(" ").Length}");

// string decodificada = cripto.Decodificar(codificada.Split(" "));

// System.Console.WriteLine("Mensagem decodificada:\n\n" + decodificada);

// Empilhadeira

// Caixa[] caixas = { new Caixa(6), new Caixa(10), new Caixa(14), new Caixa(6), new Caixa(10), new Caixa(14) };
Caixa[] caixas = { new(6), new(6), new(10), new(10), new(14), new(14) }; // entre paremteses temos os pesos

Empilhadeira empi = new Empilhadeira(caixas.Length);

empi.RecebeCaixas(caixas);
empi.MostrarPilhas();
empi.Organizar();
empi.MostrarPilhas();