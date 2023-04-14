using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2._1
{
    class Program
    {
		static void Main(string[] args)
		{
			{
				Console.WriteLine("Hello World!");
				//q1_q();
				//q1_qq();
				//q1_qqq();
				//w2_w();
				//w2_ww();
				//e3_e();
				r_r();

				Console.ReadKey();
			}
		}
			static void q1_q()
			{
				Console.WriteLine("Задание 1.1");
				int count = 0;
				Random rnd = new Random();
				int b = rnd.Next(1, 30);
				int[] batman = new int[b];
				for (int i = 0; i < b; i++)
				{
					batman[i] = rnd.Next(1, 30);
					Console.Write($"{batman[i]}\t");
				}
				Console.WriteLine();
				for (int i = 0; i < b; i++)
				{
					if (batman[i] % 2 == 0)
					{
						var w = batman[i];
						count = count + 1;
						Console.Write($"{w / 2}\t");
					}
					else
						Console.Write($"-\t");
				}
				Console.WriteLine();
				Console.WriteLine($"Количество измененных элементов = {count}");
			}
			static void q1_qq()
			{
				Console.WriteLine("Задание 1.2");
				int[] A = new int[9] { 4, 2, 3, 6, 5, 1, 9, 7, 4 };
				int[] B = new int[9] { 8, 4, 9, 3, 2, 7, 5, 6, 1 };
				int[] C = new int[9] { 7, 1, 4, 2, 6, 8, 3, 9, 5 };
				int[] D = new int[9];
				for (int i = 0; i < A.Length; i++)
				{
					if (A[i] > B[i] && A[i] > C[i]) D[i] = A[i];
					if (B[i] > A[i] && B[i] > C[i]) D[i] = B[i];
					if (C[i] > B[i] && C[i] > A[i]) D[i] = C[i];
					Console.Write(D[i] + " ");
				}
			}
			static void q1_qqq()
			{
				Console.WriteLine();
				Console.WriteLine("Задание 1.3");
				int[] A = new int[] { 7, 11, 4, 0, 6, 9, 2, 0, 2, 1 };
				Console.WriteLine("7, 11, 4, 0, 6, 9, 2, 0, 2, 1");
				int temp = -1;
				int product = 1;
				int max = -1000;
				for (int i = 0; i < A.Length; i++)
				{
					if (A[i] == 0)
					{
						temp = i;
						Console.WriteLine("Номер первого нулевого элемента: " + temp);
						break;
					}
				}
				if (temp == -1)
				{
					Console.WriteLine("нулевого элемента нет");
				}
				for (int i = 0; i < A.Length; i++)
				{
					if (i < temp)
					{
						product *= A[i];
					}
					if (i > temp)
					{
						if (A[i] > max)
						{
							max = A[i];
						}
					}
				}
				Console.WriteLine("Произведение чисел: " + product);
				Console.WriteLine("Max: " + max);
			}
			static void w2_w()
			{
				Console.WriteLine("Задание 2.1");
				Console.WriteLine("Исходный массив");
				int min = 1000;
				int minIdx = 0;
				int[,] M = new int[4, 4] { { 4, 5, 2, 9 }, { 3, 8, 2, 3 }, { 2, 1, 1, 7 }, { 1, 7, 5, 10 } };
				for (int i = 0; i < 4; i++)
				{
					for (int j = 0; j < 4; j++)
					{
						Console.Write(M[i, j] + "  ");//вывод на консоль двумерный массив
					}
					Console.WriteLine();
				}
				int[] array = new int[4];
				for (int i = 0; i < 4; i++)
				{
					array[i] = M[i, 0]; //первый столбец
				}
				for (int i = 1; i < 4; i++)
				{
					int sum = 0;
					for (int j = 0; j < 4; j++)
					{
						if (M[j, i] % 2 == 0)
						{
							sum += M[j, i];
						}
					}
					if (sum < min)
					{
						min = sum;
						minIdx = i;//поиск мин столбца
					}
				}

				for (int i = 0; i < 4; i++)
				{
					M[i, 0] = M[i, minIdx];
					M[i, minIdx] = array[i]; // замена первого столбца со столбцом, в котором мин сумма четных чисел
				}
				Console.WriteLine("Результат");
				for (int i = 0; i < 4; i++)
				{
					for (int j = 0; j < 4; j++)
					{
						Console.Write(M[i, j] + "  ");//вывод на консоль двумерный массив
					}
					Console.WriteLine();
				}

			}
			static void w2_ww()
			{
				Console.WriteLine("Задание 2.2");
				Console.WriteLine("Исходный массив");
				int[,] M = new int[4, 4] { { 4, 5, 2, 9 }, { 3, 8, 2, 3 }, { 2, 1, 1, 7 }, { 1, 7, 5, 10 } };
				for (int i = 0; i < 4; i++)
				{
					for (int j = 0; j < 4; j++)
					{
						Console.Write(M[i, j] + "  ");//вывод на консоль двумерный массив
					}
					Console.WriteLine();
				}
				for (int i = 0; i < 4; i++)
				{
					for (int j = 0; j < 4; j++)
					{
						if (i % 2 == 1)
						{
							M[i, j] = i - j; //замена элементов нечетных строк таблицы на разность номеров строк и столбцов
						}
					}
				}
				Console.WriteLine("Результат");
				for (int i = 0; i < 4; i++)
				{
					for (int j = 0; j < 4; j++)
					{
						Console.Write(M[i, j] + "  ");//вывод на консоль двумерный массив
					}
					Console.WriteLine();
				}
			}
			static void e3_e()
			{
				Console.WriteLine("Задание 2.3");
				string str1, str2, strs = "Удаленные слова: ";
				bool priznak = false;
				Console.WriteLine("Введите первое предложение:");
				str1 = Console.ReadLine();
				Console.WriteLine("Введите второе предложение:");
				str2 = Console.ReadLine();
				string[] arr1 = str1.Split(' ');
				string[] arr2 = str2.Split(' ');
				for (int i = 0; i < arr1.Length; i++)
				{
					for (int g = 0; g < arr2.Length; g++)
					{
						if (arr2[g].Equals(arr1[i]))
						{
							strs += arr1[i] + " ";
							for (int j = 0; j < arr1.Length; j++)
							{
								if (arr1[j] == (arr2[g]))
									arr1[j] = "";

							}
							arr2[g] = "";
							priznak = true;

						}
					}
					if (priznak == true)
						arr1[i] = "";
					priznak = false;
				}
				Console.WriteLine(strs);
				Console.WriteLine("Первое предложение:  " + string.Join(" ", arr1));
				Console.WriteLine("Второе предожение:  " + string.Join(" ", arr2));
				Console.ReadKey();
			}
			static void r_r()
			{
				var strings = new string[10] {"first", "second", "three", "four", "fife", "six", "seven", "eight", "nine", "ten"};
				while (true)
				{
					Console.WriteLine("Задание 3.2");
					Console.WriteLine("1.Создание строки и добавление её строки в массив на заданную позицию i. " +
						"(с соответствующим сдвигом всех следующих за i элементов массива)");
					Console.WriteLine("2.Вывод всех строк массива на экран.");
					Console.WriteLine("3.Вывод i строки массива на экран.");
					Console.WriteLine("4.Редактирование i строки массива.");
					Console.WriteLine("5.Замена слова в каждой строке массива.");
					Console.WriteLine("6.Удаление строки из массива.");
					Console.WriteLine("7.Выход");
					Console.WriteLine("Вместимость массива - 10");

					var command = Console.ReadLine();
					if (string.IsNullOrEmpty(command))
					{
						Console.WriteLine("Введите номер комманды");
						continue;
					}

					var sb = new StringBuilder();
					var commandNumber = Convert.ToInt16(command);

					if (commandNumber == 1)
					{
						Console.WriteLine("Введите слово");
						var UserText = Console.ReadLine();
						Console.WriteLine("Введите позицию");
						var idx = Convert.ToInt16(Console.ReadLine());
						if (idx > strings.Length || idx < 0)
						{
							Console.WriteLine("Введено неправильное значение");
							continue;
						}
						if (!string.IsNullOrEmpty(UserText))
						{
							for (int i = strings.Length - 2; i >= idx; i--)
							{
								strings[i + 1] = strings[i];
							}
						}
					strings[idx] = UserText;
					}

					if (commandNumber == 2)
					{
						for (var i = 0; i < strings.Length; i++)
						{
							if (!string.IsNullOrEmpty(strings[i]))
								Console.WriteLine($"{i} {strings[i]}");
						}
						continue;
					}

					if (commandNumber == 3)
					{
						Console.WriteLine("Введите позицию");
						var idx = Convert.ToInt16(Console.ReadLine());
						if (idx > strings.Length || idx < 0)
						{
							Console.WriteLine("Введено неправильное значение");
							continue;
						}

						Console.WriteLine($"{idx} {strings[idx]}");
						continue;
					}

					if (commandNumber == 4)
					{
						Console.WriteLine("Введите номер строки");
						var idx = Convert.ToInt16(Console.ReadLine());
						if (idx > strings.Length || idx < 0)
						{
							Console.WriteLine("Введено неправильное значение");
							continue;
						}
						Console.WriteLine(strings[idx]);
						Console.WriteLine("Введите что хотите заменить");
						var txtToInput = Console.ReadLine();
						Console.WriteLine("Введите на что хотите заменить");
						var txtToChange = Console.ReadLine();
						sb.Append(strings[idx]);
						if (txtToInput != null)
							sb.Replace(txtToInput, txtToChange);
						strings[idx] = sb.ToString();
						Console.WriteLine(strings[idx]);
						sb.Clear();
						continue;
					}

					if (commandNumber == 5)
					{
						Console.WriteLine("Введите слово, которое хотите заменить");
						var txtToInput = Console.ReadLine();
						Console.WriteLine("Введите на что хотите заменить");
						var txtToChange = Console.ReadLine();

						for (var i = 0; i < strings.Length; i++)
						{
							sb.Append(strings[i]);
							if (txtToInput != null)
								sb.Replace(txtToInput, txtToChange);
							strings[i] = sb.ToString();
							sb.Clear();
						}
						continue;
					}

					if (commandNumber == 6)
					{
						Console.WriteLine("Введите номер строки");
						var idx = Convert.ToInt16(Console.ReadLine());
						if (idx > strings.Length || idx < 0)
						{
							Console.WriteLine("Введено неправильное значение");
							continue;
						}

						strings[idx] = "";
						Console.WriteLine($"\"{strings[idx]}\" удалено");
						continue;
					}

					if (commandNumber == 7)
						break;
				}

			}
		}
}
