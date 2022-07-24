----"База данных программы автоматизации"
CREATE DATABASE AutomationAppDB
GO

CREATE TABLE Изделия
(
	ID_Изделия int NOT NULL IDENTITY PRIMARY KEY,
	Наименование nvarchar(80) NOT NULL
);

CREATE TABLE Модели_изделия
(
	ID_Модели_изделия int NOT NULL IDENTITY PRIMARY KEY,
	ID_Изделия int NOT NULL,
	Модель_изделия nvarchar(15) NOT NULL

	FOREIGN KEY (ID_Изделия) REFERENCES Изделия (ID_Изделия)
);

CREATE TABLE Маршрутные_листы
(
	ID_Маршрутного_листа int NOT NULL IDENTITY PRIMARY KEY,
	ID_Модели_изделия int NOT NULL,
	Номер_заказа int NOT NULL,
	Рост int NOT NULL,
	Размер int NOT NULL,
	Полнота int NOT NULL,
	Код_цвета int NOT NULL,
	
	FOREIGN KEY (ID_Модели_изделия) REFERENCES Модели_изделия (ID_Модели_изделия),
);

CREATE TABLE Изделия_принятые_на_склад
(
	ID_Принятого_изделия int NOT NULL IDENTITY PRIMARY KEY,
	ID_Маршрутного_листа int NOT NULL,
	Количество int NOT NULL,
	Сорт int NOT NULL,

	FOREIGN KEY (ID_Маршрутного_листа) REFERENCES Маршрутные_листы (ID_Маршрутного_листа)
);

CREATE TABLE Фурнитура
(
	ID_Фурнитуры int NOT NULL IDENTITY PRIMARY KEY,
	Наименование nvarchar(30) NOT NULL
);

CREATE TABLE Модели_фурнитуры
(
	ID_Модели_фурнитуры int NOT NULL IDENTITY PRIMARY KEY,
	ID_Фурнитуры int NOT NULL,
	Модель_фурнитуры nvarchar(50) NOT NULL,

	FOREIGN KEY (ID_Фурнитуры) REFERENCES Фурнитура (ID_Фурнитуры)
);

CREATE TABLE Склад_фурнитуры
(
	ID_Фурнитуры_на_складе int NOT NULL IDENTITY PRIMARY KEY,
	ID_Модели_фурнитуры int NOT NULL,
	Единица_измерения nvarchar(5) NOT NULL,
	Количество int NOT NULL,
	Цена money NOT NULL,

	FOREIGN KEY (ID_Модели_фурнитуры) REFERENCES Модели_фурнитуры (ID_Модели_фурнитуры)
);

CREATE TABLE Поставщики
(
	ID_Поставщика int NOT NULL IDENTITY PRIMARY KEY,
	Наименование nvarchar(80) NOT NULL,
	Адрес nvarchar(150) NOT NULL
);

CREATE TABLE Приходные_ордера_на_фурнитуру
(
	ID_Приходного_ордера int NOT NULL IDENTITY PRIMARY KEY,
	ID_Поставщика int NOT NULL,
	Дата_составления date NOT NULL,
	Склад nvarchar(30) NOT NULL,
	Корреспондирующий_счет nvarchar(20) NOT NULL,
	Сопроводительный_документ nvarchar(50) NOT NULL,
	Сумма money NOT NULL,

	FOREIGN KEY (ID_Поставщика) REFERENCES Поставщики (ID_Поставщика)
);

CREATE TABLE Материальные_ценности_по_ордеру_на_фурнитуру
(
	ID_Материальной_ценности int NOT NULL IDENTITY PRIMARY KEY,
	ID_Модели_фурнитуры int NOT NULL,
	ID_Приходного_ордера int NOT NULL,
	Единица_измерения nvarchar(5) NOT NULL,
	Количество int NOT NULL,
	Цена money NOT NULL,
	Сумма money NOT NULL,

	FOREIGN KEY (ID_Модели_фурнитуры) REFERENCES Модели_фурнитуры (ID_Модели_фурнитуры),
	FOREIGN KEY (ID_Приходного_ордера) REFERENCES Приходные_ордера_на_фурнитуру (ID_Приходного_ордера)
);

CREATE TABLE Цеха
(
	ID_Цеха int NOT NULL IDENTITY PRIMARY KEY,
	Наименование nvarchar(30) NOT NULL
);

CREATE TABLE Бригады
(
	ID_Бригады int NOT NULL IDENTITY PRIMARY KEY,
	ID_Цеха int NOT NULL,
	Наименование nvarchar(30) NOT NULL,
	
	FOREIGN KEY (ID_Цеха) REFERENCES Цеха (ID_Цеха)
);

CREATE TABLE Лимитно_заборные_карты
(
	ID_Лимитно_заборной_карты int NOT NULL IDENTITY PRIMARY KEY,
	ID_Бригады int NOT NULL,
	ID_Модели_изделия int NOT NULL,
	Дата_составления date NOT NULL,
	Количество_изделий int NOT NULL,
	
	FOREIGN KEY (ID_Бригады) REFERENCES Бригады (ID_Бригады),
	FOREIGN KEY (ID_Модели_изделия) REFERENCES Модели_изделия (ID_Модели_изделия)
);

CREATE TABLE Фурнитура_по_лимитно_заборной_карте
(
	ID_Фурнитруы_по_лимитно_заборной_карте int NOT NULL IDENTITY PRIMARY KEY,
	ID_Лимитно_заборной_карты int NOT NULL,
	ID_Фурнитуры_на_складе int NOT NULL,
	Норма_на_единицу_изделия int NOT NULL,
	Единица_измерения nvarchar(5) NOT NULL,
	Количество int NOT NULL,
	Цена money NOT NULL,
	Сумма money NOT NULL,

	FOREIGN KEY (ID_Лимитно_заборной_карты) REFERENCES Лимитно_заборные_карты (ID_Лимитно_заборной_карты),
	FOREIGN KEY (ID_Фурнитуры_на_складе) REFERENCES Склад_фурнитуры (ID_Фурнитуры_на_складе)
);

CREATE TABLE Ткани
(
	ID_Ткани int NOT NULL IDENTITY PRIMARY KEY,
	Наименование nvarchar(90) NOT NULL
);

CREATE TABLE Модели_ткани
(
	ID_Модели_ткани int NOT NULL IDENTITY PRIMARY KEY,
	ID_Ткани int NOT NULL,
	Модель_ткани nvarchar(50) NOT NULL,

	FOREIGN KEY (ID_Ткани) REFERENCES Ткани (ID_Ткани)
);

CREATE TABLE Склад_ткани
(
	ID_Ткани_на_складе int NOT NULL IDENTITY PRIMARY KEY,
	ID_Модели_ткани int NOT NULL,
	Единица_измерения nvarchar(5) NOT NULL,
	Количество int NOT NULL,
	Цена money NOT NULL,

	FOREIGN KEY (ID_Модели_ткани) REFERENCES Модели_ткани (ID_Модели_ткани)
);

CREATE TABLE Приходные_ордера_на_ткань
(
	ID_Приходного_ордера int NOT NULL IDENTITY PRIMARY KEY,
	ID_Поставщика int NOT NULL,
	Дата_составления date NOT NULL,
	Склад nvarchar(30) NOT NULL,
	Корреспондирующий_счет nvarchar(20) NOT NULL,
	Сопроводительный_документ nvarchar(50) NOT NULL,
	Сумма money NOT NULL,
	
	FOREIGN KEY (ID_Поставщика) REFERENCES Поставщики (ID_Поставщика)
);

CREATE TABLE Материальные_ценности_по_ордеру_на_ткань
(
	ID_Материальной_ценности int NOT NULL IDENTITY PRIMARY KEY,
	ID_Приходного_ордера int NOT NULL,
	ID_Модели_ткани int NOT NULL,
	Единица_измерения nvarchar(5) NOT NULL,
	Количество int NOT NULL,
	Цена money NOT NULL,
	Сумма_НДС money,
	Сумма_без_НДС money NOT NULL,
	Всего_с_НДС money NOT NULL,

	FOREIGN KEY (ID_Приходного_ордера) REFERENCES Приходные_ордера_на_ткань (ID_Приходного_ордера),
	FOREIGN KEY (ID_Модели_ткани) REFERENCES Модели_ткани (ID_Модели_ткани)
);

CREATE TABLE Расчётные_карты
(
	ID_Расчётной_карты int NOT NULL IDENTITY PRIMARY KEY,
	ID_Бригады int NOT NULL,
	ID_Модели_изделия int NOT NULL,
	Номер_заказа nvarchar(15) NOT NULL,
	Дата_отпуска_ткани date NOT NULL,

	FOREIGN KEY (ID_Бригады) REFERENCES Бригады (ID_Бригады),
	FOREIGN KEY (ID_Модели_изделия) REFERENCES Модели_изделия (ID_Модели_изделия)
);

CREATE TABLE Ткань_для_расчётной_карты
(
	ID_Ткани_для_карты int NOT NULL IDENTITY PRIMARY KEY,
	ID_Расчётной_карты int NOT NULL,
	ID_Ткани_на_складе int NOT NULL,
	Количество int NOT NULL,
	Единица_измерения nvarchar(5) NOT NULL,

	FOREIGN KEY (ID_Расчётной_карты) REFERENCES Расчётные_карты (ID_Расчётной_карты),
	FOREIGN KEY (ID_Ткани_на_складе) REFERENCES Склад_ткани (ID_Ткани_на_складе)
);

CREATE TABLE Склад_готовой_продукции
(
	ID_Готовой_продукции_на_складе int NOT NULL IDENTITY PRIMARY KEY,
	ID_Модели_изделия int NOT NULL,
	Сорт int NOT NULL,
	Единица_измерения nvarchar(5) NOT NULL,
	Количество int NOT NULL,

	FOREIGN KEY (ID_Модели_изделия) REFERENCES Модели_изделия (ID_Модели_изделия)
);

CREATE TABLE Контрагенты
(
	ID_Контрагента int NOT NULL IDENTITY PRIMARY KEY,
	УНП nvarchar(9) NOT NULL,
	Наименование nvarchar(80) NOT NULL,
	Адрес nvarchar(150) NOT NULL
);

CREATE TABLE Товарные_накладные
(
	ID_Товарной_накладной int NOT NULL IDENTITY PRIMARY KEY,
	Дата_отпуска date NOT NULL
);

CREATE TABLE Контрагенты_товарной_накладной
(
	ID_Контрагента_товарной_накладной int NOT NULL IDENTITY PRIMARY KEY,
	ID_Товарной_накладной int NOT NULL,
	ID_Контрагента int NOT NULL,
	Тип_контрагента nvarchar(20) NOT NULL,

	FOREIGN KEY (ID_Товарной_накладной) REFERENCES Товарные_накладные (ID_Товарной_накладной),
	FOREIGN KEY (ID_Контрагента) REFERENCES Контрагенты (ID_Контрагента)
);

CREATE TABLE Товарный_раздел_товарной_накладной
(
	ID_Товарного_раздела int NOT NULL IDENTITY PRIMARY KEY,
	ID_Товарной_накладной int NOT NULL,
	ID_Готовой_продукции_на_складе int NOT NULL,
	Единица_измерения nvarchar(5) NOT NULL,
	Количество int NOT NULL,
	Цена money NOT NULL,
	Стоимость_продукции money NOT NULL,
	Ставка_НДС int,
	Сумма_НДС int,
	Всего_с_НДС int NOT NULL,

	FOREIGN KEY (ID_Товарной_накладной) REFERENCES Товарные_накладные (ID_Товарной_накладной),
	FOREIGN KEY (ID_Готовой_продукции_на_складе) REFERENCES Склад_готовой_продукции (ID_Готовой_продукции_на_складе)
);

CREATE TABLE Автомобили
(
	ID_Автомобиля int NOT NULL IDENTITY PRIMARY KEY,
	Марка nvarchar(20) NOT NULL,
	Модель nvarchar(30) NOT NULL,
	Регистрационный_номер nvarchar(10) NOT NULL,
	Владелец nvarchar(80) NOT NULL
);

CREATE TABLE Водители
(
	ID_Водителя int NOT NULL IDENTITY PRIMARY KEY,
	ФИО nvarchar(50) NOT NULL,
	Номер_водительского_удостоверения nvarchar(10) NOT NULL,
	Дата_выдачи_удостоверения date NOT NULL
);

CREATE TABLE Товарно_транспортные_накладные
(
	ID_Товарно_транспортной_накладной int NOT NULL IDENTITY PRIMARY KEY,
	ID_Автомобиля int NOT NULL,
	ID_Водителя int NOT NULL,
	Дата_отпуска date NOT NULL,
	Основание_отпуска nvarchar(40) NOT NULL,
	Переадресовка nvarchar(150),
	Способ_погрузки nvarchar(25) NOT NULL,
	Способ_разгрузки nvarchar(25) NOT NULL,

	FOREIGN KEY (ID_Автомобиля) REFERENCES Автомобили (ID_Автомобиля),
	FOREIGN KEY (ID_Водителя) REFERENCES Водители (ID_Водителя)
);

CREATE TABLE Контрагенты_товарно_транспортной_накладной
(
	ID_Контрагента_товарно_транспортной_накладной int NOT NULL IDENTITY PRIMARY KEY,
	ID_Товарно_транспортной_накладной int NOT NULL,
	ID_Контрагента int NOT NULL,
	Тип_контрагента nvarchar(20) NOT NULL,

	FOREIGN KEY (ID_Товарно_транспортной_накладной) REFERENCES Товарно_транспортные_накладные (ID_Товарно_транспортной_накладной),
	FOREIGN KEY (ID_Контрагента) REFERENCES Контрагенты (ID_Контрагента)
);

CREATE TABLE Товарный_раздел_товарно_транспортной_накладной
(
	ID_Товарного_раздела int NOT NULL IDENTITY PRIMARY KEY,
	ID_Товарно_транспортной_накладной int NOT NULL,
	ID_Готовой_продукции_на_складе int NOT NULL,
	Единица_измерения nvarchar(5) NOT NULL,
	Количество int NOT NULL,
	Цена money NOT NULL,
	Стоимость money NOT NULL,
	Ставка_НДС int,
	Сумма_НДС int,
	Стоимость_с_НДС int NOT NULL,
	Количество_грузовых_мест int NOT NULL,
	Масса_груза int

	FOREIGN KEY (ID_Товарно_транспортной_накладной) REFERENCES Товарно_транспортные_накладные (ID_Товарно_транспортной_накладной),
	FOREIGN KEY (ID_Готовой_продукции_на_складе) REFERENCES Склад_готовой_продукции (ID_Готовой_продукции_на_складе)	
);
