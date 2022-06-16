# Итоговая проверочная работа

# Задача
*Написать программу,которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

**Примеры**
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []

## Описание решения

В исходном массиве определим какое количество строк соответствует заданным параметрам - имеет длину не более 3 символов. Для этого в цикле необходимо проверить длину каждой строки исходного массива. Если длина строки не превышает 3 символа, то предъявляем переменную-счетчик. Когда количество строк будет известно, объявляем массив, в котором будет храниться результат работы программы. В последующем, снова в цикле перебераем элементы исходного массива и копируем в новый результативный массив строки с длиной не более 3.
