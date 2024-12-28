/*
 Navicat Premium Data Transfer

 Source Server         : Devel Ferdinand
 Source Server Type    : MySQL
 Source Server Version : 80040 (8.0.40)
 Source Host           : localhost:3306
 Source Schema         : mydb

 Target Server Type    : MySQL
 Target Server Version : 80040 (8.0.40)
 File Encoding         : 65001

 Date: 29/12/2024 04:17:24
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for chat
-- ----------------------------
DROP TABLE IF EXISTS `chat`;
CREATE TABLE `chat`  (
  `id` int NOT NULL AUTO_INCREMENT,
  `sender` varchar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NULL DEFAULT NULL,
  `receiver` varchar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NULL DEFAULT NULL,
  `message` text CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NULL,
  `timestamp` datetime NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `sender`(`sender` ASC) USING BTREE,
  INDEX `receiver`(`receiver` ASC) USING BTREE,
  CONSTRAINT `chat_ibfk_1` FOREIGN KEY (`sender`) REFERENCES `user` (`username`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `chat_ibfk_2` FOREIGN KEY (`receiver`) REFERENCES `user` (`username`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of chat
-- ----------------------------
INSERT INTO `chat` VALUES (1, 'ferdinand', 'test', 'Ini testing', '2024-12-29 00:16:52');
INSERT INTO `chat` VALUES (2, 'test', 'ferdinand', 'oh iya bang, oke', '2024-12-29 00:18:06');

-- ----------------------------
-- Table structure for favorite_friends
-- ----------------------------
DROP TABLE IF EXISTS `favorite_friends`;
CREATE TABLE `favorite_friends`  (
  `username` varchar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `favorite_username` varchar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`username`, `favorite_username`) USING BTREE,
  INDEX `favorite_username`(`favorite_username` ASC) USING BTREE,
  CONSTRAINT `favorite_friends_ibfk_1` FOREIGN KEY (`username`) REFERENCES `user` (`username`) ON DELETE CASCADE ON UPDATE RESTRICT,
  CONSTRAINT `favorite_friends_ibfk_2` FOREIGN KEY (`favorite_username`) REFERENCES `user` (`username`) ON DELETE CASCADE ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of favorite_friends
-- ----------------------------
INSERT INTO `favorite_friends` VALUES ('test', 'ferdinand');
INSERT INTO `favorite_friends` VALUES ('ferdinand', 'test');
INSERT INTO `favorite_friends` VALUES ('ferdinand', 'test2');
INSERT INTO `favorite_friends` VALUES ('test', 'test2');

-- ----------------------------
-- Table structure for kisahhidup
-- ----------------------------
DROP TABLE IF EXISTS `kisahhidup`;
CREATE TABLE `kisahhidup`  (
  `Organisasi_id` int NOT NULL,
  `username` varchar(40) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `thawal` varchar(4) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NULL DEFAULT NULL,
  `thakhir` varchar(4) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NULL DEFAULT NULL,
  `deskripsi` text CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NULL,
  PRIMARY KEY (`Organisasi_id`, `username`) USING BTREE,
  INDEX `fk_Organisasi_username_username1_idx`(`username` ASC) USING BTREE,
  INDEX `fk_Organisasi_username_Organisasi1_idx`(`Organisasi_id` ASC) USING BTREE,
  CONSTRAINT `fk_Organisasi_username_Organisasi1` FOREIGN KEY (`Organisasi_id`) REFERENCES `organisasi` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `fk_Organisasi_username_username1` FOREIGN KEY (`username`) REFERENCES `user` (`username`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of kisahhidup
-- ----------------------------
INSERT INTO `kisahhidup` VALUES (1, 'ferdinand', '2023', '2024', 'Si ganteng');
INSERT INTO `kisahhidup` VALUES (1, 'test', '2023', '2024', 'testing');
INSERT INTO `kisahhidup` VALUES (1, 'test2', '2023', '2024', 'Ini kisah hidup ku, mana kisah hidupmu');

-- ----------------------------
-- Table structure for komen
-- ----------------------------
DROP TABLE IF EXISTS `komen`;
CREATE TABLE `komen`  (
  `id` int NOT NULL,
  `Komentar` text CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NULL,
  `tgl` datetime NULL DEFAULT NULL,
  `username` varchar(40) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `Konten_id` int NOT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `fk_Komen_User1_idx`(`username` ASC) USING BTREE,
  INDEX `fk_Komen_Konten1_idx`(`Konten_id` ASC) USING BTREE,
  CONSTRAINT `fk_Komen_Konten1` FOREIGN KEY (`Konten_id`) REFERENCES `konten` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `fk_Komen_User1` FOREIGN KEY (`username`) REFERENCES `user` (`username`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of komen
-- ----------------------------
INSERT INTO `komen` VALUES (1, 'si ganteng', '2024-12-24 23:25:50', 'Ferdinand', 1);
INSERT INTO `komen` VALUES (2, 'oi apaan sih', '2024-12-24 23:25:57', 'Ferdinand', 1);
INSERT INTO `komen` VALUES (3, 'Woi', '2024-12-28 21:54:17', 'ferdinand', 1);
INSERT INTO `komen` VALUES (4, 'Test', '2024-12-28 22:10:38', 'test', 1);

-- ----------------------------
-- Table structure for konten
-- ----------------------------
DROP TABLE IF EXISTS `konten`;
CREATE TABLE `konten`  (
  `id` int NOT NULL,
  `caption` text CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NULL,
  `foto` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NULL DEFAULT NULL,
  `video` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NULL DEFAULT NULL,
  `tglUpload` datetime NULL DEFAULT NULL,
  `username` varchar(40) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `fk_Konten_User1_idx`(`username` ASC) USING BTREE,
  CONSTRAINT `fk_Konten_User1` FOREIGN KEY (`username`) REFERENCES `user` (`username`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of konten
-- ----------------------------
INSERT INTO `konten` VALUES (1, 'ih ganteng', 'testing', 'testing', '2024-12-24 01:58:16', 'ferdinand');
INSERT INTO `konten` VALUES (2, 'aduh', 'testing', 'testing', '2024-12-24 12:08:11', 'ferdinand');
INSERT INTO `konten` VALUES (3, 'main yuk', 'test lagi', 'test lagi', '2024-12-24 23:26:18', 'Ferdinand');
INSERT INTO `konten` VALUES (4, 'Apateu', 'Testing', 'Testing', '2024-12-28 23:33:40', 'ferdinand');
INSERT INTO `konten` VALUES (5, 'testing ', 'testing', 'testing', '2024-12-28 23:40:53', 'ferdinand');
INSERT INTO `konten` VALUES (6, 'testing', 'konten\\.png', 'konten\\.png', '2024-12-29 02:44:28', 'test');
INSERT INTO `konten` VALUES (7, 'testing', 'konten\\Form karyawan.png', 'none', '2024-12-29 02:47:09', 'test');

-- ----------------------------
-- Table structure for kota
-- ----------------------------
DROP TABLE IF EXISTS `kota`;
CREATE TABLE `kota`  (
  `id` int NOT NULL,
  `nama` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of kota
-- ----------------------------
INSERT INTO `kota` VALUES (1, 'Bandung');
INSERT INTO `kota` VALUES (2, 'Yogyakarta');
INSERT INTO `kota` VALUES (3, 'Serang');
INSERT INTO `kota` VALUES (4, 'Pontianak');
INSERT INTO `kota` VALUES (5, 'Surabaya');
INSERT INTO `kota` VALUES (6, 'Bandar Lampung');

-- ----------------------------
-- Table structure for organisasi
-- ----------------------------
DROP TABLE IF EXISTS `organisasi`;
CREATE TABLE `organisasi`  (
  `id` int NOT NULL,
  `nama` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NULL DEFAULT NULL,
  `Kota_id` int NOT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `fk_Organisasi_Kota_idx`(`Kota_id` ASC) USING BTREE,
  CONSTRAINT `fk_Organisasi_Kota` FOREIGN KEY (`Kota_id`) REFERENCES `kota` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of organisasi
-- ----------------------------
INSERT INTO `organisasi` VALUES (1, 'Bandung Berjalan', 1);
INSERT INTO `organisasi` VALUES (2, 'Bandung Silat', 1);
INSERT INTO `organisasi` VALUES (3, 'Yogya Seiman', 2);

-- ----------------------------
-- Table structure for tag
-- ----------------------------
DROP TABLE IF EXISTS `tag`;
CREATE TABLE `tag`  (
  `Konten_id` int NOT NULL,
  `username` varchar(40) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`Konten_id`, `username`) USING BTREE,
  INDEX `fk_Konten_User_User1_idx`(`username` ASC) USING BTREE,
  INDEX `fk_Konten_User_Konten1_idx`(`Konten_id` ASC) USING BTREE,
  CONSTRAINT `fk_Konten_User_Konten1` FOREIGN KEY (`Konten_id`) REFERENCES `konten` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `fk_Konten_User_User1` FOREIGN KEY (`username`) REFERENCES `user` (`username`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tag
-- ----------------------------
INSERT INTO `tag` VALUES (5, 'test');
INSERT INTO `tag` VALUES (6, 'ferdinand');
INSERT INTO `tag` VALUES (7, 'ferdinand');

-- ----------------------------
-- Table structure for teman
-- ----------------------------
DROP TABLE IF EXISTS `teman`;
CREATE TABLE `teman`  (
  `username1` varchar(40) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `username2` varchar(40) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `tglBerteman` date NULL DEFAULT NULL,
  `status` enum('pending','accepted','rejected') CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NULL DEFAULT 'pending',
  PRIMARY KEY (`username1`, `username2`) USING BTREE,
  INDEX `fk_User_User_User2_idx`(`username2` ASC) USING BTREE,
  INDEX `fk_User_User_User1_idx`(`username1` ASC) USING BTREE,
  CONSTRAINT `fk_User_User_User1` FOREIGN KEY (`username1`) REFERENCES `user` (`username`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `fk_User_User_User2` FOREIGN KEY (`username2`) REFERENCES `user` (`username`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of teman
-- ----------------------------
INSERT INTO `teman` VALUES ('ferdinand', 'test', '2024-12-28', 'accepted');
INSERT INTO `teman` VALUES ('test2', 'ferdinand', '2024-12-29', 'accepted');
INSERT INTO `teman` VALUES ('test2', 'test', '2024-12-29', 'accepted');

-- ----------------------------
-- Table structure for user
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user`  (
  `username` varchar(40) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `password` varchar(128) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NULL DEFAULT NULL,
  `tglLahir` date NULL DEFAULT NULL,
  `noKTP` varchar(16) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NULL DEFAULT NULL,
  `foto` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NULL DEFAULT NULL,
  `Kota_id` int NOT NULL,
  PRIMARY KEY (`username`) USING BTREE,
  INDEX `fk_User_Kota1_idx`(`Kota_id` ASC) USING BTREE,
  CONSTRAINT `fk_User_Kota1` FOREIGN KEY (`Kota_id`) REFERENCES `kota` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES ('ferdinand', '1234', '2002-04-28', '1234', 'testing', 1);
INSERT INTO `user` VALUES ('test', '1234', '2024-12-25', '1234', 'test', 1);
INSERT INTO `user` VALUES ('test2', '1234', '2024-12-28', '4321', 'pictures\\Untitled design.jpg', 1);

SET FOREIGN_KEY_CHECKS = 1;
