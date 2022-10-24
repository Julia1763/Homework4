import calc
import logger

def input_data():
    print('Введите 1 для работы с комплексными числами, 2 - для работы с рациональными числами')
    data_type = input()
    if data_type == '1':
        print('Введите первое число (используйте формат: "a + bj", где j - мнимая часть):')
        f_value = input()
        print('Введите второе число (используйте формат: "a + bj", где j - мнимая часть):')
        s_value = input()
        print('Введите действие:')
        oper = input()
    elif data_type == '2':
        print('Введите первое число (используйте формат: "a/b"):')
        f_value = input()
        print('Введите второе число (используйте формат: "a/b"):')
        s_value = input()
        print('Введите действие:')
        oper = input()
    return (data_type, f_value, oper, s_value)