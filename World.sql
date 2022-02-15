use world;

select * from city
where city.CountryCode = "NIC";


select * from city where Name like "%a"; 

-- ciudades que empiezan con A
-- paises de habla ingles
 -- codigo pais, nombre del pais,  continente , nombre del idioma y si es oficial o no
 
 select country.Code, country.Name, country.Continent, countrylanguage.Language, countrylanguage.IsOfficial
 from country join countrylanguage on countrylanguage.CountryCode = country.Code 
where countrylanguage.IsOfficial = "T" and Language = "English";

-- todas las peliculas que fueron grabadas en ingles
select * from film;


-- todas las peliculas cuya duracion sea menor o = que 60 minutos y el rating es nc17
select * from film where length < 60 or rating != 'nc-17';


-- lista de todos los trabajadores de un pais en especifico
select * from address;
select * from address where address_id = 4;
select * from city where city_id = 576;
select * from country;

select staff.* from staff 
join address on address.address_id = staff.address_id
join city on city.city_id = address.city_id
join country on country.country_id = city.country_id
where country.country_id = 20
;


select first_name,email from staff;

select * from store;
select * from staff where address_id = 3;