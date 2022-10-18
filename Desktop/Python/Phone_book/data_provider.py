
import pickle

from Phone_book.logger import phone_number
Dict = {}

def enter_name(information):
    name=input('Введите имя пользователя: ')
    file = open("Text.bin", 'wb')
    pickle.dump(Dict, file)
    file.close()
    exit_menu = input("Добавить ещё данные или выйти в меню?")
    if exit_menu == 'Выйти' or exit_menu == 'выйти' or exit_menu == 'exit':
        exit()

def enter_surname(information):
    surname=input('Введите фамилию пользователя: ')
    file = open("Text.bin", 'wb')
    pickle.dump(Dict, file)
    file.close()
    exit_menu = input("Добавить ещё данные или выйти в меню?")
    if exit_menu == 'Выйти' or exit_menu == 'выйти' or exit_menu == 'exit':
        exit()


def enter_phone(information):
    phone_number=int(input('Введите фамилию пользователя: '))
    file = open("Text.bin", 'wb')
    pickle.dump(Dict, file)
    file.close()
    exit_menu = input("Добавить ещё данные или выйти в меню?")
    if exit_menu == 'Выйти' or exit_menu == 'выйти' or exit_menu == 'exit':
        exit()

def data_collection(information = 1):
    return (enter_name(information), enter_surname(information), enter_phone(information))
