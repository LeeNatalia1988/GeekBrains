'''~~~~~~~~~~~~~~~~~~ С е м и н а р  5 ~~~~~~~~~~~~~~~~'''


'''
Задача 31
Последовательностью Фибоначчи называется последовательность чисел a0, a1,
..., an, ..., где
a0 = 0, a1 = 1, ak = ak-1 + ak-2 (k > 1).
Требуется найти N-е число Фибоначчи
Input: 7
Output: 21

Задание необходимо решать через рекурсию
'''


def fib(count):
    if count == 0:
        return 0
    elif count == 1:
        return 1
    return fib(count-2) + fib(count-1)

n = int(input('Введи натуральное число N = '))
print(f'{n}-ое число Фибоначчи равно {fib(n)}')


'''
Задача 33
Хакер Василий получил доступ к классному журналу и хочет заменить
все свои минимальные оценки на максимальные. Напишите программу,
которая заменяет оценки Василия, но наоборот: все максимальные –
на минимальные.

Input: 5 -> 1 3 3 3 4
Output: 1 3 3 3 1
'''


def zamena(oneList):
    maximal = max(oneList)
    minimal = min(oneList)
    for item in range(len(oneList)):
        if oneList[item] == maximal:
            oneList[item] = minimal
    return oneList

spisok = [1, 3, 3, 3, 4]
print(zamena(spisok))


'''
Задача 35:
Напишите функцию, которая принимает одно число и проверяет, является ли оно простым
Напоминание: Простое число - это число, которое имеет 2 делителя: 1  и n(само число)

Input: 5
Output: yes
'''


def simple(num):           # решение с помощью рекурсии
    if num == 1: return 'Простое'
    elif n % (num) == 0: return 'Не простое'
    return simple(num - 1)

n = 11
print(simple(n // 2))


'''
Задача 37:
Дано натуральное число N и последовательность из N элементов.
Требуется вывести эту последовательность в обратном порядке.
Примечание. В программе запрещается объявлять массивы и использовать
циклы (даже для ввода и вывода).

Input:    2 -> 3 4
Output: 4 3
'''


def invert(count = 1):
  if count > n: return ''
  k = input(f'введи {count}-й элемент > ')
  return invert(count + 1) + ' ' + k

n = 4
print(invert())


'''
Проверка слова на палиндром
'''


def pal(text):
    if text == '': return ''
    return text[-1] + pal(text[:-1])

word = 'локон'
if word == pal(word): print(f'слово {word} - палиндром')
else: print(f'слово {word} - не палиндром')