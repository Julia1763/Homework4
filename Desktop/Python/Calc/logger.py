import calc
import UI
from fractions import Fraction

def result_logger(data, result):
    f_value, oper, s_value = data
    data_str = f'{str(f_value)} {oper} {str(s_value)}'
    with open('log.csv', 'a', encoding='UTF-8') as file:
        file.write('{}; операция : {} результат :{}\n', data_str, result)

def data_format(data):
    data_type, f_value, oper, s_value = data

    if data_type == '1':

        f_value = complex(f_value)

        s_value = complex(s_value)

    elif data_type == '2':

        a = f_value
        f_value = Fraction(int(a[0: a.index('/')]), int(a[a.index('/')+1:len(a)]))

        g = s_value
        s_value = Fraction(int(g[0: g.index('/')]), int(g[g.index('/')+1:len(g)]))

    return (f_value, oper, s_value)