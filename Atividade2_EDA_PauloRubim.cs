using System;
using System.Diagnostics;

namespace Atividade1
{
	public class EDA1
	{
		public static void Main()
		{
			int[] vetor1 = new int[1000];/*...........................................................O(1)...........*/
			int[] vetor2 = new int[5000];/*...........................................................O(1)...........*/
			Random x = new Random();/*...........................................................O(1)...........*/
			Stopwatch stopwatch = new Stopwatch();/*...........................................................O(1)...........*/
			var r = System.Diagnostics.Stopwatch.StartNew();/*...........................................................O(1)...........*/
			
			
			// -----1000
			stopwatch.Start();/*...........................................................O(1)...........*/
			for (int i = 0; i < vetor1.Length; i++)/*.....................O(n-1)+O(n)....*/
			{
				vetor1[i] = x.Next(1, 1000);
			}

			bubbleSort(vetor1, vetor1.Length);
			Console.WriteLine("\n\nVetor Ordenado pelo bubbleSort para 1000 valores\n");/*...............O(1)...........*/
			for (int i = 0; i < vetor1.Length; i++)/*.....................O(n-1)+O(n)....*/
			{
				Console.Write("{0} ", vetor1[i]);/*....................O(n)......*/
			}

			r.Stop();/*....................O(n)......*/
			Console.WriteLine("\n\nTempo Decorrido do bubbleSort: {0}", r.Elapsed);/*....................O(n)......*/
			if (!r.IsRunning)
				r.Restart();/*....................O(n)......*/
			insertionSort(vetor1, vetor1.Length);
			Console.WriteLine("\n\nVetor Ordenado pelo insertionSort para 1000 valores\n");
			for (int i = 0; i < vetor1.Length; i++) /*.....................O(n-1)+O(n)....*/
			{
				Console.Write("{0} ", vetor1[i]);/*....................O(n)......*/
			}

			r.Stop();/*....................O(n)......*/
			Console.WriteLine("\n\nTempo Decorrido do insertionSort: {0}", r.Elapsed);/*....................O(n)......*/
			if (!r.IsRunning)
				r.Restart();
			selectionSort(vetor1, vetor1.Length);/*.....................O(n-1)+O(n)....*/
			Console.WriteLine("\n\nVetor Ordenado pelo selectionSort para 1000 valores\n");/*....................O(n)......*/
			for (int i = 0; i < vetor1.Length; i++)/*....................O(n)......*/
			{
				Console.Write("{0} ", vetor1[i]);/*....................O(n)......*/
			}

			r.Stop();/*....................O(1)......*/
			Console.WriteLine("\n\nTempo Decorrido do selectionSort: {0}", r.Elapsed);/*....................O(n)......*/
			if (!r.IsRunning)
				r.Restart();/*....................O(1)......*/
			quickSort(vetor1);
			Console.WriteLine("\n\nVetor Ordenado pelo quickSort para 1000 valores\n");/*....................O(n)......*/
			for (int i = 0; i < vetor1.Length; i++)/*.....................O(n-1)+O(n)....*/
			{
				Console.Write("{0} ", vetor1[i]);/*....................O(n)......*/
			}

			r.Stop();/*....................O(1)......*/
			Console.WriteLine("\n\nTempo Decorrido do quickSort: {0}", r.Elapsed);
			if (!r.IsRunning)
				r.Restart();/*....................O(1)......*/
			//5000
			for (int i = 0; i < vetor2.Length; i++)/*.....................O(n-1)+O(n)....*/
			{
				vetor2[i] = x.Next(1, 5000);
			}

			bubbleSort(vetor2, vetor2.Length);
			Console.WriteLine("\n\nVetor Ordenado pelo bubbleSort para 5000 valores\n");/*....................O(n)......*/
			for (int i = 0; i < vetor2.Length; i++)/*.....................O(n-1)+O(n)....*/
			{
				Console.Write("{0} ", vetor2[i]);/*....................O(n)......*/
			}

			r.Stop();/*...................................................................O(1)...........*/
			Console.WriteLine("\n\nTempo Decorrido do bubbleSort: {0}", r.Elapsed);/*....................O(n)......*/
			if (!r.IsRunning)
				r.Restart();/*...................................................................O(1)...........*/
			insertionSort(vetor2, vetor2.Length);
			Console.WriteLine("\n\nVetor Ordenado pelo insertionSort para 5000 valores\n");/*....................O(n)......*/
			for (int i = 0; i < vetor2.Length; i++)/*.....................O(n-1)+O(n)....*/
			{
				Console.Write("{0} ", vetor2[i]);/*....................O(n)......*/
			}

			r.Stop();
			Console.WriteLine("\n\nTempo Decorrido do insertionSort: {0}", r.Elapsed);
			if (!r.IsRunning)
				r.Restart();
			selectionSort(vetor2, vetor2.Length);
			Console.WriteLine("\n\nVetor Ordenado pelo selectionSort para 5000 valores\n");
			for (int i = 0; i < vetor2.Length; i++)
			{
				Console.Write("{0} ", vetor2[i]);/*....................O(n)......*/
			}

			r.Stop();/*...................................................................O(1)...........*/
			Console.WriteLine("\n\nTempo Decorrido do selectionSort: {0}", r.Elapsed);/*....................O(n)......*/
			if (!r.IsRunning)/*...................................................................O(1)...........*/
				r.Restart();
			quickSort(vetor2);
			Console.WriteLine("\n\nVetor Ordenado pelo quickSort para 5000 valores\n");/*....................O(n)......*/
			for (int i = 0; i < vetor2.Length; i++)/*.....................O(n-1)+O(n)....*/
			{
				Console.Write("{0} ", vetor2[i]);/*....................O(n)......*/
			}

			r.Stop();
			Console.WriteLine("\n\nTempo Decorrido do quickSort: {0}", r.Elapsed);/*....................O(n)......*/
			if (!r.IsRunning)
				r.Restart();
			stopwatch.Stop();
			Console.WriteLine("\n\nO Tempo total Decorrido: {0}", stopwatch.Elapsed);
		}/*....................O(n)......*/

		static void bubbleSort(int[] vetor, int length)/*...................................O(n²)...................*/
		{
			int trocas = 0;
			for (int i = 0; i < length - 1; i++)
			{
				for (int j = 0; j < length - 1; j++)
				{
					if (vetor[j] > vetor[j + 1])
					{
						trocas = vetor[j];
						vetor[j] = vetor[j + 1];
						vetor[j + 1] = trocas;
					}
				}
			}
		}

		static void insertionSort(int[] vetor, int length)/*...................................O(n²)...................*/
		{
			int j, atual = 0;
			for (int i = 0; i < length; i++)
			{
				atual = vetor[i];
				j = i - 1;
				while (j >= 0 && vetor[j] > atual)
				{
					vetor[j + 1] = vetor[j];
					j = j - 1;
				}

				vetor[j + 1] = atual;
			}
		}

		static int[] selectionSort(int[] vetor, int length)/*...................................O(n²)...................*/
		{
			int min, aux;
			for (int i = 0; i < length - 1; i++)
			{
				min = i;
				for (int j = i + 1; j < length; j++)
				{
					if (vetor[j] < vetor[min])
						min = j;
				}

				if (min != i)
				{
					aux = vetor[min];
					vetor[min] = vetor[i];
					vetor[i] = aux;
				}
			}

			return vetor;
		}

		public static int[] quickSort(int[] vetor)
		{
			int inicio = 0;
			int fim = vetor.Length - 1;
			quickSort(vetor, inicio, fim);
			return vetor;
		}

		private static void quickSort(int[] vetor, int inicio, int fim)
		{
			if (inicio < fim)
			{
				int p = vetor[inicio];
				int i = inicio + 1;
				int f = fim;
				while (i <= f)
				{
					if (vetor[i] <= p)
					{
						i++;
					}
					else if (p < vetor[f])
					{
						f--;
					}
					else
					{
						int troca = vetor[i];
						vetor[i] = vetor[f];
						vetor[f] = troca;
						i++;
						f--;
					}
				}

				vetor[inicio] = vetor[f];
				vetor[f] = p;
				quickSort(vetor, inicio, f - 1);
				quickSort(vetor, f + 1, fim);
			}
		}
	}
}

//Equação Encontrada:............O(n²)+0(n-1)+0(n)+O(nlogn)+0(1)

//Tipo:..........................QUADRÁTIC