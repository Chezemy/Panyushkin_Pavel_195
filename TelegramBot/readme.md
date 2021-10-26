<h1>Создание Telegram бота</h1>
Для создания бота нужно в самом Телеграме найти бота @BotFather, написать ему /newbot, заполнить поля, которые он спросит (название бота и его короткое имя), и получить сообщение с токеном бота и ссылкой на документацию. Токен нужно сохранить, желательно надёжно, так как это единственный ключ для авторизации бота и взаимодействия с ним. Не нужно никому его давать, так как с помощью токена можно подключиться к вашему боту и получить над ним полный контроль.<br>
![image](https://user-images.githubusercontent.com/40539112/138820857-ffceddb8-e503-4d39-84f3-1e154f8cf5f4.png)
<h2>Пишем бота на Python</h2>
Устанавлием IDE или интерпретатор Python, если их нет на компьютере. В нашем случае будем использовать PyCharm, но можно использовать любую другую IDE или текстовый редактор. В командной строке windows вводим:<br><br><b>pip install pytelegrambotapi</b><br><br>
Теперь создаём файл с расширением .py и импортируем библиотеку для работы с ботом:<br>
<br><b>import telebot;<br>
bot = telebot.TeleBot('%ваш токен%');</b><br><br>
Теперь можем начинать писать бота:<br><br>
<b>@bot.message_handler(content_types=['text', 'document', 'audio'])<br>
def get_text_messages(message):<br>
  if message.text == "Привет":<br>
    bot.send_message(message.from_user.id, "Привет, чем я могу тебе помочь?")<br>
elif message.text == "/help":<br>
    bot.send_message(message.from_user.id, "Напиши привет")<br>
else:<br>
    bot.send_message(message.from_user.id, "Я тебя не понимаю. Напиши /help.")</b><br><br>
  
Осталось добавить одну строку для постоянного соединения с ботом:<br><br>
<b>bot.polling(none_stop=True, interval=0)</b><br><br>
Запускаем файл через консоль или IDE и бот начинает работать. Основной функционал готов, дальше при желании можно добавлять боту новым функции.
![image](https://user-images.githubusercontent.com/40539112/138822879-87a55980-ea25-4f8a-907e-e42c2de4faa4.png)

