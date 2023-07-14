#Материалы по данному мастер классу и видео традиционно выкладываю в группу: https://vk.com/codelevel
Одноименный курс на Stepik: https://stepik.org/course/91715/promo
#Мои контакты
Русаков Алексей
vk.com/rusalm   t.me/RusAl84
Презентация здесь: https://github.com/RusAl84/MyMessengerMasterClass

##Сегодня исходники здесь:
https://github.com/RusAl84/mAPI - исходный код сервера питон
https://github.com/RusAl84/mQ - исходный код клиента

##Команды для создания сервера
Ctrl + Shift + P = Select Interpreter
python -m venv .venv
https://python-scripts.com/virtualenv
pip install Flask Flask-Cors
##Форамат сообщений
post http://127.0.0.1:5000/mes 
{
  "MessageText": "Привет",
  "UserName": "RusAl",
  "TimeStamp": "12:30"
}
get http://localhost:5000/mes/4
##почитать о технологиях
https://code.visualstudio.com/
https://metanit.com/python/tutorial/
https://pythonworld.ru/
https://www.python.org/


#Команды для создания клиента
##установка NodeJs
https://nodejs.org/en/
node -v
##Если у Вас Windows, то нужно разрешить выполнение сторонних подписанных скриптов,
для этого запустите powerShell под администартором и выполните команду
Set-ExecutionPolicy RemoteSigned 
##Установка quasar 
npm install -g @quasar/cli 
##Cоздание проекта quasar                                                                                                                                                                                                                                                                            
npm init quasar
quasar dev
##Почитать о технологиях
https://metanit.com/web/javascript
https://quasar.dev/
https://ru.vuejs.org/
##Пример верстки и получение данных с бекэнда через библиотеку AXIOS
https://jsonplaceholder.typicode.com/guide/
https://github.com/axios/axios
https://www.flaticon.com/premium-icon/hedgehog_2658090#
