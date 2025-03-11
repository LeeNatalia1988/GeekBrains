# Напишите программу, которая найдёт произведение пар чисел списка. 
# Парой считаем первый и последний элемент, второй и предпоследний и т.д.

# Пример:

# - [2, 3, 4, 5, 6] => [12, 15, 16];
# - [2, 3, 5, 6] => [12, 15]

print('Введите количество чисел: ')
n = int(input())
number = [0]*n
i = 0
k = 0
print('Введите числа: ')
for i in range(n):
    number[i] = int(input())
if n%2 == 0:
    result = [0]*int(n/2)
    for i in range(int(n/2)):
        result[i] = number[i]*number[n - 1 - i]
else:
    result = [0]*(int(n/2 + 1))
    result[int(n/2)] = number[int(n/2)]**2
    for i in range(int(n/2)):
        result[i] = number[i]*number[n - 1 - i]
print(result)

# print('Произведения пар элементов:')
# result = []
# for i in range(int((n + 1) / 2)):  # подсчет произведения пар элементов
#     result.append(numbers[i] * numbers[- 1 - i])
# print(result)
