--------------------------------------------------------
-- Archivo creado  - martes-noviembre-21-2023   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Sequence SEQ_ID_EGRESOS
--------------------------------------------------------

   CREATE SEQUENCE  "SEQ_ID_EGRESOS"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 4 NOCACHE  NOORDER  NOCYCLE  NOKEEP  NOSCALE  GLOBAL ;
--------------------------------------------------------
--  DDL for Sequence SEQ_ID_INGRESOS
--------------------------------------------------------

   CREATE SEQUENCE  "SEQ_ID_INGRESOS"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 7 NOCACHE  NOORDER  NOCYCLE  NOKEEP  NOSCALE  GLOBAL ;
--------------------------------------------------------
--  DDL for Table EGRESOS
--------------------------------------------------------

  CREATE TABLE "EGRESOS" 
   (	"ID_EGRESOS" NUMBER, 
	"EGRESO" NUMBER, 
	"ASUNTO" VARCHAR2(50 BYTE), 
	"FRECUENCIA" NUMBER, 
	"FECHA" DATE, 
	"CORREO" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table INGRESOS
--------------------------------------------------------

  CREATE TABLE "INGRESOS" 
   (	"ID_INGRESOS" NUMBER, 
	"INGRESO" NUMBER, 
	"ASUNTO" VARCHAR2(50 BYTE), 
	"FRECUENCIA" NUMBER, 
	"FECHA" DATE, 
	"CORREO" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table USUARIOS
--------------------------------------------------------

  CREATE TABLE "USUARIOS" 
   (	"NAME" VARCHAR2(20 BYTE), 
	"CORREO" VARCHAR2(50 BYTE), 
	"CLAVE" VARCHAR2(50 BYTE), 
	"SALDO" NUMBER DEFAULT 0
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
REM INSERTING into EGRESOS
SET DEFINE OFF;
Insert into EGRESOS (ID_EGRESOS,EGRESO,ASUNTO,FRECUENCIA,FECHA,CORREO) values ('3','40000','PERFUME','0',to_date('09/11/23','DD/MM/RR'),'sarangolindarte@gmail.com');
REM INSERTING into INGRESOS
SET DEFINE OFF;
Insert into INGRESOS (ID_INGRESOS,INGRESO,ASUNTO,FRECUENCIA,FECHA,CORREO) values ('5','1200000','SALARIO MENSUAL','30',to_date('30/11/23','DD/MM/RR'),'sarangolindarte@gmail.com');
Insert into INGRESOS (ID_INGRESOS,INGRESO,ASUNTO,FRECUENCIA,FECHA,CORREO) values ('6','400000','JOVENES EN ACCION','0',to_date('01/11/23','DD/MM/RR'),'sarangolindarte@gmail.com');
REM INSERTING into USUARIOS
SET DEFINE OFF;
Insert into USUARIOS (NAME,CORREO,CLAVE,SALDO) values ('Sergio Lindarte','sarangolindarte@gmail.com','123','360000');
--------------------------------------------------------
--  DDL for Index EGRESOS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "EGRESOS_PK" ON "EGRESOS" ("ID_EGRESOS") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index INGRESOS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "INGRESOS_PK" ON "INGRESOS" ("ID_INGRESOS") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index USUARIOS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "USUARIOS_PK" ON "USUARIOS" ("CORREO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index EGRESOS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "EGRESOS_PK" ON "EGRESOS" ("ID_EGRESOS") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index INGRESOS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "INGRESOS_PK" ON "INGRESOS" ("ID_INGRESOS") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index USUARIOS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "USUARIOS_PK" ON "USUARIOS" ("CORREO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Trigger TRG_INCREMENTOEGRESO
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE TRIGGER "TRG_INCREMENTOEGRESO" 
BEFORE INSERT ON EGRESOS
FOR EACH ROW
BEGIN
  :NEW.ID_EGRESOS := SEQ_ID_EGRESOS.NEXTVAL;
END;
/
ALTER TRIGGER "TRG_INCREMENTOEGRESO" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TRG_INCREMENTOINGRESO
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE TRIGGER "TRG_INCREMENTOINGRESO" 
BEFORE INSERT ON INGRESOS
FOR EACH ROW
BEGIN
  :NEW.ID_INGRESOS := SEQ_ID_INGRESOS.NEXTVAL;
END;
/
ALTER TRIGGER "TRG_INCREMENTOINGRESO" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TRG_INCREMENTOEGRESO
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE TRIGGER "TRG_INCREMENTOEGRESO" 
BEFORE INSERT ON EGRESOS
FOR EACH ROW
BEGIN
  :NEW.ID_EGRESOS := SEQ_ID_EGRESOS.NEXTVAL;
END;
/
ALTER TRIGGER "TRG_INCREMENTOEGRESO" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TRG_INCREMENTOINGRESO
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE TRIGGER "TRG_INCREMENTOINGRESO" 
BEFORE INSERT ON INGRESOS
FOR EACH ROW
BEGIN
  :NEW.ID_INGRESOS := SEQ_ID_INGRESOS.NEXTVAL;
END;
/
ALTER TRIGGER "TRG_INCREMENTOINGRESO" ENABLE;
--------------------------------------------------------
--  DDL for Procedure PRC_ACTUALIZARSALDO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "PRC_ACTUALIZARSALDO" (u_correo IN VARCHAR2, u_nuevoSaldo IN NUMBER)
AS
BEGIN
  UPDATE USUARIOS SET SALDO = u_nuevoSaldo WHERE CORREO = u_correo;
  COMMIT;
END prc_ActualizarSaldo;

/
--------------------------------------------------------
--  DDL for Procedure PRC_CAMBIARCONTRASEÑA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "PRC_CAMBIARCONTRASEÑA" (u_correo IN VARCHAR2, u_nuevaClave IN VARCHAR2)
AS
BEGIN
  UPDATE USUARIOS SET CLAVE = u_nuevaClave WHERE CORREO = u_correo;
  COMMIT;
END prc_CambiarContraseña;

/
--------------------------------------------------------
--  DDL for Procedure PRC_CONSULTAREGRESOS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "PRC_CONSULTAREGRESOS" (FK IN VARCHAR2, resultados OUT SYS_REFCURSOR)
AS
BEGIN
  OPEN resultados FOR
    SELECT
      e.egreso "egreso",
      e.asunto "asunto",
      e.frecuencia "frecuencia",
      e.fecha "fecha"
    FROM egresos e
    WHERE e.correo = FK;
END prc_ConsultarEgresos;

/
--------------------------------------------------------
--  DDL for Procedure PRC_CONSULTARINGRESOS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "PRC_CONSULTARINGRESOS" (FK IN VARCHAR2, resultados OUT SYS_REFCURSOR)
AS
BEGIN
  OPEN resultados FOR
    SELECT
      i.ingreso "ingreso",
      i.asunto "asunto",
      i.frecuencia "frecuencia",
      i.fecha "fecha"
    FROM ingresos i
    WHERE i.correo = FK;
END prc_ConsultarIngresos;

/
--------------------------------------------------------
--  DDL for Procedure PRC_CONSULTARUSERS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "PRC_CONSULTARUSERS" (resultados OUT SYS_REFCURSOR)
AS
BEGIN
  OPEN resultados FOR
    SELECT
      u.name "name",
      u.correo "correo",
      u.clave "clave",
      u.saldo "saldo"
    FROM usuarios u;
END prc_Consultarusers;

/
--------------------------------------------------------
--  DDL for Procedure PRC_INSERTAREGRESO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "PRC_INSERTAREGRESO" (
    egreso EGRESOS.EGRESO%TYPE,
    asunto EGRESOS.ASUNTO%TYPE,
    frecuencia EGRESOS.FRECUENCIA%TYPE,
    fecha EGRESOS.FECHA%TYPE,
    correo EGRESOS.CORREO%TYPE
)
IS
BEGIN
    INSERT INTO EGRESOS (EGRESO, ASUNTO, FRECUENCIA, FECHA, CORREO)
    VALUES (egreso, asunto, frecuencia, fecha, correo);
    COMMIT;
END prc_InsertarEgreso;

/
--------------------------------------------------------
--  DDL for Procedure PRC_INSERTARINGRESO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "PRC_INSERTARINGRESO" (
    ingreso INGRESOS.INGRESO%TYPE,
    asunto INGRESOS.ASUNTO%TYPE,
    frecuencia INGRESOS.FRECUENCIA%TYPE,
    fecha INGRESOS.FECHA%TYPE,
    correo INGRESOS.CORREO%TYPE
)
IS
BEGIN
    INSERT INTO INGRESOS (INGRESO, ASUNTO, FRECUENCIA, FECHA, CORREO)
    VALUES (ingreso, asunto, frecuencia, fecha, correo);
    COMMIT;
END prc_InsertarIngreso;

/
--------------------------------------------------------
--  DDL for Procedure PRC_INSERTARUSER
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "PRC_INSERTARUSER" (
    name USUARIOS.NAME%TYPE,
    correo USUARIOS.CORREO%TYPE,
    clave USUARIOS.CLAVE%TYPE,
    saldo USUARIOS.SALDO%TYPE
)
IS
BEGIN
    INSERT INTO USUARIOS (NAME, CORREO, CLAVE, SALDO)
    VALUES (name, correo, clave, saldo);
    COMMIT;
END prc_Insertaruser;

/
--------------------------------------------------------
--  Constraints for Table EGRESOS
--------------------------------------------------------

  ALTER TABLE "EGRESOS" MODIFY ("ID_EGRESOS" NOT NULL ENABLE);
  ALTER TABLE "EGRESOS" MODIFY ("EGRESO" NOT NULL ENABLE);
  ALTER TABLE "EGRESOS" MODIFY ("ASUNTO" NOT NULL ENABLE);
  ALTER TABLE "EGRESOS" MODIFY ("FECHA" NOT NULL ENABLE);
  ALTER TABLE "EGRESOS" MODIFY ("CORREO" NOT NULL ENABLE);
  ALTER TABLE "EGRESOS" ADD CONSTRAINT "EGRESOS_PK" PRIMARY KEY ("ID_EGRESOS")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
  ALTER TABLE "EGRESOS" MODIFY ("FRECUENCIA" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table INGRESOS
--------------------------------------------------------

  ALTER TABLE "INGRESOS" MODIFY ("ID_INGRESOS" NOT NULL ENABLE);
  ALTER TABLE "INGRESOS" MODIFY ("INGRESO" NOT NULL ENABLE);
  ALTER TABLE "INGRESOS" MODIFY ("ASUNTO" NOT NULL ENABLE);
  ALTER TABLE "INGRESOS" MODIFY ("FECHA" NOT NULL ENABLE);
  ALTER TABLE "INGRESOS" MODIFY ("CORREO" NOT NULL ENABLE);
  ALTER TABLE "INGRESOS" ADD CONSTRAINT "INGRESOS_PK" PRIMARY KEY ("ID_INGRESOS")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
  ALTER TABLE "INGRESOS" MODIFY ("FRECUENCIA" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table USUARIOS
--------------------------------------------------------

  ALTER TABLE "USUARIOS" MODIFY ("NAME" NOT NULL ENABLE);
  ALTER TABLE "USUARIOS" MODIFY ("CORREO" NOT NULL ENABLE);
  ALTER TABLE "USUARIOS" MODIFY ("CLAVE" NOT NULL ENABLE);
  ALTER TABLE "USUARIOS" ADD CONSTRAINT "USUARIOS_PK" PRIMARY KEY ("CORREO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table EGRESOS
--------------------------------------------------------

  ALTER TABLE "EGRESOS" ADD CONSTRAINT "FK_CORREOE" FOREIGN KEY ("CORREO")
	  REFERENCES "USUARIOS" ("CORREO") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table INGRESOS
--------------------------------------------------------

  ALTER TABLE "INGRESOS" ADD CONSTRAINT "FK_CORREO" FOREIGN KEY ("CORREO")
	  REFERENCES "USUARIOS" ("CORREO") ENABLE;
