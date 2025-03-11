from datetime import datetime
import os
def show_menu():
    print("\nВыберите необходимое действие:\n"
          "1) Создать новую заметку\n"
          "2) Найти заметку по дате или заголовку\n"
          "3) Вывести все заметки в консоль\n"
          "4) Редактировать заметку\n"
          "5) Удалить заметку")
    choice = int(input())
    return choice

# Cheked: Основное меню для выбора дальнейшего действия
def work_with_notes():
    choice = show_menu()
    fields = ["Поля: Дата создания (идентификатор)", "Заголовок", "Текст заметки", "Дата последнего изменения"]
    while (choice != 6):
        if choice == 1:
            add_to_notes()
            return_to_show_menu()
        elif choice == 2:
            find = input('Введите дату (гггг-мм-дд) или заголовок заметки: -> ')
            print(find)
            find_notes(find)
            return_to_show_menu()
        elif choice == 3:
            print(f'{"".join(fields)}\n')
            for line in read_from_csv():
                print(*line, end='')
            return_to_show_menu()              
        elif choice == 4:
            find = input('Введите заголовок заметки, которую нужно изменить: ')
            choice_1 = int(input('Введите что нужно изменить в этой заметке (1 - заголовок, 2 - текст заметки): '))
            change = str(input('Введите на что нужно заменить: '))
            print('\nOk', end='\n')
            print('Измененная заметка: ')
            change_note(find, choice_1, change)
            return_to_show_menu()
        elif choice == 5:
            find = input('Введите заголовок заметки, которую нужно удалить: ')
            print('Удаленная заметка: ')
            delete_from_csv(find)
            print('\nOk', end='')
            return_to_show_menu()
        choice = show_menu()

# Cheked: Функция для возврата в главное меню
def return_to_show_menu():
    input('\nНажмите любую клавишу для возврата к основному меню или 6 для завешения...')

# Cheked: Функция чтения из файла
def read_from_csv():
    notes = []
    with open('notes.csv', 'r', encoding='UTF-8') as file:
        for line in file:
            notes.append(line.split(';'))
    return notes

# Cheked: Функция для добавления новой заметки 
def add_to_notes():
    notes = []
    notes.append(str(datetime.now().date()))
    print('Введите необходимые для записи данные:\nЗаголовок заметки: ')
    notes.append(input())
    print('Текст заметки: ')
    notes.append(input())
    notes.append(str(datetime.now().date()))
    with open('notes.csv', 'a', encoding='UTF-8') as file:
       file.write(f'{";".join(notes)}\n')
       file.close()

# Cheked: Функция для поиска данных
def find_notes(find):
    notes = read_from_csv()
    find_list = []
    for line in notes:
        if find in line:
            find_list.append(line)
    if len(find_list) == 0: print('Не найден.')
    else: 
        for line in find_list:
            print(*line, end='')
        return find_list
    
# Cheked: Функция для изменения заметки
def change_note(find, choice_1, change):
    notes = read_from_csv()
    for line in notes:
        if find in line:
                notes.remove(line)
                if choice_1 == 1:
                    line[1] = change
                    line[3] = str(datetime.now().date())
                elif choice_1 == 2:
                    line[2] = change 
                    line[3] = str(datetime.now().date())
                notes.append(line) 
    print(*line, end='')
    with open('notes.csv', 'w', encoding='UTF-8') as file:
       for line in notes:
                if line != ["\n"]:
                    file.write(f'{";".join(line)}\n')
       file.close() 

# Cheked: Функция удаления заметки 
def delete_from_csv(find):
    notes = read_from_csv()
    for line in notes:
        if find in line:
            print(*line)
            notes.remove(line)
    with open('notes.csv', 'w', encoding='UTF-8') as file:
       for line in notes:
                if line != ["\n"]:
                    file.write(f'{";".join(line)}\n')
       file.close()

  