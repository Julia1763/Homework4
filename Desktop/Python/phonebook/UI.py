import imp


import data_provider as prov
import logger as log
import display
import xml

def name_view(information):
    data = prov.enter_name(information)
    log.name_logger(data)
    return data


def surname_view(information):
    data = prov.enter_surname(information)
    log.surname_logger(data)
    return data

    
def phone_view(information):
    data = prov.enter_phone(information)
    log.phone_logger(data)
    return data

def menu(data):
    answer = display.menu_display()
    if answer ==1:
        display.display_data(data)
    elif answer==2:
        new_data = input('Введите новые данные через "-": ')
        row = new_data.split('-')
        data.append(row[0], row[1], row[2], row[3])
    elif answer==3:
        del_data = input('Введите номер записи, которую необходимо удалить')
        for i in range(len(data)):
            if data[i][0] == del_data:
                del (data[i])
    elif answer==4:
        xml.write_data(data.xml, data)
    elif answer==5:
        print('До свидания!')
    else:
        print('Введите еще раз')
            
