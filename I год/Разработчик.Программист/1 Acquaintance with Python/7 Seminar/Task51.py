# Задача No51. Решение в группах - в домашку
# Напишите функцию same_by(characteristic, objects), которая проверяет, все ли объекты имеют одинаковое 
# значение некоторой характеристики, и возвращают True, если это так. Если значение характеристики для разных объектов 
# отличается - то False. Для пустого набора объектов, функция должна возвращать True. Аргумент characteristic - это функция, 
# которая принимает объект и вычисляет его характеристику.
# Ввод: Вывод:
# values = [0, 2, 10, 6] same if same_by(lambda x: x % 2, values):
# print(‘same’) else:
# print(‘different’)
# 20 минут

values = [0, 2, 10, 6]
same_by = list(filter(lambda x: x % 2 == 0, values))
if same_by == values:
    print('Same')
else:
    print('Different')


    def same_by(func, collection):
    return len(list(filter(func, collection))) == 0


def same_by(characteristic, objects):
    for i in objects:
        if (characteristic(objects[0])) != (characteristic(i)):
            return False
    return True

values = [0, 2, 10, 6]
# values = []
if same_by(lambda x: x % 2, values):
    print('same')
else:
    print('different')
