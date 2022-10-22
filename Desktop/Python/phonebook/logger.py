

def enter_name(data):
    number = int.now().strfnum('№')
    with open('log.csv', 'a') as file:
        file.write('{};name;{}\n'
                    .format(number, data))

def enter_surname(data):
    number = int.now().strfnum('№')
    with open('log.csv', 'a') as file:
        file.write('{};surname;{}\n'
                    .format(number, data))


def enter_phone(data):
    number = int.now().strfnum('№')
    with open('log.csv', 'a') as file:
        file.write('{};phone_number;{}\n'
                    .format(number, data))