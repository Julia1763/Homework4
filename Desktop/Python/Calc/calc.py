import UI
import logger


def function_calc(f_value, s_value):
    if oper == '+':
        return f_value + s_value
    elif oper =='-':
        return f_value-s_value
    elif oper =='*':
        return f_value*s_value
    elif oper =='/':
        if s_value ==0:
            print('На 0 делить нельзя!')
        else:
            return f_value/s_value
   
