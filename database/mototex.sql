CREATE DATABASE IF NOT EXISTS `mototex` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `mototex`;

-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: mototex
-- ------------------------------------------------------
-- Server version	8.0.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `clients`
--

DROP TABLE IF EXISTS `clients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clients` (
  `Phone_number` varchar(45) NOT NULL,
  `Surname` varchar(45) DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Lastname` varchar(45) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `Gender` varchar(45) DEFAULT NULL,
  `Status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Phone_number`),
  KEY `Gender_idx` (`Gender`),
  KEY `Status3_idx` (`Status`),
  KEY `Status4_idx` (`Status`),
  CONSTRAINT `Gender` FOREIGN KEY (`Gender`) REFERENCES `gender` (`Name_gender`),
  CONSTRAINT `Status4` FOREIGN KEY (`Status`) REFERENCES `status` (`Name_status`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clients`
--

LOCK TABLES `clients` WRITE;
/*!40000 ALTER TABLE `clients` DISABLE KEYS */;
INSERT INTO `clients` VALUES ('+7(915)123-12-33','Яковлев','Михаил','Сергеевич','AstinTorn@mail.ru','М','Активен'),('+7(915)236-73-56','Михайлов ','Захар','Павлович','Mista@mail.ru','М','Активен'),('+7(915)777-77-77','Кузякин','Валерий','Сергеевич','Hellow@mail.ru','М','Активен'),('+7(916)555-55-55','Смирнов','Алексей','Игоревич','Smirnov@mail.ru','М','Активен'),('+7(916)783-23-11','Богур','Денис','Алексеевич','Littl@mail.ru','М','Активен'),('+7(925)444-25-74','Быканова','Елена','Юрьевна','List@mail.ru','Ж','Активен'),('+7(978)583-55-78','Пускулова','Екатерина','Олеговна','ASDWssw@mail.ru','Ж','Активен'),('+7(979)835-22-12','Доронин','Вадим','Кириллович','Vadim@mail.ru','М','Активен'),('+7(999)293-94-92','Матвеев','Кирилл','Рустамович','qwe@mail.ru','М','Активен');
/*!40000 ALTER TABLE `clients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `color`
--

DROP TABLE IF EXISTS `color`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `color` (
  `Name_color` varchar(45) NOT NULL,
  PRIMARY KEY (`Name_color`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `color`
--

LOCK TABLES `color` WRITE;
/*!40000 ALTER TABLE `color` DISABLE KEYS */;
INSERT INTO `color` VALUES ('Cиний нейтральный'),('Аквамариновый	'),('Античный белый'),('Аспидно-синий'),('Бежевый'),('Белый'),('Белый дым'),('Белый навахо'),('Бирюзовый'),('Бирюзовый нейтральный'),('Бисквит'),('Бланшированный миндаль'),('Бледно-бирюзовый	'),('Бледно-зелёный	'),('Бледный золотарник'),('Васильковый голубой	'),('Весенне зелёный'),('Военно-морского флота'),('Геинсборо'),('Жёлто-зелёный'),('Жёлтый'),('Загар'),('Зелёно-жёлтый'),('Зелёное море	'),('Зелёный'),('Зелёный газон'),('Зелёный лайм'),('Зелёный лесной'),('Золотарниковый'),('Золотой'),('Индиго'),('Коралловый'),('Коричневый'),('Королевский синий'),('Красный'),('Красный индийский'),('Кукурузный волос'),('Лаванда	'),('Лазурный	'),('Лаймовый'),('Лиловый'),('Лимонный шифон'),('Лососевый'),('Маджента'),('Малиновый'),('Медвяная роса	'),('Мокасиновый'),('Морская волна'),('Морская ракушка'),('Мятный крем	'),('Насыщенный розовый'),('Небесно-голубой'),('Небесно-голубой тёмный'),('Нейтральный аспидно-синий'),('Нейтральный цвет орхидеи'),('Обманчивый синий'),('Огнеупорный кирпич'),('Оливковый'),('Оранжево-красный'),('Оранжевый'),('Орхидея'),('Охра'),('Персиковая пудра'),('Перу'),('Песочно-коричневый'),('Плотное дерево7'),('Побег папайи'),('Полуночный синий'),('Призрачно-белый'),('Пшеничный'),('Пыльный голубой'),('Розово-коричневый'),('Розово-лавандовый'),('Розово-фиолетовый'),('Розовый'),('Светло-голубой	'),('Светло-жёлтый'),('Светло-жёлтый золотарник'),('Светло-зелёное море'),('Светло-зелёный	'),('Светло-коралловый'),('Светло-розовый'),('Светло-серый'),('Светло-серый шифер	'),('Светло-синий	'),('Светло-стальной синий	'),('Светлый лосось'),('Седло Браун'),('Серебряный'),('Серо-синий	'),('Серый'),('Серый шифер	'),('Сине-фиолетовый'),('Синий'),('Синяя сталь'),('Синяя Элис'),('Слива светлая'),('Слоновая кость'),('Снег'),('Старое кружево'),('Текстильный'),('Тёмная орхидея'),('Тёмно-бирюзовый'),('Тёмно-бордовый'),('Тёмно-зелёное море	'),('Тёмно-зелёный	'),('Тёмно-красный'),('Тёмно-оливковый'),('Тёмно-оливковый зелёный'),('Тёмно-оранжевый'),('Тёмно-серый'),('Тёмно-синий'),('Тёмно-фиолетовый'),('Тёмный аспидно-синий'),('Тёмный грифельно-серый'),('Тёмный золотарник'),('Тёмный лосось'),('Тёмный маджента'),('Тёмный хаки'),('Тёмный циан'),('Томатный'),('Туманная роза'),('Тускло-серый'),('Фиолетово-красный'),('Фиолетовый'),('Фиолетовый нейтральный'),('Хаки'),('Цветочный белый'),('Чёрный'),('Чертополох'),('Шартрёз'),('Шоколадный'),('Ярко-розовый');
/*!40000 ALTER TABLE `color` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `country`
--

DROP TABLE IF EXISTS `country`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `country` (
  `Name_country` varchar(45) NOT NULL,
  PRIMARY KEY (`Name_country`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `country`
--

LOCK TABLES `country` WRITE;
/*!40000 ALTER TABLE `country` DISABLE KEYS */;
INSERT INTO `country` VALUES ('Абхазия'),('Австралия'),('Австрия'),('Азербайджан'),('Албания'),('Алжир'),('Ам. Виргинские острова'),('Американское Самоа'),('Ангола'),('Андорра'),('Антигуа и Барбуда'),('Аргентина'),('Армения'),('Аруба'),('Афганистан'),('Багамы'),('Бангладеш'),('Барбадос'),('Бахрейн'),('Белиз'),('Белоруссия'),('Бельгия'),('Бенин'),('Бермудские Острова'),('Болгария'),('Боливия'),('Бонэйр'),('Босния и Герцеговина'),('Ботсвана'),('Бр. Виргинские острова'),('Бразилия'),('Бруней'),('Буркина-Фасо'),('Бурунди'),('Бутан'),('Вануату'),('Ватикан'),('Великобритания'),('Венгрия'),('Венесуэла'),('Восточный Тимор'),('Вьетнам'),('Габон'),('Гаити'),('Гайана'),('Гамбия'),('Гана'),('Гватемала'),('Гвинея'),('Гвинея-Бисау'),('Германия'),('Гондурас'),('Гонконг'),('Гренада'),('Греция'),('Грузия'),('Д.Р. Конго'),('Дания'),('Джерси'),('Джибути'),('Доминика'),('Доминикана'),('Египет'),('Замбия'),('Зимбабве'),('Израиль'),('Индия'),('Индонезия'),('Иордания'),('Ирак'),('Иран'),('Ирландия'),('Исландия'),('Испания'),('Италия'),('Йемен'),('Кабо-Верде'),('Казахстан'),('Камбоджа'),('Камерун'),('Канада'),('Катар'),('Кения'),('Кипр'),('Киргизия'),('Кирибати'),('Китай'),('КНДР'),('Кокосовые острова'),('Колумбия'),('Коморские Острова'),('Конго'),('Корея'),('Коста-Рика'),('Кот-д\'Ивуар'),('Куба'),('Кувейт'),('Кюрасао'),('Лаос'),('Латвия'),('Лесото'),('Либерия'),('Ливан'),('Ливия'),('Литва'),('Лихтенштейн'),('Люксембург'),('Маврикий'),('Мавритания'),('Мадагаскар'),('Македония'),('Малави'),('Малайзия'),('Мали'),('Мальдивы'),('Мальта'),('Марокко'),('Маршалловы Острова'),('Мексика'),('Мозамбик'),('Молдавия'),('Монако'),('Монголия'),('Мьянма'),('Намибия'),('Науру'),('Непал'),('Нигер'),('Нигерия'),('Нидерланды'),('Никарагуа'),('Новая Зеландия'),('Норвегия'),('ОАЭ'),('Оман'),('Острова Кука'),('Пакистан'),('Палау'),('Панама'),('Папуа-Новая Гвинея'),('Парагвай'),('Перу'),('Польша'),('Португалия'),('Пуэрто-Рико'),('Россия'),('Руанда'),('Румыния'),('Саба'),('Сальвадор'),('Самоа'),('Сан-Марино'),('Сан-Томе и Принсипи'),('Саудовская Аравия'),('Свазиленд'),('Сейшелы'),('Сен-Мартен'),('Сенегал'),('Сент-Винсент и Гренадины'),('Сент-Китс и Невис'),('Сент-Люсия'),('Сербия'),('Сингапур'),('Синт-Эстатиус'),('Сирия'),('Словакия'),('Словения'),('Соломоновы Острова'),('Сомали'),('Судан'),('Суринам'),('США'),('Сьерра-Леоне'),('Таджикистан'),('Таиланд'),('Танзания'),('Того'),('Токелау'),('Тонга'),('Тринидад и Тобаго'),('Тувалу'),('Тунис'),('Туркменистан'),('Турция'),('Уганда'),('Узбекистан'),('Украина'),('Уоллис и Футуна'),('Уругвай'),('Фарерские острова'),('Фед. Штаты Микронезии'),('Фиджи'),('Филиппины'),('Финляндия'),('Фолклендские острова'),('Франция'),('Французская Полинезия'),('Хорватия'),('ЦАР'),('Чад'),('Черногория'),('Чехия'),('Чили'),('Швейцария'),('Швеция'),('Шри-Ланка'),('Эквадор'),('Экваториальная Гвинея'),('Эритрея'),('Эстония'),('Эфиопия'),('ЮАР'),('Южный Судан'),('Ямайка'),('Япония');
/*!40000 ALTER TABLE `country` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gender`
--

DROP TABLE IF EXISTS `gender`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gender` (
  `Name_gender` varchar(45) NOT NULL,
  PRIMARY KEY (`Name_gender`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gender`
--

LOCK TABLES `gender` WRITE;
/*!40000 ALTER TABLE `gender` DISABLE KEYS */;
INSERT INTO `gender` VALUES ('Ж'),('М');
/*!40000 ALTER TABLE `gender` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `manufacturer`
--

DROP TABLE IF EXISTS `manufacturer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `manufacturer` (
  `Name` varchar(45) NOT NULL,
  `Country` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Name`),
  KEY `Country_idx` (`Country`),
  CONSTRAINT `Country` FOREIGN KEY (`Country`) REFERENCES `country` (`Name_country`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `manufacturer`
--

LOCK TABLES `manufacturer` WRITE;
/*!40000 ALTER TABLE `manufacturer` DISABLE KEYS */;
INSERT INTO `manufacturer` VALUES ('Derbi','Великобритания'),('Ducati','Великобритания'),('Victory','Великобритания'),('BMW','Германия'),('Gilera','Греция'),('Can-Am','Египет'),('Kymco','Испания'),('Aprilia','Канада'),('Sachs','Канада'),('Stels','Канада'),('Zero','Кипр'),('Bajaj','Китай'),('Moto Guzzi','Колумбия'),('CFMoto','Корея'),('KTM','Корея'),('SYM','Корея'),('Indian','Литва'),('Piaggio','Мексика'),('Урал','Россия'),('Triumph','Румыния'),('Baltomotors','США'),('Harley-Davidson','США'),('Royal Enfield','США'),('Минск','Украина'),('Husqvarna','Швейцария'),('Honda','Япония'),('Kawasaki','Япония'),('Suzuki','Япония'),('Vespa','Япония'),('Yamaha','Япония');
/*!40000 ALTER TABLE `manufacturer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `model`
--

DROP TABLE IF EXISTS `model`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `model` (
  `Name_model` varchar(45) NOT NULL,
  PRIMARY KEY (`Name_model`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `model`
--

LOCK TABLES `model` WRITE;
/*!40000 ALTER TABLE `model` DISABLE KEYS */;
INSERT INTO `model` VALUES ('1290 Super Duke GT'),('1299 Panigale S'),('California 1400 Touring SE'),('Chief Vintage'),('Chieftan'),('CVO Limited'),('CVO Road Glide Ultra'),('CVO Street Glide'),('Diavel Titanium'),('Electra Glide Ultra Classic'),('F800GSA'),('GSX-R750'),('Iron 883'),('Low Rider'),('Ninja H2R'),('Panigale R'),('Road Glide Special'),('Roadmaster'),('Scout'),('Scrambler Full Throttle'),('Street Triple RS'),('SuperSport'),('Thruxton 1200'),('Thunderbird Commander'),('Tiger Explorer 1200 XC'),('TMAX DX'),('Tri Glide Ultra'),('Trophy SE'),('Ultra Limited'),('Vegas'),('VFR800F'),('Vision Tour'),('Wide Glide'),('Z900RS'),('ZX-10RR');
/*!40000 ALTER TABLE `model` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `motor_vehicles`
--

DROP TABLE IF EXISTS `motor_vehicles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `motor_vehicles` (
  `Article_moto` varchar(45) NOT NULL,
  `Name_moto` varchar(45) DEFAULT NULL,
  `Type_moto` varchar(45) DEFAULT NULL,
  `Model` varchar(45) DEFAULT NULL,
  `Manufacturer` varchar(45) DEFAULT NULL,
  `Color` varchar(45) DEFAULT NULL,
  `Quantity` varchar(45) DEFAULT NULL,
  `Cost` varchar(45) DEFAULT NULL,
  `Status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Article_moto`),
  KEY `Type_idx` (`Type_moto`),
  KEY `Model_idx` (`Model`),
  KEY `Color_idx` (`Color`),
  KEY `Status3_idx` (`Status`),
  KEY `Proiz_idx` (`Manufacturer`),
  CONSTRAINT `Color` FOREIGN KEY (`Color`) REFERENCES `color` (`Name_color`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `Model` FOREIGN KEY (`Model`) REFERENCES `model` (`Name_model`),
  CONSTRAINT `Proiz` FOREIGN KEY (`Manufacturer`) REFERENCES `manufacturer` (`Name`),
  CONSTRAINT `Status3` FOREIGN KEY (`Status`) REFERENCES `status` (`Name_status`),
  CONSTRAINT `Type` FOREIGN KEY (`Type_moto`) REFERENCES `type_moto` (`Name_type`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `motor_vehicles`
--

LOCK TABLES `motor_vehicles` WRITE;
/*!40000 ALTER TABLE `motor_vehicles` DISABLE KEYS */;
INSERT INTO `motor_vehicles` VALUES ('0A','Z900RS','Супербайк','Vegas','BMW','Бежевый','20','4250000.00','Активен'),('11A','Chieftan','Скрэмблер','Chieftan','Zero','Бисквит','5','4500000.00','Активен'),('12A','F800GSA','Круизер','F800GSA','Sachs','Бежевый','15','1100000.00','Активен'),('1A','1290 Super Duke GT','Круизер','1290 Super Duke GT','Aprilia','Чёрный','15','1700000.00','Активен'),('2A','1299 Panigale S','Круизер','1299 Panigale S','Aprilia','Белый','10','1300000.00','Активен'),('3A','California 1400 Touring SE','Пауэр','California 1400 Touring SE','Derbi','Золотой','10','2000000.00','Активен'),('4A','Chief Vintage','Скрэмблер','Chief Vintage','Honda','Оранжевый','5','2000000.00','Активен'),('5A','Chieftan','Скрэмблер','Chieftan','Royal Enfield','Оранжевый','7','3000000.00','Активен'),('6A','Ninja H2R','Супербайк','Ninja H2R','BMW','Морская волна','3','7500000.00','Активен'),('7A','Roadmaster','Спортбайк','Roadmaster','Aprilia','Коричневый','3','1500000.00','Активен'),('8A','Street Triple RS','Спорт-турер','Street Triple RS','Yamaha','Морская волна','22','3250000.00','Активен'),('9A','Vegas','Классический','Vegas','Suzuki','Жёлто-зелёный','20','250000.00','Активен');
/*!40000 ALTER TABLE `motor_vehicles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payment_type`
--

DROP TABLE IF EXISTS `payment_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payment_type` (
  `Payment_type` varchar(45) NOT NULL,
  PRIMARY KEY (`Payment_type`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment_type`
--

LOCK TABLES `payment_type` WRITE;
/*!40000 ALTER TABLE `payment_type` DISABLE KEYS */;
INSERT INTO `payment_type` VALUES ('Безналичный'),('Наличный');
/*!40000 ALTER TABLE `payment_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role` (
  `Name_role` varchar(45) NOT NULL,
  PRIMARY KEY (`Name_role`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES ('Администратор'),('Директор'),('Менеджер');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sales`
--

DROP TABLE IF EXISTS `sales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sales` (
  `id_Sales` int NOT NULL AUTO_INCREMENT,
  `Workers` varchar(45) DEFAULT NULL,
  `Clients` varchar(45) DEFAULT NULL,
  `Moto` varchar(45) DEFAULT NULL,
  `Quantity` varchar(45) DEFAULT NULL,
  `Cost` varchar(45) DEFAULT NULL,
  `Payment_type` varchar(45) DEFAULT NULL,
  `Final_price` varchar(45) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  PRIMARY KEY (`id_Sales`),
  KEY `Moto1_idx` (`Moto`),
  KEY `payment type_idx` (`Payment_type`),
  KEY `Client_idx` (`Clients`),
  KEY `Workers_idx` (`Workers`),
  CONSTRAINT `Client` FOREIGN KEY (`Clients`) REFERENCES `clients` (`Phone_number`),
  CONSTRAINT `Moto1` FOREIGN KEY (`Moto`) REFERENCES `motor_vehicles` (`Article_moto`),
  CONSTRAINT `payment type` FOREIGN KEY (`Payment_type`) REFERENCES `payment_type` (`Payment_type`),
  CONSTRAINT `Workers` FOREIGN KEY (`Workers`) REFERENCES `workers` (`Login`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sales`
--

LOCK TABLES `sales` WRITE;
/*!40000 ALTER TABLE `sales` DISABLE KEYS */;
INSERT INTO `sales` VALUES (1,'m','+7(915)123-12-33','9A','1','250000.00','Наличный','250000.00','2021-06-14'),(2,'m','+7(916)555-55-55','11A','3','4500000.00','Наличный','13500000.00','2021-06-17'),(3,'m','+7(978)583-55-78','0A','5','4250000.00','Наличный','21250000.00','2021-06-17');
/*!40000 ALTER TABLE `sales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `status`
--

DROP TABLE IF EXISTS `status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `status` (
  `Name_status` varchar(45) NOT NULL,
  PRIMARY KEY (`Name_status`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status`
--

LOCK TABLES `status` WRITE;
/*!40000 ALTER TABLE `status` DISABLE KEYS */;
INSERT INTO `status` VALUES ('Активен'),('Не активен'),('Удален');
/*!40000 ALTER TABLE `status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `type_moto`
--

DROP TABLE IF EXISTS `type_moto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `type_moto` (
  `Name_type` varchar(45) NOT NULL,
  PRIMARY KEY (`Name_type`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `type_moto`
--

LOCK TABLES `type_moto` WRITE;
/*!40000 ALTER TABLE `type_moto` DISABLE KEYS */;
INSERT INTO `type_moto` VALUES ('Боббер'),('Драгстер'),('Дрессер'),('Классический'),('Кроссовый'),('Круизер'),('Минибайк'),('Неоклассик'),('Пауэр'),('Скрэмблер'),('Спидвей'),('Спорт-турер'),('Спортбайк'),('Супербайк'),('Туристический '),('Чоппер'),('Электроцикл'),('Эндуро');
/*!40000 ALTER TABLE `type_moto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `workers`
--

DROP TABLE IF EXISTS `workers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `workers` (
  `Login` varchar(45) NOT NULL,
  `Password` varchar(45) DEFAULT NULL,
  `Surname` varchar(45) DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Lastname` varchar(45) DEFAULT NULL,
  `Role` varchar(45) DEFAULT NULL,
  `Gender` varchar(45) DEFAULT NULL,
  `Status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Login`),
  UNIQUE KEY `Login_UNIQUE` (`Login`),
  KEY `Role_idx` (`Role`),
  KEY `Role1_idx` (`Role`),
  KEY `Gender1_idx` (`Gender`),
  KEY `Status1_idx` (`Status`),
  CONSTRAINT `Gender1` FOREIGN KEY (`Gender`) REFERENCES `gender` (`Name_gender`),
  CONSTRAINT `Role1` FOREIGN KEY (`Role`) REFERENCES `role` (`Name_role`),
  CONSTRAINT `Status1` FOREIGN KEY (`Status`) REFERENCES `status` (`Name_status`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `workers`
--

LOCK TABLES `workers` WRITE;
/*!40000 ALTER TABLE `workers` DISABLE KEYS */;
INSERT INTO `workers` VALUES ('a','a','Титов','Артём','Андреевич','Администратор','М','Активен'),('d','d','Матвеев','Денис','Алексеевич','Директор','М','Активен'),('m','m','Киркоров','Максим','Алексеевич','Менеджер','М','Активен');
/*!40000 ALTER TABLE `workers` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-17  9:31:24
