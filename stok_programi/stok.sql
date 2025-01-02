/*
Navicat MySQL Data Transfer

Source Server         : myo
Source Server Version : 50505
Source Host           : localhost:3306
Source Database       : stok

Target Server Type    : MYSQL
Target Server Version : 50505
File Encoding         : 65001

Date: 2023-05-31 13:07:52
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `musteri_tablosu`
-- ----------------------------
DROP TABLE IF EXISTS `musteri_tablosu`;
CREATE TABLE `musteri_tablosu` (
  `m_sira` int(11) NOT NULL AUTO_INCREMENT,
  `m_tc_no` varchar(11) COLLATE utf8_turkish_ci NOT NULL,
  `m_isim` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `m_firma_ismi` varchar(30) COLLATE utf8_turkish_ci DEFAULT NULL,
  `m_tel` varchar(11) COLLATE utf8_turkish_ci NOT NULL,
  `m_adres` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `m_mail` varchar(25) COLLATE utf8_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`m_sira`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- ----------------------------
-- Records of musteri_tablosu
-- ----------------------------
INSERT INTO `musteri_tablosu` VALUES ('1', '11111111444', 'Ali Hesap', '', '03241111111', 'Papatya Sok. No:3 Mersin', 'ali@hesap.com');
INSERT INTO `musteri_tablosu` VALUES ('2', '11111111114', 'Veli Satar', 'Berber Veli', '03242222222', '1. Sokak No:1 Mersin', 'saticiveli@xmail.com');
INSERT INTO `musteri_tablosu` VALUES ('3', '11111111116', 'Mehmet Kale', 'Kale Ticaret', '03244444444', 'Kalekoy No:3 Mersin', 'kale@mehmet.com');
INSERT INTO `musteri_tablosu` VALUES ('4', '11111111112', 'Ali Kale', '', '03241111111', 'Kale Köy Kule Sokak No:1', 'ali@kale.com');

-- ----------------------------
-- Table structure for `stok_tablosu`
-- ----------------------------
DROP TABLE IF EXISTS `stok_tablosu`;
CREATE TABLE `stok_tablosu` (
  `s_sira` int(11) NOT NULL AUTO_INCREMENT,
  `s_u_seri` varchar(10) COLLATE utf8_turkish_ci NOT NULL,
  `s_m_tc` varchar(11) COLLATE utf8_turkish_ci NOT NULL,
  `s_miktar` decimal(10,2) NOT NULL,
  `s_fiyat` decimal(10,2) NOT NULL,
  `s_tutar` decimal(10,2) NOT NULL,
  `s_al_sat` varchar(5) COLLATE utf8_turkish_ci NOT NULL,
  `s_tarih` date NOT NULL,
  `s_saat` time NOT NULL,
  PRIMARY KEY (`s_sira`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- ----------------------------
-- Records of stok_tablosu
-- ----------------------------
INSERT INTO `stok_tablosu` VALUES ('1', 'USB101', '11111111444', '2.00', '150.00', '300.00', 'AL', '2023-05-09', '11:21:00');
INSERT INTO `stok_tablosu` VALUES ('2', 'USB101', '11111111444', '1.00', '150.00', '150.00', 'AL', '2023-05-09', '11:33:00');
INSERT INTO `stok_tablosu` VALUES ('3', 'USB101', '11111111116', '2.00', '150.00', '300.00', 'AL', '2023-05-09', '11:40:00');
INSERT INTO `stok_tablosu` VALUES ('4', 'USB101', '11111111444', '2.00', '150.00', '300.00', 'AL', '2023-05-09', '11:41:00');
INSERT INTO `stok_tablosu` VALUES ('5', 'USB101', '11111111444', '2.00', '150.00', '300.00', 'AL', '2023-05-09', '11:41:00');
INSERT INTO `stok_tablosu` VALUES ('6', 'PRN001', '11111111444', '1.00', '1950.00', '1950.00', 'SAT', '2023-05-09', '12:28:00');
INSERT INTO `stok_tablosu` VALUES ('7', 'KLM002', '11111111116', '5.00', '7.00', '35.00', 'SAT', '2023-05-09', '12:34:00');
INSERT INTO `stok_tablosu` VALUES ('8', 'USB101', '11111111444', '3.00', '150.00', '450.00', 'AL', '2023-05-09', '13:01:00');
INSERT INTO `stok_tablosu` VALUES ('9', 'PRN001', '11111111114', '3.00', '1500.00', '4500.00', 'AL', '2023-05-11', '11:44:03');
INSERT INTO `stok_tablosu` VALUES ('10', 'KLM002', '11111111444', '15.00', '7.00', '107.00', 'SAT', '2023-05-11', '11:48:10');
INSERT INTO `stok_tablosu` VALUES ('11', 'KLM002', '11111111116', '12.00', '7.00', '85.80', 'SAT', '2023-05-11', '11:49:10');
INSERT INTO `stok_tablosu` VALUES ('12', 'USB101', '11111111114', '2.00', '150.00', '300.00', 'AL', '2023-11-05', '15:11:55');
INSERT INTO `stok_tablosu` VALUES ('13', 'KLM055', '11111111114', '5.00', '3.50', '17.50', 'AL', '2023-05-11', '15:16:27');
INSERT INTO `stok_tablosu` VALUES ('14', 'KLM002', '11111111114', '3.00', '5.00', '16.50', 'AL', '2023-05-11', '15:21:27');
INSERT INTO `stok_tablosu` VALUES ('15', 'KLM055', '11111111116', '3.00', '4.55', '13.65', 'SAT', '2023-05-11', '15:29:56');
INSERT INTO `stok_tablosu` VALUES ('16', 'KLM002', '11111111444', '5.00', '5.50', '27.00', 'AL', '2023-05-18', '10:25:00');
INSERT INTO `stok_tablosu` VALUES ('17', 'BRD001', '11111111114', '100.00', '1.00', '100.00', 'AL', '2023-05-24', '12:35:00');
INSERT INTO `stok_tablosu` VALUES ('18', 'BRD001', '11111111116', '33.00', '1.30', '42.90', 'SAT', '2023-05-24', '12:36:00');
INSERT INTO `stok_tablosu` VALUES ('19', 'KLM002', '11111111116', '50.00', '5.50', '220.00', 'AL', '2023-05-25', '14:22:00');
INSERT INTO `stok_tablosu` VALUES ('20', 'KLM055', '11111111114', '12.00', '3.00', '36.00', 'AL', '2023-05-31', '12:24:00');
INSERT INTO `stok_tablosu` VALUES ('21', 'BRD001', '11111111112', '12.00', '2.00', '24.00', 'AL', '2023-05-31', '12:35:00');
INSERT INTO `stok_tablosu` VALUES ('22', 'BRD001', '11111111112', '5.00', '2.00', '10.00', 'AL', '2023-05-31', '12:37:00');
INSERT INTO `stok_tablosu` VALUES ('23', 'BRD001', '11111111114', '20.00', '2.60', '52.00', 'SAT', '2023-05-31', '12:40:00');
INSERT INTO `stok_tablosu` VALUES ('24', 'KLM055', '11111111114', '15.00', '3.00', '45.00', 'AL', '2023-05-31', '12:49:00');
INSERT INTO `stok_tablosu` VALUES ('25', 'KLM055', '11111111112', '9.00', '3.90', '35.10', 'SAT', '2023-05-31', '12:52:00');
INSERT INTO `stok_tablosu` VALUES ('26', 'USB101', '11111111444', '6.00', '150.00', '900.00', 'AL', '2023-05-31', '12:52:00');
INSERT INTO `stok_tablosu` VALUES ('27', 'KLM002', '11111111114', '77.00', '7.15', '550.55', 'SAT', '2023-05-31', '13:04:00');
INSERT INTO `stok_tablosu` VALUES ('28', 'KLM002', '11111111114', '75.00', '5.50', '412.50', 'AL', '2023-05-31', '13:05:00');
INSERT INTO `stok_tablosu` VALUES ('29', 'KLM002', '11111111114', '55.00', '5.50', '302.50', 'AL', '2023-05-31', '13:06:00');

-- ----------------------------
-- Table structure for `urun_tablosu`
-- ----------------------------
DROP TABLE IF EXISTS `urun_tablosu`;
CREATE TABLE `urun_tablosu` (
  `u_sira` int(11) NOT NULL AUTO_INCREMENT,
  `u_seri` varchar(10) COLLATE utf8_turkish_ci NOT NULL,
  `u_isim` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `u_birim` varchar(10) COLLATE utf8_turkish_ci NOT NULL,
  `u_fiyat` decimal(10,2) NOT NULL,
  `u_stok_miktar` decimal(10,2) NOT NULL,
  PRIMARY KEY (`u_sira`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- ----------------------------
-- Records of urun_tablosu
-- ----------------------------
INSERT INTO `urun_tablosu` VALUES ('1', 'USB101', 'Usb Çoklayici 4xUSB3.0', 'Adet', '150.00', '20.00');
INSERT INTO `urun_tablosu` VALUES ('2', 'PRN001', 'A4 Laser Printer (siyah beyaz)', 'Adet', '1500.00', '2.00');
INSERT INTO `urun_tablosu` VALUES ('3', 'KLM055', 'Kursun Kalem', 'Adet', '3.00', '20.00');
INSERT INTO `urun_tablosu` VALUES ('4', 'KLM002', 'Silgili Kalem', 'Adet', '5.50', '79.00');
INSERT INTO `urun_tablosu` VALUES ('5', 'BRD001', 'Bardak', 'Adet', '2.00', '64.00');
