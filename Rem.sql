USE RemDatabase;
-- DROP SCHEMA RemDataBase;
-- SELECT * FROM central;
-- SELECT * FROM aviso;
-- SELECT * FROM condicaoclimatica;
-- SELECT * FROM empresa;
-- SELECT * FROM energia;
-- SELECT * FROM gestor;
-- SELECT * FROM listacentraisutilizador;
-- SELECT * FROM localizacao;
-- SELECT * FROM utilizador;

INSERT INTO localizacao (coordenadaX,coordenadaY,Endereco) VALUES
	(10,10,"Braga"),
    (10,15,"Lisboa"),
    (15,20,"Porto"),
    (1,5,"Madeira");
INSERT INTO empresa (nome,ceo,descricao,sede,contacto) VALUES
	("RemEletro","Carlos","Conhecida e Confiável","Braga","986206397"),
    ("EnergySavings","Sara","Recen Desenvolvida","Porto","978162964"),
    ("GreenPower","Joel","Empresa Nacional","Lisboa","972640289");
INSERT INTO utilizador (email,password,nome,gestor,logged,lastActivity) VALUES
	("carlos@hotmail.com","1234","Carlos Ferreira",True,False,'2021-06-03 13:40:00'),
    ("sara@hotmail.com","1234","Sara",True,False,'2021-06-03 13:40:00'),
    ("joel@hotmail.com","1234","Joel",True,False,'2021-06-03 13:40:00'),
    ("catarina@hotmail.com","1234","Catarina",True,False,'2021-06-03 13:40:00'),
    ("manuel@hotmail.com","1234","Manuel",False,False,'2021-06-03 13:40:00'),
     ("jose@hotmail.com","1234","Jose",False,False,'2021-06-03 13:40:00');
INSERT INTO  gestor (cargo,Empresa_id,Utilizador_email) VALUES
	("CEO",1,"carlos@hotmail.com"),
    ("CEO",2,"sara@hotmail.com"),
	("CEO",3,"joel@hotmail.com"),
    ("Tecnico",1,"catarina@hotmail.com");
INSERT INTO central (estado,motorers,ultimaAtividade,nome,tipo,valor,inauguracao,Empresa_id,Localizacao_id,maximoDiario,minimoDiario,Gestor_Utilizador_email) Values
	("Funcionar",10,'2021-06-03',"RemEletroCentralBraga","eolica",0,2000,1,1,400,200,"carlos@hotmail.com"),
    ("Funcionar",20,'2021-06-03',"RemEletroCentralLisboa","eolica",0,2007,1,2,480,300,"carlos@hotmail.com"),
    ("Pausa",5,'2021-06-03',"EnergySavingsCentralPorto","hidrolica",0,2005,2,3,400,200,"sara@hotmail.com"),
    ("Pausa",7,'2021-06-03',"GreenPowerCentralMadeira","geotermina",0,2010,3,4,400,200,"joel@hotmail.com");
/*
INSERT INTO condicaoClimatica (data,hora,CondicaoNumerica,Central_ID) VALUES
	('2010-06-01',1,50,1),('2010-06-10',2,50,1),('2010-06-25',3,50,1),
    ('2010-06-01',2,50,1),('2010-06-10',3,50,1),('2010-06-25',4,50,1),
    ('2010-07-01',1,20,1),('2010-07-10',2,20,1),('2010-07-25',3,20,1),
	('2010-06-01',1,50,2),('2010-06-10',2,50,2),('2010-06-25',3,50,2),
    ('2010-07-01',1,20,2),('2010-07-10',2,20,2),('2010-07-25',3,20,2),
	('2010-06-01',1,50,3),('2010-06-10',2,50,3),('2010-06-25',3,50,3),
    ('2010-07-01',1,20,3),('2010-07-10',2,20,3),('2010-07-25',3,20,3);
INSERT INTO energia (quantidade,data,hora,Central_ID) VALUES
	(50,'2010-06-01',1,1),(10,'2010-06-10',2,1),(30,'2010-06-25',3,1),
    (50,'2010-06-01',2,1),(10,'2010-06-10',3,1),(30,'2010-06-25',4,1),
    (50,'2010-07-01',1,1),(10,'2010-07-10',2,1),(30,'2010-07-25',3,1),
	(20,'2010-06-01',1,2),(10,'2010-06-10',2,2),(30,'2010-06-25',3,2),
    (20,'2010-07-01',1,2),(10,'2010-07-10',2,2),(30,'2010-07-25',3,2),
	(20,'2010-06-01',1,3),(10,'2010-06-10',2,3),(30,'2010-06-25',3,3),
    (20,'2010-07-01',1,3),(10,'2010-07-10',2,3),(30,'2010-07-25',3,3);
    */
INSERT INTO aviso (mensagem,data,autor,Central_id) VALUES 
	("fechado por covid",'2021-06-05','carlos@hotmail.com',1),
    ("fechado por covid",'2021-06-05','carlos@hotmail.com',2);
    

-- Registo de Utilizador ----------------------------------------------------------
-- -------------------------------------------------------------------------------
-- DROP POCEDURE registoUtilizador;
DELIMITER $$
CREATE PROCEDURE registoUtilizador(IN Email VARCHAR(45),IN Password VARCHAR(45),IN Nome VARCHAR (45))
BEGIN
DECLARE UltimaAtividade datetime;
SET ultimaAtividade = NOW();
INSERT INTO utilizador (email,password,nome,gestor,logged,lastActivity) VALUES 
	(Email,Password,Nome,False,False,ultimaAtividade);
END$$
-- CALL registoUtilizador('claudia@hotmail.com','1234','Claudia')
-- ------------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------

-- Mapa Central -----------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------
-- DROP PROCEDURE mapaCentral;
DELIMITER $$
CREATE PROCEDURE mapaCentral()
BEGIN
SELECT central.Id,Nome,Tipo,CoordenadaX,CoordenadaY,Endereco FROM central 
	INNER JOIN Localizacao ON central.Localizacao_id=localizacao.id;
END$$
-- CALL mapaCentral();
-- ------------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------

-- Mapa Central -----------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------
-- DROP PROCEDURE centralInfo;
DELIMITER $$
CREATE PROCEDURE centralInfo(IN idInput INT)
BEGIN
SELECT estado,motorers,central.nome,tipo,valor,maximoDiario,minimoDiario,inauguracao,Endereco,CoordenadaX,CoordenadaY,
	Gestor_Utilizador_email,empresa.nome AS empresaNome,empresa.ceo,empresa.sede,empresa.contacto,central.ultimaAtividade,empresa.descricao
FROM central 
	INNER JOIN Localizacao ON central.Localizacao_id=localizacao.id
    INNER JOIN Empresa ON Empresa.id=central.Empresa_id
    WHERE central.id=idInput;
END$$
-- CALL centralInfo(1);
-- ------------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------

-- Login ------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------
-- DROP PROCEDURE login;
DELIMITER $$
CREATE PROCEDURE login(IN email VARCHAR(45),IN pass VARCHAR(45))
BEGIN
	SELECT email,password,gestor FROM utilizador Where utilizador.email=email AND utilizador.password=pass; 
	UPDATE utilizador SET logged=true WHERE utilizador.email=email AND utilizador.password=pass;
END$$
-- CALL login ('carlos@hotmail.com','1234');
-- ------------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------

-- LogOut ------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------
-- DROP PROCEDURE logOut;
DELIMITER $$
CREATE PROCEDURE logOut(IN email VARCHAR(45))
BEGIN
	UPDATE utilizador SET logged=false WHERE utilizador.email=email;
END$$
-- CALL logOut ('carlos3@hotmail.com');
-- ------------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------

-- QueroAvisos ------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------
-- DROP PROCEDURE queroAvisos;
DELIMITER $$
CREATE PROCEDURE queroAvisos (IN email VARCHAR(45),IN id INT)
BEGIN
	INSERT INTO listacentraisutilizador (Central_id,Utilizador_email) VALUES (id,email);
END$$
-- CALL queroAvisos('carlos@hotmail.com',1);
-- ------------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------

-- InserirAviso ------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------
-- DROP PROCEDURE inserirAviso;
DELIMITER $$
CREATE PROCEDURE inserirAviso (IN idCentral INT,IN mensagemInput VARCHAR(45),in email VARCHAR(45))
BEGIN
	INSERT INTO aviso (mensagem,data,Central_id,autor) VALUES (mensagemInput,NOW(),idCentral,email);
END$$
-- CALL inserirAviso(1,'Esta a explodir','carlos@hotmail.com');
-- ------------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------

-- verifica Gestor --------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------
-- DROP PROCEDURE verificaGestor;
DELIMITER $$
CREATE PROCEDURE verificaGestor (IN idCentral INT,IN email VARCHAR(45),IN pass VARCHAR(45))
BEGIN
	IF (email IN (SELECT gestor_Utilizador_email FROM central WHERE central.id=idCentral) 
    AND (pass IN (SELECT password FROM utilizador WHERE utilizador.email=email))) THEN
    SELECT (TRUE) AS booleanM; ELSE SELECT (FALSE) AS booleanM;
    END IF;
END$$
-- CALL verificaGestor(2,'carlos@hotmail.com','1234');
-- ------------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------

-- verifica Aviso --------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------
-- DROP PROCEDURE verificaAviso;
DELIMITER $$
CREATE PROCEDURE verificaAviso (IN idCentral INT,IN email VARCHAR(45))
BEGIN
	IF (email IN (SELECT Utilizador_Email FROM listacentraisutilizador WHERE central_id=idCentral)) 
    THEN SELECT (TRUE) AS booleanM; ELSE SELECT (FALSE) AS booleanM;
    END IF;
END$$
-- CALL verificaAviso(1,'carlos@hotmail.com');
-- ------------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------

-- nao Quero Aviso --------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------
-- DROP PROCEDURE naoQueroAviso;
DELIMITER $$
CREATE PROCEDURE naoQueroAviso (IN idCentral INT,IN email VARCHAR(45))
BEGIN
	DELETE FROM listacentraisutilizador WHERE idCentral=Central_id AND email=utilizador_email;
END$$
-- CALL naoQueroAviso (1,'carlos@hotmail.com');
-- ------------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------

-- Condicoes Climaticas ---------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------
-- DROP PROCEDURE condicoesClimaticas;
DELIMITER $$
CREATE PROCEDURE condicoesClimaticas (IN idCentral INT,IN dataMin DATE,IN dataMax DATE,IN unidade VARCHAR(45))
BEGIN
	IF (unidade='horas') THEN SELECT  data,hora,CondicaoNumerica AS quant FROM condicaoClimatica where central_id=idCentral
		AND data>=dataMin AND data<=dataMax ORDER BY Data,hora;
	END IF;
	IF (unidade='dias') THEN SELECT  data,SUM(CondicaoNumerica) AS quant FROM condicaoClimatica where central_id=idCentral
		AND data>=dataMin AND data<=dataMax GROUP BY data ORDER BY data;
	END IF;
	IF (unidade='mes') THEN SELECT  data,SUM(CondicaoNumerica) AS quant FROM condicaoClimatica where central_id=idCentral
		AND data>=dataMin AND data<=dataMax GROUP BY MONTH(data) ORDER BY data;
	END IF;
END$$
-- CALL condicoesClimaticas (1,'2000-01-01','2020-02-07','dias');
-- CALL condicoesClimaticas (1,'2000-01-01','2020-02-07','horas');
-- CALL condicoesClimaticas (1,'2000-01-01','2020-02-07','mes');
-- ------------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------

-- Historico Energias -----------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------
-- DROP PROCEDURE historicoEnergias;
DELIMITER $$
CREATE PROCEDURE historicoEnergias (IN idCentral INT,IN dataMin DATE,IN dataMax DATE,IN unidade VARCHAR(45))
BEGIN
	IF (unidade='horas') THEN SELECT  data,hora,quantidade AS quant FROM energia where central_id=idCentral
		AND data>=dataMin AND data<=dataMax ORDER BY Data,hora;
	END IF;
	IF (unidade='dias') THEN SELECT  data,SUM(quantidade) AS quant FROM energia where central_id=idCentral
		AND data>=dataMin AND data<=dataMax GROUP BY data ORDER BY data;
	END IF;
	IF (unidade='mes') THEN SELECT  data,SUM(quantidade) AS quant FROM energia where central_id=idCentral
		AND data>=dataMin AND data<=dataMax GROUP BY MONTH(data) ORDER BY data;
	END IF;
END$$
-- CALL historicoEnergias (1,'2000-01-01','2020-02-07','dias');
-- CALL historicoEnergias (1,'2000-01-01','2020-02-07','horas');
-- CALL historicoEnergias (1,'2000-01-01','2020-02-07','mes');
-- CALL historicoEnergias (1,'01/01/2000','01/01/2030','horas');
-- ------------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------

-- Ver Avisos -------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------
-- DROP PROCEDURE verAvisos;
DELIMITER $$
CREATE PROCEDURE verAvisos (IN idCentral INT,IN dataMin DATE)
BEGIN
	SELECT mensagem,data,Central_id AS central,nome FROM aviso 
    INNER JOIN central ON central.id=aviso.Central_id WHERE idCentral=Central_id AND data>=dataMin;
END$$
-- CALL verAvisos (1,'2000-06-01');
-- ------------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------

-- MudarEstado -------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------
-- DROP PROCEDURE mudarEstado;
DELIMITER $$
CREATE PROCEDURE mudarEstado (IN idCentral INT,IN estadoInput VARCHAR(45))
BEGIN
	UPDATE central SET estado=estadoInput WHERE central.id=idCentral;
END$$
-- CALL mudarEstado (1,'em construção');
-- ------------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------

-- MeusAvisos -------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------
-- DROP PROCEDURE meusAvisos;
DELIMITER $$
CREATE PROCEDURE meusAvisos (IN email VARCHAR(45))
BEGIN
	 DECLARE ultdata DATETIME;
     SELECT lastActivity INTO ultdata FROM utilizador WHERE utilizador.email=email;
	 SELECT mensagem,aviso.data,aviso.Central_id AS central,nome FROM aviso
     INNER JOIN central ON aviso.Central_id=central.id
		WHERE (aviso.data>ultdata) 
		AND (
			aviso.Central_id IN
			(SELECT listacentraisutilizador.Central_id FROM listacentraisutilizador WHERE utilizador_email=email)
		);
END$$
-- CALL meusAvisos ('carlos@hotmail.com');
-- ------------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------

-- resetLastActivitu -------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------
-- DROP PROCEDURE resetLastActivity;
DELIMITER $$
CREATE PROCEDURE resetLastActivity (IN email VARCHAR(45))
BEGIN
	UPDATE utilizador SET lastActivity=NOW() WHERE utilizador.email=email;
END$$
-- CALL resetLastActivity ('carlos@hotmail.com');
-- ------------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------

-- dadosNacionais ------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------
-- DROP PROCEDURE dadosNacionais;
DELIMITER $$
CREATE PROCEDURE dadosNacionais (IN dataDados DATE,IN tipo VARCHAR(45))
BEGIN
	SELECT SUM(quantidade) AS quant,CoordenadaX,CoordenadaY,Endereco FROM 
		energia INNER JOIN central ON energia.Central_id=central.id
        INNER JOIN localizacao ON localizacao.id=central.Localizacao_id
        WHERE energia.data=dataDados AND central.tipo=tipo
		GROUP BY energia.Central_id;
END$$
-- CALL dadosNacionais ('2010-06-01','eolica');
-- ------------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------

-- removeCentral -----------------------------------------------------------------
-- --------------------------------------------------------------------------------
-- DROP PROCEDURE removeCentral;
DELIMITER $$
CREATE PROCEDURE removeCentral (IN idCentral INT)
BEGIN
	DELETE FROM aviso WHERE aviso.Central_id=idCentral;
	DELETE FROM listaCentraisUtilizador WHERE Central_id=idCentral;
    DELETE FROM energia WHERE energia.Central_id=idCentral;
    DELETE FROM condicaoClimatica WHERE Central_id=idCentral;
	DELETE FROM central WHERE central.id=idCentral;
END$$
-- CALL removeCentral(1);
-- ------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------

-- adicionarCentral ---------------------------------------------------------------------
-- --------------------------------------------------------------------------------------
-- DROP PROCEDURE adicionarCentral;
DELIMITER $$
CREATE PROCEDURE adicionarCentral (IN Estado VARCHAR(45),IN Motores INT,
								   IN Nome VARCHAR(45), IN Tipo VARCHAR(45),IN Inauguracao INT,
                                   IN Empresa INT, IN CoordenadaX INT,IN CoordenadaY INT,IN Endereco VARCHAR(45),
								   IN MaxDiario INT, IN MinDiario INT, IN EmailGestor VARCHAR(45))
BEGIN
	DECLARE idLoc INT;
	INSERT INTO localizacao (coordenadaX,coordenadaY,Endereco) VALUES (CoordenadaX,CoordenadaY,Endereco);
    SELECT id INTO idLoc FROM localizacao WHERE (localizacao.coordenadaX=coordenadaX AND localizacao.CoordenadaY=coordenadaY AND localizacao.Endereco=Endereco);
	
    INSERT INTO central (estado,motorers,ultimaAtividade,nome,tipo,valor,inauguracao,Empresa_id,Localizacao_id,maximoDiario,minimoDiario,Gestor_Utilizador_email)
    VALUES (Estado,Motores,NOW(),Nome,Tipo,0,Inauguracao,Empresa,idLoc,MaxDiario,MinDiario,EmailGestor);
END $$

-- CALL adicionarCentral ('fechado',16,'bragaCentral1234','eolica',2000,1,50,60,'Madeira',60,30,'carlos@hotmail.com');
-- -----------------------------------------------------------------------------------------------------------------------
-- -----------------------------------------------------------------------------------------------------------------------

-- registoGestor ---------------------------------------------------
-- ----------------------------------------------------------------------------
-- DROP PROCEDURE registoGestor;
DELIMITER $$
CREATE PROCEDURE registoGestor(IN Email VARCHAR(45),IN Password VARCHAR(45),IN Nome VARCHAR (45),IN Empresa INT,IN Cargo VARCHAR (45))
BEGIN
	DECLARE UltimaAtividade datetime;
	SET ultimaAtividade = NOW();
	INSERT INTO utilizador (email,password,nome,gestor,logged,lastActivity) VALUES (Email,Password,Nome,True,False,ultimaAtividade);
	INSERT INTO gestor (cargo,Utilizador_email,Empresa_id) VALUES (Cargo,Email,Empresa);
END $$
-- CALL registoGestor("joel123@mail.com","1234","JoelMart",5,"operador");
-- -----------------------------------------------------------------------------------------------------------------------
-- -----------------------------------------------------------------------------------------------------------------------

-- registaEmpresa --------------------------------------------------
-- --------------------------------------------------------------------------
-- DROP PROCEDURE registoEmpresa;
DELIMITER $$
CREATE PROCEDURE registoEmpresa(IN Nome VARCHAR(45),IN Ceo VARCHAR(45),IN Sede VARCHAR (45),IN PassEspecial VARCHAR (45),IN Contacto VARCHAR (45),IN Descricao VARCHAR (45))
BEGIN
	INSERT INTO empresa (nome,ceo,descricao,sede,contacto) VALUES (Nome,Ceo,Descricao,Sede,Contacto);
END $$
-- CALL registoEmpresa("GreenPower","JOelMartins","Castelo","ola123","925781555","Alglodfsgdfg");
-- -----------------------------------------------------------------------------------------------------------------------
-- -----------------------------------------------------------------------------------------------------------------------



-- verEmpresas -----------------------------------------
-- ----------------------------------------------------
-- DROP PROCEDURE verEmpresas;
DELIMITER $$
CREATE PROCEDURE verEmpresas()
BEGIN
	SELECT empresa.id AS Id,empresa.nome AS nome,ceo,descricao,sede,contacto FROM empresa;
END $$
-- CALL verEmpresas();
-- -----------------------------------------------------------------------------------------------------------------------
-- -----------------------------------------------------------------------------------------------------------------------

-- Retirar Avisos -----------------------------------------
-- --------------------------------------------------------
-- DROP PROCEDURE retirarAvisos;
DELIMITER $$
CREATE PROCEDURE retirarAvisos(IN idCentral INT,IN dataInput DATETIME)
BEGIN
	DELETE FROM aviso WHERE Central_id=idCentral AND aviso.data<=dataInput;
END $$
-- CALL retirarAvisos(1,'2030-01-01');
-- -----------------------------------------------------------------------------------------------------------------------
-- -----------------------------------------------------------------------------------------------------------------------

-- Retirar Historico -----------------------------------------
-- --------------------------------------------------------
-- DROP PROCEDURE retirarHistorico;
DELIMITER $$
CREATE PROCEDURE retirarHistorico(IN idCentral INT,IN dataInput DATETIME)
BEGIN
	DELETE FROM energia WHERE Central_id=idCentral AND energia.data<=dataInput;
    DELETE FROM condicaoclimatica WHERE Central_id=idCentral AND condicaoclimatica.data<=dataInput;
END $$
-- -----------------------------------------------------------------------------------------------------------------------
-- -----------------------------------------------------------------------------------------------------------------------

-- insereDados ------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------
-- DROP PROCEDURE insereDados;
DELIMITER $$
CREATE PROCEDURE insereDados (IN centralID INT,IN dataInsere DATE,IN horaInsere INT,IN quant INT,IN quantCond INT)
BEGIN
	DECLARE en INT;
    DECLARE maximo INT;
    DECLARE minimo INT;
    DECLARE ultFunc DATE;
    
	-- -------------------------------------------------------------------------------------------
	-- Vai Buscar as variavéis
    SELECT valor,maximoDiario,minimoDiario,ultimaAtividade INTO en,maximo,minimo,ultFunc 
		FROM central WHERE central.id=centralID;
	-- ------------------------------------------------------------------------------------
    
    IF (dataInsere >=ultFunc) THEN
		-- Se passou um dia e não atingiu minimo manda aviso
		IF (dataInsere=ultFunc + INTERVAL 1 DAY AND en<minimo) THEN
		INSERT INTO aviso (mensagem,data,Central_id,autor) VALUES ('minimo Nao Alcancado Ontem',dataInsere,centralID,'automatico');
		END IF;
    
		-- Se passou mais que um dia atualiza variavéis de valor e ultimoFuncionamento
		IF (dataInsere>ultFunc) THEN
		UPDATE central SET valor=0,ultimaAtividade=dataInsere WHERE central.id=centralID;
		END IF;
    
		-- ------------------------------------------------------------------------------
		SELECT ultimaAtividade,valor INTO ultFunc,en FROM central WHERE central.id=centralID;
		-- -----------------------------------------------------------------------------
    
		-- Se atingiu o minimo manda aviso
		IF (en<=minimo AND en+quant>minimo) THEN
		INSERT INTO aviso (mensagem,data,Central_id,autor) VALUES ('minimo Alcancado',dataInsere,centralID,'automatico');
		END IF;
    
		-- Se atingiu o maximo manda aviso
		IF (en<=maximo AND en+quant>maximo) THEN
		INSERT INTO aviso (mensagem,data,Central_id,autor) VALUES ('maximo Alcancado',dataInsere,centralID,'automatico');
		END IF;
    
		-- Atualiza valor na central
		UPDATE central SET valor=valor+quant WHERE central.id=centralID;
    
		-- Insere Dados na tabla de energias
		INSERT INTO energia (quantidade,data,hora,Central_id) VALUES (quant,dataInsere,horaInsere,centralID);
		INSERT INTO condicaoclimatica (condicaoNumerica,data,hora,Central_id) VALUES (quant,dataInsere,horaInsere,centralID);
    END IF;
END$$
-- CALL insereDados(1,'2021-06-04',13,5,50);
-- ---------------------------------------------------------------------------------------------------
-- -------------------------------------------------------------------------------------------------------

