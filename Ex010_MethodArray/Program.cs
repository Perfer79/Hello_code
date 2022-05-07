/* Найти элемент FIND в массиве ARRAY из N элементов
1. Установим счетчик index в позицию 0
2. Если Array[index] = find, алгоритм завершил работу успешно
3. else Увеличить index на 1
4. Если index < n, то перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно
*/
int[] array = {1,12,31,4,15,16,17,18};

int n = array.Length;
int find = 4; 

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    index = index++;
}