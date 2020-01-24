/*
SQLyog Community v13.1.2 (64 bit)
MySQL - 10.1.38-MariaDB : Database - dvds
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`dvds` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `dvds`;

/*Table structure for table `dvd` */

DROP TABLE IF EXISTS `dvd`;

CREATE TABLE `dvd` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(30) DEFAULT NULL,
  `Genre` char(20) DEFAULT NULL,
  `Rating` int(11) DEFAULT NULL,
  `Maturity Level` char(3) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

/*Data for the table `dvd` */

insert  into `dvd`(`ID`,`Name`,`Genre`,`Rating`,`Maturity Level`) values 
(1,'Mission Impossible 2','Action',4,'M'),
(2,'Bob the Builder','Children',3,'G'),
(3,'Thomas the Tank Engine','Children',5,'PG'),
(4,'Hunger Games: Catching Fire','Action',1,'M'),
(5,'The Incredible Hulk','Action',3,'R13'),
(6,'Big Fat Liar','Comedy',4,'PGR'),
(7,'Ring','Horror',5,'R18'),
(8,'Harry Potter I','Adventure',5,'M'),
(9,'Harry Potter II','Adventure',2,'M'),
(10,'Harry Potter III','Adventure',3,'M'),
(11,'Harry Potter IIII','Adventure',1,'M'),
(12,'Harry Potter IIIII','Adventure',5,'R13'),
(13,'Harry Potter IIIIII','Adventure',5,'R13');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
