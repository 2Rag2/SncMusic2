
-- -----------------------------------------------------
-- Schema dbsncmusic
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema dbsncmusic
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS dbsncmusic DEFAULT CHARACTER SET utf8 ;
USE dbsncmusic ;

-- -----------------------------------------------------
-- Table dbsncmusic.tb_aluno
-- -----------------------------------------------------
DROP TABLE IF EXISTS dbsncmusic.tb_aluno ;

CREATE TABLE IF NOT EXISTS dbsncmusic.tb_aluno (
  id_aluno INT NOT NULL AUTO_INCREMENT,
  nome_aluno VARCHAR(50) NOT NULL,
  cpf VARCHAR(11) NOT NULL unique,
  sexo VARCHAR(10) NOT NULL,
  email VARCHAR(60) NOT NULL,
  telefone VARCHAR(9) NOT NULL,
  PRIMARY KEY (id_aluno))
  ENGINE = InnoDB
AUTO_INCREMENT = 12
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table dbsncmusic.tb_professor
-- -----------------------------------------------------
DROP TABLE IF EXISTS dbsncmusic.tb_professor ;

CREATE TABLE IF NOT EXISTS dbsncmusic.tb_professor (
  id_professor INT(10) NOT NULL,
  nome_professor VARCHAR(50) NULL DEFAULT NULL,
  cpf VARCHAR(11) NULL unique NULL,
  email VARCHAR(60) NULL DEFAULT NULL,
  telefone VARCHAR(9) NULL DEFAULT NULL,
  PRIMARY KEY (id_professor))
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table dbsncmusic.tb_curso
-- -----------------------------------------------------
DROP TABLE IF EXISTS dbsncmusic.tb_curso ;

CREATE TABLE IF NOT EXISTS dbsncmusic.tb_curso (
  id_curso INT NOT NULL AUTO_INCREMENT,
  nome_curso VARCHAR(45) NOT NULL,
  id_professor_curso INT NOT NULL,
  PRIMARY KEY (id_curso),
  INDEX fk_prof_curso_idx (id_professor_curso),
  CONSTRAINT fk_prof_curso
    FOREIGN KEY (id_professor_curso)
    REFERENCES dbsncmusic.tb_professor (id_professor)
    )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table dbsncmusic.tb_matricula
-- -----------------------------------------------------
DROP TABLE IF EXISTS dbsncmusic.tb_matricula ;

CREATE TABLE IF NOT EXISTS dbsncmusic.tb_matricula (
  id_matricula INT NOT NULL AUTO_INCREMENT,
  id_aluno_mat INT NOT NULL,
  id_curso INT NOT NULL,
  situacao CHAR(1) NOT NULL,
  data_mat TIMESTAMP NOT NULL DEFAULT current_timestamp,
  horario VARCHAR(10) NOT NULL,
  dia_semana VARCHAR(45) NOT NULL,
  PRIMARY KEY (id_matricula),
  INDEX fk_saiqueesuatafarel_aluno_mat_idx (id_aluno_mat),
  INDEX fk_curso_mat_4564_idx (id_curso),
  CONSTRAINT fk_saiqueesuatafarel_aluno_mat
    FOREIGN KEY (id_aluno_mat)
    REFERENCES dbsncmusic.tb_aluno (id_aluno)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_curso_mat_4564
    FOREIGN KEY (id_curso)
    REFERENCES dbsncmusic.tb_curso (id_curso)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;