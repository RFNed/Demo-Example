-- phpMyAdmin SQL Dump
-- version 5.2.2
-- https://www.phpmyadmin.net/
--
-- Хост: MySQL-8.4:3306
-- Время создания: Мар 19 2026 г., 19:22
-- Версия сервера: 8.4.6
-- Версия PHP: 8.4.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `demo`
--

-- --------------------------------------------------------

--
-- Структура таблицы `building`
--

CREATE TABLE `building` (
  `id` int NOT NULL,
  `postal_code` int DEFAULT NULL,
  `city` varchar(22) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `street` varchar(21) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `house` varchar(3) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `building`
--

INSERT INTO `building` (`id`, `postal_code`, `city`, `street`, `house`) VALUES
(1, 420151, ' г. Лесной', ' ул. Вишневая', ' 32'),
(2, 125061, ' г. Лесной', ' ул. Подгорная', ' 8'),
(3, 630370, ' г. Лесной', ' ул. Шоссейная', ' 24'),
(4, 400562, ' г. Лесной', ' ул. Зеленая', ' 32'),
(5, 614510, ' г. Лесной', ' ул. Маяковского', ' 47'),
(6, 410542, ' г. Лесной', ' ул. Светлая', ' 46'),
(7, 620839, ' г. Лесной', ' ул. Цветочная', ' 8'),
(8, 443890, ' г. Лесной', ' ул. Коммунистическая', ' 1'),
(9, 603379, ' г. Лесной', ' ул. Спортивная', ' 46'),
(10, 603721, ' г. Лесной', ' ул. Гоголя', ' 41'),
(11, 410172, ' г. Лесной', ' ул. Северная', ' 13'),
(12, 614611, ' г. Лесной', ' ул. Молодежная', ' 50'),
(13, 454311, ' г.Лесной', ' ул. Новая', ' 19'),
(14, 660007, ' г.Лесной', ' ул. Октябрьская', ' 19'),
(15, 603036, ' г. Лесной', ' ул. Садовая', ' 4'),
(16, 394060, ' г.Лесной', ' ул. Фрунзе', ' 43'),
(17, 410661, ' г. Лесной', ' ул. Школьная', ' 50'),
(18, 625590, ' г. Лесной', ' ул. Коммунистическая', ' 20'),
(19, 625683, ' г. Лесной', ' ул. 8 Марта', NULL),
(20, 450983, ' г.Лесной', ' ул. Комсомольская', ' 26'),
(21, 394782, ' г. Лесной', ' ул. Чехова', ' 3'),
(22, 603002, ' г. Лесной', ' ул. Дзержинского', ' 28'),
(23, 450558, ' г. Лесной', ' ул. Набережная', ' 30'),
(24, 344288, ' г. Лесной', ' ул. Чехова', ' 1'),
(25, 614164, ' г.Лесной', '  ул. Степная', ' 30'),
(26, 394242, ' г. Лесной', ' ул. Коммунистическая', ' 43'),
(27, 660540, ' г. Лесной', ' ул. Солнечная', ' 25'),
(28, 125837, ' г. Лесной', ' ул. Шоссейная', ' 40'),
(29, 125703, ' г. Лесной', ' ул. Партизанская', ' 49'),
(30, 625283, ' г. Лесной', ' ул. Победы', ' 46'),
(31, 614753, ' г. Лесной', ' ул. Полевая', ' 35'),
(32, 426030, ' г. Лесной', ' ул. Маяковского', ' 44'),
(33, 450375, 'г. Лесной', 'ул. Клубная', NULL),
(34, 625560, ' г. Лесной', ' ул. Некрасова', ' 12'),
(35, 630201, ' г. Лесной', ' ул. Комсомольская', ' 17'),
(36, 190949, ' г. Лесной', ' ул. Мичурина', ' 26');

-- --------------------------------------------------------

--
-- Структура таблицы `category`
--

CREATE TABLE `category` (
  `id` int NOT NULL,
  `name` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `category`
--

INSERT INTO `category` (`id`, `name`) VALUES
(1, 'Женская обувь'),
(2, 'Мужская обувь');

-- --------------------------------------------------------

--
-- Структура таблицы `company`
--

CREATE TABLE `company` (
  `id` int NOT NULL,
  `name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `company`
--

INSERT INTO `company` (`id`, `name`) VALUES
(1, 'Kari'),
(2, 'Обувь для вас'),
(5, 'Marco Tozzi'),
(6, 'Рос'),
(7, 'Rieker'),
(8, 'Alessio Nesca'),
(9, 'CROSBY');

-- --------------------------------------------------------

--
-- Структура таблицы `orders`
--

CREATE TABLE `orders` (
  `order_id` int NOT NULL,
  `order_date` varchar(10) DEFAULT NULL,
  `delivery_date` varchar(10) DEFAULT NULL,
  `address` int DEFAULT NULL,
  `client` int DEFAULT NULL,
  `code_access` int DEFAULT NULL,
  `status` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `orders`
--

INSERT INTO `orders` (`order_id`, `order_date`, `delivery_date`, `address`, `client`, `code_access`, `status`) VALUES
(1, '27.02.2025', '20.04.2025', 1, 4, 901, 2),
(2, '28.09.2022', '21.04.2025', 11, 1, 902, 2),
(3, '21.03.2025', '22.04.2025', 2, 2, 903, 2),
(4, '20.02.2025', '23.04.2025', 11, 3, 904, 2),
(5, '17.03.2025', '24.04.2025', 2, 4, 905, 2),
(6, '01.03.2025', '25.04.2025', 15, 1, 906, 2),
(7, '30.02.2025', '26.04.2025', 3, 2, 907, 2),
(8, '31.03.2025', '27.04.2025', 19, 3, 908, 1),
(9, '02.04.2025', '28.04.2025', 5, 4, 909, 1),
(10, '03.04.2025', '29.04.2025', 19, 4, 910, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `order_details`
--

CREATE TABLE `order_details` (
  `id` int NOT NULL,
  `order_id` int DEFAULT NULL,
  `tovar_id` int DEFAULT NULL,
  `quantity` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `order_details`
--

INSERT INTO `order_details` (`id`, `order_id`, `tovar_id`, `quantity`) VALUES
(1, 1, 1, 2),
(2, 2, 3, 1),
(3, 3, 5, 10),
(4, 4, 7, 5),
(5, 5, 1, 2),
(6, 6, 3, 1),
(7, 7, 5, 10),
(8, 8, 7, 5),
(9, 9, 9, 5),
(10, 10, 11, 5),
(11, 1, 2, 2),
(12, 2, 4, 1),
(13, 3, 6, 10),
(14, 4, 8, 4),
(15, 5, 2, 2),
(16, 6, 4, 1),
(17, 7, 6, 10),
(18, 8, 8, 4),
(19, 9, 10, 1),
(20, 10, 12, 5);

-- --------------------------------------------------------

--
-- Структура таблицы `roles`
--

CREATE TABLE `roles` (
  `id` int NOT NULL,
  `name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `roles`
--

INSERT INTO `roles` (`id`, `name`) VALUES
(1, 'Администратор'),
(2, 'Менеджер'),
(3, 'Авторизированный клиент');

-- --------------------------------------------------------

--
-- Структура таблицы `status_order`
--

CREATE TABLE `status_order` (
  `id` int NOT NULL,
  `name` varchar(40) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `status_order`
--

INSERT INTO `status_order` (`id`, `name`) VALUES
(1, 'Новый'),
(2, 'Завершен');

-- --------------------------------------------------------

--
-- Структура таблицы `tovar`
--

CREATE TABLE `tovar` (
  `id` int NOT NULL,
  `articul` varchar(6) DEFAULT NULL,
  `name` varchar(11) DEFAULT NULL,
  `ed_ic` varchar(3) DEFAULT NULL,
  `price` int DEFAULT NULL,
  `supplier` int DEFAULT NULL,
  `maker` int DEFAULT NULL,
  `category` int DEFAULT NULL,
  `promo` int DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  `description` varchar(71) DEFAULT NULL,
  `photo` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT 'picture.png'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `tovar`
--

INSERT INTO `tovar` (`id`, `articul`, `name`, `ed_ic`, `price`, `supplier`, `maker`, `category`, `promo`, `quantity`, `description`, `photo`) VALUES
(1, 'А112Т4', 'Ботинки', 'шт.', 4990, 1, 1, 1, 3, 6, 'Женские Ботинки демисезонные kari', '1.jpg'),
(2, 'F635R4', 'Ботинки', 'шт.', 3244, 2, 5, 1, 2, 13, 'Ботинки Marco Tozzi женские демисезонные, размер 39, цвет бежевый', '2.jpg'),
(3, 'H782T5', 'Туфли', 'шт.', 4499, 1, 1, 2, 4, 5, 'Туфли kari мужские классика MYZ21AW-450A, размер 43, цвет: черный', '3.jpg'),
(4, 'G783F5', 'Ботинки', 'шт.', 5900, 1, 6, 2, 2, 8, 'Мужские ботинки Рос-Обувь кожаные с натуральным мехом', '4.jpg'),
(5, 'J384T6', 'Ботинки', 'шт.', 3800, 2, 7, 2, 2, 16, 'B3430/14 Полуботинки мужские Rieker', '5.jpg'),
(6, 'D572U8', 'Кроссовки', 'шт.', 4100, 2, 6, 2, 3, 6, '129615-4 Кроссовки мужские', '6.jpg'),
(7, 'F572H7', 'Туфли', 'шт.', 2700, 1, 5, 1, 2, 14, 'Туфли Marco Tozzi женские летние, размер 39, цвет черный', '7.jpg'),
(8, 'D329H3', 'Полуботинки', 'шт.', 1890, 2, 8, 1, 4, 4, 'Полуботинки Alessio Nesca женские 3-30797-47, размер 37, цвет: бордовый', '8.jpg'),
(9, 'B320R5', 'Туфли', 'шт.', 4300, 1, 7, 1, 2, 6, 'Туфли Rieker женские демисезонные, размер 41, цвет коричневый', '9.jpg'),
(10, 'G432E4', 'Туфли', 'шт.', 2800, 1, 1, 1, 3, 15, 'Туфли kari женские TR-YR-413017, размер 37, цвет: черный', '10.jpg'),
(11, 'S213E3', 'Полуботинки', 'шт.', 2156, 2, 9, 2, 3, 6, '407700/01-01 Полуботинки мужские CROSBY', 'picture.png'),
(12, 'E482R4', 'Полуботинки', 'шт.', 1800, 1, 1, 1, 2, 14, 'Полуботинки kari женские MYZ20S-149, размер 41, цвет: черный', 'picture.png'),
(13, 'S634B5', 'Кеды', 'шт.', 5500, 2, 9, 2, 3, 0, 'Кеды Caprice мужские демисезонные, размер 42, цвет черный', 'picture.png'),
(14, 'K345R4', 'Полуботинки', 'шт.', 2100, 2, 9, 2, 2, 3, '407700/01-02 Полуботинки мужские CROSBY', 'picture.png'),
(15, 'O754F4', 'Туфли', 'шт.', 5400, 2, 7, 1, 4, 18, 'Туфли женские демисезонные Rieker артикул 55073-68/37', 'picture.png'),
(16, 'G531F4', 'Ботинки', 'шт.', 6600, 1, 1, 1, 12, 9, 'Ботинки женские зимние ROMER арт. 893167-01 Черный', 'picture.png'),
(17, 'J542F5', 'Тапочки', 'шт.', 500, 1, 1, 2, 13, 0, 'Тапочки мужские Арт.70701-55-67син р.41', 'picture.png'),
(18, 'B431R5', 'Ботинки', 'шт.', 2700, 2, 7, 2, 2, 5, 'Мужские кожаные ботинки/мужские ботинки', 'picture.png'),
(19, 'P764G4', 'Туфли', 'шт.', 6800, 1, 9, 1, 15, 15, 'Туфли женские, ARGO, размер 38', 'picture.png'),
(20, 'C436G5', 'Ботинки', 'шт.', 10200, 1, 8, 1, 15, 9, 'Ботинки женские, ARGO, размер 40', 'picture.png'),
(21, 'F427R5', 'Ботинки', 'шт.', 11800, 2, 7, 1, 15, 11, 'Ботинки на молнии с декоративной пряжкой FRAU', 'picture.png'),
(22, 'N457T5', 'Полуботинки', 'шт.', 4600, 1, 9, 1, 3, 13, 'Полуботинки Ботинки черные зимние, мех', 'picture.png'),
(23, 'D364R4', 'Туфли', 'шт.', 12400, 1, 1, 1, 16, 5, 'Туфли Luiza Belly женские Kate-lazo черные из натуральной замши', 'picture.png'),
(24, 'S326R5', 'Тапочки', 'шт.', 9900, 2, 9, 2, 17, 15, 'Мужские кожаные тапочки \"Профиль С.Дали\" ', 'picture.png'),
(25, 'L754R4', 'Полуботинки', 'шт.', 1700, 1, 1, 1, 2, 7, 'Полуботинки kari женские WB2020SS-26, размер 38, цвет: черный', 'picture.png'),
(26, 'M542T5', 'Кроссовки', 'шт.', 2800, 2, 7, 2, 18, 3, 'Кроссовки мужские TOFA', 'picture.png'),
(27, 'D268G5', 'Туфли', 'шт.', 4399, 2, 7, 1, 3, 12, 'Туфли Rieker женские демисезонные, размер 36, цвет коричневый', 'picture.png'),
(28, 'T324F5', 'Сапоги', 'шт.', 4699, 1, 9, 1, 2, 5, 'Сапоги замша Цвет: синий', 'picture.png'),
(29, 'K358H6', 'Тапочки', 'шт.', 599, 1, 7, 2, 20, 2, 'Тапочки мужские син р.41', 'picture.png'),
(30, 'H535R5', 'Ботинки', 'шт.', 2300, 2, 7, 1, 2, 7, 'Женские Ботинки демисезонные', 'picture.png');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int NOT NULL,
  `role_id` int NOT NULL,
  `name` varchar(29) DEFAULT NULL,
  `login` varchar(21) DEFAULT NULL,
  `passw` varchar(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `role_id`, `name`, `login`, `passw`) VALUES
(1, 1, 'Никифорова Весения Николаевна', '94d5ous@gmail.com', 'uzWC67'),
(2, 1, 'Сазонов Руслан Германович', 'uth4iz@mail.com', '2L6KZG'),
(3, 1, 'Одинцов Серафим Артёмович', 'yzls62@outlook.com', 'JlFRCZ'),
(4, 2, 'Степанов Михаил Артёмович', '1diph5e@tutanota.com', '8ntwUp'),
(5, 2, 'Ворсин Петр Евгеньевич', 'tjde7c@yahoo.com', 'YOyhfR'),
(6, 2, 'Старикова Елена Павловна', 'wpmrc3do@tutanota.com', 'RSbvHv'),
(7, 3, 'Михайлюк Анна Вячеславовна', '5d4zbu@tutanota.com', 'rwVDh9'),
(8, 3, 'Ситдикова Елена Анатольевна', 'ptec8ym@yahoo.com', 'LdNyos'),
(9, 3, 'Ворсин Петр Евгеньевич', '1qz4kw@mail.com', 'gynQMT'),
(10, 3, 'Старикова Елена Павловна', '4np6se@mail.com', 'AtnDjr'),
(11, 1, '123', '123', '123');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `building`
--
ALTER TABLE `building`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `company`
--
ALTER TABLE `company`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`order_id`),
  ADD KEY `client` (`client`),
  ADD KEY `status` (`status`),
  ADD KEY `address` (`address`);

--
-- Индексы таблицы `order_details`
--
ALTER TABLE `order_details`
  ADD PRIMARY KEY (`id`),
  ADD KEY `order_id` (`order_id`),
  ADD KEY `tovar_id` (`tovar_id`);

--
-- Индексы таблицы `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `status_order`
--
ALTER TABLE `status_order`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `tovar`
--
ALTER TABLE `tovar`
  ADD PRIMARY KEY (`id`),
  ADD KEY `category` (`category`),
  ADD KEY `maker` (`maker`),
  ADD KEY `supplier` (`supplier`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD KEY `role_id` (`role_id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `building`
--
ALTER TABLE `building`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT для таблицы `category`
--
ALTER TABLE `category`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `company`
--
ALTER TABLE `company`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT для таблицы `orders`
--
ALTER TABLE `orders`
  MODIFY `order_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT для таблицы `order_details`
--
ALTER TABLE `order_details`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT для таблицы `roles`
--
ALTER TABLE `roles`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `status_order`
--
ALTER TABLE `status_order`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `tovar`
--
ALTER TABLE `tovar`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`client`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`status`) REFERENCES `status_order` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `orders_ibfk_3` FOREIGN KEY (`address`) REFERENCES `building` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `order_details`
--
ALTER TABLE `order_details`
  ADD CONSTRAINT `order_details_ibfk_1` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `order_details_ibfk_2` FOREIGN KEY (`tovar_id`) REFERENCES `tovar` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `tovar`
--
ALTER TABLE `tovar`
  ADD CONSTRAINT `tovar_ibfk_1` FOREIGN KEY (`category`) REFERENCES `category` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tovar_ibfk_2` FOREIGN KEY (`maker`) REFERENCES `company` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tovar_ibfk_3` FOREIGN KEY (`supplier`) REFERENCES `company` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`role_id`) REFERENCES `roles` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
