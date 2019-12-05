DROP TABLE IF EXISTS ~TMPCLP176011;
CREATE TABLE ~TMPCLP176011(
     PRIMARY KEY (Код),
     Код BIGINT NOT NULL, 
     Ассортимент BIGINT, 
     Описание VARCHAR(255), 
     Кодпредложения BIGINT, 
     Количество BIGINT
     );

DROP TABLE IF EXISTS ~TMPCLP640431;
CREATE TABLE ~TMPCLP640431(
     PRIMARY KEY (Код),
     Код BIGINT NOT NULL, 
     Наименование VARCHAR(255), 
     Описание VARCHAR(255)
     );

DROP TABLE IF EXISTS Абонемент;
CREATE TABLE Абонемент(
     PRIMARY KEY (Код),
     Код BIGINT NOT NULL, 
     Название VARCHAR(255), 
     Скидка BIGINT
     );

DROP TABLE IF EXISTS АссортВЗанятии;
CREATE TABLE АссортВЗанятии(
     PRIMARY KEY (Код),
     Код BIGINT NOT NULL, 
     Кодзанятия BIGINT, 
     Кодассорт BIGINT, 
     Количество BIGINT
     );

DROP TABLE IF EXISTS Ассортимент;
CREATE TABLE Ассортимент(
     PRIMARY KEY (Код),
     Код BIGINT NOT NULL, 
     Наименование VARCHAR(255), 
     Описание VARCHAR(255), 
     Цена BIGINT
     );

DROP TABLE IF EXISTS Занятия;
CREATE TABLE Занятия(
     PRIMARY KEY (Код),
     Код BIGINT NOT NULL, 
     Кодклиента BIGINT, 
     Кодсотдрудника BIGINT, 
     Дата DATE, 
     Замечания VARCHAR(255)
     );

DROP TABLE IF EXISTS Посетители;
CREATE TABLE Посетители(
     PRIMARY KEY (Код),
     Код BIGINT NOT NULL, 
     Фамилия VARCHAR(255), 
     Имя VARCHAR(255), 
     Отчество VARCHAR(255), 
     Адрес VARCHAR(255), 
     Паспорт VARCHAR(255), 
     Датарегистрации DATE, 
     Абонемент BIGINT
     );

DROP TABLE IF EXISTS Сотрудники;
CREATE TABLE Сотрудники(
     PRIMARY KEY (Код),
     Код BIGINT NOT NULL, 
     Фамилия VARCHAR(255), 
     Имя VARCHAR(255), 
     Отчество VARCHAR(255), 
     Датаприема VARCHAR(255), 
     Адрес VARCHAR(255), 
     Контактныеданные VARCHAR(255)
     );

