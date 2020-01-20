-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema dbsncmusic01
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema dbsncmusic01
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `dbsncmusic01` DEFAULT CHARACTER SET utf8 ;
USE `dbsncmusic01` ;

-- -----------------------------------------------------
-- Table `dbsncmusic01`.`tb_aluno`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsncmusic01`.`tb_aluno` (
  `id_aluno` INT(11) NOT NULL AUTO_INCREMENT,
  `nome_aluno` VARCHAR(50) NOT NULL,
  `cpf_aluno` VARCHAR(11) NOT NULL,
  `sexo_aluno` VARCHAR(10) NOT NULL,
  `email_aluno` VARCHAR(60) NOT NULL,
  `telefone_aluno` VARCHAR(9) NOT NULL,
  `data_cadastro_aluno` TIMESTAMP NULL DEFAULT current_timestamp,
  PRIMARY KEY (`id_aluno`),
  UNIQUE INDEX `cpf` (`cpf_aluno` ASC) ,
  UNIQUE INDEX `email_UNIQUE` (`email_aluno` ASC) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `dbsncmusic01`.`tb_curso`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsncmusic01`.`tb_curso` (
  `id_curso` INT(11) NOT NULL AUTO_INCREMENT,
  `nome_curso` VARCHAR(45) NOT NULL,
  `carga_horaria_curso` INT NOT NULL,
  `valor_curso` DECIMAL NOT NULL,
  PRIMARY KEY (`id_curso`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `dbsncmusic01`.`tb_usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsncmusic01`.`tb_usuario` (
  `id_usuario` INT NOT NULL AUTO_INCREMENT,
  `nome_usuario` VARCHAR(45) NOT NULL,
  `email_usuario` VARCHAR(45) NOT NULL,
  `senha_usuario` VARCHAR(45) NOT NULL,
  `situacao_usuario` CHAR(1) NOT NULL,
  PRIMARY KEY (`id_usuario`),
  UNIQUE INDEX `email_usuario_UNIQUE` (`email_usuario` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `dbsncmusic01`.`tb_matricula`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsncmusic01`.`tb_matricula` (
  `id_matricula` INT(11) NOT NULL AUTO_INCREMENT,
  `id_aluno_mat` INT(11) NOT NULL,
  `id_curso` INT(11) NOT NULL,
  `situacao` CHAR(1) NOT NULL,
  `horario` VARCHAR(10) NOT NULL,
  `dia_semana` VARCHAR(45) NOT NULL,
  `valor_curso_matricula` DECIMAL NOT NULL,
  `data_matricula` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `usuario_id_usuario` INT NOT NULL,
  PRIMARY KEY (`id_matricula`),
  INDEX `fk_saiqueesuatafarel_aluno_mat_idx` (`id_aluno_mat` ASC) ,
  INDEX `fk_curso_mat_4564_idx` (`id_curso` ASC) ,
  INDEX `fk_tb_matricula_tb_usuario1_idx` (`usuario_id_usuario` ASC) ,
  CONSTRAINT `fk_curso_mat_4564`
    FOREIGN KEY (`id_curso`)
    REFERENCES `dbsncmusic01`.`tb_curso` (`id_curso`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_saiqueesuatafarel_aluno_mat`
    FOREIGN KEY (`id_aluno_mat`)
    REFERENCES `dbsncmusic01`.`tb_aluno` (`id_aluno`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_matricula_tb_usuario1`
    FOREIGN KEY (`usuario_id_usuario`)
    REFERENCES `dbsncmusic01`.`tb_usuario` (`id_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `dbsncmusic01`.`tb_professor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsncmusic01`.`tb_professor` (
  `id_professor` INT(10) NOT NULL,
  `nome_professor` VARCHAR(50) NOT NULL,
  `cpf_professor` VARCHAR(11) NOT NULL,
  `email_professor` VARCHAR(60) NOT NULL,
  `telefone_professor` VARCHAR(9) NOT NULL,
  `data_cadastro_professor` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  PRIMARY KEY (`id_professor`),
  UNIQUE INDEX `cpf` (`cpf_professor` ASC) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `dbsncmusic01`.`tb_professor_curso`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsncmusic01`.`tb_professor_curso` (
  `professor_id_professor` INT(10) NOT NULL,
  `curso_id_curso` INT(11) NOT NULL,
  `data_associacao` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  INDEX `fk_tb_professor_has_tb_curso_tb_curso1_idx` (`curso_id_curso` ASC) ,
  INDEX `fk_tb_professor_has_tb_curso_tb_professor1_idx` (`professor_id_professor` ASC) ,
  CONSTRAINT `fk_tb_professor_has_tb_curso_tb_professor1`
    FOREIGN KEY (`professor_id_professor`)
    REFERENCES `dbsncmusic01`.`tb_professor` (`id_professor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_professor_has_tb_curso_tb_curso1`
    FOREIGN KEY (`curso_id_curso`)
    REFERENCES `dbsncmusic01`.`tb_curso` (`id_curso`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `dbsncmusic01`.`tb_endereco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsncmusic01`.`tb_endereco` (
  `cep` CHAR(8) NOT NULL,
  `logradouro` VARCHAR(100) NOT NULL,
  `numero` VARCHAR(20) NOT NULL,
  `complemento` VARCHAR(60) NULL,
  `bairro` VARCHAR(45) NULL,
  `cidade` VARCHAR(45) NULL,
  `estado` VARCHAR(45) NULL,
  `sigla_estado` CHAR(2) NULL,
  `aluno_id_aluno` INT(11) NOT NULL,
  INDEX `fk_tb_endereco_tb_aluno1_idx` (`aluno_id_aluno` ASC) ,
  CONSTRAINT `fk_tb_endereco_tb_aluno1`
    FOREIGN KEY (`aluno_id_aluno`)
    REFERENCES `dbsncmusic01`.`tb_aluno` (`id_aluno`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
