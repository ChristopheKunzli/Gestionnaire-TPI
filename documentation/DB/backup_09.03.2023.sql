-- --------------------------------------------------------
-- Hôte:                         127.0.0.1
-- Version du serveur:           10.9.2-MariaDB - mariadb.org binary distribution
-- SE du serveur:                Win64
-- HeidiSQL Version:             12.1.0.6541
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Listage de la structure de la base pour tpi-manager
CREATE DATABASE IF NOT EXISTS `tpi-manager` /*!40100 DEFAULT CHARACTER SET utf8mb3 */;
USE `tpi-manager`;

-- Listage de la structure de table tpi-manager. candidates
CREATE TABLE IF NOT EXISTS `candidates` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(100) NOT NULL,
  `lastName` varchar(100) NOT NULL,
  `firstName` varchar(100) NOT NULL,
  `Classes_id` int(11) NOT NULL,
  PRIMARY KEY (`id`,`Classes_id`),
  UNIQUE KEY `email_UNIQUE` (`email`),
  KEY `fk_Class` (`Classes_id`),
  CONSTRAINT `fk_Candidates_Classes1` FOREIGN KEY (`Classes_id`) REFERENCES `classes` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=219 DEFAULT CHARSET=utf8mb3;

-- Listage des données de la table tpi-manager.candidates : ~218 rows (environ)
INSERT INTO `candidates` (`id`, `email`, `lastName`, `firstName`, `Classes_id`) VALUES
	(1, 'Marc-Antoine.ABOUD@cpnv.ch', 'ABOUD', 'Marc-Antoine', 15),
	(2, 'Yasin-Salih.AKYUZ@cpnv.ch', 'AKYUZ', 'Yasin-Salih', 10),
	(3, 'Kathleen.ANAND@cpnv.ch', 'ANAND', 'Kathleen', 28),
	(4, 'Zacharie.ANDRE@cpnv.ch', 'ANDRE', 'Zacharie', 28),
	(5, 'Elod.ARIFI@cpnv.ch', 'ARIFI', 'Elod', 2),
	(6, 'Erfan.ASHKAN@cpnv.ch', 'ASHKAN', 'Erfan', 20),
	(7, 'Kenan.AUGSBURGER@cpnv.ch', 'AUGSBURGER', 'Kenan', 18),
	(8, 'Yanira-Aracely.AVEIGA-RODRIGUEZ@cpnv.ch', 'AVEIGA-RODRIGUEZ', 'Yanira-Aracely', 28),
	(9, 'Xavier.AZEVEDO-JESUS@cpnv.ch', 'AZEVEDO-JESUS', 'Xavier', 1),
	(10, 'Pedro.BARCHA-NETO@cpnv.ch', 'BARCHA-NETO', 'Pedro', 20),
	(11, 'Corentin-Mikael.BARDET@cpnv.ch', 'BARDET', 'Corentin-Mikael', 11),
	(12, 'Tristan.BARRAS@cpnv.ch', 'BARRAS', 'Tristan', 11),
	(13, 'Alex.BARREIRA-VIDEIRA@cpnv.ch', 'BARREIRA-VIDEIRA', 'Alex', 3),
	(14, 'Ryan.BERSIER@cpnv.ch', 'BERSIER', 'Ryan', 1),
	(15, 'Morgane.BEURET@cpnv.ch', 'BEURET', 'Morgane', 23),
	(16, 'Yoann.BONZON@cpnv.ch', 'BONZON', 'Yoann', 7),
	(17, 'Maxime.BORGEAUD@cpnv.ch', 'BORGEAUD', 'Maxime', 10),
	(18, 'Jean-Amedee.BOSCH@cpnv.ch', 'BOSCH', 'Jean-Amedee', 7),
	(19, 'Timothee-Tristan.BOSSY@cpnv.ch', 'BOSSY', 'Timothee-Tristan', 28),
	(20, 'Arthur.BOTTEMANNE@cpnv.ch', 'BOTTEMANNE', 'Arthur', 5),
	(21, 'Gaetan.BRAILLARD@cpnv.ch', 'BRAILLARD', 'Gaetan', 29),
	(22, 'Theo.BROCARD@cpnv.ch', 'BROCARD', 'Theo', 4),
	(23, 'Ken.CACCIABUE@cpnv.ch', 'CACCIABUE', 'Ken', 20),
	(24, 'Ryan.CARDAMONE@cpnv.ch', 'CARDAMONE', 'Ryan', 2),
	(25, 'Joao-Alexandre.CARVALHO-SANTOS@cpnv.ch', 'CARVALHO-SANTOS', 'Joao-Alexandre', 3),
	(26, 'Simone.CATHERINE@cpnv.ch', 'CATHERINE', 'Simone', 29),
	(27, 'Rojhat.CEYLAN@cpnv.ch', 'CEYLAN', 'Rojhat', 20),
	(28, 'Nathan.CHAUVEAU@cpnv.ch', 'CHAUVEAU', 'Nathan', 6),
	(29, 'Daniel.CHEVALLEY@cpnv.ch', 'CHEVALLEY', 'Daniel', 4),
	(30, 'Quentin.CLORY@cpnv.ch', 'CLORY', 'Quentin', 22),
	(31, 'Ian.CLOT@cpnv.ch', 'CLOT', 'Ian', 10),
	(32, 'Nathanael.COLLAUD@cpnv.ch', 'COLLAUD', 'Nathanael', 18),
	(33, 'Benjamin.CONSTANTIN@cpnv.ch', 'CONSTANTIN', 'Benjamin', 29),
	(34, 'Luke.CORNAZ@cpnv.ch', 'CORNAZ', 'Luke', 7),
	(35, 'Maikol.CORREIA-DA-SILVA@cpnv.ch', 'CORREIA-DA-SILVA', 'Maikol', 10),
	(36, 'Athos.CRUCHET@cpnv.ch', 'CRUCHET', 'Athos', 2),
	(37, 'Simon.CUANY@cpnv.ch', 'CUANY', 'Simon', 7),
	(38, 'Tiago.DA-COSTA-LOURENCO@cpnv.ch', 'DA-COSTA-LOURENCO', 'Tiago', 2),
	(39, 'Matteo.DA-CUNHA@cpnv.ch', 'DA-CUNHA', 'Matteo', 4),
	(40, 'Diogo.DA-SILVA-FERNANDES@cpnv.ch', 'DA-SILVA-FERNANDES', 'Diogo', 17),
	(41, 'David.DA-SILVA-SOARES@cpnv.ch', 'DA-SILVA-SOARES', 'David', 5),
	(42, 'Amin.DE-ABREU-JDIDI@cpnv.ch', 'DE-ABREU-JDIDI', 'Amin', 4),
	(43, 'Kevin.DE-ALMEIDA-GOMES@cpnv.ch', 'DE-ALMEIDA-GOMES', 'Kevin', 8),
	(44, 'Andre.DE-CARVALHO-VARELA-BATISTA@cpnv.ch', 'DE-CARVALHO-VARELA-BATISTA', 'Andre', 11),
	(45, 'Daniel.DE-PINHO-LOPES-FERREIRA@cpnv.ch', 'DE-PINHO-LOPES-FERREIRA', 'Daniel', 14),
	(46, 'Nathalie.DELEVAUX@cpnv.ch', 'DELEVAUX', 'Nathalie', 20),
	(47, 'Edona.DELIU@cpnv.ch', 'DELIU', 'Edona', 28),
	(48, 'Nicolas.DENARIE@cpnv.ch', 'DENARIE', 'Nicolas', 22),
	(49, 'Elodie.DEPIERRAZ@cpnv.ch', 'DEPIERRAZ', 'Elodie', 6),
	(50, 'Nora.DIZEKO@cpnv.ch', 'DIZEKO', 'Nora', 20),
	(51, 'Mathieu.DORMOND@cpnv.ch', 'DORMOND', 'Mathieu', 21),
	(52, 'Jessica.DOS-SANTOS-ANDRADE-DOMINGUES@cpnv.ch', 'DOS-SANTOS-ANDRADE-DOMINGUES', 'Jessica', 29),
	(53, 'Leo.DUTOIT@cpnv.ch', 'DUTOIT', 'Leo', 25),
	(54, 'Hadi-Alistair.EL-MOUSSAOUI@cpnv.ch', 'EL-MOUSSAOUI', 'Hadi-Alistair', 21),
	(55, 'Nolan.EVARD@cpnv.ch', 'EVARD', 'Nolan', 19),
	(56, 'Yann.FANHA-DIAS@cpnv.ch', 'FANHA-DIAS', 'Yann', 7),
	(57, 'Benjamin.FAVRE@cpnv.ch', 'FAVRE', 'Benjamin', 21),
	(58, 'Julien.FAVRE2@cpnv.ch', 'FAVRE2', 'Julien', 25),
	(59, 'Carlos-Miguel.FERREIRA-DA-SILVA@cpnv.ch', 'FERREIRA-DA-SILVA', 'Carlos-Miguel', 2),
	(60, 'Tibo.FERREIRA-DE-CARVALHO@cpnv.ch', 'FERREIRA-DE-CARVALHO', 'Tibo', 5),
	(61, 'Blinar.FETIU@cpnv.ch', 'FETIU', 'Blinar', 1),
	(62, 'Christophe.FONSECA-DIOGO@cpnv.ch', 'FONSECA-DIOGO', 'Christophe', 1),
	(63, 'Benjamin.FONTANA@cpnv.ch', 'FONTANA', 'Benjamin', 7),
	(64, 'Caitlin.FORSYTH@cpnv.ch', 'FORSYTH', 'Caitlin', 28),
	(65, 'Bastien.FUCARINO@cpnv.ch', 'FUCARINO', 'Bastien', 28),
	(66, 'Celine.GAILLARD@cpnv.ch', 'GAILLARD', 'Celine', 20),
	(67, 'Jeremie.GAILLARD@cpnv.ch', 'GAILLARD', 'Jeremie', 28),
	(68, 'Luca.GATTO@cpnv.ch', 'GATTO', 'Luca', 8),
	(69, 'Mateus.GEBREMICAEL@cpnv.ch', 'GEBREMICAEL', 'Mateus', 20),
	(70, 'Naomie.GERBER@cpnv.ch', 'GERBER', 'Naomie', 28),
	(71, 'Paul-Loup.GERMAIN@cpnv.ch', 'GERMAIN', 'Paul-Loup', 6),
	(72, 'Theo.GHIELMINI@cpnv.ch', 'GHIELMINI', 'Theo', 11),
	(73, 'Loic.GIGANDET@cpnv.ch', 'GIGANDET', 'Loic', 1),
	(74, 'Martin.GLAUSER@cpnv.ch', 'GLAUSER', 'Martin', 13),
	(75, 'Gabriel.GLOOR@cpnv.ch', 'GLOOR', 'Gabriel', 17),
	(76, 'Vanessa.GOMES-DOS-SANTOS@cpnv.ch', 'GOMES-DOS-SANTOS', 'Vanessa', 28),
	(77, 'Joao-Pedro.GONCALVES-AIRES@cpnv.ch', 'GONCALVES-AIRES', 'Joao-Pedro', 12),
	(78, 'Sylvie.GONZALEZ-FIDALGO@cpnv.ch', 'GONZALEZ-FIDALGO', 'Sylvie', 28),
	(79, 'Andreas.GRANADA@cpnv.ch', 'GRANADA', 'Andreas', 8),
	(80, 'Adam.GRUBER@cpnv.ch', 'GRUBER', 'Adam', 9),
	(81, 'Quentin.GUEISSAZ@cpnv.ch', 'GUEISSAZ', 'Quentin', 5),
	(82, 'Mathias.GUIGNARD@cpnv.ch', 'GUIGNARD', 'Mathias', 7),
	(83, 'Robin.GUMY@cpnv.ch', 'GUMY', 'Robin', 11),
	(84, 'Maxime.GUMY@cpnv.ch', 'GUMY', 'Maxime', 20),
	(85, 'Shanshe.GUNDISHVILI@cpnv.ch', 'GUNDISHVILI', 'Shanshe', 8),
	(86, 'Christophe.HAGER@cpnv.ch', 'HAGER', 'Christophe', 20),
	(87, 'Simao.HENRIQUES-SILVA@cpnv.ch', 'HENRIQUES-SILVA', 'Simao', 3),
	(88, 'Romain.HUMBERT-DROZ-LAURENT@cpnv.ch', 'HUMBERT-DROZ-LAURENT', 'Romain', 6),
	(89, 'Danis.IBRAHIMOVIC@cpnv.ch', 'IBRAHIMOVIC', 'Danis', 1),
	(90, 'Luca.ISELI@cpnv.ch', 'ISELI', 'Luca', 20),
	(91, 'John.JACCARD@cpnv.ch', 'JACCARD', 'John', 13),
	(92, 'Liam.JACCARD@cpnv.ch', 'JACCARD', 'Liam', 2),
	(93, 'Sacha.JACCARD@cpnv.ch', 'JACCARD', 'Sacha', 3),
	(94, 'Leo.JAQUIER@cpnv.ch', 'JAQUIER', 'Leo', 4),
	(95, 'Eliott.JAQUIER@cpnv.ch', 'JAQUIER', 'Eliott', 8),
	(96, 'Cyprien.JAQUIER@cpnv.ch', 'JAQUIER', 'Cyprien', 7),
	(97, 'Christopher-Philippe.JAUREGUI@cpnv.ch', 'JAUREGUI', 'Christopher-Philippe', 2),
	(98, 'Coralie.JENNY@cpnv.ch', 'JENNY', 'Coralie', 20),
	(99, 'Baptiste.JOLY@cpnv.ch', 'JOLY', 'Baptiste', 22),
	(100, 'Mikael.JUILLET@cpnv.ch', 'JUILLET', 'Mikael', 8),
	(101, 'Kushtrim.JUSUFI@cpnv.ch', 'JUSUFI', 'Kushtrim', 2),
	(102, 'Amine-Mohamed.KADDOURI@cpnv.ch', 'KADDOURI', 'Amine-Mohamed', 2),
	(103, 'Maria-da-Conceicao.KLEIN@cpnv.ch', 'KLEIN', 'Maria-da-Conceicao', 29),
	(104, 'Timothe.KOBEL@cpnv.ch', 'KOBEL', 'Timothe', 4),
	(105, 'Thierry.KOETSCHET@cpnv.ch', 'KOETSCHET', 'Thierry', 11),
	(106, 'Christophe.KUNZLI@cpnv.ch', 'KUNZLI', 'Christophe', 11),
	(107, 'Geraldine.LACROIX@cpnv.ch', 'LACROIX', 'Geraldine', 28),
	(108, 'Jimmy-Gia-Bao.LAM@cpnv.ch', 'LAM', 'Jimmy-Gia-Bao', 13),
	(109, 'Sara.LAMBELET@cpnv.ch', 'LAMBELET', 'Sara', 20),
	(110, 'Camilo-Ernesto.LASSO-GOMEZ@cpnv.ch', 'LASSO-GOMEZ', 'Camilo-Ernesto', 20),
	(111, 'Loe.LAVAUD@cpnv.ch', 'LAVAUD', 'Loe', 4),
	(112, 'Mahe.LAVAUD@cpnv.ch', 'LAVAUD', 'Mahe', 5),
	(113, 'Amos.LE-COQ@cpnv.ch', 'LE-COQ', 'Amos', 6),
	(114, 'Thibault.LE-NORMAND@cpnv.ch', 'LE-NORMAND', 'Thibault', 2),
	(115, 'Alexis.LEAKOS@cpnv.ch', 'LEAKOS', 'Alexis', 12),
	(116, 'Sylvain.LECHAIRE@cpnv.ch', 'LECHAIRE', 'Sylvain', 6),
	(117, 'Ivan.LECOMTE@cpnv.ch', 'LECOMTE', 'Ivan', 12),
	(118, 'Romain.LENOIR@cpnv.ch', 'LENOIR', 'Romain', 3),
	(119, 'Oliwier.LEWANDROWSKI@cpnv.ch', 'LEWANDROWSKI', 'Oliwier', 2),
	(120, 'Marina.MACHADO-CAPISTRANO-SILVA@cpnv.ch', 'MACHADO-CAPISTRANO-SILVA', 'Marina', 8),
	(121, 'Gabriel.MACHADO-PEREIRA@cpnv.ch', 'MACHADO-PEREIRA', 'Gabriel', 7),
	(122, 'Lucas.MACHARD@cpnv.ch', 'MACHARD', 'Lucas', 10),
	(123, 'Agathe.MAKUMBI-MBUKA@cpnv.ch', 'MAKUMBI-MBUKA', 'Agathe', 21),
	(124, 'Alex.MARGOT@cpnv.ch', 'MARGOT', 'Alex', 3),
	(125, 'Antoine.MARTET@cpnv.ch', 'MARTET', 'Antoine', 10),
	(126, 'Mei.MARTIN@cpnv.ch', 'MARTIN', 'Mei', 21),
	(127, 'Ethan.MARTIN@cpnv.ch', 'MARTIN', 'Ethan', 1),
	(128, 'Beatriz.MARTIN-PENALOSA@cpnv.ch', 'MARTIN-PENALOSA', 'Beatriz', 11),
	(129, 'Evann.MARTINS@cpnv.ch', 'MARTINS', 'Evann', 14),
	(130, 'Jeremy.MARZOLINI@cpnv.ch', 'MARZOLINI', 'Jeremy', 3),
	(131, 'Johan-Laurent.MATTHEY@cpnv.ch', 'MATTHEY', 'Johan-Laurent', 28),
	(132, 'Valentin.MAURER@cpnv.ch', 'MAURER', 'Valentin', 10),
	(133, 'Alessia.MAVRAJ@cpnv.ch', 'MAVRAJ', 'Alessia', 3),
	(134, 'Damien.MAYOR@cpnv.ch', 'MAYOR', 'Damien', 11),
	(135, 'Colin.MENOUD@cpnv.ch', 'MENOUD', 'Colin', 3),
	(136, 'Pierrot.METILLE@cpnv.ch', 'METILLE', 'Pierrot', 6),
	(137, 'Loik.MEYLAN@cpnv.ch', 'MEYLAN', 'Loik', 7),
	(138, 'Sara-Elodie.MEZENEN@cpnv.ch', 'MEZENEN', 'Sara-Elodie', 28),
	(139, 'Garis.MIEHLBRADT@cpnv.ch', 'MIEHLBRADT', 'Garis', 17),
	(140, 'Dunia-Alexandra.MIELE@cpnv.ch', 'MIELE', 'Dunia-Alexandra', 29),
	(141, 'Ambre.MIELLOT@cpnv.ch', 'MIELLOT', 'Ambre', 10),
	(142, 'Khalil-Amadeo.MIRANDA-JACOME@cpnv.ch', 'MIRANDA-JACOME', 'Khalil-Amadeo', 20),
	(143, 'Myline.MONDOUX@cpnv.ch', 'MONDOUX', 'Myline', 28),
	(144, 'Rui-Miguel.MONTEIRO-PEREIRA@cpnv.ch', 'MONTEIRO-PEREIRA', 'Rui-Miguel', 5),
	(145, 'Sebastien.MORAZ@cpnv.ch', 'MORAZ', 'Sebastien', 8),
	(146, 'David.MOSER@cpnv.ch', 'MOSER', 'David', 11),
	(147, 'Ahmed.MUJANOVIC@cpnv.ch', 'MUJANOVIC', 'Ahmed', 15),
	(148, 'Benjamin.MUMINOVIC@cpnv.ch', 'MUMINOVIC', 'Benjamin', 18),
	(149, 'Brad-Dylan.MUNOZ@cpnv.ch', 'MUNOZ', 'Brad-Dylan', 1),
	(150, 'Mathias.NEGA@cpnv.ch', 'NEGA', 'Mathias', 21),
	(151, 'Logan.NGUYEN@cpnv.ch', 'NGUYEN', 'Logan', 15),
	(152, 'Bersabeh.NIKODIMOS@cpnv.ch', 'NIKODIMOS', 'Bersabeh', 29),
	(153, 'Enzo.NONNENMACHER@cpnv.ch', 'NONNENMACHER', 'Enzo', 8),
	(154, 'Theo.NUSSBAUM@cpnv.ch', 'NUSSBAUM', 'Theo', 2),
	(155, 'Benjamin.OCONNER@cpnv.ch', 'OCONNER', 'Benjamin', 5),
	(156, 'Ayami.OGAY@cpnv.ch', 'OGAY', 'Ayami', 10),
	(157, 'Diogo.OLIVEIRA-SOARES@cpnv.ch', 'OLIVEIRA-SOARES', 'Diogo', 4),
	(158, 'Naidin.OMEROVIC@cpnv.ch', 'OMEROVIC', 'Naidin', 1),
	(159, 'Bibi.ONYEMACHI-MWABANA@cpnv.ch', 'ONYEMACHI-MWABANA', 'Bibi', 29),
	(160, 'Fakime-Nur.OZDEMIR@cpnv.ch', 'OZDEMIR', 'Fakime-Nur', 2),
	(161, 'Alessandra.PALUMBO@cpnv.ch', 'PALUMBO', 'Alessandra', 28),
	(162, 'Jonathan.PENARANDA-GONZALEZ@cpnv.ch', 'PENARANDA-GONZALEZ', 'Jonathan', 4),
	(163, 'Julian.PEREZ@cpnv.ch', 'PEREZ', 'Julian', 4),
	(164, 'Esteban.PEREZ-NARCISI@cpnv.ch', 'PEREZ-NARCISI', 'Esteban', 2),
	(165, 'Judah-Abishek.PERIYASAMY-GHANESHAN@cpnv.ch', 'PERIYASAMY-GHANESHAN', 'Judah-Abishek', 12),
	(166, 'Jonatan.PERRET@cpnv.ch', 'PERRET', 'Jonatan', 19),
	(167, 'Thomas.PETERMANN@cpnv.ch', 'PETERMANN', 'Thomas', 5),
	(168, 'Loic.PEYRAMAURE@cpnv.ch', 'PEYRAMAURE', 'Loic', 20),
	(169, 'Fabian.PILLONEL@cpnv.ch', 'PILLONEL', 'Fabian', 23),
	(170, 'Pedro.PINTO@cpnv.ch', 'PINTO', 'Pedro', 7),
	(171, 'Jorge-Miguel.PINTO-COSTA@cpnv.ch', 'PINTO-COSTA', 'Jorge-Miguel', 3),
	(172, 'Miguel.PINTO-GOMES@cpnv.ch', 'PINTO-GOMES', 'Miguel', 1),
	(173, 'Diego.PINTO-TOMAZ@cpnv.ch', 'PINTO-TOMAZ', 'Diego', 3),
	(174, 'Axel.PITTET@cpnv.ch', 'PITTET', 'Axel', 18),
	(175, 'Celia.POLIGNE@cpnv.ch', 'POLIGNE', 'Celia', 28),
	(176, 'Thirusan.RAJADURAI@cpnv.ch', 'RAJADURAI', 'Thirusan', 9),
	(177, 'Cecile.RAMOS@cpnv.ch', 'RAMOS', 'Cecile', 21),
	(178, 'Timothee.RAPIN@cpnv.ch', 'RAPIN', 'Timothee', 8),
	(179, 'Sven.RAVAL@cpnv.ch', 'RAVAL', 'Sven', 4),
	(180, 'Arnaud.REICHENBACH@cpnv.ch', 'REICHENBACH', 'Arnaud', 22),
	(181, 'Nuno.RIBEIRO-PEREIRA@cpnv.ch', 'RIBEIRO-PEREIRA', 'Nuno', 5),
	(182, 'Luca.RICHARD@cpnv.ch', 'RICHARD', 'Luca', 2),
	(183, 'Matheo.RISSE@cpnv.ch', 'RISSE', 'Matheo', 1),
	(184, 'Theo.RIZZO@cpnv.ch', 'RIZZO', 'Theo', 20),
	(185, 'Raphael.ROBERT@cpnv.ch', 'ROBERT', 'Raphael', 4),
	(186, 'Sam.RODRIGUES-PEREIRA@cpnv.ch', 'RODRIGUES-PEREIRA', 'Sam', 29),
	(187, 'Marc-Antoine.ROMAO@cpnv.ch', 'ROMAO', 'Marc-Antoine', 1),
	(188, 'Tobias-Luca.ROUCHE@cpnv.ch', 'ROUCHE', 'Tobias-Luca', 28),
	(189, 'Antoine.ROULIN@cpnv.ch', 'ROULIN', 'Antoine', 8),
	(190, 'Salima.RUFER@cpnv.ch', 'RUFER', 'Salima', 28),
	(191, 'Fatime.RUSINOVCI@cpnv.ch', 'RUSINOVCI', 'Fatime', 29),
	(192, 'Tiago.SANTOS@cpnv.ch', 'SANTOS', 'Tiago', 7),
	(193, 'Nicola-Marco.SCELSI@cpnv.ch', 'SCELSI', 'Nicola-Marco', 28),
	(194, 'Ethann.SCHNEIDER@cpnv.ch', 'SCHNEIDER', 'Ethann', 6),
	(195, 'Adam.SIFATE@cpnv.ch', 'SIFATE', 'Adam', 6),
	(196, 'Ajin.SIVASAMPOO@cpnv.ch', 'SIVASAMPOO', 'Ajin', 1),
	(197, 'Zachary.SMITH@cpnv.ch', 'SMITH', 'Zachary', 1),
	(198, 'Edward.STEWART@cpnv.ch', 'STEWART', 'Edward', 5),
	(199, 'Kristina.STOJADINOVIC@cpnv.ch', 'STOJADINOVIC', 'Kristina', 21),
	(200, 'Ivan.STOJILOVIC@cpnv.ch', 'STOJILOVIC', 'Ivan', 8),
	(201, 'Philippe.STRASSLE-ZUNIGA@cpnv.ch', 'STRASSLE-ZUNIGA', 'Philippe', 21),
	(202, 'Joshua.SURICO@cpnv.ch', 'SURICO', 'Joshua', 5),
	(203, 'Leo.TEIXEIRA@cpnv.ch', 'TEIXEIRA', 'Leo', 2),
	(204, 'Quentin.TIYANGOU@cpnv.ch', 'TIYANGOU', 'Quentin', 11),
	(205, 'Tina.TORRENT@cpnv.ch', 'TORRENT', 'Tina', 20),
	(206, 'Yasemin.TUGCU-GUZEL@cpnv.ch', 'TUGCU-GUZEL', 'Yasemin', 29),
	(207, 'Hajrudin.TURSUNOVIC@cpnv.ch', 'TURSUNOVIC', 'Hajrudin', 1),
	(208, 'Marcos.VALENTE-DA-SILVA@cpnv.ch', 'VALENTE-DA-SILVA', 'Marcos', 3),
	(209, 'Margot.VALIN@cpnv.ch', 'VALIN', 'Margot', 21),
	(210, 'Youri.VILLIGER@cpnv.ch', 'VILLIGER', 'Youri', 15),
	(211, 'Sacha.VOLERY@cpnv.ch', 'VOLERY', 'Sacha', 4),
	(212, 'Sven.VOLERY@cpnv.ch', 'VOLERY', 'Sven', 7),
	(213, 'Gwenael.WEST@cpnv.ch', 'WEST', 'Gwenael', 8),
	(214, 'Valentin.WILHEM@cpnv.ch', 'WILHEM', 'Valentin', 5),
	(215, 'Matthieu.WIRZ@cpnv.ch', 'WIRZ', 'Matthieu', 10),
	(216, 'Muamer.ZAHIROVIC@cpnv.ch', 'ZAHIROVIC', 'Muamer', 27),
	(217, 'Nadia.ZARGUI-MEHRAZ@cpnv.ch', 'ZARGUI-MEHRAZ', 'Nadia', 28),
	(218, 'Pablo-Fernando.ZUBIETA-RODRIGUEZ@cpnv.ch', 'ZUBIETA-RODRIGUEZ', 'Pablo-Fernando', 11);

-- Listage de la structure de table tpi-manager. classes
CREATE TABLE IF NOT EXISTS `classes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(10) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `name_UNIQUE` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb3;

-- Listage des données de la table tpi-manager.classes : ~29 rows (environ)
INSERT INTO `classes` (`id`, `name`) VALUES
	(1, 'SI-C1a'),
	(2, 'SI-C1b'),
	(3, 'SI-C2a'),
	(4, 'SI-C2b'),
	(5, 'SI-C3a'),
	(6, 'SI-C3b'),
	(7, 'SI-C4a'),
	(8, 'SI-C4b'),
	(9, 'SI-C4r'),
	(10, 'SI-CA1a'),
	(11, 'SI-CA2a'),
	(12, 'SI-MI1a'),
	(13, 'SI-MI1b'),
	(14, 'SI-MI2a'),
	(15, 'SI-MI2b'),
	(16, 'SI-MI3a'),
	(17, 'SI-MI3b'),
	(18, 'SI-MI4a'),
	(19, 'SI-MI4b'),
	(20, 'SM-CA1a'),
	(21, 'SM-CA2a'),
	(22, 'SP-CA1a'),
	(23, 'SP-CA2a'),
	(24, 'YA-CA1a'),
	(25, 'YA-CA2a'),
	(26, 'YAD-CA2a'),
	(27, 'YAD-CA4a'),
	(28, 'YS-CA2a'),
	(29, 'YS-CA2b');

-- Listage de la structure de table tpi-manager. collaborators
CREATE TABLE IF NOT EXISTS `collaborators` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(100) NOT NULL,
  `acronym` varchar(3) NOT NULL,
  `lastName` varchar(100) NOT NULL,
  `firstName` varchar(100) NOT NULL,
  `isResponsableTPI` tinyint(4) NOT NULL DEFAULT 0,
  `password` varchar(255) NOT NULL DEFAULT '1234',
  PRIMARY KEY (`id`),
  UNIQUE KEY `email_UNIQUE` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb3;

-- Listage des données de la table tpi-manager.collaborators : ~44 rows (environ)
INSERT INTO `collaborators` (`id`, `email`, `acronym`, `lastName`, `firstName`, `isResponsableTPI`, `password`) VALUES
	(1, 'patrick.altieri@cpnv.ch', 'PAI', 'ALTIERI', 'Patrick', 0, 'Pa$$w0rd'),
	(2, 'Frederique.ANDOLFATTO@cpnv.ch', 'FAO', 'ANDOLFATTO', 'Frederique', 0, '1234'),
	(3, 'pascal.benzonana@cpnv.ch', 'PBA', 'BENZONANA', 'Pascal', 0, 'Pa$$w0rd'),
	(4, 'claude-chantal.blanc@cpnv.ch', 'CBC', 'BLANC', 'Claude Chantal', 0, '1234'),
	(5, 'eric.bouthiaux@cpnv.ch', 'EBX', 'BOUTHIAUX', 'Eric', 0, '1234'),
	(6, 'blaise.brocard@cpnv.ch', 'BBD', 'BROCARD', 'Blaise', 0, '1234'),
	(7, 'Yann.CHARRERE@cpnv.ch', 'YCE', 'CHARRERE', 'Yann', 0, '1234'),
	(8, 'jean-philippe.chavey@cpnv.ch', 'JCY', 'CHAVEY', 'Jean-Philippe', 0, '1234'),
	(9, 'gabriel.cimenti@cpnv.ch', 'GCI', 'CIMENTI', 'Gabriel', 0, '1234'),
	(10, 'christine.codourey@cpnv.ch', 'CCY', 'CODOUREY', 'Christine', 0, '1234'),
	(11, 'Massimiliano.CRICCO@cpnv.ch', 'MCO', 'CRICCO', 'Massimiliano', 0, '1234'),
	(12, 'marc.dafflon@cpnv.ch', 'MDN', 'DAFFLON', 'Marc', 0, '1234'),
	(13, 'thierry.de-heller@cpnv.ch', 'TDR', 'DE HELLER', 'Thierry', 0, '1234'),
	(14, 'Ana.DE-LAMEGO-RESENDE@cpnv.ch', 'ARE', 'DE-LAMEGO-RESENDE', 'Ana', 0, '1234'),
	(15, 'stephane.delaporte@cpnv.ch', 'SDE', 'DELAPORTE', 'Stéphane', 0, '1234'),
	(16, 'Valerie.DILLET@cpnv.ch', 'VDT', 'DILLET', 'Valerie', 0, '1234'),
	(17, 'sylvain.fasola@cpnv.ch', 'SFA', 'FASOLA', 'Sylvain', 0, '1234'),
	(18, 'raphael.favre@cpnv.ch', 'RFA', 'FAVRE', 'Raphaël', 0, '1234'),
	(19, 'Olivia.FERRIERO@cpnv.ch', 'OFO', 'FERRIERO', 'Olivia', 0, '1234'),
	(20, 'Nicolas.GLASSEY@cpnv.ch', 'NGY', 'GLASSEY', 'Nicolas', 0, '1234'),
	(21, 'Yoachim.GRABER@cpnv.ch', 'YGR', 'GRABER', 'Yoachim', 0, '1234'),
	(22, 'Cindy.HARDEGGER@cpnv.ch', 'CHA', 'HARDEGGER', 'Cindy', 1, 'Pa$$w0rd'),
	(23, 'pascal.hurni@cpnv.ch', 'PHI', 'HURNI', 'Pascal', 0, '1234'),
	(24, 'Julien.ITHURBIDE@cpnv.ch', 'JIE', 'ITHURBIDE', 'Julien', 0, '1234'),
	(25, 'laurent.jaggi@cpnv.ch', 'LJI', 'JAGGI', 'Laurent', 0, '1234'),
	(26, 'charles-henri.kohli@cpnv.ch', 'CKI', 'KOHLI', 'Charles-Henri', 0, '1234'),
	(27, 'Yawo.KONOUTSE@cpnv.ch', 'YKE', 'KONOUTSE', 'Yawo', 0, '1234'),
	(28, 'Agnes.LAYAZ@cpnv.ch', 'ALZ', 'LAYAZ', 'Agnes', 0, '1234'),
	(29, 'sophie-helene.martin@cpnv.ch', 'SMM', 'MARTIN', 'Sophie-Hélène', 0, '1234'),
	(30, 'Joelle.MATTER@cpnv.ch', 'JMR', 'MATTER', 'Joëlle', 0, '1234'),
	(31, 'Mathieu.MEYLAN@cpnv.ch', 'MMN', 'MEYLAN', 'Mathieu', 0, '1234'),
	(32, 'judith.mondada@cpnv.ch', 'JMA', 'MONDADA', 'Judith', 0, '1234'),
	(33, 'andre.mottier@cpnv.ch', 'AMR', 'MOTTIER', 'André', 0, '1234'),
	(34, 'Alessio.PARATA@cpnv.ch', 'APA', 'PARATA', 'Alessio', 0, '1234'),
	(35, 'claude.rochat@cpnv.ch', 'CRT', 'ROCHAT', 'Claude', 0, '1234'),
	(36, 'monika.ryser@cpnv.ch', 'MRY', 'RYSER', 'Monika', 0, '1234'),
	(37, 'yann.saison@cpnv.ch', 'YSN', 'SAISON', 'Yann', 0, '1234'),
	(38, 'Julien.SAVARY@cpnv.ch', 'JSY', 'SAVARY', 'Julien', 0, '1234'),
	(39, 'yvan.thiery@cpnv.ch', 'YTY', 'THIERY', 'Yvan', 0, '1234'),
	(40, 'jean-yves.tinembart@cpnv.ch', 'JTT', 'TINEMBART', 'Jean-Yves', 0, '1234'),
	(41, 'francis.varela@cpnv.ch', 'FVA', 'VARELA', 'Francis', 0, 'Pa$$w0rd'),
	(42, 'Loic.VIRET@cpnv.ch', 'LVT', 'VIRET', 'Loic', 0, '1234'),
	(43, 'didier.wulliamoz@cpnv.ch', 'DWZ', 'WULLIAMOZ', 'Didier', 0, '1234'),
	(44, 'Michael.WYSSA@cpnv.ch', 'MWA', 'WYSSA', 'Michael', 0, '1234');

-- Listage de la structure de table tpi-manager. experts
CREATE TABLE IF NOT EXISTS `experts` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(100) NOT NULL,
  `lastName` varchar(100) NOT NULL,
  `firstName` varchar(100) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `email_UNIQUE` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;

-- Listage des données de la table tpi-manager.experts : ~4 rows (environ)
INSERT INTO `experts` (`id`, `email`, `lastName`, `firstName`) VALUES
	(1, 'Jean.Paul@gmail.com', 'Paul', 'Jean'),
	(2, 'Jeanne.Pauline@gmail.com', 'Pauline', 'Jeanne'),
	(3, 'Damien.Dupont@gmail.com', 'Dupont', 'Damien'),
	(4, 'Leblanc.Dupond@gmail.com', 'Dupond', 'Leblanc');

-- Listage de la structure de table tpi-manager. technologies
CREATE TABLE IF NOT EXISTS `technologies` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `siteLink` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `name_UNIQUE` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb3;

-- Listage des données de la table tpi-manager.technologies : ~8 rows (environ)
INSERT INTO `technologies` (`id`, `name`, `siteLink`) VALUES
	(1, '.net', 'https://dotnet.microsoft.com/en-us/'),
	(2, 'c#', 'https://dotnet.microsoft.com/en-us/languages/csharp'),
	(3, 'Microsoft Visual Studio', 'https://visualstudio.microsoft.com/fr/'),
	(4, 'mariadb', 'https://mariadb.com/'),
	(5, 'git', 'https://git-scm.com/'),
	(6, 'draw.io', 'https://www.draw.io/index.html'),
	(7, 'Mysql Workbench', 'https://www.mysql.com/products/workbench/'),
	(8, 'HeidiSql', 'https://www.heidisql.com/');

-- Listage de la structure de table tpi-manager. tpi
CREATE TABLE IF NOT EXISTS `tpi` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(200) NOT NULL,
  `year` date NOT NULL,
  `remarks` varchar(2000) DEFAULT NULL,
  `duration` int(11) DEFAULT NULL,
  `CDC` varchar(200) DEFAULT NULL,
  `Candidates_id` int(11) NOT NULL,
  `Collaborators_id` int(11) NOT NULL,
  PRIMARY KEY (`id`,`Candidates_id`,`Collaborators_id`),
  UNIQUE KEY `title_UNIQUE` (`title`),
  KEY `fk_Candidate` (`Candidates_id`),
  KEY `fk_Collaborator` (`Collaborators_id`),
  CONSTRAINT `fk_TPI_Candidates1` FOREIGN KEY (`Candidates_id`) REFERENCES `candidates` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_TPI_Collaborators1` FOREIGN KEY (`Collaborators_id`) REFERENCES `collaborators` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;

-- Listage des données de la table tpi-manager.tpi : ~5 rows (environ)
INSERT INTO `tpi` (`id`, `title`, `year`, `remarks`, `duration`, `CDC`, `Candidates_id`, `Collaborators_id`) VALUES
	(1, 'Consultation et archivage des sujets donnés lors des PRE-TPI et TPI à l\'aide d\'une application c#', '2023-01-31', 'Le meilleur TPI au monde', 96, NULL, 106, 2),
	(2, 'Mise en service de GLPI avec liaison Active Directory', '2023-01-30', '', 92, NULL, 11, 41),
	(3, 'WIFI multiple SSID', '2023-01-29', NULL, 93, NULL, 146, 41),
	(4, 'Mise à jour de la solution de déploiement avec un impact minimisé, de fichiers très volumineux sur les PC d\'une salle', '2023-01-28', NULL, 94, NULL, 83, 41),
	(5, 'Déploiement de systèmes d\'exploitation Windows 10 avec le logiciel libre G4L (Ghost for Linux)', '2023-02-01', NULL, 97, NULL, 128, 41);

-- Listage de la structure de table tpi-manager. tpi_has_experts
CREATE TABLE IF NOT EXISTS `tpi_has_experts` (
  `TPI_id` int(11) NOT NULL,
  `Experts_id` int(11) NOT NULL,
  PRIMARY KEY (`TPI_id`,`Experts_id`),
  KEY `fk_Expert` (`Experts_id`),
  KEY `fk_TPI` (`TPI_id`),
  CONSTRAINT `fk_TPI_has_Experts_Experts1` FOREIGN KEY (`Experts_id`) REFERENCES `experts` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_TPI_has_Experts_TPI` FOREIGN KEY (`TPI_id`) REFERENCES `tpi` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Listage des données de la table tpi-manager.tpi_has_experts : ~4 rows (environ)
INSERT INTO `tpi_has_experts` (`TPI_id`, `Experts_id`) VALUES
	(1, 3),
	(1, 4),
	(2, 1),
	(2, 2);

-- Listage de la structure de table tpi-manager. tpi_uses_technologies
CREATE TABLE IF NOT EXISTS `tpi_uses_technologies` (
  `TPI_id` int(11) NOT NULL,
  `Technologies_id` int(11) NOT NULL,
  PRIMARY KEY (`TPI_id`,`Technologies_id`),
  KEY `fk_Technologie` (`Technologies_id`),
  KEY `fk_TPI` (`TPI_id`),
  CONSTRAINT `fk_TPI_has_Technologies_TPI1` FOREIGN KEY (`TPI_id`) REFERENCES `tpi` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_TPI_has_Technologies_Technologies1` FOREIGN KEY (`Technologies_id`) REFERENCES `technologies` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Listage des données de la table tpi-manager.tpi_uses_technologies : ~6 rows (environ)
INSERT INTO `tpi_uses_technologies` (`TPI_id`, `Technologies_id`) VALUES
	(1, 1),
	(1, 2),
	(1, 3),
	(1, 4),
	(1, 5),
	(2, 5);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
