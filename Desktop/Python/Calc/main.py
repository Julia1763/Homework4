import UI
import calc
import logger
from logger import result_logger

def button_click():
    j = logger.data_format(UI.input_data())
    calc_result = calc(j)
    UI.view_data(calc_result, 'Ответ:')
    result_logger(j, calc_result)

button_click()