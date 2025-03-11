
# Задача No(49) 38.
# Решение в группах Создать телефонный справочник с возможностью импорта и
# экспорта данных в формате .txt. Фамилия, имя, отчество, номер телефона -
# данные, которые должны находиться в файле.
# 1. Программа должна выводить данные
# 2. Программа должна сохранять данные в текстовом файле
# 3. Пользователь может ввести одну из характеристик для поиска определенной
# записи(Например имя или фамилию человека)
# 4. Использование функций. Ваша программа не должна быть линейной

import os
file = 'phone_book.txt'
fields = ["Фамилия", "Имя", "Отчество", "Телефон", "Описание абонента\n"]
phone_list1 = []
def show_menu():
    print("\nВыберите необходимое действие:\n"
          "1) Вывести справочник на экран\n"
          "2) Сохранить справочник в текстовом файле\n"
          "3) Найти по фамилии\n"
          "4) Найти по имени\n"
          "5) Добавить абонента в текстовый файл\n"
          "6) Удалить абонента из текстового файла")
    choice = int(input())
    return choice

# Ok - основное меню для выбора дальнейшего действия
def work_with_phonebook():
    choice = show_menu()
    while (choice != 7):
        if choice == 1:
            for line in read_from_txt(file):
                print(*line, end='')
            return_to_show_menu()
        elif choice == 2:
            write_to_txt(file, phone_list1)
            print('\nOk', end='')
            return_to_show_menu()
        elif choice == 3:
            finded = input_finded('Введите фамилию:')
            find_abonent(file, finded)
            return_to_show_menu()              
        elif choice == 4:
            finded = input_finded('Введите имя:')
            find_abonent(file, finded)
            return_to_show_menu()
        elif choice == 5:
            add_to_txt(file)
            print('\nOk', end='')
            return_to_show_menu()
        elif choice == 6:
            finded = input_finded('Введите фамилию или имя:')
            delete_from_txt(file, finded)
            print('\nOk', end='')
            return_to_show_menu()
        choice = show_menu()

# Ок - функция для возврата к меню выбора
def return_to_show_menu():
    input('\nНажмите любую клавишу для возврата к основному меню.')

# Ок - функция чтения с тхт файла
def read_from_txt(filename):
    phone_list = [fields]
    with open(filename, 'r', encoding='utf-8') as file:
        for line in file:
            phone_list.append(line.split(','))
    return phone_list

# Ок - функция записи в тхт файл
def write_to_txt(filename, phone_dict):
    with open(filename, 'w+', encoding='utf-8') as file:
        for line in phone_dict:
            file.write(",".join(line))

# Ок - функция добавления в тхт файл данных
def add_to_txt(filename, line = []):
    print('Введите необходимые для записи данные:')
    for item in fields:
        line.append(input(f'\n{item.strip()} > ').title())
    with open(filename, 'a', encoding='utf-8') as file:
        file.write(f'{",".join(line)}\n')

# Ок - функция удаления из тхт файла данных
def delete_from_txt(filename, find):
    phone_book = read_from_txt(filename)[1:]
    for line in phone_book:
        if find in line:
            print(*line)
            phone_book.remove(line)
    write_to_txt(filename, phone_book)

# Ок - функция ввода данных для поиска
def input_finded(message):
    answer = input(f'\n{message} > ').title()
    print('\n')
    return answer

# Ок - функция для поиска по введенным в input_finded данным
def find_abonent(filename, find):
    phone_list = read_from_txt(filename)
    find_list = []
    for line in phone_list:
        if find in line:
            find_list.append(line)
    if len(find_list) == 0: print('Не найден.')
    else: 
        find_list.insert(0, fields)
        for line in find_list:
            print(*line, end='')
        return find_list
    



# Задача №49. Решение в группах
# Создать телефонный справочник с
# возможностью импорта и экспорта данных в
# формате .txt. Фамилия, имя, отчество, номер
# телефона - данные, которые должны находиться
# в файле.
# 1. Программа должна выводить данные
# 2. Программа должна сохранять данные в текстовом файле
# 3. Пользователь может ввести одну из характеристик для поиска определенной
# записи(Например имя или фамилию человека)
# 4. Использование функций. Ваша программа не должна быть линейной

# Задача 38: Дополнить телефонный справочник возможностью изменения и удаления данных.
# Пользователь также может ввести имя или фамилию, и Вы должны реализовать функционал
# для изменения и удаления данных.
# --------------- Решение ------------------

# def show_menu() -> int:
#     print("\nВыберите необходимое действие:\n"
#           "1. Отобразить весь справочник\n"
#           "2. Найти абонента по фамилии\n"
#           "3. Найти абонента по номеру телефона\n"
#           "4. Добавить абонента в справочник\n"
#           "5. Удалить абонента из справочника\n"
#           "6. Сохранить справочник в текстовом формате\n"
#           "7. Закончить работу")
#     choice = int(input())
#     return choice

# def work_with_phonebook():
#     choice = show_menu()
#     phone_book = read_csv('phonebook.csv')

#     while (choice != 7):
#         if choice == 1: # 1. Отобразить весь справочник
#             print_result(phone_book) 
#         elif choice == 2: # 2. Найти абонента по фамилии
#             name = get_search_name()
#             print_result(find_by_name(phone_book, name)) 
#         elif choice == 3: # 3. Найти абонента по номеру телефона
#             number = get_search_number() 
#             print_result(find_by_number(phone_book, number))
#         elif choice == 4: # 4. Добавить абонента в справочник
#             user_data = get_new_user() 
#             add_user(phone_book, user_data)
#             write_csv('phonebook.csv', phone_book)
#         elif choice == 5: # 5. Удалить абонента из справочника
#             name = get_search_name() 
#             print_result(find_by_name(phone_book, name)) 
#             delete_user(phone_book, find_by_name(phone_book, name))
#             write_csv('phonebook.csv', phone_book)
#         elif choice == 6:  # Сохранить справочник в текстовом формате
#             file_name = get_file_name()
#             write_txt(file_name, phone_book)
#         choice = show_menu()

# def read_csv(filename: str) -> list:
#     data = []
#     fields = ["Фамилия", "Имя", "Телефон", "Описание"]
#     with open(filename, 'r', encoding='utf-8') as fin:
#         for line in fin:
#             record = dict(zip(fields, line.strip().split(',')))
#             data.append(record)
#     return data

# def write_csv(filename: str, data: list):
#     with open(filename, 'w', encoding='utf-8') as fout:
#         for i in range(len(data)):
#             s = ''
#             for v in data[i].values():
#                 s += v + ','
#             fout.write(f'{s[:-1]}\n')

# def write_txt(filename: str, data: list):
#     txt_filename = filename + '.txt'
#     print(txt_filename)
#     with open(txt_filename, 'w', encoding='utf-8') as fout:
#         s = '│'
#         fout.write('┌' + '─'*20 + '┬' + '─'*20  + '┬' + '─'*20 + '┬' + '─'*20 + '┐'+'\n')
#         fields = ["Фамилия", "Имя", "Телефон", "Описание"]
#         for v in fields:
#             s += v.center(20) + "│"
#         fout.write(f'{s}\n')
#         fout.write('├' + '─'*20 + '┼' + '─'*20  + '┼' + '─'*20 + '┼' + '─'*20 + '┤'+ '\n')    

#         for i in range(len(data)):
#             s = '│'
#             for v in data[i].values():
#                 s += v.center(20) + "│"
#             fout.write(f'{s}\n')
#             fout.write('├' + '─'*20 + '┼' + '─'*20  + '┼' + '─'*20 + '┼' + '─'*20 + '┤' + '\n')
#         fout.write(f'Всего сохранено {len(data)} записей')

# def print_result(data: list):
#     s = '│'
#     print('┌' + '─'*20 + '┬' + '─'*20  + '┬' + '─'*20 + '┬' + '─'*20 + '┐')
#     fields = ["Фамилия", "Имя", "Телефон", "Описание"]
#     for v in fields:
#         s += v.center(20) + "│"
#     print(f'{s}')
#     print('├' + '─'*20 + '┼' + '─'*20  + '┼' + '─'*20 + '┼' + '─'*20 + '┤')

#     for i in range(len(data)):
#             s = '│'
#             for v in data[i].values():
#                 s += v.center(20) + "│"
#             print(f'{s}')
#             print('├' + '─'*20 + '┼' + '─'*20  + '┼' + '─'*20 + '┼' + '─'*20 + '┤')
#     print(f'Всего найдено {len(data)} записей')

# def find_by_name(data: list, first_name):
#     search_by_name = []
#     for line in data:
#         index = line['Фамилия'].lower()
#         if index.find(first_name.lower()) == 0:
#             search_by_name.append(dict(line))
#     return search_by_name

# def find_by_number(data: list, number):
#     search_by_number = []
#     for line in data:
#         index = line['Телефон']
#         if  index.find(number) == 0:
#             search_by_number.append(dict(line))
#     return search_by_number

# def get_new_user():
#     line = {}
#     fields = ["Фамилия", "Имя", "Телефон", "Описание"]
#     for v in fields:
#         data = input(f'Введите {v}: ')
#         line[v] = data
#     return line

# def delete_user(data: list, name):
#     # print(f'name:{name}')
#     tmp = []
#     for record in name:      
#         if record in data:
#             print('Найдена запись для удаления:')
#             tmp.append(record)
#             print_result(tmp)
#             confirmation = input('Для подтверждения удаления записи введите ""yes"",\n'
#                                  'для отмены операции удаления введите ""no"":')
#             if confirmation == 'yes':
#                 data.remove(record)
#             elif confirmation == 'no':
#                 return
#             tmp.clear()
        

# def add_user(data: list, user_data: dict):
#     data.append(dict(user_data))
#     return data

# def get_search_name():
#     first_name = input("Введите фамилию: ")
#     return first_name

# def get_search_number():
#     name = input("Введите номер: ")
#     return name

# def get_file_name():
#     name = input("Введите имя файла: ")
#     return name
# # import os
# # path = os.getcwd() 
# # print(path + '\sem_8')
# # os.chdir(path+ '\sem_8') # устанавливаем рабочую директорию
# # print(os.getcwd()) # вывести рабочую директорию
# work_with_phonebook()