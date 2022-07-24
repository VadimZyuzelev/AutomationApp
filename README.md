Программное средство для автоматизации технологического процесса, учета фурнитуры, ткани и готовой продукции на швейном производстве.

В данном репозитории размещен весь проект и папка с готовой программой (AutomationApp (Release)). 

Для успешного запуска на компьютере необходима платформа .Net Framework версии не ниже 4.7.2, СУБД MS SQL Server EXPRESS 2016 с развернутой базой данных и созданными пользователями.

База данных может размещаться на локальном компьютере - в качестве проверки; и на сервере - для прохождения маршрутного листа через технологический процесс (как на швейном производстве).

При развертывании базы данных необходимо произвести следующие настройки:
1. В SQL Server Configuration Manager в пункте "Сетевая конфигурация"-> протоколы SQL EXPRESS -> TCP/IP (правой кнопкой мыши - свойства). В открывшемся окне выставляем активно - да, на вкладке IP-адреса в поле IPII прописываем порт 1433. Для остальных IP-адресов также прописать порт 1433;
2. Сохранить и перезапустить службу;
3. Для правильной работы пользователей необходимо изменить проверку подлинности сервера: https://docs.microsoft.com/ru-ru/previous-versions/sql/sql-server-2008-r2/ms188670(v=sql.105)?redirectedfrom=MSDN. После чего **ОБЯЗАТЕЛЬНО ПЕРЕЗАПУСТИТЬ СЕРВЕР!**.

Для создания базы данных необходимо воспользоваться скриптами, размещенными в папке Scripts; после создания базы данных необходимо добавить триггеры, которые также размещены в указанной папке.

В папке с готовой программой размещен файл "Users" - в данном файле описаны пользователи и пароли.
