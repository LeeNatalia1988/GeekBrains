# Задача 18: Требуется найти в массиве A[1..N] самый близкий по
# величине элемент к заданному числу X. Пользователь в первой строке
# вводит натуральное число N – количество элементов в массиве. В
# последующих строках записаны N целых чисел Ai
# . Последняя строка
# содержит число X

numbers = list(map(int, input('Введите элементы массива через пробел: ').split()))
x = int(input(print('Введите число: ')))
count = abs(x - numbers[0])
number = 0
flag = 1
for i in range(len(numbers)):
    if x == numbers[i]:
        number = numbers[i]
        flag = 0
    elif abs(x - numbers[i]) < count & flag == True:
        count = abs(x - numbers[i])
        number = numbers[i]
print(f'Искомый элемент массива: {number}')
