--CREACIÓN DE LA BASE DE DATOS
Create DATABASE PatronesDiseno
GO 
USE PatronesDiseno
--CREACION DE LA TABLA
CREATE TABLE Clientes(
ID INT IDENTITY(1,1) PRIMARY KEY, 
Nombre VARCHAR(20) NOT NULL, 
Apellido VARCHAR(30) NOT NULL, 
Direccion VARCHAR(100), 
Ciudad VARCHAR(100), 
Email VARCHAR(100), 
Telefono VARCHAR(13) NOT NULL, 
Ocupacion VARCHAR(70) NOT NULL
);
GO
--INSERCION DE REGISTROS
INSERT INTO Clientes values ('Wagner', 'Suarez', 'Villa Mella Santo Domingo Norte', 'Santo Domingo Norte','wagner2164@gmail.com', '829-380-0416', 'Desarrollador'),
('Kiara', 'Aza', 'Eustaquia de Jesus, Villa Mella, Santo Domingo Norte', 'Kiaraaza@gmail.com', 'Santo Domingo Norte', '809-316-1604', 'Empleada Publica'),
('Jacob', 'Suarez Aza', 'Ortega y Gasset esq. Pedro Livio Cedeno',  'Santo Domingo Norte',  'Jacobsuarez@gmail.com','809-563-9627', 'Estudiante'),
('Nicoll', 'Suarez', 'Los Prados Bloque A', 'Distrito Nacional', 'nicollsuarez@hotmail.com', '829-642-5080', 'Gerente Administrativa'),
('Gilberto', 'Rojas', 'Ens la fe #34',  'Distrito Nacional', 'gilbertorojas@gmail.com', '849-653-1516', 'Gerente General');
--Busqueda de datos en la tabla clientes
SELECT * FROM Clientes WHERE Apellido = 'Suarez'
--BUSQUEDA DE DATOS POR APROXIMACION
SELECT * FROM Clientes WHERE Telefono LIKE '809'
--PROCEDIMIENTO
CREATE PROC VerRegistros
@Condicion VARCHAR(30)
AS
SELECT * FROM Clientes WHERE Apellido like @Condicion+'%' or Telefono like @Condicion+'%'
GO
EXEC VerRegistros 'Suarez'