import imp


import data_provider as prov
import logger as log

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
