-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema RemDatabase
-- -----------------------------------------------------
-- 
-- -----------------------------------------------------
-- Schema RemDatabase
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `RemDatabase` DEFAULT CHARACTER SET utf8 ;
USE `RemDatabase` ;

-- -----------------------------------------------------
-- Table `RemDatabase`.`Utilizador`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `RemDatabase`.`Utilizador` (
  `email` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `nome` VARCHAR(45) NOT NULL,
  `gestor` TINYINT NOT NULL,
  `logged` TINYINT NOT NULL,
  `lastActivity` DATETIME NOT NULL,
  PRIMARY KEY (`email`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `RemDatabase`.`Empresa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `RemDatabase`.`Empresa` (
  `id` INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `ceo` VARCHAR(45) NOT NULL,
  `descricao` VARCHAR(45) NOT NULL,
  `sede` VARCHAR(45) NOT NULL,
  `contacto` VARCHAR(45) NOT NULL)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `RemDatabase`.`Localizacao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `RemDatabase`.`Localizacao` (
  `id` INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  `coordenadaX` INT NOT NULL,
  `coordenadaY` INT NOT NULL,
  `Endereco` VARCHAR(45) NULL)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `RemDatabase`.`Gestor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `RemDatabase`.`Gestor` (
  `cargo` VARCHAR(45) NULL,
  `Empresa_id` INT NOT NULL,
  `Utilizador_email` VARCHAR(45) NOT NULL,
  INDEX `fk_Gestor_Empresa1_idx` (`Empresa_id` ASC) VISIBLE,
  INDEX `fk_Gestor_Utilizador1_idx` (`Utilizador_email` ASC) VISIBLE,
  PRIMARY KEY (`Utilizador_email`),
  CONSTRAINT `fk_Gestor_Empresa1`
    FOREIGN KEY (`Empresa_id`)
    REFERENCES `RemDatabase`.`Empresa` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Gestor_Utilizador1`
    FOREIGN KEY (`Utilizador_email`)
    REFERENCES `RemDatabase`.`Utilizador` (`email`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `RemDatabase`.`Central`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `RemDatabase`.`Central` (
  `id` INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  `estado` VARCHAR(45) NOT NULL,
  `motorers` INT NOT NULL,
  `ultimaAtividade` DATE NOT NULL,
  `nome` VARCHAR(45) NOT NULL,
  `tipo` VARCHAR(45) NOT NULL,
  `valor` INT NOT NULL,
  `inauguracao` INT NOT NULL,
  `Empresa_id` INT NOT NULL,
  `Localizacao_id` INT NOT NULL,
  `maximoDiario` INT NULL,
  `minimoDiario` INT NULL,
  `Gestor_Utilizador_email` VARCHAR(45) NOT NULL,
  INDEX `fk_Central_Empresa1_idx` (`Empresa_id` ASC) VISIBLE,
  INDEX `fk_Central_Localizacao1_idx` (`Localizacao_id` ASC) VISIBLE,
  INDEX `fk_Central_Gestor1_idx` (`Gestor_Utilizador_email` ASC) VISIBLE,
  CONSTRAINT `fk_Central_Empresa1`
    FOREIGN KEY (`Empresa_id`)
    REFERENCES `RemDatabase`.`Empresa` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Central_Localizacao1`
    FOREIGN KEY (`Localizacao_id`)
    REFERENCES `RemDatabase`.`Localizacao` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Central_Gestor1`
    FOREIGN KEY (`Gestor_Utilizador_email`)
    REFERENCES `RemDatabase`.`Gestor` (`Utilizador_email`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `RemDatabase`.`CondicaoClimatica`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `RemDatabase`.`CondicaoClimatica` (
  `id` INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  `data` DATE NOT NULL,
  `hora` INT NOT NULL,
  `CondicaoNumerica` DOUBLE NOT NULL,
  `Central_id` INT NOT NULL,
  INDEX `fk_Fator_Central1_idx` (`Central_id` ASC) VISIBLE,
  CONSTRAINT `fk_Fator_Central1`
    FOREIGN KEY (`Central_id`)
    REFERENCES `RemDatabase`.`Central` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `RemDatabase`.`Energia`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `RemDatabase`.`Energia` (
  `id` INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  `quantidade` DOUBLE NOT NULL,
  `data` DATE NOT NULL,
  `hora` INT NOT NULL,
  `Central_id` INT NOT NULL,
  INDEX `fk_Energia_Central1_idx` (`Central_id` ASC) VISIBLE,
  CONSTRAINT `fk_Energia_Central1`
    FOREIGN KEY (`Central_id`)
    REFERENCES `RemDatabase`.`Central` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `RemDatabase`.`Aviso`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `RemDatabase`.`Aviso` (
  `id` INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  `mensagem` VARCHAR(45) NOT NULL,
  `data` DATETIME NOT NULL,
  `autor` VARCHAR(45) NOT NULL,
  `Central_id` INT NOT NULL,
  INDEX `fk_Aviso_Central1_idx` (`Central_id` ASC) VISIBLE,
  CONSTRAINT `fk_Aviso_Central1`
    FOREIGN KEY (`Central_id`)
    REFERENCES `RemDatabase`.`Central` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `RemDatabase`.`ListaCentraisUtilizador`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `RemDatabase`.`ListaCentraisUtilizador` (
  `Central_id` INT NOT NULL,
  `Utilizador_email` VARCHAR(45) NOT NULL,
  INDEX `fk_ListaCentraisUtilizador_Central1_idx` (`Central_id` ASC) VISIBLE,
  INDEX `fk_ListaCentraisUtilizador_Utilizador1_idx` (`Utilizador_email` ASC) VISIBLE,
  CONSTRAINT `fk_ListaCentraisUtilizador_Central1`
    FOREIGN KEY (`Central_id`)
    REFERENCES `RemDatabase`.`Central` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ListaCentraisUtilizador_Utilizador1`
    FOREIGN KEY (`Utilizador_email`)
    REFERENCES `RemDatabase`.`Utilizador` (`email`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
