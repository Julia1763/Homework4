

def enter_name(information):
    name=input('Введите имя пользователя: ')
    return name
    

def enter_surname(information):
    surname=input('Введите фамилию пользователя: ')
    return surname
   

def enter_phone(information):
    phone_number=int(input('Введите фамилию пользователя: '))
    return phone_number

def data_collection(information = 1):
    return (enter_name(information), enter_surname(information), enter_phone(information))
