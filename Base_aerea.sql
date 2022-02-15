USE aerea;
-- INSERT Into base (nombre) VALUES ("California");
insert into piloto (nombre, horas_vuelo, base_id) values ("pedro", 5, 2);
INSERT into avion (tipo, piloto_id, base_id) values ("humon", 2, 2);
insert into miembro_tripulacion (nombre, base_id) values ("juanita", 2);
insert into vuelo (origen, destino, hora_determinada, piloto_id, avion_id) values 
("managua", "valle", 15, 2, 2);
insert into vuelo_has_miembro_tripulacion (vuelo_id, miembro_tripulacion_id) values 
(2, 2);
insert into base (nombre) values ("xkl");
use almacenvehiculo;
select * from almacenes;


SELECT * From base;
SELECT * From piloto;
SELECT * From avion;
SELECT * From miembro_tripulacion;
SELECT * From vuelo;
SELECT * From vuelo_has_miembro_tripulacion;



-- delete from base where id = 3;
delete from base where id = 1;
-- piloto juan maria, pedro hV 1000
update piloto set nombre = "maria" where id = 2;
update piloto set nombre = "pedro", horas_vuelo = 1000 where id = 1;


use sakila;

insert into carrera (nombre) value ("ing. sistemas");
insert into area_conocimiento (nombre, departamento_id) value ("geografia", 2);
insert into departamento (nombre) value ("OLA");
insert into asignatura (nombre, area_conocimiento_id) value ("geografia", 2);
insert into profesor (nombre, area_conocimiento_id) value ("Carlos", 2);
select * from carrera;
insert into asignatura_has_carrera (asignatura_id, carrera_id) value (2, 2);
insert into profesor_has_asignatura (profesor_id, asignatura_id) value (2,2);








use coches;
select * from vehiculo;
	
use sakila;
select * from country;


-- CRUD
-- C: Create -> INSERT INTO table (cols) VALUES (valores);
-- R: Read -> SELECT cols FROM table;
-- U: Update -> UPDATE table SET col = value WHERE col = condicion;
-- D: Delete -> DELETE FROM table WHERE col = condicion;

