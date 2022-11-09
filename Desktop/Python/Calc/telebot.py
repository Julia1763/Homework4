import telebot
import logging
import time
Bot = telebot.TeleBot('')
Bot.message_handler(commands=['/start'])

def start_message(message):
    Bot.send_message(message.chat.id, 'Добро пожаловать!')
Bot.polling()

logger = logging.getLogger(__name__)


def Bot_info(self):
        info =  "Bot for different calculations. \r\n" + \
                "Supported operations: \r\n" + \
                "x + y \r\n" + \
                "x - y \r\n" + \
                "x * y \r\n" + \
                "x / y \r\n" + \
                "x % y \r\n" + \
                "x ** y \r\n" + \
                "x == y \r\n" + \
                "x < y \r\n" + \
                "x > y \r\n" + \
                "x <= y \r\n" + \
                "x >= y \r\n" + \
                "sin(x) \r\n" + \
                "cos(x) \r\n" + \
                "sqrt(x) \r\n" + \
                "pi() , where π = 3.141592...\r\n" + \
                "e() , where e = 2.718281...\r\n" + \
                "f(x) , factorial x! \r\n" + \
                "hex(x) \r\n" + \
                "int(x) \r\n" + \
                "base64enc(\"string\") \r\n" + \
                "base64dec(\"c3RyaW5n\") \r\n" + \
                "md5(\"string\") \r\n" + \
                "sha256(\"string\") \r\n" + \
                "\r\nExample: base64dec(base64enc(hex(int((((2**3) + 12)/172 - 99)**2))))\r\n" + \
                "\r\nP.S. Bot is in development state."
        return info

Bot.polling()

def __message_handle(self, msg):
        content_type, chat_type, chat_id = telebot.glance(msg)
        logger.debug('Content Type: %s; Chat Type: %s; Chat ID: %s', \
                     content_type, chat_type, chat_id)
        if content_type == 'text':
            input_text = msg['text']
            logger.debug('Input Text: %s', input_text)
            if input_text.lower() == "/start":
                answer =  "Bot is working. Enter /help."
            else:
                answer = "Operation is not supported."
                try:
                    if input_text.lower()[0:5] == "/calc":
                        answer = self.function_calc(input_text[6:])
                    else:
                        answer = self.function_calc(input_text)
            try:
                if (len(str(answer)) < 4096):
                    self.Bot.sendMessage(chat_id, answer)
                else:
                    answer = "Operation result is too long."
                    self.Bot.sendMessage(chat_id, answer) 
                return None
Bot.polling()

def __enter__(self):
        self.Bot.message_loop(self.__message_handle)
        while 1:
            time.sleep(10)



def function_calc(f_value, s_value, oper):
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