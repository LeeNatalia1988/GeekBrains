# Задача 20: В настольной игре Скрабл (Scrabble) каждая буква имеет определенную
# ценность. В случае с английским алфавитом очки распределяются так:
# ● A, E, I, O, U, L, N, S, T, R – 1 очко;
# ● D, G – 2 очка;
# ● B, C, M, P – 3 очка;
# ● F, H, V, W, Y – 4 очка;
# ● K – 5 очков;
# ● J, X – 8 очков;
# ● Q, Z – 10 очков.
# А русские буквы оцениваются так:
# ● А, В, Е, И, Н, О, Р, С, Т – 1 очко;
# ● Д, К, Л, М, П, У – 2 очка;
# ● Б, Г, Ё, Ь, Я – 3 очка;
# ● Й, Ы – 4 очка;
# ● Ж, З, Х, Ц, Ч – 5 очков;
# ● Ш, Э, Ю – 8 очков;
# ● Ф, Щ, Ъ – 10 очков.
# Напишите программу, которая вычисляет стоимость введенного пользователем слова.
# Будем считать, что на вход подается только одно слово, которое содержит либо только
# английские, либо только русские буквы.

dict_1 = {'AEIOULNSTRАВЕИНОРСТ': 1, 'DGДКЛМПУ': 2, 'BCMPБГЁЬЯ': 3, 'FHVWYЙЫ': 4, 'KЖЗХЦЧ': 5, 'JXШЭЮ': 8, 'QZФЩЪ': 10} 
word = list(input('Введите слово буквами верхнего регистра: '))
price = 0
for i in word:
    for key in dict_1:
        if i in key:
            price = price + dict_1.get(key)
print(f'Стоимость слова: {price}.')

Второй вариант
onePoints = dict.fromkeys(['А', 'В', 'Е', 'И', 'Н', 'О', 'Р', 'С', 'Т'], 1)
twoPoints = dict.fromkeys(['Д', 'К', 'Л', 'М', 'П', 'У'], 2)
threePoints = dict.fromkeys(['Б', 'Г', 'Ё', 'Ь', 'Я' ], 3)
fourPoints = dict.fromkeys(['Й', 'Ы'], 4)
fivePoints = dict.fromkeys(['Ж', 'З', 'Х', 'Ц', 'Ч'], 5)
eightPoints = dict.fromkeys(['Ш', 'Э', 'Ю'], 8)
tenPoints = dict.fromkeys(['Ф', 'Щ', 'Ъ'], 10)
mergedDict = onePoints | twoPoints | threePoints | fourPoints | fivePoints | eightPoints | tenPoints 

userText = list(input("Введите одно слово ").upper())
sum = 0
for i in userText:
    sum += mergedDict[i]
print(sum)
