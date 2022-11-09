message = ''' Что необходимо сделать?
1 - просмотр таблицы
2 - добавление новой записи
3 - удаление записи с номером N
4 - сохранение в файл
5 - выход\n
'''

def display_data(data):
    for line in data:
        print(line)

def menu_display():
    answer = int(input(message))
    return answer